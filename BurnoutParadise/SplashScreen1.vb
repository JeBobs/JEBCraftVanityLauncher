Public NotInheritable Class SplashScreen1
    Public Property Copyright As Object
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
    Private Sub Timer1_Tick() Handles Timer1.Tick
        Close()
    End Sub
End Class
