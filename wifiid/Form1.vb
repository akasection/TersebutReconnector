Imports Reconnector.ICMPClass
Imports System.Threading
Imports System.IO
Imports System.Reflection


Public Class baseForm
    Private pinger As ICMPClass
    Private cunt As Integer
    Private installPath As String = "C:\Windows\wifi.cmd"
    Private lastMessage As String
    Private timeToleranceLimit As Integer = 60
    Private globalcounter As Integer
    Private RTOTolerance As Integer = 14
    Dim theThread As Threading.Thread
    Dim threadAwaker As StayAwake
    Private _Message As String
    Private AcquireState As Boolean = False
    Private NavigateState As Boolean = True
    Private _msTimeToPing = 2000
    Private _msMaximumPing = 2000
    Private isOpen As Boolean = True
    Private isFirstInstall = True
    Private isNoClose = False
    Private isVerbosed = False
    Private isLogged = False
    Private numOfMessages As Integer = 0
    Dim ArrayConfig()() As String
    Dim lastPost As Integer = 0
    Private Path As String = Application.StartupPath + "\" + "tersebut.ini"
    Private isProgramStarted As Boolean = False
    'Private Shared HTMLFormatter As HtmlToRichTextBox
    Private cursorPosition As Long = 0
    Private userName As String
    Private password As String = ""

    Private CommenceStop As Integer = 0
    Private Property acctype As String
    Private Defined As Boolean = False

    'Pengaturan Ukuran dari kodingan
    Private C_WINDOW_SIZE As New Size(967, 629)

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UnregisterHotKey(Me.Handle, 100)
        UnregisterHotKey(Me.Handle, 200)
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isNoClose Then
            MinimizeToTrayToolStripMenuItem_Click(Me, Nothing)
            e.Cancel = True

        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If Defined Then
        Dim fileExists As Boolean = True 'My.Computer.FileSystem.FileExists(installPath)
        If fileExists Then
            '_Message += "Reconnector Service Status : Installed."
            'MessagingStatus()
            isFirstInstall = False
            Button3.Text = "Uninstall Reconnector Service"
            StopReconnectorToolStripMenuItem.Enabled = False
            'Button4.Enabled = True
        Else
            OpenClose()
            StopReconnectorToolStripMenuItem.Enabled = False
            StartReconnectorToolStripMenuItem.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = False
            'Sizing
            Me.Size = C_WINDOW_SIZE
        End If
        'End If
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
            password = txtPassword.Text

            _Message += "Loaded configuration from " + Path
            MessagingStatus()
            'turning out
            isVerbosed = ckVerbose.Checked
            isLogged = ckLog.Checked

        Else
            ReDim ArrayConfig(IniLookup.Length - 1)
            For a As Integer = 0 To IniLookup.Length - 1 Step 1
                ReDim ArrayConfig(a)(2)
            Next a
            IniModule.InitArrayValue(ArrayConfig)
            _Message += "Cannot find configuration file. Using default setting instead."
            MessagingStatus()
            _Message += "First run detected. Please configure your account first and some other extra configurations."
            MessagingStatus()

        End If
        'PrePut
        numInterval.Value = _msTimeToPing
        numTimeSafe.Value = timeToleranceLimit
        numTolerance.Value = RTOTolerance
        numMaxInterval.Value = _msMaximumPing

        lblLatency.Visible = ckLatencyView.Checked
        lblTitleLatency.Visible = ckLatencyView.Checked
        'Me.Width = 559
        'Me.Left += 75
        OpenClose()
        Me.Text += " v" + Application.ProductVersion
        Me.Icon = My.Resources.tersebut1
        miniIcon.Icon = My.Resources.tersebut2
        'UPS! License Checker! :3
        If Not UnlockMod.GetRegistered() Then
            'Licensing.ShowDialog(Me)
        End If

        'Visibility anti-bug
        Call comboAccount_SelectedIndexChanged(Me, Nothing)

        'Hotkeys EXPERIMENTAL
        RegisterHotKey(Me.Handle, 100, MOD_ALT, Keys.F12)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        isProgramStarted = True
        Button1.Enabled = False
        Button3.Enabled = False
        Timer1.Enabled = True
        pinger = New ICMPClass
        _Message += "Begin :" + " " + "Pinging 1.1.1.1"
        MessagingStatus()
        Timer2.Start()
        Button2.Enabled = True
        globalcounter = timeToleranceLimit
        threadAwaker = New StayAwake()
        theThread = New Threading.Thread(AddressOf ThreadAction)
        theThread.Start()
        AcquireState = False
        miniIcon.Icon = My.Resources.tersebut1
        Me.Icon = miniIcon.Icon

        StartReconnectorToolStripMenuItem.Enabled = False
        StopReconnectorToolStripMenuItem.Enabled = True
    End Sub



    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        If isProgramStarted Then
            'InjectBlocker()
            Dim tmpText As String = "res://"
            If wb.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Connection Dropped, retrying..."
                MessagingStatus()
                wb.Stop()
                NavigateState = False
                wb.Navigate("http://1.1.1.1/login.html")
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        isProgramStarted = False
        'Timer1.Stop()
        Timer2.Stop()
        wb.Stop()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        _Message += "Reconnector has been stopped."
        MessagingStatus()
        theThread.Abort()
        _Message += "Stopped."
        MessagingStatus2()
        miniIcon.Icon = My.Resources.tersebut2
        Me.Icon = miniIcon.Icon
        StartReconnectorToolStripMenuItem.Enabled = True
        StopReconnectorToolStripMenuItem.Enabled = False
        Logging("Reconnector Stopped")
        lastMessage = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TextBox1.Select(TextBox1.TextLength - 1, 2)
        txtLogger.ScrollToCaret()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Install Reconnector Service" Then


            Dim text As String = "netsh wlan disconnect"
            text += vbCrLf + "netsh wlan connect name=free@wifi.id ssid=free@wifi.id"
            My.Computer.FileSystem.WriteAllText(installPath, text, False)
            'Shell("netsh wlan add profile filename=free@wifi.id.xml")
            MessageBox.Show("Install Suceeded.", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _Message += "Reconnector Service Installed."
            MessagingStatus()
            If isFirstInstall Then OpenClose()

            'Button2.Enabled = True
            Button1.Enabled = True

            'Button4.Enabled = True
            StartReconnectorToolStripMenuItem.Enabled = True
            StopReconnectorToolStripMenuItem.Enabled = False
            Button3.Text = "Uninstall Reconnector Service"
        Else
            Dim r As DialogResult = MessageBox.Show("Are you sure to remove Reconnector Service?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            'My.Computer.FileSystem.WriteAllText(installPath, Text, False)
            If r = Windows.Forms.DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile(installPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                'Shell("netsh wlan delete profile filename=free@wifi.id.xml")
                MessageBox.Show("Uninstall Suceeded.", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _Message += "Reconnector Service Uninstalled."
                MessagingStatus()
                Button2.Enabled = False
                Button1.Enabled = False

                StartReconnectorToolStripMenuItem.Enabled = False
                StopReconnectorToolStripMenuItem.Enabled = False
                Button3.Text = "Install Reconnector Service"
            Else
            End If
        End If
    End Sub

    Private Sub Logging(ByVal str As String)
        If isLogged Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\log.txt", "[" + DateTime.Now.ToShortDateString + "|" + DateTime.Now.ToLongTimeString() + "]" + str + vbCrLf, True)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        globalcounter += 1
        Label1.Text = "Program time counter : " + globalcounter.ToString + " seconds."
        'If globalcounter = 600 Then '600 is elevation limit level 1
        ' RTOTolerance /= 2
        ' ElseIf globalcounter = 850 Then '850 is elevation limit level maximum
        'RTOTolerance /= 2
        ' End If
    End Sub

    Private Sub ThreadAction()
        Do While True = True
            If AcquireState = False Then

                Dim a As ICMPClass.ICMPReplyStructure
                Try
                    a = pinger.Ping("1.1.1.1", _msMaximumPing, 64, 1)
                Catch e As ArgumentOutOfRangeException
                    _Message += "ERROR: There is a problem with the wifi addressing. Commanding program to stop."
                    MessagingStatus()
                    _Message += "Please connect another wifi.id access point and try starting Reconnector again."
                    MessagingStatus()
                    'Button2_Click(Me, Nothing)
                    CommenceStop = 1
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
                '_Message += "Connection Break Detected at second of " + globalcounter.ToString + "."
                MessagingStatus2()

                If Defined Then
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
                End If

                'code sendform http
                _Message += "Waiting the HTML to be opened."
                MessagingStatus()
                Logging("Navigate to login page : 1.1.1.1")
                wb.Navigate("http://1.1.1.1/login.html")
                'theThread.Suspend()

            End If

            'If AcquireState Then
            'Thread.Sleep(Timeout.Infinite)
            'End If

        Loop
    End Sub

    Private Sub MessagingStatus()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf MessagingStatus))
        Else
            If _Message <> "" Then
                Dim theMessage = "[" + DateTime.Now.ToLongTimeString() + "]"
                'ReDim TextBox1.Lines(TextBox1.Lines.Length + 1)
                txtLogger.AppendText(theMessage + _Message + vbCrLf)
                'TextBox1.Select(cursorPosition, theMessage.Length)
                'TextBox1.SelectionColor = Color.Blue
                'Console.WriteLine(TextBox1.SelectedText)
                cursorPosition += theMessage.Length
                'TextBox1.DeselectAll()
                'TextBox1.SelectionColor = Color.Black
                'TextBox1.Select(cursorPosition, (_Message + vbCrLf).Length - 1)
                'TextBox1.SelectionColor = Color.Black
                'Console.WriteLine(TextBox1.SelectedText)

                'TextBox1.DeselectAll()

                'Label2.Text = TextBox1.Find(theMessage, lastPost, RichTextBoxFinds.NoHighlight)
                'TextBox1.SelectionStart = TextBox1.Find("[")
                'TextBox1.SelectionLength = theMessage.Length

                'TextBox1.Select()

                'TextBox1.SelectionStart = TextBox1.Find("]") + 1
                'TextBox1.SelectionLength = TextBox1.Lines(numOfMessages).Length - theMessage.Length
                'TextBox1.SelectionColor = Color.Black
                'lastPost = TextBox1.SelectionLength
                'TextBox1.DeselectAll()
                'TextBox1.SelectionStart = TextBox1.TextLength - 1
                '+ _Message + vbCrLf).Length
                'TextBox1.SelectionLength = 1
                'TextBox1.Select()

                txtLogger.ScrollToCaret()
                numOfMessages += 1
            End If
            _Message = ""
        End If
    End Sub

    Private Sub MessagingStatus2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf MessagingStatus))
        Else
            Label1.Text = _Message + vbCrLf
            _Message = ""
        End If
    End Sub

    Private Sub MessagingLatency()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf MessagingLatency))
        Else

            'Coloring time
            Try
                Dim g As Double = Double.Parse(_Message)
                If g > 0 And g <= 75 Then
                    lblLatency.ForeColor = Color.DarkGreen
                ElseIf g > 75 And g <= 300 Then
                    lblLatency.ForeColor = Color.DarkOrange
                ElseIf g > 300 Then
                    lblLatency.ForeColor = Color.DarkRed

                End If
                lblLatency.Text = _Message + " ms"
            Catch e As FormatException
                lblLatency.ForeColor = Color.Black
                lblLatency.Text = _Message
            End Try

            _Message = ""
        End If
    End Sub

    Private Sub TimerStop()
        'Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wb.Navigated
        If isProgramStarted Then

            'InjectBlocker()
            _Message += "Page Loading to " + wb.Url.AbsoluteUri
            MessagingStatus2()
            _Message += "Page Loading to " + wb.Url.AbsoluteUri
            MessagingStatus()
            Logging("Web Direct Link : " + wb.Url.AbsoluteUri)

            'Prevent Redirect to Forbidden Website
            Dim tmpText As String = "http://1.1.1.1/"
            If Not wb.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Invalid Redirection Specified, trying to stop action."
                MessagingStatus()
                wb.Stop()
                AcquireState = False
                NavigateState = False
                'WebBrowser1.Navigate("http://1.1.1.1/login.html")
                'theThread.Interrupt()
            Else
                'theThread.Interrupt()
                globalcounter = 0
            End If
            tmpText = "res://"
            If wb.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Connection Dropped, retrying..."
                MessagingStatus()
                wb.Stop()
                NavigateState = False
                wb.Navigate("http://1.1.1.1/login.html")
            End If
        End If
    End Sub

    Public Function Get_LocalIPAddress() As String

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        'return any string found
        For Each a In h.AddressList

            If Not a.IsIPv6LinkLocal Then
                Return CType(a, System.Net.IPAddress).ToString()
            End If
        Next
        'CType(h.AddressList.GetValue(0), System.Net.IPAddress).ToString()
        Return "0.0.0.0"
    End Function

    Private Sub AdvancedConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedConfig.Click
        OpenClose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Raw Save Config
        'Verbose
        _Message += "====== Option Summary ======" + vbCrLf
        If ckVerbose.Checked Then
            isVerbosed = True
            _Message += "Verbose Reporting Mode activated." + vbCrLf + "You will see more messages of Reconnection."
        Else
            isVerbosed = False
            _Message += "Verbose Reporting Mode deactivated." + vbCrLf + "You will see simpler messages of Reconnection."
        End If
        MessagingStatus()
        'Logging
        If ckLog.Checked Then
            isLogged = True
            _Message += "Log to File activated. Some traces are saved to " + Application.StartupPath + "log.txt"
        Else
            isLogged = False
            _Message += "Log to File disabled. No traces are saved to file."
        End If
        MessagingStatus()
        'Close to Tray
        If ckClose.Checked Then
            _Message += "Close to tray activated. Program will not exit when this window closed." + vbCrLf + "Instead click exit on the tray to quit program."
            isNoClose = True
        Else
            _Message += "Close to tray disabled."
            isNoClose = False
        End If
        MessagingStatus()
        'Interval
        _Message += "Ping Interval changed from " + _msTimeToPing.ToString + " to " + numInterval.Value.ToString
        MessagingStatus()
        _msTimeToPing = numInterval.Value

        'TimeSafe (Ignore)
        _Message += "TimeSafe Timeout changed from " + timeToleranceLimit.ToString + " to " + numTimeSafe.Value.ToString
        MessagingStatus()
        timeToleranceLimit = numTimeSafe.Value


        'RTOTolerance
        _Message += "Reconnect Tolerance changed from " + RTOTolerance.ToString + " to " + numTolerance.Value.ToString
        MessagingStatus()
        RTOTolerance = numTolerance.Value

        'Max Latency
        _Message += "Maximum Ping Interval changed from " + _msMaximumPing.ToString + " to " + numMaxInterval.Value.ToString
        MessagingStatus()
        _msMaximumPing = numMaxInterval.Value

        'View
        If ckLatencyView.Checked Then
            _Message += "Latency will be shown."

        Else
            _Message += "Latency will be hidden."
        End If
        lblLatency.Visible = ckLatencyView.Checked
        lblTitleLatency.Visible = ckLatencyView.Checked
        MessagingStatus()

        'USERNAME
        _Message += "Username changed to " + usname.Text + " with account type " + comboAccount.Text + "."
        MessagingStatus()
        userName = usname.Text

        'PASSWORD
        If ckSavePassword.Checked Then
            _Message += "Password saved in plain text."
        Else
            _Message += "Password cleared each time program closes."
        End If
        MessagingStatus()

        password = txtPassword.Text

        acctype = GetAccountType(comboAccount.Text)
        _Message += "====== End of Option ======"
        MessagingStatus()
        _Message += "Configuration saved."
        MessagingStatus2()
        'Saving Configuration



        If ArrayConfig Is Nothing Then
            ReDim ArrayConfig(IniLookup.Length)
            For a As Integer = 0 To IniLookup.Length Step 1
                ReDim ArrayConfig(a)(2)
            Next a
        End If



        SetOptionValue(ArrayConfig, "TIME_SAFE", numTimeSafe.Value)
        SetOptionValue(ArrayConfig, "RTO_TOLERANCE", numTolerance.Value)
        SetOptionValue(ArrayConfig, "PING_INTERVAL", numInterval.Value)

        SetOptionValue(ArrayConfig, "VERBOSE", ckVerbose.Checked)
        SetOptionValue(ArrayConfig, "LOG_TO_FILE", ckLog.Checked)
        SetOptionValue(ArrayConfig, "TRAY", ckClose.Checked)

        SetOptionValue(ArrayConfig, "USERNAME", usname.Text)
        SetOptionValue(ArrayConfig, "ACCTYPE", comboAccount.Text)

        SetOptionValue(ArrayConfig, "VIEWLATENCY", ckLatencyView.Checked)
        SetOptionValue(ArrayConfig, "MAXPING", numMaxInterval.Value)

        If ckSavePassword.Checked Then
            SetOptionValue(ArrayConfig, "PASSWORD", txtPassword.Text)
        Else
            SetOptionValue(ArrayConfig, "PASSWORD", "")
        End If

        IniModule.WriteINI(Path, ArrayConfig)
        OpenClose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenClose()
    End Sub

    Private Sub OpenClose()
        Dim resizer = 319
        If isOpen Then
            Me.Width -= resizer
            'Me.Left += resizer / 2

        Else
            Me.Width += resizer
            'Me.Left -= resizer / 2
        End If
        isOpen = Not isOpen
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinToTray.Click
        miniIcon.Visible = True
        Me.Hide()
        miniIcon.ShowBalloonTip(3000)
    End Sub



    Private Sub miniIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles miniIcon.MouseDoubleClick
        Me.Show()
        miniIcon.Visible = False
    End Sub


    Private Sub StartReconnectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartReconnectorToolStripMenuItem.Click
        Button1_Click(Me, Nothing)
    End Sub

    Private Sub StopReconnectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopReconnectorToolStripMenuItem.Click
        Button2_Click(Me, Nothing)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ShowWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowWindowToolStripMenuItem.Click
        Me.Show()
        miniIcon.Visible = False
    End Sub

    Private Sub miniMenu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles miniMenu.LostFocus
        miniMenu.Close()
    End Sub


    Private Sub context_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles context.Opening
        If txtLogger.SelectedText.Length = 0 Then
            tcopy.Visible = False
            tselAll.Visible = True
        Else
            tcopy.Visible = True
            tselAll.Visible = False
        End If
    End Sub

    Private Sub tclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tclear.Click
        txtLogger.Text = "" + vbCrLf
    End Sub

    Private Sub tselAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tselAll.Click
        txtLogger.SelectAll()
    End Sub

    Private Sub tcopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcopy.Click
        Clipboard.SetText(txtLogger.SelectedText)
    End Sub


    Public Function GetWirelessIP() As String
        For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            If nic.OperationalStatus = Net.NetworkInformation.OperationalStatus.Up And nic.NetworkInterfaceType = Net.NetworkInformation.NetworkInterfaceType.Wireless80211 Then
                For a As Integer = 0 To nic.GetIPProperties().UnicastAddresses.Count - 1
                    Dim add = nic.GetIPProperties().UnicastAddresses(a).Address
                    'MessageBox.Show(add.GetAddressBytes.Length)
                    If add.GetAddressBytes.Length < 16 Then
                        Return CType(add, System.Net.IPAddress).ToString()
                    End If
                Next a
            End If

        Next
        Return "127.0.0.1"
    End Function

    Private Function GetAccountType(ByVal p1 As String) As String
        'SPIN
        'Telkomsel()
        'Flexi()
        'Speedy()
        'Voucher()
        If p1 = "SPIN" Then
            Return "@SPIN"

        End If
        If p1 = "Speedy" Then
            Return "@telkom.net"
        End If

        If p1 = "Flexi" Then
            Return ""
        End If
        If p1 = "Voucher" Then
            Return ""
        End If
        If p1 = "Telkomsel" Then
            Return "@t.sel"
        End If
        If p1 = "Radnet" Then
            Return "@idn.telkom.net"
        End If
        Return ""
    End Function


    Private Sub WebBrowser1_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles wb.NewWindow
        e.Cancel = True
        Logging("Cancelling new Window.")
    End Sub

    Private Sub comboAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboAccount.SelectedIndexChanged
        If comboAccount.Text = "free@wifi.id" Then
            usname.Visible = False
            txtPassword.Visible = False
            ckSavePassword.Visible = False
            lblUsername.Visible = False
            lblPassword.Visible = False
        Else

            If comboAccount.Text = "Speedy" Then
                txtPassword.Text = "123"
                txtPassword.Enabled = False
            Else
                txtPassword.Enabled = True
            End If

            usname.Visible = True
            txtPassword.Visible = True
            ckSavePassword.Visible = True
            lblUsername.Visible = True
            lblPassword.Visible = True

        End If
    End Sub

    Public Function Int2Boolean(ByVal int As Integer) As Boolean
        If int > 0 Then Return True
        Return False
    End Function

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim webAddress As String = "http://www.facebook.com/akasection"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim webAddress As String = "http://axection.deviantart.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panelAbout.Hide()
    End Sub

    Private Sub mnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAbout.Click
        'Set Location
        panelAbout.Location = New Point(8, 32)
        panelAbout.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CommenceStop = 1 Then
            CommenceStop = 0
            Button2_Click(Me, Nothing)
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    If isProgramStarted = True Then
                        Button2_Click(Me, Nothing)
                    Else
                        Button1_Click(Me, Nothing)
                    End If
                    'MessageBox.Show("You pressed ALT+D key combination")
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

End Class
