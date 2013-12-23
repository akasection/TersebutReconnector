Module CryptModule
#Region "Encryption Library"
    Public Function I2C(ByVal nt As Double) As String
        Select Case nt
            Case 26
                I2C = "A"
            Case 34
                I2C = "B"
            Case 72
                I2C = "C"
            Case 69
                I2C = "D"
            Case 50
                I2C = "E"
            Case 61
                I2C = "F"
            Case 33
                I2C = "G"
            Case 21
                I2C = "H"
            Case 73
                I2C = "I"
            Case 98
                I2C = "J"
            Case 15
                I2C = "K"
            Case 81
                I2C = "L"
            Case 29
                I2C = "M"
            Case 99
                I2C = "N"
            Case 10
                I2C = "O"
            Case 27
                I2C = "P"
            Case 56
                I2C = "Q"
            Case 59
                I2C = "R"
            Case 71
                I2C = "S"
            Case 36
                I2C = "T"
            Case 19
                I2C = "U"
            Case 51
                I2C = "V"
            Case 93
                I2C = "W"
            Case 74
                I2C = "X"
            Case 66
                I2C = "Y"
            Case 75
                I2C = "Z"
            Case 37
                I2C = "8"
            Case 58
                I2C = "a"
            Case 95
                I2C = "b"
            Case 32
                I2C = "c"
            Case 28
                I2C = "d"
            Case 38
                I2C = "e"
            Case 12
                I2C = "f"
            Case 60
                I2C = "g"
            Case 88
                I2C = "h"
            Case 62
                I2C = "i"
            Case 53
                I2C = "j"
            Case 45
                I2C = "k"
            Case 30
                I2C = "l"
            Case 24
                I2C = "m"
            Case 77
                I2C = "n"
            Case 23
                I2C = "o"
            Case 41
                I2C = "p"
            Case 90
                I2C = "q"
            Case 68
                I2C = "r"
            Case 16
                I2C = "s"
            Case 43
                I2C = "t"
            Case 64
                I2C = "u"
            Case 86
                I2C = "v"
            Case 20
                I2C = "w"
            Case 47
                I2C = "x"
            Case 83
                I2C = "y"
            Case 13
                I2C = "z"
            Case 89
                I2C = "0"
            Case 76
                I2C = "1"
            Case 46
                I2C = "2"
            Case 42
                I2C = "3"
            Case 17
                I2C = "4"
            Case 22
                I2C = "5"
            Case 54
                I2C = "6"
            Case 96
                I2C = "7"
            Case 82
                I2C = "8"
            Case 48
                I2C = "9"
            Case 11
                I2C = "C"
            Case 14
                I2C = "7"
            Case 18
                I2C = "n"
            Case 25
                I2C = "R"
            Case 31
                I2C = "T"
            Case 35
                I2C = "J"
            Case 39
                I2C = "u"
            Case 40
                I2C = "Q"
            Case 44
                I2C = "x"
            Case 49
                I2C = "W"
            Case 52
                I2C = "E"
            Case 55
                I2C = "6"
            Case 57
                I2C = "9"
            Case 63
                I2C = "A"
            Case 65
                I2C = "a"
            Case 67
                I2C = "O"
            Case 70
                I2C = "g"
            Case 78
                I2C = "I"
            Case 79
                I2C = "P"
            Case 80
                I2C = "l"
            Case 84
                I2C = "s"
            Case 85
                I2C = "X"
            Case 87
                I2C = "8"
            Case 91
                I2C = "d"
            Case 96
                I2C = "B"
            Case 94
                I2C = " "
            Case 97
                I2C = "-"
            Case 92
                I2C = "_"
            Case Else
                I2C = "H"
        End Select
    End Function

    Public Function C2I(ByVal Ch As String) As Integer
        Select Case Ch
            Case "A"
                C2I = 26
            Case "B"
                C2I = 34
            Case "C"
                C2I = 72
            Case "D"
                C2I = 69
            Case "E"
                C2I = 50
            Case "F"
                C2I = 61
            Case "G"
                C2I = 33
            Case "H"
                C2I = 21
            Case "I"
                C2I = 73
            Case "J"
                C2I = 98
            Case "K"
                C2I = 15
            Case "L"
                C2I = 81
            Case "M"
                C2I = 29
            Case "N"
                C2I = 99
            Case "O"
                C2I = 10
            Case "P"
                C2I = 27
            Case "Q"
                C2I = 56
            Case "R"
                C2I = 59
            Case "S"
                C2I = 71
            Case "T"
                C2I = 36
            Case "U"
                C2I = 19
            Case "V"
                C2I = 51
            Case "W"
                C2I = 93
            Case "X"
                C2I = 74
            Case "Y"
                C2I = 66
            Case "Z"
                C2I = 75
            Case "a"
                C2I = 58
            Case "b"
                C2I = 95
            Case "c"
                C2I = 32
            Case "d"
                C2I = 28
            Case "e"
                C2I = 38
            Case "f"
                C2I = 12
            Case "g"
                C2I = 60
            Case "h"
                C2I = 88
            Case "i"
                C2I = 62
            Case "j"
                C2I = 53
            Case "k"
                C2I = 45
            Case "l"
                C2I = 30
            Case "m"
                C2I = 24
            Case "n"
                C2I = 77
            Case "o"
                C2I = 23
            Case "p"
                C2I = 41
            Case "q"
                C2I = 90
            Case "r"
                C2I = 68
            Case "s"
                C2I = 16
            Case "t"
                C2I = 43
            Case "u"
                C2I = 64
            Case "v"
                C2I = 86
            Case "w"
                C2I = 20
            Case "x"
                C2I = 47
            Case "y"
                C2I = 83
            Case "z"
                C2I = 13
            Case "1"
                C2I = 76
            Case "2"
                C2I = 46
            Case "0"
                C2I = 89
            Case "3"
                C2I = 42
            Case "4"
                C2I = 17
            Case "5"
                C2I = 22
            Case "6"
                C2I = 54
            Case "7"
                C2I = 96
            Case "8"
                C2I = 82
            Case "9"
                C2I = 48
            Case " "
                C2I = 94
            Case "-"
                C2I = 97
            Case "_"
                C2I = 92
        End Select
        Return C2I
    End Function
#End Region

    Public Function SplitTextAdd(ByVal theString As String, ByVal Add As String) As String
        Dim lpart As String
        Dim rpart As String
        Dim Adda As String
        lpart = Left(theString, (theString.Length / 2))
        rpart = Right(theString, theString.Length / 2)
        Adda = Add
        'MsgBox "left is " & lpart & " and right is " & rpart
        SplitTextAdd = lpart & Adda & rpart
    End Function

    Public Function AbstractString(ByVal input As String) As String
        Dim lenI As Long
        Dim allchar As String

        Dim result As String = ""

        allchar = input
        lenI = input.Length

        For Each c As Char In allchar
            result = SplitTextAdd(result, C2I(c.ToString).ToString)
        Next

        'THE DECOMPILER
        Dim willResult As String = ""
        Dim lenDbl As Double
        Dim ch2 As Double
        lenDbl = result.Length
        Do Until result = ""
            ch2 = Val(Left(result, 2))
            lenDbl = lenDbl - 2
            willResult = willResult & I2C(ch2)
            result = Right(result, lenDbl)

        Loop
        Return willResult

    End Function

End Module
