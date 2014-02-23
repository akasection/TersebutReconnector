Partial Public Class baseForm
    'Preset Class
    Dim currentShowPreset As Integer
    Dim PresetDescription As String() = {
"For low wifi.id signal strength but has potency to play games and obviously intended to play online games.",
"For weak-to-mid signal and using wifi.id as browsing or download purposes.",
"For strong wifi.id signal, and you are very sure that the wifi load is currently low. Intended for extreme (low latency) online games.",
"For strong wifi.id singnal, and used for multipurposes like playing minor games, browsing, office and syncing.",
"Perfect Reconnect is discouraged, as it will try to reconnect as fast as possible, ignoring any condition. Use with caution and make sure you have maximum signal and very low wifi load.",
"Custom setting to suit your preferences. Advanced Users only. Please consult to community for best settings you might need."
}
    Dim PresetImage As Image() = {
        My.Resources.tersebut_lowgaming,
        My.Resources.tersebut_work,
        My.Resources.tersebut_highgaming,
        My.Resources.high_standard,
        My.Resources.tersebut_perfect,
        My.Resources.tersebut_custom}

    Dim NumericPreset As Integer()()

    Private Sub InitializePresets()
        ReDim NumericPreset(6)
        ReDim NumericPreset(6)(0)
        ReDim NumericPreset(6)(1)
        ReDim NumericPreset(6)(2)
        ReDim NumericPreset(6)(3)
        ReDim NumericPreset(6)(4)
        ReDim NumericPreset(6)(5)

        'Input Numbers
        NumericPreset(0) = {500, 2000, 30, 4} 'Low Gaming
        NumericPreset(1) = {1000, 4000, 1, 6} 'Works
        NumericPreset(2) = {350, 1000, 30, 5} 'High Gaming
        NumericPreset(3) = {350, 2000, 60, 4} 'High Standard
        NumericPreset(4) = {200, 750, 1, 2} 'Perfect
        NumericPreset(5) = {_msTimeToPing, _msMaximumPing, timeToleranceLimit, RTOTolerance}
    End Sub
    Private Sub ShiftPreset(ByVal toLeft As Boolean)
        If toLeft Then
            currentShowPreset -= 1
        Else
            currentShowPreset += 1
        End If

        If currentShowPreset < 0 Then
            currentShowPreset = 5
        ElseIf currentShowPreset > 5 Then
            currentShowPreset = 0
        End If
        If currentShowPreset = selectedPreset Then
            btnSelectPresets.Enabled = False
            btnSelectPresets.Text = "Selected"
        Else
            btnSelectPresets.Text = "Select this preset!"
        End If
        txtDescription.Text = PresetDescription(currentShowPreset)
        imgPreset.Image = PresetImage(currentShowPreset)
    End Sub

    Private Sub SetPreset(ByVal whichPreset As Integer)
        currentShowPreset = whichPreset
        txtDescription.Text = PresetDescription(currentShowPreset)
        imgPreset.Image = PresetImage(currentShowPreset)
        btnSelectPresets.Text = "Selected"
        btnSelectPresets.Enabled = False

        'Set Property
        selectedPreset = whichPreset
        _msTimeToPing = NumericPreset(whichPreset)(0)
        _msMaximumPing = NumericPreset(whichPreset)(1)
        timeToleranceLimit = NumericPreset(whichPreset)(2)
        RTOTolerance = NumericPreset(whichPreset)(3)

        'Set Interface
        numInterval.Value = _msTimeToPing
        numMaxInterval.Value = _msMaximumPing
        numTimeSafe.Value = timeToleranceLimit
        numTolerance.Value = RTOTolerance
        'Save Configuration
        SaveConfiguration()
        _Message += "Preset Enabled : " + Preset(selectedPreset)
        MessagingStatus()
        _Message += "Preset : " + Preset(selectedPreset)
        MessagingStatus2()
        TabMaster.SelectTab(tabLog)
    End Sub

End Class
