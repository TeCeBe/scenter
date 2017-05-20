Public Class select_radio

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ListBox1.SelectedItem = "Radio Plus Głogów" Then
            radio.Show()
            radio.WebBrowser1.Url = New Uri("http://www.radioplus.pl/player?select=glogow&id=40")
            radio.Label1.Text = "Radio Plus Głogów"
            main.Label2.Text = "Teraz gra Radio Plus Głogów"
            main.PictureBox2.Show()
            start.Close()
            Me.Close()
        End If
        If ListBox1.SelectedItem = "Radio Plus Legnica" Then
            radio.Show()
            radio.WebBrowser1.Url = New Uri("http://www.radioplus.pl/player?select=legnica&id=40")
            radio.Label1.Text = "Radio Plus Legnica"
            main.Label2.Text = "Teraz gra Radio Plus Legnica"
            main.PictureBox2.Show()
            start.Close()
            Me.Close()
        End If
        If ListBox1.SelectedItem = "Radio Złote Przeboje" Then
            radio.Show()
            radio.WebBrowser1.Url = New Uri("http://fm.tuba.pl/play/9/2/radio-zlote-przeboje")
            radio.Label1.Text = "Radio Złote Przeboje"
            main.Label2.Text = "Teraz gra Radio Złote Przeboje"
            main.PictureBox2.Show()
            start.Close()
            Me.Close()
        End If
    End Sub
End Class