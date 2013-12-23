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
    Private password As String = "123"

    Private Property acctype As String
    Private Defined As Boolean = False

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
            _Message += "Reconnector Service Status : Installed."
            MessagingStatus()
            isFirstInstall = False
            Button3.Text = "Uninstall Reconnector Service"
            StopReconnectorToolStripMenuItem.Enabled = False
            'Button4.Enabled = True
        Else
            _Message += "Reconnector Service Status : Not Installed." + vbCrLf + "Please install service first to use Reconnector."
            MessagingStatus()
            OpenClose()
            StopReconnectorToolStripMenuItem.Enabled = False
            StartReconnectorToolStripMenuItem.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = False

        End If
        'End If
        'READ CONFIGURATION!
        ArrayConfig = IniModule.ReadINI(Path)
        If Not ArrayConfig Is Nothing Then
            _msTimeToPing = Integer.Parse(GetOptionValue(ArrayConfig, "PING_INTERVAL"))
            timeToleranceLimit = Integer.Parse(GetOptionValue(ArrayConfig, "TIME_SAFE"))
            RTOTolerance = Integer.Parse(GetOptionValue(ArrayConfig, "RTO_TOLERANCE"))
            ckVerbose.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "VERBOSE"))
            ckLog.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "LOG_TO_FILE"))
            ckClose.Checked = Boolean.Parse(GetOptionValue(ArrayConfig, "TRAY"))
            usname.Text = GetOptionValue(ArrayConfig, "USERNAME")
            comboAccount.Text = GetOptionValue(ArrayConfig, "ACCTYPE")

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
        End If
        'PrePut
        numInterval.Value = _msTimeToPing
        numTimeSafe.Value = timeToleranceLimit
        numTolerance.Value = RTOTolerance


        'Me.Width = 559
        'Me.Left += 75
        OpenClose()
        Me.Text += " v" + Application.ProductVersion
        Me.Icon = My.Resources.tersebut1
        miniIcon.Icon = My.Resources.tersebut1
        'UPS! License Checker! :3
        If Not UnlockMod.GetRegistered() Then
            Licensing.ShowDialog(Me)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        isProgramStarted = True
        Button1.Enabled = False
        Button3.Enabled = False
        Timer1.Enabled = True
        pinger = New ICMPClass
        _Message += "Program has been started!" + " " + "Pinging 1.1.1.1..."
        MessagingStatus()
        Timer2.Start()
        Button2.Enabled = True
        globalcounter = timeToleranceLimit
        threadAwaker = New StayAwake()
        theThread = New Threading.Thread(AddressOf ThreadAction)
        theThread.Start()
        AcquireState = False
        miniIcon.Icon = My.Resources.tersebut2
        Me.Icon = miniIcon.Icon

        StartReconnectorToolStripMenuItem.Enabled = False
        StopReconnectorToolStripMenuItem.Enabled = True
    End Sub



    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If isProgramStarted Then
            'InjectBlocker()
            _Message += "Document Completed."
            MessagingStatus()
            _Message += "Page Load Completed."
            MessagingStatus2()

            Dim theElementCollection As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("Input")
            For Each curElement As HtmlElement In theElementCollection
                Dim controlName As String = curElement.GetAttribute("name").ToString
                If controlName = "username" Then
                    curElement.SetAttribute("Value", usname.Text + GetAccountType(comboAccount.Text))
                End If
            Next
            'Part 3: Locate the Password TextBox and automatically input your password   
            '<INPUT class=yreg_ipt id=passwd type=password maxLength=64 size=17 value="" name=passwd>   
            theElementCollection = WebBrowser1.Document.GetElementsByTagName("Input")
            For Each curElement As HtmlElement In theElementCollection
                Dim controlName As String = curElement.GetAttribute("name").ToString
                If controlName = "password" Then
                    curElement.SetAttribute("Value", password)
                End If
            Next


            WebBrowser1.Document.InvokeScript("submitAction()")
            Logging(WebBrowser1.StatusText + " reporting HTML status :" + vbCrLf + WebBrowser1.Document.GetElementsByTagName("head")(0).InnerText)
            Logging("Page Title : " + WebBrowser1.DocumentTitle)
            theElementCollection = WebBrowser1.Document.GetElementsByTagName("Input")
            For Each curElement As HtmlElement In theElementCollection
                If curElement.GetAttribute("name").ToString = "Submit" Then
                    curElement.InvokeMember("click")
                    'Javascript has a click method for we need to invoke on the current submit button element.  

                End If
            Next
            'SendKeys.Send(Chr(Keys.Enter))
            'SendKeys.Send(vbCrLf)

            'Timer1.Start()
            Timer2.Start()
            cunt = 0
            AcquireState = False
            globalcounter = 0
            NavigateState = True

            'theThread.Resume()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        isProgramStarted = False
        Timer1.Stop()
        Timer2.Stop()
        WebBrowser1.Stop()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        _Message += "Reconnector has been stopped."
        MessagingStatus()
        theThread.Abort()
        _Message += "Stopped."
        MessagingStatus2()
        miniIcon.Icon = My.Resources.tersebut1
        Me.Icon = miniIcon.Icon
        StartReconnectorToolStripMenuItem.Enabled = True
        StopReconnectorToolStripMenuItem.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TextBox1.Select(TextBox1.TextLength - 1, 2)
        TextBox1.ScrollToCaret()

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
        Label1.Text = "Program has run " + globalcounter.ToString + " seconds after last successful reconnect attempt."
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
                a = pinger.Ping("1.1.1.1", _msTimeToPing, 128, 64)
                System.Threading.Thread.Sleep(_msTimeToPing)
                If pinger.GetMessage(a.Status) <> "Success" Then
                    cunt += 1
                Else
                    cunt = 0
                End If

                On Error Resume Next
                If isVerbosed Then
                    _Message += pinger.GetMessage(a.Status)
                Else
                    If lastMessage <> pinger.GetMessage(a.Status) Then _Message += pinger.GetMessage(a.Status)
                End If
                MessagingStatus()
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

                _Message += "Connection Break Detected at second of " + globalcounter.ToString

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
                WebBrowser1.Navigate("http://1.1.1.1/login.html")
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
                TextBox1.AppendText(theMessage + _Message + vbCrLf)
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

                TextBox1.ScrollToCaret()
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

    Private Sub TimerStop()
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        If isProgramStarted Then

            'InjectBlocker()
            _Message += "Page Loading to " + WebBrowser1.Url.AbsoluteUri
            MessagingStatus2()
            _Message += "Page Loading to " + WebBrowser1.Url.AbsoluteUri
            MessagingStatus()
            Logging("Web Direct Link : " + WebBrowser1.Url.AbsoluteUri)

            'Prevent Redirect to Forbidden Website
            Dim tmpText As String = "http://1.1.1.1/"
            If Not WebBrowser1.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Invalid Redirection Specified, trying to stop action."
                MessagingStatus()
                WebBrowser1.Stop()
                AcquireState = False
                NavigateState = False
                'WebBrowser1.Navigate("http://1.1.1.1/login.html")
                theThread.Interrupt()
            Else
                theThread.Interrupt()
            End If
            tmpText = "res://"
            If WebBrowser1.Url.AbsoluteUri.ToString().Substring(0, tmpText.Length).Equals(tmpText) Then
                _Message += "Connection Dropped, retrying..."
                MessagingStatus()
                WebBrowser1.Stop()
                NavigateState = False
                WebBrowser1.Navigate("http://1.1.1.1/login.html")
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

    Private Sub AdvancedConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedConfigToolStripMenuItem.Click
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

        'USERNAME
        _Message += "Username changed to " + usname.Text + " with account type " + comboAccount.Text + "."
        MessagingStatus()
        userName = usname.Text
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

        IniModule.WriteINI(Path, ArrayConfig)
        OpenClose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenClose()
    End Sub

    Private Sub OpenClose()
        Dim resizer = GroupBox1.Width + 10
        If isOpen Then
            Me.Width -= resizer
            Me.Left += resizer / 2

        Else
            Me.Width += resizer
            Me.Left -= resizer / 2
        End If
        isOpen = Not isOpen
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
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
        If TextBox1.SelectedText.Length = 0 Then
            tcopy.Visible = False
            tselAll.Visible = True
        Else
            tcopy.Visible = True
            tselAll.Visible = False
        End If
    End Sub

    Private Sub tclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tclear.Click
        TextBox1.Text = "" + vbCrLf
    End Sub

    Private Sub tselAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tselAll.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub tcopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcopy.Click
        Clipboard.SetText(TextBox1.SelectedText)
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
        Return ""
    End Function

   
    Private Sub WebBrowser1_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
    End Sub
End Class
