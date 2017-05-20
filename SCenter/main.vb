Public Class main
    Dim t As Int32 = 1
    Dim network As Int32 = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If t = 1 Then
            Dim d As Date = Date.Today
            Label1.Text = d.ToString("dd MMMM yyyy")
            t = t + 1
        ElseIf t = 2 Then
            Dim time As Date = DateTime.Now
            Label1.Text = time.ToString("H:mm")
            If Me.BackColor = Color.Black Then
                t = t + 1
            Else
                t = 1
            End If
        ElseIf t = 3 Then
            Label1.Text = "Tryb nocny aktywny"
            t = 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If DateTime.Now.Hour >= 22 OrElse DateTime.Now.Hour < 7 Then
            Me.BackColor = Color.Black
        Else
            Me.BackColor = Color.SteelBlue
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        start.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        radio.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If My.Computer.Network.IsAvailable = False Then
            network = network + 1
        Else
            network = 0
        End If
        If network = 1 Then
            Dim network As Boolean = False
            err_scr.Label2.Text = "Brak połączenia z internetem!"
            err_scr.Show()
            My.Computer.Audio.Play(My.Resources.dingdong, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel1.Hide()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        err_scr.Close()
        Timer4.Stop()
    End Sub
End Class
