Imports System.Threading
Imports System.Runtime.InteropServices
Public Class reminder
    Dim WM_SYSCOMMAND As Int32 = 274
    Dim SC_CLOSE As UInt32 = 61536
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As IntPtr
    End Function
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Button4.Enabled = True
        Button3.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateTimePicker1.Text = TimeOfDay Then
            main.Panel1.Show()
            main.Label4.Text = TextBox1.Text
            main.Label3.Text = "Przypomnienie:"
            Timer3.Stop()
            Button3.PerformClick()
            My.Computer.Audio.Play(My.Resources.dingdong, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.dingdong, AudioPlayMode.Background)
        main.Panel1.Show()
        main.Label4.Text = "Ustawiono przypomnienie o " + DateTimePicker1.Text
        main.Label3.Text = "Informacja:"
        start.Close()
        Me.WindowState = FormWindowState.Minimized
        Timer3.Start()
        Timer1.Start()
        Button4.Enabled = False
        Button3.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = "Aktualna godzina: " + TimeOfDay
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        main.Label3.Text = "Przypomnienie:"
        main.Label4.Text = "Nowe przypomnienie"
        main.Panel1.Hide()
        Timer3.Stop()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        DateTimePicker1.Text = "12:00:00"
    End Sub
End Class