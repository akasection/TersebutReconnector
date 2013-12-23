Imports System.Threading

Public Class StayAwake

    Dim sleepSwitchValue As Boolean = False

    WriteOnly Property SleepSwitch As Boolean
        Set(ByVal value As Boolean)
            sleepSwitchValue = value
        End Set
    End Property

    Sub New()
    End Sub


End Class
