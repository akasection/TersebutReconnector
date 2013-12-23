Module UnlockMod
    Public curVersion As String = My.Resources.regVersion.Substring(0, 8) 'Application.ProductVersion.Substring(0, 8)
    Private _fileRegistrationPath As String = Application.StartupPath + "\" + "tersebut.license"
    Public LocalInputKey As String = (My.Computer.Name + My.Resources.encodedRegCode.Substring(My.Computer.Name.Length - 1)).Substring(0, 32)

    Public Function Generate32LengthCode(ByVal input As String) As String
        Dim conntainer(8) As Byte
        Dim byt(32) As Byte
        Dim Result As String = ""
        'Dim ReformatInput As String = My.Computer.Name + My.Resources.encodedRegCode.Substring(My.Computer.Name.Length - 1)
        For a As Integer = 0 To 7
            conntainer(a) = Asc(curVersion(a))
        Next a
        Dim x As Integer = 0
        Dim xx As Integer = 0
        For Each b As Char In input 'ReformatInput
            byt(x) = Asc(b) Xor conntainer(xx)
            Result += Chr(byt(x))
            x += 1
            xx += 1
            If xx = 8 Then xx = 0
        Next
        Return Result
    End Function

    Public Function GetRegistered() As Boolean
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(_fileRegistrationPath)
        If (fileExists) Then
            Dim fileContents As Byte()
            fileContents = My.Computer.FileSystem.ReadAllBytes(_fileRegistrationPath)
            Dim f As String = ""
            For Each c As Byte In fileContents
                f += Chr(c).ToString
            Next
            If ValidateKey(f) = True Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function ValidateKey(ByVal input As String) As Boolean
        Dim checker As String = Generate32LengthCode(input).Substring(0, 32)
        'MessageBox.Show(checker + vbNewLine + AbstractString(LocalInputKey))
        'MessageBox.Show(UnlockMod.LocalInputKey)
        If checker = AbstractString(LocalInputKey) Then
            Return True
        End If
        Return False
    End Function
    Public Sub SetRegistered(ByVal ValidKey As String)
        Dim fileContents(32) As Byte
        For c As Integer = 0 To ValidKey.Length - 1 Step 1
            fileContents(c) = Asc(ValidKey(c))
        Next
        My.Computer.FileSystem.WriteAllBytes(_fileRegistrationPath, fileContents, False)

    End Sub
End Module
