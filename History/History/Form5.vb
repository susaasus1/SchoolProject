Public Class Form5
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = X
        Me.Height = Y

        PictureBox2.Top = (20 / 900) * Y
        PictureBox2.Left = (1068 / 1440) * X
        PictureBox2.Height = (324 / 900) * Y
        PictureBox2.Width = (324 / 1440) * X

        Label1.Top = (20 / 900) * Y
        Label1.Left = (88 / 1440) * X
        Label1.Height = 20 * Y
        Label1.Width = (859 / 1440) * X

        VScrollBar1.Top = 0
        VScrollBar1.Height = Y
        VScrollBar1.Width = (33 / 1440) * X
        VScrollBar1.Left = 0

        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox1.Top = (777 / 900) * Y
        PictureBox1.Left = (1308 / 1440) * X
        PictureBox1.Height = (89 / 900) * Y
        PictureBox1.Width = (93 / 1440) * X



    End Sub
    Private Sub Form5_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Label1.Top = -VScrollBar1.Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class