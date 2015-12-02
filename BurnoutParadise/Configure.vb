Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Module INIHelper
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) As Integer
End Module

Public Class Configure
    Public Property VPInsLoc As Object
    Public Property BPInsLoc As Object

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        VPInsLoc = (UsernameTextBox.Text)
        BPInsLoc = (PasswordTextBox.Text)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\BackSound.wav",
    AudioPlayMode.Background)
        Me.Close()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        UsernameTextBox.Text = (OpenFileDialog1.FileName)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        PasswordTextBox.Text = (OpenFileDialog2.FileName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myStream As Stream = Nothing
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "Program Files (*.exe, *.lnk)|*.exe ,*.lnk|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = OpenFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    UsernameTextBox.Text = OpenFileDialog1.FileName()
                End If
            Catch Ex As Exception
                MsgBox("Cannot read file! Error 1", vbMsgBoxHelp)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
Public Class GlobalVariables
    Public Shared ConfClose As Integer = 0
    Public Shared SelectSound As String
End Class