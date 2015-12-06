Public Class ErrorBox
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        My.Computer.Audio.Play("C:\Users\jebob\Desktop\Code Projects\burnout-paradise-fansite-kit\Audio\BackSound.wav",
    AudioPlayMode.Background)
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpButton.Click
        Me.Close()
    End Sub
End Class
