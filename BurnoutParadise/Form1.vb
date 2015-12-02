Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.ConfClose = 1 Then
            My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\BackSound.wav",
                    AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("This feature has been neutered from this version of Vanity Launcher, Sorry! Error 9000", vbMsgBoxHelp)
    End Sub

    Private Sub ConfigureButton_Click(sender As Object, e As EventArgs) Handles ConfigureButton.Click
        Configure.Show()
    End Sub
    Private Sub ConfigureButton_MouseHover(sender As Object, e As EventArgs) Handles ConfigureButton.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub CheckVar_Click(sender As Object, e As EventArgs)
        MsgBox(GlobalVariables.ConfClose, vbOKOnly)
    End Sub
End Class
