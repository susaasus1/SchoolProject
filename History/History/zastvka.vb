Public Class zastvka
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim s As Integer
    Public k As Integer
    Private Sub Zastvka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = X
        Me.Height = Y

        PictureBox1.Top = 0
        PictureBox1.left = 0
        picturebox1.width = X
        PictureBox1.Height = Y

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox1.Image = My.Resources.zastavka
        PictureBox2.Image = My.Resources.kaz
        PictureBox3.Image = My.Resources.rus1


        PictureBox2.Top = (654 / 900) * Y
        PictureBox2.Left = (532 / 1440) * X
        PictureBox2.Height = (84 / 900) * Y
        PictureBox2.Width = (147 / 1440) * X


        PictureBox3.Top = (654 / 900) * Y
        PictureBox3.Left = (759 / 1440) * X
        PictureBox3.Height = (84 / 900) * Y
        PictureBox3.Width = (147 / 1440) * X

    End Sub





    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        k = 1
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        k = 0
        Form1.Show()
    End Sub
End Class