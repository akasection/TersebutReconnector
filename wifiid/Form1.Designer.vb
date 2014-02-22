<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseForm
    Inherits System.Windows.Forms.Form
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baseForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tcopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tselAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tclear = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ckVerbose = New System.Windows.Forms.CheckBox()
        Me.ckLog = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdvancedConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToTray = New System.Windows.Forms.ToolStripMenuItem()
        Me.HepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnGuide = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.windowControl = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDisplay = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGateway = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.numSamples = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ckLegacyBrowser = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.numMaxInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckSavePassword = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.comboAccount = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.usname = New System.Windows.Forms.TextBox()
        Me.numTolerance = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numTimeSafe = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ckLatencyView = New System.Windows.Forms.CheckBox()
        Me.btnSelectPresets = New System.Windows.Forms.Button()
        Me.ckClose = New System.Windows.Forms.CheckBox()
        Me.miniIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.miniMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartReconnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopReconnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ttt = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblLatency = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.lblTitleLatency = New System.Windows.Forms.Label()
        Me.TabMaster = New System.Windows.Forms.TabControl()
        Me.tabMonitor = New System.Windows.Forms.TabPage()
        Me.chartPing = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.txtLogger = New System.Windows.Forms.RichTextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.panelAbout = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPreset = New System.Windows.Forms.Label()
        Me.imgPreset = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.context.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.windowControl.SuspendLayout()
        CType(Me.numSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTolerance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimeSafe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.miniMenu.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.tabMonitor.SuspendLayout()
        CType(Me.chartPing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLog.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.panelAbout.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPreset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'context
        '
        Me.context.DropShadowEnabled = False
        Me.context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tcopy, Me.tselAll, Me.tclear})
        Me.context.Name = "context"
        Me.context.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.context.Size = New System.Drawing.Size(140, 70)
        '
        'tcopy
        '
        Me.tcopy.Name = "tcopy"
        Me.tcopy.Size = New System.Drawing.Size(139, 22)
        Me.tcopy.Text = "Copy"
        Me.tcopy.Visible = False
        '
        'tselAll
        '
        Me.tselAll.Name = "tselAll"
        Me.tselAll.Size = New System.Drawing.Size(139, 22)
        Me.tselAll.Text = "Select All"
        '
        'tclear
        '
        Me.tclear.Name = "tclear"
        Me.tclear.Size = New System.Drawing.Size(139, 22)
        Me.tclear.Text = "Clear Screen"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'wb
        '
        Me.wb.IsWebBrowserContextMenuEnabled = False
        Me.wb.Location = New System.Drawing.Point(8, 360)
        Me.wb.MinimumSize = New System.Drawing.Size(23, 23)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(292, 212)
        Me.wb.TabIndex = 99
        Me.wb.WebBrowserShortcutsEnabled = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 576)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 20)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Install Reconnector Service"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 576)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Waiting..."
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'ckVerbose
        '
        Me.ckVerbose.AutoSize = True
        Me.ckVerbose.Location = New System.Drawing.Point(16, 429)
        Me.ckVerbose.Name = "ckVerbose"
        Me.ckVerbose.Size = New System.Drawing.Size(126, 19)
        Me.ckVerbose.TabIndex = 14
        Me.ckVerbose.Text = "Verbose Reporting"
        Me.ttt.SetToolTip(Me.ckVerbose, "Generates more logging text for debugging " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or developer purposes.")
        Me.ckVerbose.UseVisualStyleBackColor = True
        '
        'ckLog
        '
        Me.ckLog.AutoSize = True
        Me.ckLog.Location = New System.Drawing.Point(162, 429)
        Me.ckLog.Name = "ckLog"
        Me.ckLog.Size = New System.Drawing.Size(81, 19)
        Me.ckLog.TabIndex = 15
        Me.ckLog.Text = "Log to File"
        Me.ttt.SetToolTip(Me.ckLog, "Saves any logging made into a text file.")
        Me.ckLog.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdvancedConfig, Me.MinToTray, Me.HepToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "Menu"
        '
        'AdvancedConfig
        '
        Me.AdvancedConfig.Name = "AdvancedConfig"
        Me.AdvancedConfig.Size = New System.Drawing.Size(107, 20)
        Me.AdvancedConfig.Text = "Configuration"
        '
        'MinToTray
        '
        Me.MinToTray.Name = "MinToTray"
        Me.MinToTray.Size = New System.Drawing.Size(125, 20)
        Me.MinToTray.Text = "Minimize to Tray"
        '
        'HepToolStripMenuItem
        '
        Me.HepToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnGuide, Me.OpenWebsiteToolStripMenuItem, Me.ToolStripSeparator3, Me.mnAbout})
        Me.HepToolStripMenuItem.Name = "HepToolStripMenuItem"
        Me.HepToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.HepToolStripMenuItem.Text = "Help"
        Me.HepToolStripMenuItem.Visible = False
        '
        'mnGuide
        '
        Me.mnGuide.Enabled = False
        Me.mnGuide.Name = "mnGuide"
        Me.mnGuide.Size = New System.Drawing.Size(176, 22)
        Me.mnGuide.Text = "Guide"
        '
        'OpenWebsiteToolStripMenuItem
        '
        Me.OpenWebsiteToolStripMenuItem.Enabled = False
        Me.OpenWebsiteToolStripMenuItem.Name = "OpenWebsiteToolStripMenuItem"
        Me.OpenWebsiteToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.OpenWebsiteToolStripMenuItem.Text = "Visit Homepage"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(173, 6)
        '
        'mnAbout
        '
        Me.mnAbout.Name = "mnAbout"
        Me.mnAbout.Size = New System.Drawing.Size(176, 22)
        Me.mnAbout.Text = "About"
        Me.mnAbout.Visible = False
        '
        'windowControl
        '
        Me.windowControl.Controls.Add(Me.Label2)
        Me.windowControl.Controls.Add(Me.cbDisplay)
        Me.windowControl.Controls.Add(Me.Label17)
        Me.windowControl.Controls.Add(Me.txtGateway)
        Me.windowControl.Controls.Add(Me.Label16)
        Me.windowControl.Controls.Add(Me.numSamples)
        Me.windowControl.Controls.Add(Me.Label14)
        Me.windowControl.Controls.Add(Me.Label13)
        Me.windowControl.Controls.Add(Me.ckLegacyBrowser)
        Me.windowControl.Controls.Add(Me.Label12)
        Me.windowControl.Controls.Add(Me.Label11)
        Me.windowControl.Controls.Add(Me.Label10)
        Me.windowControl.Controls.Add(Me.numMaxInterval)
        Me.windowControl.Controls.Add(Me.Label9)
        Me.windowControl.Controls.Add(Me.ckSavePassword)
        Me.windowControl.Controls.Add(Me.txtPassword)
        Me.windowControl.Controls.Add(Me.comboAccount)
        Me.windowControl.Controls.Add(Me.Label8)
        Me.windowControl.Controls.Add(Me.lblUsername)
        Me.windowControl.Controls.Add(Me.lblPassword)
        Me.windowControl.Controls.Add(Me.usname)
        Me.windowControl.Controls.Add(Me.numTolerance)
        Me.windowControl.Controls.Add(Me.Label5)
        Me.windowControl.Controls.Add(Me.ckLog)
        Me.windowControl.Controls.Add(Me.numTimeSafe)
        Me.windowControl.Controls.Add(Me.ckVerbose)
        Me.windowControl.Controls.Add(Me.Label4)
        Me.windowControl.Controls.Add(Me.numInterval)
        Me.windowControl.Controls.Add(Me.Label3)
        Me.windowControl.Controls.Add(Me.Button6)
        Me.windowControl.Controls.Add(Me.Button5)
        Me.windowControl.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowControl.Location = New System.Drawing.Point(644, 28)
        Me.windowControl.Name = "windowControl"
        Me.windowControl.Size = New System.Drawing.Size(312, 564)
        Me.windowControl.TabIndex = 11
        Me.windowControl.TabStop = False
        Me.windowControl.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Latency Display"
        '
        'cbDisplay
        '
        Me.cbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDisplay.FormattingEnabled = True
        Me.cbDisplay.Items.AddRange(New Object() {"Average", "Exact", "Optimized", "Off"})
        Me.cbDisplay.Location = New System.Drawing.Point(137, 257)
        Me.cbDisplay.Name = "cbDisplay"
        Me.cbDisplay.Size = New System.Drawing.Size(146, 23)
        Me.cbDisplay.TabIndex = 116
        Me.ttt.SetToolTip(Me.cbDisplay, "Display the what kind result of the ping " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on the main screen.")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 15)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "Gateway"
        '
        'txtGateway
        '
        Me.txtGateway.Location = New System.Drawing.Point(7, 98)
        Me.txtGateway.Name = "txtGateway"
        Me.txtGateway.Size = New System.Drawing.Size(126, 24)
        Me.txtGateway.TabIndex = 114
        Me.txtGateway.Text = "1.1.1.1"
        Me.txtGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttt.SetToolTip(Me.txtGateway, "Gateway address of wifi.id access. Default is 1.1.1.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "May be changed if specifie" & _
        "d wifi.id access has different " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gateway.")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 406)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 20)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Developer"
        '
        'numSamples
        '
        Me.numSamples.Location = New System.Drawing.Point(6, 256)
        Me.numSamples.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numSamples.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSamples.Name = "numSamples"
        Me.numSamples.Size = New System.Drawing.Size(113, 24)
        Me.numSamples.TabIndex = 8
        Me.ttt.SetToolTip(Me.numSamples, "Number of Samples " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defines how many samples that latency take to make" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "an aver" & _
        "age of current latency. If set to 1, it will show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "current latency, ignoring lat" & _
        "ency value in the past.")
        Me.numSamples.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 15)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Number of Samples"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Monitor and Report"
        '
        'ckLegacyBrowser
        '
        Me.ckLegacyBrowser.AutoSize = True
        Me.ckLegacyBrowser.Location = New System.Drawing.Point(16, 191)
        Me.ckLegacyBrowser.Name = "ckLegacyBrowser"
        Me.ckLegacyBrowser.Size = New System.Drawing.Size(188, 19)
        Me.ckLegacyBrowser.TabIndex = 7
        Me.ckLegacyBrowser.Text = "Use Legacy Reconnect Method"
        Me.ttt.SetToolTip(Me.ckLegacyBrowser, resources.GetString("ckLegacyBrowser.ToolTip"))
        Me.ckLegacyBrowser.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 20)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Account"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 20)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Reconnection Rule"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 20)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Ping Configuration"
        '
        'numMaxInterval
        '
        Me.numMaxInterval.Location = New System.Drawing.Point(153, 58)
        Me.numMaxInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numMaxInterval.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numMaxInterval.Name = "numMaxInterval"
        Me.numMaxInterval.Size = New System.Drawing.Size(140, 24)
        Me.numMaxInterval.TabIndex = 4
        Me.ttt.SetToolTip(Me.numMaxInterval, "Maximum Ping interval (in ms)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<Part of Dynamic Ping>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defines how long progr" & _
        "am waits the ping for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "responding before program pings again.")
        Me.numMaxInterval.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(154, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 15)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Maximum Ping Interval"
        '
        'ckSavePassword
        '
        Me.ckSavePassword.AutoSize = True
        Me.ckSavePassword.Location = New System.Drawing.Point(162, 330)
        Me.ckSavePassword.Name = "ckSavePassword"
        Me.ckSavePassword.Size = New System.Drawing.Size(104, 19)
        Me.ckSavePassword.TabIndex = 11
        Me.ckSavePassword.Text = "Save Password"
        Me.ttt.SetToolTip(Me.ckSavePassword, "Keep the password on the configuration, otherwise, it would be cleared each time " & _
        "program closes.")
        Me.ckSavePassword.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(159, 369)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(144, 24)
        Me.txtPassword.TabIndex = 13
        Me.ttt.SetToolTip(Me.txtPassword, "Login password that used to login.")
        '
        'comboAccount
        '
        Me.comboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAccount.FormattingEnabled = True
        Me.comboAccount.Items.AddRange(New Object() {"SPIN", "Speedy", "Flexi", "Voucher", "Telkomsel FLASHZone", "Radnet", "free@wifi.id", "BandungJuara@wifi.id", "SPINSurprise", "Telkom Gift", "Esia", "*Generic"})
        Me.comboAccount.Location = New System.Drawing.Point(7, 328)
        Me.comboAccount.Name = "comboAccount"
        Me.comboAccount.Size = New System.Drawing.Size(146, 23)
        Me.comboAccount.TabIndex = 10
        Me.ttt.SetToolTip(Me.comboAccount, "Defines what account should be used to connect the wifi.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Account Type"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(10, 353)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(62, 15)
        Me.lblUsername.TabIndex = 14
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(159, 353)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 15)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'usname
        '
        Me.usname.Location = New System.Drawing.Point(9, 369)
        Me.usname.Name = "usname"
        Me.usname.Size = New System.Drawing.Size(144, 24)
        Me.usname.TabIndex = 12
        Me.ttt.SetToolTip(Me.usname, "Username used to login into the wifi.")
        '
        'numTolerance
        '
        Me.numTolerance.Location = New System.Drawing.Point(153, 161)
        Me.numTolerance.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numTolerance.Name = "numTolerance"
        Me.numTolerance.Size = New System.Drawing.Size(140, 24)
        Me.numTolerance.TabIndex = 6
        Me.ttt.SetToolTip(Me.numTolerance, resources.GetString("numTolerance.ToolTip"))
        Me.numTolerance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Reconnect Tolerance"
        '
        'numTimeSafe
        '
        Me.numTimeSafe.Location = New System.Drawing.Point(6, 161)
        Me.numTimeSafe.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numTimeSafe.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTimeSafe.Name = "numTimeSafe"
        Me.numTimeSafe.Size = New System.Drawing.Size(140, 24)
        Me.numTimeSafe.TabIndex = 5
        Me.ttt.SetToolTip(Me.numTimeSafe, resources.GetString("numTimeSafe.ToolTip"))
        Me.numTimeSafe.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TimeSafe Timeout"
        '
        'numInterval
        '
        Me.numInterval.Location = New System.Drawing.Point(7, 58)
        Me.numInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numInterval.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(140, 24)
        Me.numInterval.TabIndex = 3
        Me.ttt.SetToolTip(Me.numInterval, "Minimum Ping Interval (in ms)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<Part of Dynamic Ping>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defines the minimum ti" & _
        "me program will ping again" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to server after receiving response.")
        Me.numInterval.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Minimum Ping Interval"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(214, 522)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 36)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Cancel"
        Me.ttt.SetToolTip(Me.Button6, "Discard changes.")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(115, 522)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 36)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Save"
        Me.ttt.SetToolTip(Me.Button5, "Save the configuration you have been made.")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ckLatencyView
        '
        Me.ckLatencyView.AutoSize = True
        Me.ckLatencyView.Location = New System.Drawing.Point(382, 540)
        Me.ckLatencyView.Name = "ckLatencyView"
        Me.ckLatencyView.Size = New System.Drawing.Size(156, 19)
        Me.ckLatencyView.TabIndex = 9
        Me.ckLatencyView.Text = "Display Average Latency"
        Me.ttt.SetToolTip(Me.ckLatencyView, "Display the result of the ping on the main screen.")
        Me.ckLatencyView.UseVisualStyleBackColor = True
        Me.ckLatencyView.Visible = False
        '
        'btnSelectPresets
        '
        Me.btnSelectPresets.Enabled = False
        Me.btnSelectPresets.Location = New System.Drawing.Point(400, 565)
        Me.btnSelectPresets.Name = "btnSelectPresets"
        Me.btnSelectPresets.Size = New System.Drawing.Size(146, 28)
        Me.btnSelectPresets.TabIndex = 16
        Me.btnSelectPresets.Text = "Select this preset!"
        Me.ttt.SetToolTip(Me.btnSelectPresets, "Select this to apply preset into your current configuration.")
        Me.btnSelectPresets.UseVisualStyleBackColor = True
        '
        'ckClose
        '
        Me.ckClose.AutoSize = True
        Me.ckClose.Location = New System.Drawing.Point(170, 578)
        Me.ckClose.Name = "ckClose"
        Me.ckClose.Size = New System.Drawing.Size(120, 19)
        Me.ckClose.TabIndex = 8
        Me.ckClose.Text = "Close Box to Tray"
        Me.ttt.SetToolTip(Me.ckClose, "Clicking Close Button will order program to minimize to tray. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use Right-click t" & _
        "ray and close to close program.")
        Me.ckClose.UseVisualStyleBackColor = True
        Me.ckClose.Visible = False
        '
        'miniIcon
        '
        Me.miniIcon.BalloonTipText = "Reconnector has running in background!"
        Me.miniIcon.BalloonTipTitle = "Reconnector in Background"
        Me.miniIcon.ContextMenuStrip = Me.miniMenu
        Me.miniIcon.Text = "Tersebut Reconnector"
        '
        'miniMenu
        '
        Me.miniMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowWindowToolStripMenuItem, Me.ToolStripSeparator2, Me.StartReconnectorToolStripMenuItem, Me.StopReconnectorToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.miniMenu.Name = "miniMenu"
        Me.miniMenu.Size = New System.Drawing.Size(169, 104)
        '
        'ShowWindowToolStripMenuItem
        '
        Me.ShowWindowToolStripMenuItem.Name = "ShowWindowToolStripMenuItem"
        Me.ShowWindowToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ShowWindowToolStripMenuItem.Text = "Show Window"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'StartReconnectorToolStripMenuItem
        '
        Me.StartReconnectorToolStripMenuItem.Name = "StartReconnectorToolStripMenuItem"
        Me.StartReconnectorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.StartReconnectorToolStripMenuItem.Text = "Start Reconnector"
        '
        'StopReconnectorToolStripMenuItem
        '
        Me.StopReconnectorToolStripMenuItem.Name = "StopReconnectorToolStripMenuItem"
        Me.StopReconnectorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.StopReconnectorToolStripMenuItem.Text = "Stop Reconnector"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(332, 576)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "Manual Color"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'ttt
        '
        Me.ttt.AutoPopDelay = 10000
        Me.ttt.InitialDelay = 50
        Me.ttt.IsBalloon = True
        Me.ttt.ReshowDelay = 100
        Me.ttt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttt.ToolTipTitle = "Tersebut Reconnector"
        '
        'lblLatency
        '
        Me.lblLatency.AutoSize = True
        Me.lblLatency.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatency.Location = New System.Drawing.Point(193, 341)
        Me.lblLatency.Name = "lblLatency"
        Me.lblLatency.Size = New System.Drawing.Size(66, 16)
        Me.lblLatency.TabIndex = 104
        Me.lblLatency.Text = "unknown"
        Me.lblLatency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttt.SetToolTip(Me.lblLatency, "This displays the latency of your connection. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Green means good quality." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yellow" & _
        " means fair quality (but be warned)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Red means poor quality." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Black means impos" & _
        "sible.")
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(471, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop Reconnector"
        Me.ttt.SetToolTip(Me.Button2, "Hotkey : Alt-F12 (Toggles with Start)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stops the reconnector.")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Reconnector"
        Me.ttt.SetToolTip(Me.Button1, "Hotkey : Alt-F12 (Toggles with Stop)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Starts the reconnector.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(349, 445)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(20, 50)
        Me.btnLeft.TabIndex = 115
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(586, 445)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(20, 50)
        Me.btnRight.TabIndex = 117
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'lblTitleLatency
        '
        Me.lblTitleLatency.AutoSize = True
        Me.lblTitleLatency.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLatency.Location = New System.Drawing.Point(91, 333)
        Me.lblTitleLatency.Name = "lblTitleLatency"
        Me.lblTitleLatency.Size = New System.Drawing.Size(113, 25)
        Me.lblTitleLatency.TabIndex = 103
        Me.lblTitleLatency.Text = "Latency: "
        Me.lblTitleLatency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabMaster
        '
        Me.TabMaster.Controls.Add(Me.tabMonitor)
        Me.TabMaster.Controls.Add(Me.tabLog)
        Me.TabMaster.Controls.Add(Me.tabAbout)
        Me.TabMaster.Location = New System.Drawing.Point(6, 36)
        Me.TabMaster.Name = "TabMaster"
        Me.TabMaster.SelectedIndex = 0
        Me.TabMaster.Size = New System.Drawing.Size(632, 297)
        Me.TabMaster.TabIndex = 100
        '
        'tabMonitor
        '
        Me.tabMonitor.Controls.Add(Me.chartPing)
        Me.tabMonitor.Location = New System.Drawing.Point(4, 24)
        Me.tabMonitor.Name = "tabMonitor"
        Me.tabMonitor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMonitor.Size = New System.Drawing.Size(624, 269)
        Me.tabMonitor.TabIndex = 1
        Me.tabMonitor.Text = "Latency Monitor"
        Me.tabMonitor.UseVisualStyleBackColor = True
        '
        'chartPing
        '
        Me.chartPing.BorderlineWidth = 0
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.Minimum = 1.0R
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX2.LineWidth = 3
        ChartArea1.AxisY.IsLogarithmic = True
        ChartArea1.AxisY.IsMarginVisible = False
        ChartArea1.AxisY.LineWidth = 3
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY2.Crossing = -1.7976931348623157E+308R
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea1.AxisY2.LineWidth = 3
        ChartArea1.AxisY2.MajorGrid.Interval = 200.0R
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.MinorGrid.Enabled = True
        ChartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.CursorY.AxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        ChartArea1.CursorY.IsUserEnabled = True
        ChartArea1.CursorY.IsUserSelectionEnabled = True
        ChartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.CursorY.SelectionColor = System.Drawing.Color.Gray
        ChartArea1.Name = "charts"
        Me.chartPing.ChartAreas.Add(ChartArea1)
        Me.chartPing.Location = New System.Drawing.Point(6, 6)
        Me.chartPing.Name = "chartPing"
        Me.chartPing.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartPing.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Black}
        Series1.BorderWidth = 3
        Series1.ChartArea = "charts"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.EmptyPointStyle.Color = System.Drawing.Color.Red
        Series1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.IsXValueIndexed = True
        Series1.MarkerBorderWidth = 3
        Series1.Name = "dataSeries"
        Series1.ShadowColor = System.Drawing.Color.Gray
        Series1.ShadowOffset = 1
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.chartPing.Series.Add(Series1)
        Me.chartPing.Size = New System.Drawing.Size(612, 257)
        Me.chartPing.TabIndex = 0
        '
        'tabLog
        '
        Me.tabLog.Controls.Add(Me.txtLogger)
        Me.tabLog.Location = New System.Drawing.Point(4, 24)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLog.Size = New System.Drawing.Size(624, 269)
        Me.tabLog.TabIndex = 0
        Me.tabLog.Text = "Logging"
        Me.tabLog.UseVisualStyleBackColor = True
        '
        'txtLogger
        '
        Me.txtLogger.BackColor = System.Drawing.Color.White
        Me.txtLogger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogger.ContextMenuStrip = Me.context
        Me.txtLogger.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogger.Location = New System.Drawing.Point(0, 3)
        Me.txtLogger.Name = "txtLogger"
        Me.txtLogger.ReadOnly = True
        Me.txtLogger.Size = New System.Drawing.Size(625, 266)
        Me.txtLogger.TabIndex = 101
        Me.txtLogger.Text = ""
        Me.txtLogger.WordWrap = False
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.panelAbout)
        Me.tabAbout.Location = New System.Drawing.Point(4, 24)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(624, 269)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'panelAbout
        '
        Me.panelAbout.BackColor = System.Drawing.Color.White
        Me.panelAbout.Controls.Add(Me.lblVersion)
        Me.panelAbout.Controls.Add(Me.LinkLabel3)
        Me.panelAbout.Controls.Add(Me.Label7)
        Me.panelAbout.Controls.Add(Me.LinkLabel2)
        Me.panelAbout.Controls.Add(Me.LinkLabel1)
        Me.panelAbout.Controls.Add(Me.Label6)
        Me.panelAbout.Controls.Add(Me.PictureBox2)
        Me.panelAbout.Controls.Add(Me.PictureBox1)
        Me.panelAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAbout.Location = New System.Drawing.Point(0, 0)
        Me.panelAbout.Name = "panelAbout"
        Me.panelAbout.Size = New System.Drawing.Size(624, 269)
        Me.panelAbout.TabIndex = 103
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(364, 79)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(64, 15)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "version XX"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(469, 249)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(29, 15)
        Me.LinkLabel3.TabIndex = 7
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Web"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(504, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Created by SECTION"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(556, 249)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(63, 15)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "deviantArt"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(498, 249)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 15)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Facebook"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(348, 135)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Reconnector.My.Resources.Resources.tersebut
        Me.PictureBox2.Location = New System.Drawing.Point(248, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(360, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Reconnector.My.Resources.Resources.sectiontile
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPreset
        '
        Me.lblPreset.AutoSize = True
        Me.lblPreset.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreset.Location = New System.Drawing.Point(436, 422)
        Me.lblPreset.Name = "lblPreset"
        Me.lblPreset.Size = New System.Drawing.Size(80, 20)
        Me.lblPreset.TabIndex = 114
        Me.lblPreset.Text = "Presets!"
        '
        'imgPreset
        '
        Me.imgPreset.Location = New System.Drawing.Point(382, 445)
        Me.imgPreset.Name = "imgPreset"
        Me.imgPreset.Size = New System.Drawing.Size(188, 50)
        Me.imgPreset.TabIndex = 116
        Me.imgPreset.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDescription.Location = New System.Drawing.Point(349, 502)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(257, 57)
        Me.txtDescription.TabIndex = 118
        Me.txtDescription.Text = "<CONTENT_DESCRIPTION>"
        '
        'baseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 600)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.imgPreset)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.lblPreset)
        Me.Controls.Add(Me.btnSelectPresets)
        Me.Controls.Add(Me.TabMaster)
        Me.Controls.Add(Me.lblLatency)
        Me.Controls.Add(Me.lblTitleLatency)
        Me.Controls.Add(Me.windowControl)
        Me.Controls.Add(Me.ckLatencyView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ckClose)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "baseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tersebut Reconnector"
        Me.context.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.windowControl.ResumeLayout(False)
        Me.windowControl.PerformLayout()
        CType(Me.numSamples, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTolerance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimeSafe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.miniMenu.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.tabMonitor.ResumeLayout(False)
        CType(Me.chartPing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLog.ResumeLayout(False)
        Me.tabAbout.ResumeLayout(False)
        Me.panelAbout.ResumeLayout(False)
        Me.panelAbout.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPreset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents wb As System.Windows.Forms.WebBrowser
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ckVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents ckLog As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdvancedConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents windowControl As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents numTolerance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numTimeSafe As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents miniIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents MinToTray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckClose As System.Windows.Forms.CheckBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents miniMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartReconnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopReconnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tcopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tselAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tclear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents comboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents usname As System.Windows.Forms.TextBox
    Friend WithEvents ckSavePassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents HepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnGuide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttt As System.Windows.Forms.ToolTip
    Friend WithEvents ckLatencyView As System.Windows.Forms.CheckBox
    Friend WithEvents numMaxInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTitleLatency As System.Windows.Forms.Label
    Friend WithEvents lblLatency As System.Windows.Forms.Label
    Friend WithEvents OpenWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents numSamples As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ckLegacyBrowser As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabMaster As System.Windows.Forms.TabControl
    Friend WithEvents tabLog As System.Windows.Forms.TabPage
    Friend WithEvents txtLogger As System.Windows.Forms.RichTextBox
    Friend WithEvents tabMonitor As System.Windows.Forms.TabPage
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents panelAbout As System.Windows.Forms.Panel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSelectPresets As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtGateway As System.Windows.Forms.TextBox
    Friend WithEvents lblPreset As System.Windows.Forms.Label
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents imgPreset As System.Windows.Forms.PictureBox
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents chartPing As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDisplay As System.Windows.Forms.ComboBox

End Class
