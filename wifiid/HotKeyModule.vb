Imports System.Runtime.InteropServices

Module HotKeyModule
    Public Const MOD_ALT As Integer = &H1           'Alt key
    Public Const WM_HOTKEY As Integer = &H312       '


    <DllImport("User32.dll")> _
    Public Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")> _
    Public Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function


End Module
