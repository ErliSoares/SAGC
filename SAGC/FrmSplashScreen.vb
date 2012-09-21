Public Class FrmSplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FrmPrincipal.Show()
        Me.Visible = False
    End Sub
End Class