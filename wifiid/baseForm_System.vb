Imports System.Net
Imports System.Text
Imports System.IO

Partial Public Class baseForm

    'Property v1.4
    Private _msTimeToPing = 2000
    Private _msMaximumPing = 2000
    Private isNoClose = False
    Private isVerbosed = False
    Private isLogged = False
    Private userName As String
    Private password As String = ""

    'New Property v1.7
    Private Gateway As String = "1.1.1.1"
    Private Preset As String() = {"Low Signal - Gaming",
                                  "Any Signal - Work/Browsing",
                                  "High Signal - Gaming",
                                  "High Signal - Standard",
                                  "Perfect Reconnect",
                                  "Custom"}
    Private legacyConnection As Boolean = False
    Private numSample As Integer
    'Helper Property 1.7
    Dim selectedPreset As Integer = 5 'custome
    Dim sampleHelperArray As Integer()
    Dim lastLatency As Integer
    Dim LatencyQueue As New Collections.Generic.Queue(Of Double)
    Dim ReconnectorReactivation As New Timer
    Dim loadBrowser As Integer

    Private Property LatencyDisplay As String

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        If isProgramStarted Then
            'InjectBlocker()
            Dim tmpText As String = "res://"
            If wb.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Connection Dropped, retrying..."
                MessagingStatus()
                wb.Stop()
                NavigateState = False
                wb.Navigate("http://" + Gateway + "/login.html")
                Exit Sub
            Else
                _Message += "Document Completed."
                MessagingStatus()
                _Message += "Page Load Completed."
                MessagingStatus2()
                Logging("Page Finishes Loading with success.")
            End If
            Dim theElementCollection As HtmlElementCollection = wb.Document.GetElementsByTagName("Input")
            For Each curElement As HtmlElement In theElementCollection
                Dim controlName As String = curElement.GetAttribute("name").ToString
                If controlName = "username" Then
                    curElement.SetAttribute("Value", usname.Text + GetAccountType(comboAccount.Text))
                End If
            Next
            'Part 3: Locate the Password TextBox and automatically input your password   
            '<INPUT class=yreg_ipt id=passwd type=password maxLength=64 size=17 value="" name=passwd>   
            theElementCollection = wb.Document.GetElementsByTagName("Input")
            For Each curElement As HtmlElement In theElementCollection
                Dim controlName As String = curElement.GetAttribute("name").ToString
                If controlName = "password" Then
                    curElement.SetAttribute("Value", password)
                End If
            Next


            wb.Document.InvokeScript("submitAction()")

            Logging(wb.StatusText + " reporting HTML status :" + vbCrLf + wb.Document.GetElementsByTagName("head")(0).InnerText)
            Logging("Page Title : " + wb.DocumentTitle)
            theElementCollection = wb.Document.GetElementsByTagName("Input")
            For Each curElement As HtmlElement In theElementCollection
                If curElement.GetAttribute("name").ToString = "Submit" Then
                    curElement.InvokeMember("click")
                    'Javascript has a click method for we need to invoke on the current submit button element.  
                    Logging("Submitting entry.")

                End If
            Next
            'SendKeys.Send(Chr(Keys.Enter))
            'SendKeys.Send(vbCrLf)

            'Timer1.Start()
            Timer2.Start()

            cunt = 0
            AcquireState = False

            NavigateState = True

            'theThread.Resume()
        End If
        Logging("Program finishes loading page: " + e.Url.ToString)
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wb.Navigated
        If isProgramStarted Then

            'InjectBlocker()
            _Message += "Page Loading to " + wb.Url.AbsoluteUri
            MessagingStatus2()
            _Message += "Page Loading to " + wb.Url.AbsoluteUri
            MessagingStatus()
            Logging("Web Direct Link : " + wb.Url.AbsoluteUri)
            loadBrowser += 1
            'Prevent Redirect to Forbidden Website
            Dim tmpText As String = "http://" + Gateway + "/"
            If Not wb.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Invalid Redirection Specified, trying to stop action."
                MessagingStatus()
                wb.Stop()
                AcquireState = False
                NavigateState = False
                globalcounter = LastValidNumber
                'WebBrowser1.Navigate("http://"+ Gateway +"/login.html")
                'theThread.Interrupt()
                loadBrowser = 0
            Else
                'theThread.Interrupt()
                If loadBrowser = 2 Then
                    globalcounter = 0
                    loadBrowser = 0
                End If
            End If
            tmpText = "res://"
            If wb.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Connection Dropped, retrying..."
                MessagingStatus()
                wb.Stop()
                NavigateState = False
                wb.Navigate("http://" + Gateway + "/login.html")
            End If
        End If
    End Sub
    Private Sub ThreadAction()
        Do While True = True
            If AcquireState = False Then

                Dim a As ICMPClass.ICMPReplyStructure
                Try
                    a = pinger.Ping(Gateway, _msMaximumPing, 64, 1)
                Catch e As ArgumentOutOfRangeException
                    _Message += "ERROR: There is a problem with the wifi addressing. Commanding program to stop."
                    MessagingStatus()
                    _Message += "Reactivate Tersebut in 30 seconds... Or Start Reconnector manually."
                    MessagingStatus()
                    'Button2_Click(Me, Nothing)
                    ActionCommand = 1
                    theThread.Interrupt()
                    Exit Sub
                End Try
                System.Threading.Thread.Sleep(Math.Abs(_msTimeToPing - a.RoundTripTime))
                If pinger.GetMessage(a.Status) <> "Success" Then
                    cunt += 1
                Else
                    cunt = 0
                End If


                If isVerbosed Then
                    _Message += pinger.GetMessage(a.Status) + " with delay of " + a.RoundTripTime.ToString
                Else
                    If lastMessage <> pinger.GetMessage(a.Status) Then _Message += pinger.GetMessage(a.Status)
                End If
                MessagingStatus()
                If a.RoundTripTime > 0 Then
                    _Message += a.RoundTripTime.ToString
                Else
                    _Message += "Timed out."
                End If
                MessagingLatency()
                lastMessage = pinger.GetMessage(a.Status)
            End If

            Dim theCondition As Boolean = (cunt > RTOTolerance And globalcounter >= timeToleranceLimit And AcquireState = False)
            If isVerbosed Then
                _Message += "DEBUG: Breaking Status : " & theCondition.ToString
                MessagingStatus()
            End If

            If theCondition Then
                AcquireState = True
                TimerStop()
                threadAwaker.SleepSwitch = True

                _Message += "Connection Break at : " + globalcounter.ToString + " seconds."

                If isVerbosed Then
                    _Message += " " + "with Status Acquired = " + AcquireState.ToString
                End If
                MessagingStatus()

                Logging(globalcounter.ToString + " break time.")
                LastValidNumber = globalcounter
                '_Message += "Connection Break Detected at second of " + globalcounter.ToString + "."
                MessagingStatus2()

#If Defined Then
                    Shell(installPath, AppWinStyle.Hide, True)
                    _Message += "Current IP : " & Get_LocalIPAddress()
                    MessagingStatus()
                    If isVerbosed Then
                        _Message += "Assign new IP."
                        MessagingStatus()
                    End If

                    Do While GetWirelessIP() = "127.0.0.1"
                        Application.DoEvents()
                        System.Threading.Thread.Sleep(1)
                    Loop
                    If isVerbosed Then
                        _Message += "Refreshed IP : " & GetWirelessIP()
                        MessagingStatus()
                    End If
#End If
                If legacyConnection = True Then
                    'code sendform http
                    _Message += "Waiting the HTML to be opened."
                    MessagingStatus()
                    Logging("Navigate to login page : " + Gateway + "")
                    wb.Navigate("http://" + Gateway + "/login.html") '''TODO : login.html changed!

                Else
                    _Message += "Sending POST Data to gateway."
                    MessagingStatus()
                    Logging("SENDING POST DATA : " + Gateway)
                    CallLogout()
                    CallLogin()

                End If
            End If

        Loop
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Raw Save Config
        'Verbose
        _Message += vbCrLf + "====== Option Summary ======" + vbCrLf + ""
        If ckVerbose.Checked Then
            isVerbosed = True
            _Message += "Verbose Mode : On" + vbCrLf + ""
        Else
            isVerbosed = False
            _Message += "Verbose Mode : Off" + vbCrLf + ""
        End If
        'MessagingStatus()
        'Logging
        If ckLog.Checked Then
            isLogged = True
            _Message += "Log to File : activated." + vbCrLf + ""
        Else
            isLogged = False
            _Message += "Log to File : disabled." + vbCrLf + ""
        End If
        'MessagingStatus()
        'Close to Tray
        If ckClose.Checked Then
            _Message += "Close to tray : Activated. " + vbCrLf + "Right click Tray > Exit to quit program." + vbCrLf + ""
            isNoClose = True
        Else
            _Message += "Close to tray : Disabled." + vbCrLf + ""
            isNoClose = False
        End If
        'MessagingStatus()
        'Interval
        _Message += "Ping Interval : " + _msTimeToPing.ToString + " -> " + numInterval.Value.ToString + "" + vbCrLf + ""
        'MessagingStatus()
        _msTimeToPing = numInterval.Value

        'TimeSafe (Ignore)
        _Message += "TimeSafe Timeout : " + timeToleranceLimit.ToString + " -> " + numTimeSafe.Value.ToString + "" + vbCrLf + ""
        'MessagingStatus()
        timeToleranceLimit = numTimeSafe.Value


        'RTOTolerance
        _Message += "Reconnect Tolerance : " + RTOTolerance.ToString + " -> " + numTolerance.Value.ToString + "" + vbCrLf + ""
        'MessagingStatus()
        RTOTolerance = numTolerance.Value

        'Max Latency
        _Message += "Maximum Ping Interval : " + _msMaximumPing.ToString + " -> " + numMaxInterval.Value.ToString + "" + vbCrLf + ""
        'MessagingStatus()
        _msMaximumPing = numMaxInterval.Value

        'View
        'If ckLatencyView.Checked Then
        '_Message += "Latency : Show" + vbCrLf + ""
        'Else
        '_Message += "Latency : Hide" + vbCrLf + ""
        'End If
        lblLatency.Visible = True 'ckLatencyView.Checked
        lblTitleLatency.Visible = True 'ckLatencyView.Checked
        _Message += "Latency Display : " + cbDisplay.Text + vbCrLf + ""
        'MessagingStatus()
        TabMaster.TabPages.Remove(tabMonitor)
        If cbDisplay.Text = "Off" Then
            TabMaster.TabPages.Remove(tabMonitor)
        Else
            TabMaster.TabPages.Insert(0, tabMonitor)
        End If
        LatencyDisplay = cbDisplay.Text
        'USERNAME
        _Message += "Username : " + usname.Text + " " + vbCrLf + "Account Type : " + comboAccount.Text + "" + vbCrLf + ""
        'MessagingStatus()
        userName = usname.Text

        'PASSWORD
        If ckSavePassword.Checked Then
            _Message += "Password : Saved." + vbCrLf + ""
        Else
            _Message += "Password : Not Saved." + vbCrLf + ""
        End If
        'MessagingStatus()

        'SAMPLES
        _Message += "Number of Samples : " + numSample.ToString + " -> " + numSamples.Value.ToString + "" + vbCrLf + ""
        numSample = numSamples.Value
        password = txtPassword.Text

        'Legacy
        If ckSavePassword.Checked Then
            _Message += "Use Legacy Method : Yes" + vbCrLf + ""
        Else
            _Message += "Use Legacy Method : No." + vbCrLf + ""
        End If

        'Gateway
        _Message += "Gateway : " + Gateway + " -> " + txtGateway.Text + "" + vbCrLf + ""
        Gateway = txtGateway.Text


        acctype = GetAccountType(comboAccount.Text)
        _Message += "====== End of Option ======"
        MessagingStatus()

        SaveConfiguration()
        OpenClose()
        TabMaster.SelectTab(tabLog)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fileExists As Boolean = True 'My.Computer.FileSystem.FileExists(installPath)
        If fileExists Then
            isFirstInstall = False
            Button3.Text = "Uninstall Reconnector Service"
            StopReconnectorToolStripMenuItem.Enabled = False
            'Button4.Enabled = True
        Else
            OpenClose()
            StopReconnectorToolStripMenuItem.Enabled = False
            StartReconnectorToolStripMenuItem.Enabled = False
            btnStop.Enabled = False
            btnStart.Enabled = False
            'Sizing
            Me.Size = C_WINDOW_SIZE
        End If

        'READ CONFIGURATION!
        ArrayConfig = IniModule.ReadINI(Path)
        If Not ArrayConfig Is Nothing Then
            On Error Resume Next
            _msTimeToPing = Integer.Parse(GetOptionValue(ArrayConfig, "PING_INTERVAL"))
            timeToleranceLimit = Integer.Parse(GetOptionValue(ArrayConfig, "TIME_SAFE"))
            RTOTolerance = Integer.Parse(GetOptionValue(ArrayConfig, "RTO_TOLERANCE"))
            ckVerbose.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "VERBOSE"))
            ckLog.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "LOG_TO_FILE"))
            ckClose.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "TRAY"))
            usname.Text = GetOptionValue(ArrayConfig, "USERNAME")
            comboAccount.Text = GetOptionValue(ArrayConfig, "ACCTYPE")

            txtPassword.Text = GetOptionValue(ArrayConfig, "PASSWORD")
            ckSavePassword.Checked = Int2Boolean(txtPassword.TextLength)
            ckLatencyView.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "VIEWLATENCY"))
            _msMaximumPing = Integer.Parse(GetOptionValue(ArrayConfig, "MAXPING"))

            'New Property 1.7
            ckLegacyBrowser.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "LEGACY"))
            Gateway = GetOptionValue(ArrayConfig, "GATEWAY")
            numSamples.Value = Integer.Parse(GetOptionValue(ArrayConfig, "SAMPLES"))
            selectedPreset = Integer.Parse(GetOptionValue(ArrayConfig, "PRESET"))
            cbDisplay.Text = GetOptionValue(ArrayConfig, "DISPLAY")

            'Binding property 1.7 to variable
            numSample = numSamples.Value
            LatencyDisplay = cbDisplay.Text
            legacyConnection = ckLegacyBrowser.Checked

            _Message += "Loaded configuration from " + Path
            MessagingStatus()
            'Binding Property 1.4 to variable
            userName = usname.Text
            password = txtPassword.Text
            isVerbosed = ckVerbose.Checked
            isLogged = ckLog.Checked
            isNoClose = ckClose.Checked
        Else
            ReDim ArrayConfig(IniLookup.Length - 1)
            For a As Integer = 0 To IniLookup.Length - 1 Step 1
                ReDim ArrayConfig(a)(2)
            Next a
            IniModule.InitArrayValue(ArrayConfig)
            _Message += "Cannot find configuration file. Using default setting instead."
            MessagingStatus()
            _Message += "First run detected. Please configure your account first and other configuration."
            MessagingStatus()

        End If
        'PrePut
        numInterval.Value = _msTimeToPing
        numTimeSafe.Value = timeToleranceLimit
        numTolerance.Value = RTOTolerance
        numMaxInterval.Value = _msMaximumPing
        txtGateway.Text = Gateway
        lblLatency.Visible = ckLatencyView.Checked
        lblTitleLatency.Visible = ckLatencyView.Checked

        OpenClose()

        SetPreset(selectedPreset)

        'UI Update
        Me.Text += " v" + Application.ProductVersion
        lblVersion.Text = "version " + Application.ProductVersion
        Me.Icon = My.Resources.tersebut2
        miniIcon.Icon = My.Resources.tersebut2

        TabMaster.TabPages.Remove(tabMonitor)
        If cbDisplay.Text = "Off" Then
            TabMaster.TabPages.Remove(tabMonitor)
        Else
            TabMaster.TabPages.Insert(0, tabMonitor)
        End If
        'UPS! License Checker! :3
        If Not UnlockMod.GetRegistered() Then
            'Licensing.ShowDialog(Me)
        End If

        'Visibility anti-bug
        Call comboAccount_SelectedIndexChanged(Me, Nothing)

        'Hotkeys EXPERIMENTAL
        RegisterHotKey(Me.Handle, 100, MOD_ALT, Keys.F12)
    End Sub

    Public Sub CallLogin()
        Dim request As HttpWebRequest = HttpWebRequest.Create("http://" + Gateway + "/login.html")

        'Prepare Request
        request.Method = WebRequestMethods.Http.Post
        request.Accept = "text/html, application/xhtml+xml, */*"
        request.Referer = "http://" + Gateway + "/login.html"
        request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko"
        request.ContentType = "application/x-www-form-urlencoded"""
        request.Host = Gateway

        Dim postData As String = "buttonClicked=4&err_flag=0&err_msg=&info_flag=0&info_msg=&redirect_url="
        postData += "&username=" + userName + "&password=" + password

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentLength = byteArray.Length
        Logging(postData)
        MessagingStatus()
        'Send Request
        Dim writer As Stream = request.GetRequestStream()
        writer.Write(byteArray, 0, byteArray.Length)
        writer.Close()

        'Read Response (VERBOSE)
        If isVerbosed Then
            Dim response As WebResponse = request.GetResponse()
            _Message += (CType(response, HttpWebResponse).StatusDescription)
            MessagingStatus()
            Dim dataStream As New StreamReader(response.GetResponseStream())
            Dim responseFromServer As String = dataStream.ReadToEnd()
            _Message += responseFromServer
            MessagingStatus()
            Logging(responseFromServer)
            Logging((CType(response, HttpWebResponse).StatusDescription))
            dataStream.Close()
            response.Close()
        End If
        'Same Endpoint
        cunt = 0
        globalcounter = 0
        loadBrowser = 0
        AcquireState = False
        NavigateState = True
        ActionCommand = 3
    End Sub

    Public Sub CallLogout()
        Dim request As HttpWebRequest = HttpWebRequest.Create("http://" + Gateway + "/logout.html")

        'Prepare Request
        request.Method = WebRequestMethods.Http.Post
        request.Accept = "text/html, application/xhtml+xml, */*"
        request.Referer = "http://" + Gateway + "/logout.html"
        request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko"
        request.ContentType = "application/x-www-form-urlencoded"""
        request.Host = Gateway
        request.Timeout = 1000
        Dim postData As String = "userStatus=1&err_flag=0&err_msg="
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentLength = byteArray.Length
        Logging(postData)
        MessagingStatus()
        'Send Request
        Dim writer As Stream = request.GetRequestStream()
        writer.Write(byteArray, 0, byteArray.Length)
        writer.Close()

        'Read Response (VERBOSE)
        If isVerbosed Then
            Dim response As WebResponse = request.GetResponse()
            _Message += (CType(response, HttpWebResponse).StatusDescription)
            MessagingStatus()
            Dim dataStream As New StreamReader(response.GetResponseStream())
            Dim responseFromServer As String = dataStream.ReadToEnd()
            _Message += responseFromServer
            MessagingStatus()
            Logging(responseFromServer)
            Logging((CType(response, HttpWebResponse).StatusDescription))
            dataStream.Close()
            response.Close()
        End If
    End Sub
End Class
