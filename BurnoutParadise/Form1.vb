Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(LocVars.VPTestLocation) Then
            LocVars.VPLocation = (LocVars.VPTestLocation)
        End If
        'If GlobalVariables.ConfClose = 1 Then
        '  My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\BackSound.wav",
        ' AudioPlayMode.Background)
        'End If
    End Sub

    Private Sub VPLaunch_Click(sender As Object, e As EventArgs) Handles VPLaunch.Click
        If LocVars.VPLocation = ("undefined") Then
            ErrorBox.Show()
            ErrorBox.MessageLabel.Text = ("An error has occurred, please try again. 
If this error persists, please send a screenshot 
of this window to the developers at 
jebcraftgroup@gmail.com 
- 
Error 
" & "300")
        Else
            Process.Start(LocVars.VPLocation)
        End If

    End Sub

    Private Sub ConfigureButton_Click(sender As Object, e As EventArgs) Handles ConfigureButton.Click
        Configure.Show()
        Configure.UsernameTextBox.Text = (LocVars.VPLocation)
    End Sub
    Private Sub ConfigureButton_MouseHover(sender As Object, e As EventArgs) Handles ConfigureButton.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles VPLaunch.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub CheckVar_Click(sender As Object, e As EventArgs)
        'MsgBox(GlobalVariables.ConfClose, vbOKOnly)
    End Sub
    Private Sub DebugButton_MouseHover(sender As Object, e As EventArgs) Handles DebugButton.MouseHover
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\SelectSound.wav",
    AudioPlayMode.Background)
    End Sub
    Private Sub DebugButton_Click(sender As Object, e As EventArgs) Handles DebugButton.Click
        ErrorBox.Show()
        ErrorBox.MessageLabel.Text = ("An error has occurred, please try again. 
If this error persists, please send a screenshot 
of this window to the developers at 
jebcraftgroup@gmail.com 
- 
Error 
" & "DebugTest")
    End Sub
End Class