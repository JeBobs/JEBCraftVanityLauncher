Public Class DebugMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorBox.Show()
        ErrorBox.MessageLabel.Text = ("An error has occurred, please try again. 
If this error persists, please send a screenshot 
of this window to the developers at 
jebcraftgroup@gmail.com 
- 
Error 
" & "ErrorBoxTest")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("LocVars.VPLocation = " & LocVars.VPLocation, vbOKOnly)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class