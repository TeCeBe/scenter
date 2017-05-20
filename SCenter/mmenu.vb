Public Class mmenu
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Label2.MouseEnter
        Panel1.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave, Label2.MouseLeave
        Panel1.BackColor = Color.Transparent
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Panel1.Click
        select_radio.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class