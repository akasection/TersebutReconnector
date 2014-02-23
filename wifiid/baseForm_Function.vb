Partial Public Class baseForm
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

    Private Sub SaveConfiguration()
        'Message
        _Message += "Configuration saved."
        MessagingStatus2()

        'Saving Configuration
        If ArrayConfig Is Nothing Then
            ReDim ArrayConfig(IniLookup.Length)
            For a As Integer = 0 To IniLookup.Length Step 1
                ReDim ArrayConfig(a)(2)
            Next a
        End If

        'Reconnection
        SetOptionValue(ArrayConfig, "TIME_SAFE", numTimeSafe.Value)
        SetOptionValue(ArrayConfig, "RTO_TOLERANCE", numTolerance.Value)
        SetOptionValue(ArrayConfig, "PING_INTERVAL", numInterval.Value)

        'Developer
        SetOptionValue(ArrayConfig, "VERBOSE", ckVerbose.Checked)
        SetOptionValue(ArrayConfig, "LOG_TO_FILE", ckLog.Checked)
        SetOptionValue(ArrayConfig, "TRAY", ckClose.Checked)

        'Account 
        SetOptionValue(ArrayConfig, "USERNAME", usname.Text)
        SetOptionValue(ArrayConfig, "ACCTYPE", comboAccount.Text)
        If ckSavePassword.Checked Then
            SetOptionValue(ArrayConfig, "PASSWORD", txtPassword.Text)
        Else
            SetOptionValue(ArrayConfig, "PASSWORD", "")
        End If

        SetOptionValue(ArrayConfig, "VIEWLATENCY", ckLatencyView.Checked)
        SetOptionValue(ArrayConfig, "MAXPING", numMaxInterval.Value)

        'Option 1.7
        SetOptionValue(ArrayConfig, "GATEWAY", txtGateway.Text)
        SetOptionValue(ArrayConfig, "LEGACY", ckLegacyBrowser.Checked)
        SetOptionValue(ArrayConfig, "PRESET", selectedPreset) 'Actually this isn't needed :p but well...
        SetOptionValue(ArrayConfig, "SAMPLES", numSamples.Value)
        SetOptionValue(ArrayConfig, "DISPLAY", cbDisplay.Text)
        SetOptionValue(ArrayConfig, "LOGINPAGE", cbLogin.Text)
        'Save
        IniModule.WriteINI(Path, ArrayConfig)
        
    End Sub

    Public Function Int2Boolean(ByVal int As Integer) As Boolean
        If int > 0 Then Return True
        Return False
    End Function

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

    Private Function GetAccountType(ByVal p1 As String) As String
        'SPIN
        'Telkomsel()
        'Flexi()
        'Speedy()
        'Voucher()
        If p1 = "SPIN" Then
            Return "@SPIN"
        End If
        If p1 = "SPINSurprise" Then
            Return "@spin2"
        End If
        If p1 = "Speedy" Then
            Return "@telkom.net"
        End If
        If p1 = "Flexi" Then
            Return ""
        End If
        If p1 = "Telkom Voucher" Then
            Return "@telkomvoucher"
        End If
        If p1 = "Telkomsel FLASHZone" Then
            Return "@t.sel"
        End If
        If p1 = "Radnet" Then
            Return "@idn.telkom.net"
        End If
        If p1 = "Telkom Gift" Then
            Return "@gr3tong"
        End If
        If p1 = "Esia" Then
            Return "@esia"
        End If
        Return ""
    End Function
    Private Sub MessagingStatus()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf MessagingStatus))
        Else
            If _Message <> "" Then
                Dim theMessage = "[" + DateTime.Now.ToLongTimeString() + "]"

                txtLogger.AppendText(theMessage + _Message + vbCrLf)

                cursorPosition += theMessage.Length

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
                lastLatency = g
                LatencyQueue.Enqueue(g)
                chartPing.Series("dataSeries").Points.AddY(g)

                If (LatencyQueue.Count > numSample) Then
                    LatencyQueue.Dequeue()
                    chartPing.Series("dataSeries").Points.RemoveAt(0)
                End If
                'Averaging :)

            Catch e As FormatException
                LatencyQueue.Enqueue(_msMaximumPing)
                lastLatency = _msMaximumPing
                chartPing.Series("dataSeries").Points.AddY(_msMaximumPing)

                If (LatencyQueue.Count > numSample) Then
                    LatencyQueue.Dequeue()
                    chartPing.Series("dataSeries").Points.RemoveAt(0)
                End If
            End Try
            chartPing.ChartAreas(0).Axes(3).Maximum = LatencyQueue.Max
            ''' To give more bounce to current ping
            ''' We add increasing number of last ping to increase the factor of last ping.
            ''' 
            Dim avedata As Double
            If LatencyDisplay = "Off" Then
                'TabMaster.TabPages.Remove(tabMonitor)
                'TabMaster.TabPages(0).Hide()
            Else
                'TabMaster.TabPages.Add(tabMonitor)
                If LatencyDisplay = "Exact" Then
                    avedata = lastLatency
                ElseIf LatencyDisplay = "Average" Then
                    avedata = Math.Ceiling(LatencyQueue.Sum / LatencyQueue.Count)
                ElseIf LatencyDisplay = "Optimized" Then
                    Dim BounceNumber As Integer = 16
                    avedata = Math.Ceiling((LatencyQueue.Sum + (BounceNumber * lastLatency)) / (LatencyQueue.Count + BounceNumber))
                End If
            End If

            If avedata > 0 And avedata <= 50 Then
                lblLatency.ForeColor = Color.DarkGreen
            ElseIf avedata > 50 And avedata <= 200 Then
                lblLatency.ForeColor = Color.DarkOrange
            ElseIf avedata > 200 Then
                lblLatency.ForeColor = Color.DarkRed
            End If
            lblLatency.Text = avedata.ToString + "ms"
            _Message = ""

           
        End If
    End Sub

    Private Sub Logging(ByVal str As String)
        If isLogged Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\log.txt", "[" + DateTime.Now.ToShortDateString + "|" + DateTime.Now.ToLongTimeString() + "]" + str + vbCrLf, True)
        End If
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

#Region "Obsolete"
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
            btnStart.Enabled = True

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
                btnStop.Enabled = False
                btnStart.Enabled = False

                StartReconnectorToolStripMenuItem.Enabled = False
                StopReconnectorToolStripMenuItem.Enabled = False
                Button3.Text = "Install Reconnector Service"
            Else
            End If
        End If
    End Sub
#End Region
End Class
