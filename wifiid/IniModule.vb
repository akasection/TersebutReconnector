Imports Microsoft.VisualBasic
Module IniModule
    Public ReadOnly IniLookup As String() = {"PING_INTERVAL",
                                             "TIME_SAFE",
                                             "RTO_TOLERANCE",
                                             "VERBOSE",
                                             "LOG_TO_FILE",
                                             "TRAY",
                                             "USERNAME",
                                             "ACCTYPE",
                                             "PASSWORD",
                                             "VIEWLATENCY",
                                             "MAXPING",
                                             "GATEWAY",
                                             "LEGACY",
                                             "PRESET",
                                             "SAMPLES",
                                             "DISPLAY",
                                             "LOGINPAGE"
                                            }

    Public Function ReadINI(ByVal INIpath As String) As String()()
        If Not My.Computer.FileSystem.FileExists(INIpath) Then
            Return Nothing
        End If
        'Path = App.Path & DIR_SYSTEM & "config.fsys"

        Dim temp As String = ""
        Dim collectedString(IniLookup.Length - 1)() As String
        Dim numPos As Integer = 0
        Dim openNumber As Integer = FreeFile()
        For a As Integer = 0 To IniLookup.Length - 1 Step 1
            ReDim collectedString(a)(2)
        Next a
        Microsoft.VisualBasic.FileOpen(openNumber, INIpath, OpenMode.Input)
        Do While Not EOF(1)
            Microsoft.VisualBasic.Input(openNumber, temp)
            If Left(temp, 2) <> "//" Then
                For a As Integer = 0 To IniLookup.Length - 1 Step 1
                    collectedString(a)(0) = IniLookup(a)
                    ReadINIPart(temp, IniLookup(a), collectedString(a)(1))
                Next a
            End If
        Loop
        Microsoft.VisualBasic.FileClose(openNumber)
        Return collectedString
    End Function

    Public Sub WriteINI(ByVal INIpath As String, ByRef Containment As String()())
        Dim temp As String = ""
        Dim openNUmber As Integer = FreeFile()
        'Path = App.Path & DIR_SYSTEM & "config.fsys"
        'Microsoft.VisualBasic.FileOpen(openNUmber, INIpath, OpenMode.Output)
        'WRITE HEADERS!
        temp += "//Tersebut Reconnector Premium Configuration" & vbNewLine & "//Created by SECTION" & vbNewLine & "//Program Version " + Application.ProductVersion + vbNewLine + "//INI Version 1.1" & vbNewLine & vbNewLine
        'WriteLine(openNUmber, temp)
        For a As Integer = 0 To Containment.Length - 1 Step 1
            temp += Containment(a)(0) + "=" + Containment(a)(1) + vbNewLine
            'WriteLine(openNUmber, temp)
        Next a
        Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText(INIpath, temp, False)

    End Sub

    Public Sub ReadINIPart(ByVal StringPart As String, ByVal StringComparator As String, ByRef WhereToPut As String)
        If Left(StringPart, StringComparator.Length + 1) = StringComparator & "=" Then
            WhereToPut = Right(StringPart, Len(StringPart) - StringComparator.Length - 1)
        End If
    End Sub

    Public Function GetOptionValue(ByRef Containment As String()(), ByVal WhatOption As String) As String
        For a As Integer = 0 To Containment.Length - 1
            If Containment(a)(0).ToUpper = WhatOption.ToUpper Then
                Return Containment(a)(1)
            End If
        Next a
        Return Nothing
    End Function

    Public Sub SetOptionValue(ByRef Containment As String()(), ByVal WhatOption As String, ByVal WhatValue As String)
        For a As Integer = 0 To Containment.Length - 1
            If Containment(a)(0) = WhatOption Then
                Containment(a)(1) = WhatValue
                Exit Sub
            End If
        Next a
    End Sub
    Public Sub InitArrayValue(ByRef Containment As String()())
        For a As Integer = 0 To Containment.Length - 1
            Containment(a)(0) = IniLookup(a)
        Next a
    End Sub
End Module
