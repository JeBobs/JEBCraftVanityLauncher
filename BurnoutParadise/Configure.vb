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

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        LocVars.VPLocation = (UsernameTextBox.Text)
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
        OpenFileDialog1.Filter = "Executable (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                myStream = OpenFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    UsernameTextBox.Text = OpenFileDialog1.FileName()
                End If
            Catch Ex As Exception
                ErrorBox.Show()
                ErrorBox.MessageLabel.Text = ("An error has occurred, please try again. 
If this error persists, please send a screenshot 
of this window to the developers at 
jebcraftgroup@gmail.com 
- 
Error 
" & "100")
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class