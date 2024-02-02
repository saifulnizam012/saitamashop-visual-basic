Public Class frm_welcome_a179830
    Private Sub btn_welcome_Click(sender As Object, e As EventArgs) Handles btn_welcome.Click

        username = txt_name.Text

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub frm_welcome_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class