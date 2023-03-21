Public Class info
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim ss As Integer
    Dim z As String

    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.start()


        Me.Width = X
        Me.Height = Y


        PictureBox2.Image = My.Resources.comeback
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage





        PictureBox2.Top = (33 / 900) * Y
        PictureBox2.Left = (26 / 1400) * X
        PictureBox2.Height = (118 / 900) * Y
        PictureBox2.Width = (118 / 1400) * X

        Label1.Top = 0
        Label1.Left = 200 / 1440 * X
        Label1.Height = Y
        Label1.Width = 900 / 1440 * X



        z = IO.File.ReadAllText("info/Novy_textovy_dokument (2).txt", System.Text.Encoding.Default)
        Label1.Text = z

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub


End Class