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
        Me.context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tcopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tselAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tclear = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckVerbose = New System.Windows.Forms.CheckBox()
        Me.ckLog = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdvancedConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboAccount = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.usname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckClose = New System.Windows.Forms.CheckBox()
        Me.numTolerance = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numTimeSafe = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.miniIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.miniMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartReconnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopReconnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.context.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numTolerance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimeSafe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.miniMenu.SuspendLayout()
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(317, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Reconnector"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(9, 286)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(23, 23)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(292, 212)
        Me.WebBrowser1.TabIndex = 99
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(476, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop Reconnector"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 46)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Install Reconnector Service"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Waiting..."
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2012-2013 Tersebut Reconnector" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SECTION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ckVerbose
        '
        Me.ckVerbose.AutoSize = True
        Me.ckVerbose.Location = New System.Drawing.Point(9, 203)
        Me.ckVerbose.Name = "ckVerbose"
        Me.ckVerbose.Size = New System.Drawing.Size(126, 19)
        Me.ckVerbose.TabIndex = 6
        Me.ckVerbose.Text = "Verbose Reporting"
        Me.ckVerbose.UseVisualStyleBackColor = True
        '
        'ckLog
        '
        Me.ckLog.AutoSize = True
        Me.ckLog.Location = New System.Drawing.Point(9, 231)
        Me.ckLog.Name = "ckLog"
        Me.ckLog.Size = New System.Drawing.Size(81, 19)
        Me.ckLog.TabIndex = 7
        Me.ckLog.Text = "Log to File"
        Me.ckLog.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdvancedConfigToolStripMenuItem, Me.MinimizeToTrayToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "Menu"
        '
        'AdvancedConfigToolStripMenuItem
        '
        Me.AdvancedConfigToolStripMenuItem.Name = "AdvancedConfigToolStripMenuItem"
        Me.AdvancedConfigToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.AdvancedConfigToolStripMenuItem.Text = "Advanced Config"
        '
        'MinimizeToTrayToolStripMenuItem
        '
        Me.MinimizeToTrayToolStripMenuItem.Name = "MinimizeToTrayToolStripMenuItem"
        Me.MinimizeToTrayToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.MinimizeToTrayToolStripMenuItem.Text = "Minimize to Tray"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboAccount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.usname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ckClose)
        Me.GroupBox1.Controls.Add(Me.numTolerance)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ckLog)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.numTimeSafe)
        Me.GroupBox1.Controls.Add(Me.ckVerbose)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.numInterval)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(644, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 489)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced Config"
        '
        'comboAccount
        '
        Me.comboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAccount.FormattingEnabled = True
        Me.comboAccount.Items.AddRange(New Object() {"Speedy"})
        Me.comboAccount.Location = New System.Drawing.Point(8, 352)
        Me.comboAccount.Name = "comboAccount"
        Me.comboAccount.Size = New System.Drawing.Size(152, 23)
        Me.comboAccount.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Account Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Wifi.ID Username"
        '
        'usname
        '
        Me.usname.Location = New System.Drawing.Point(8, 304)
        Me.usname.Name = "usname"
        Me.usname.Size = New System.Drawing.Size(152, 24)
        Me.usname.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Service Status"
        '
        'ckClose
        '
        Me.ckClose.AutoSize = True
        Me.ckClose.Location = New System.Drawing.Point(9, 258)
        Me.ckClose.Name = "ckClose"
        Me.ckClose.Size = New System.Drawing.Size(120, 19)
        Me.ckClose.TabIndex = 8
        Me.ckClose.Text = "Close Box to Tray"
        Me.ckClose.UseVisualStyleBackColor = True
        '
        'numTolerance
        '
        Me.numTolerance.Location = New System.Drawing.Point(9, 157)
        Me.numTolerance.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numTolerance.Name = "numTolerance"
        Me.numTolerance.Size = New System.Drawing.Size(140, 24)
        Me.numTolerance.TabIndex = 5
        Me.numTolerance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Reconnect Tolerance"
        '
        'numTimeSafe
        '
        Me.numTimeSafe.Location = New System.Drawing.Point(9, 102)
        Me.numTimeSafe.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numTimeSafe.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTimeSafe.Name = "numTimeSafe"
        Me.numTimeSafe.Size = New System.Drawing.Size(140, 24)
        Me.numTimeSafe.TabIndex = 4
        Me.numTimeSafe.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TimeSafe Timeout"
        '
        'numInterval
        '
        Me.numInterval.Location = New System.Drawing.Point(9, 46)
        Me.numInterval.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numInterval.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(140, 24)
        Me.numInterval.TabIndex = 3
        Me.numInterval.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ping Interval"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(88, 456)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 27)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 456)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 27)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ContextMenuStrip = Me.context
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(9, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(625, 239)
        Me.TextBox1.TabIndex = 100
        Me.TextBox1.Text = ""
        Me.TextBox1.WordWrap = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(552, 456)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 27)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "Manual Color"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'baseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 525)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "baseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tersebut Reconnector Premium "
        Me.context.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numTolerance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimeSafe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.miniMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents ckLog As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdvancedConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents numTolerance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numTimeSafe As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents miniIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents MinimizeToTrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckClose As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents comboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents usname As System.Windows.Forms.TextBox

End Class
