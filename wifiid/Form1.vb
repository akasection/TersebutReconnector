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
    Private LastValidNumber As Integer = 0
 
    Dim theThread As Threading.Thread
    Dim threadAwaker As StayAwake
    Private _Message As String
    Private AcquireState As Boolean = False
    Private NavigateState As Boolean = True
    Private isOpen As Boolean = True
    Private isFirstInstall = True
    Private numOfMessages As Integer = 0
    Dim lastPost As Integer = 0
    Private cursorPosition As Long = 0
    Private isProgramStarted As Boolean = False
    'Property Initiator
    Dim ArrayConfig()() As String
    Private Path As String = Application.StartupPath + "\" + "tersebut.ini"

    Private ActionCommand As Integer = 0
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        isProgramStarted = True
        Button1.Enabled = False
        Button3.Enabled = False
        Timer1.Enabled = True
        pinger = New ICMPClass
        _Message += "Begin :" + " " + "Pinging Gateway : " + Gateway
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
        txtLogger.ScrollToCaret()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        globalcounter += 1
        Label1.Text = "Program time counter : " + globalcounter.ToString + " seconds."
    End Sub

    Private Sub TimerStop()
        'Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub AdvancedConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedConfig.Click
        OpenClose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenClose()
    End Sub

#Region "UI Event"
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
#End Region

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
        If ActionCommand = 1 Then 'Command : Stop
            ActionCommand = 0
            Button2_Click(Me, Nothing)
        End If
        If ActionCommand = 2 Then 'Command : Start
            ActionCommand = 0
            Button1_Click(Me, Nothing)
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim webAddress As String = "http://akasection.tumblr.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub btnSelectPresets_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectPresets.Click
        btnSelectPresets.Enabled = False
    End Sub

    Private Sub btnLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft.Click
        btnSelectPresets.Enabled = True
        ShiftPreset(True)

    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click
        btnSelectPresets.Enabled = True
        ShiftPreset(False)
    End Sub

End Class
