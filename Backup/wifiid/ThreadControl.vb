Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
'Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Public Class ThreadControl
    <DllImport("Kernel32.dll")> _
    Private Shared Function SuspendThread(ByVal hThread As IntPtr) As Int32
    End Function

    Public Function Thread_Suspend(ByVal ThreadHandle As IntPtr) As Integer
        Return SuspendThread(ThreadHandle)
    End Function

    <DllImport("kernel32.dll")> _
    Private Shared Function ResumeThread(ByVal hThread As IntPtr) As Integer
    End Function
    Public Function Thread_Resume(ByVal ThreadHandle As IntPtr) As Integer
        Return ResumeThread(ThreadHandle)
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function OpenThread(ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As Integer) As IntPtr
    End Function

    Public Function Thread_GetHandle(ByVal ThreadID As Integer) As IntPtr
        Return OpenThread(ThreadAccess.SUSPEND_RESUME, False, ThreadID)
    End Function

    Public Function Thread_GetHandle(ByVal ThreadID As Integer, ByVal DesiredAccess As ThreadAccess) As IntPtr
        Return OpenThread(DesiredAccess, False, ThreadID)
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function CloseHandle(ByVal hHandle As IntPtr) As Boolean
    End Function
    Public Function Handle_Close(ByVal OpenedHandle As IntPtr) As Boolean
        Return CloseHandle(OpenedHandle)
    End Function

End Class

<Flags()> _
Public Enum ThreadAccess As Integer
    TERMINATE = (&H1)
    SUSPEND_RESUME = (&H2)
    GET_CONTEXT = (&H8)
    SET_CONTEXT = (&H10)
    SET_INFORMATION = (&H20)
    QUERY_INFORMATION = (&H40)
    SET_THREAD_TOKEN = (&H80)
    IMPERSONATE = (&H100)
    DIRECT_IMPERSONATION = (&H200)
End Enum
