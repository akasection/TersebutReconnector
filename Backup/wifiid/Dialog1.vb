Imports System.Windows.Forms


Public Class Licensing

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ValidateKey(UnlockInput.Text) Then
            MessageBox.Show("Unlock succeeded. Thank you for using Tersebut Reconnector!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UnlockMod.SetRegistered(UnlockMod.LocalInputKey)
            Me.Close()
        Else
            MessageBox.Show("Invalid Unlock Code! " + vbNewLine + "Please verify that you have entered right code, or acquired the code from the right developer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End
    End Sub

    Private Sub Licensing_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Licensing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show(UnlockMod.LocalInputKey.Length)

        UnlockInput.Text = CryptModule.AbstractString(UnlockMod.LocalInputKey)
        'MessageBox.Show(UnlockInput.Text.Length)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clipboard.SetText(UnlockInput.Text)
    End Sub
End Class
