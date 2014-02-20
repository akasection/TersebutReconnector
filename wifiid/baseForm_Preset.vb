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

    End Sub
End Class
