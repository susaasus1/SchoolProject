Public Class Form2
    Dim k As Integer
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim ss, p As Integer
    Public k1, r1 As Integer
    Dim k2 As Integer


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.PictureBox13.Visible = False Then
            k1 = 1
        Else
            k1 = 0
        End If

        Timer1.Start()
        Me.Width = X
        Me.Height = Y
        P = Form1.c
        PictureBox4.Top = 0
        PictureBox4.Left = 0
        PictureBox4.Height = Y
        PictureBox4.Width = X

        PictureBox1.Top = (830 / 900) * Y
        PictureBox1.Left = (12 / 1440) * X
        PictureBox1.Height = (60 / 900) * Y
        PictureBox1.Width = (80 / 1440) * X

        PictureBox3.Top = (12 / 900) * Y
        PictureBox3.Left = (12 / 1440) * X
        PictureBox3.Height = (106 / 900) * Y
        PictureBox3.Width = (105 / 1440) * X

        PictureBox2.Top = (830 / 900) * Y
        PictureBox2.Left = (1350 / 1440) * X
        PictureBox2.Height = (60 / 900) * Y
        PictureBox2.Width = (80 / 1440) * X

        PictureBox4.Controls.Add(PictureBox3)
        PictureBox4.Controls.Add(PictureBox2)
        PictureBox4.Controls.Add(PictureBox1)
        If Form1.PictureBox13.Visible = False Then
            PictureBox4.Image = My.Resources._111
        Else PictureBox4.Image = My.Resources._111k
        End If

        k2 = 1
        If k2 = 1 Then PictureBox1.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        k2 = k2 - 1
        If p = 1 Then
            If k2 = 1 Then PictureBox4.Image = My.Resources._111
            If k2 = 2 Then PictureBox4.Image = My.Resources._222
            If k2 = 3 Then PictureBox4.Image = My.Resources._333
            If k2 = 4 Then PictureBox4.Image = My.Resources._444
            If k2 = 5 Then PictureBox4.Image = My.Resources._555
            If k2 = 6 Then PictureBox4.Image = My.Resources._666
            If k2 = 7 Then PictureBox4.Image = My.Resources._777

        Else
            If k2 = 1 Then PictureBox4.Image = My.Resources._111k
            If k2 = 2 Then PictureBox4.Image = My.Resources._222k
            If k2 = 3 Then PictureBox4.Image = My.Resources._333k
            If k2 = 4 Then PictureBox4.Image = My.Resources._444k
            If k2 = 5 Then PictureBox4.Image = My.Resources._555k
            If k2 = 6 Then PictureBox4.Image = My.Resources._666k
            If k2 = 7 Then PictureBox4.Image = My.Resources._777k
        End If
        If k2 = 1 Then PictureBox1.Visible = False
        If k2 = 6 Then PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Form1.Show()
        If k1 = 1 Then
            Form1.PictureBox13.Visible = False
            Form1.PictureBox12.Visible = True
            Form1.PictureBox15.Visible = False
            Form1.PictureBox17.Visible = False
        Else
            Form1.PictureBox13.Visible = True
            Form1.PictureBox12.Visible = False
        End If
        r1 = 1

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        k2 = k2 + 1
        If p = 1 Then
            If k2 = 1 Then PictureBox4.Image = My.Resources._111
            If k2 = 2 Then PictureBox4.Image = My.Resources._222
            If k2 = 3 Then PictureBox4.Image = My.Resources._333
            If k2 = 4 Then PictureBox4.Image = My.Resources._444
            If k2 = 5 Then PictureBox4.Image = My.Resources._555
            If k2 = 6 Then PictureBox4.Image = My.Resources._666
            If k2 = 7 Then PictureBox4.Image = My.Resources._777

        Else
            If k2 = 1 Then PictureBox4.Image = My.Resources._111k
            If k2 = 2 Then PictureBox4.Image = My.Resources._222k
            If k2 = 3 Then PictureBox4.Image = My.Resources._333k
            If k2 = 4 Then PictureBox4.Image = My.Resources._444k
            If k2 = 5 Then PictureBox4.Image = My.Resources._555k
            If k2 = 6 Then PictureBox4.Image = My.Resources._666k
            If k2 = 7 Then PictureBox4.Image = My.Resources._777k
        End If
        If k2 = 2 Then PictureBox1.Visible = True
        If k2 = 7 Then PictureBox2.Visible = False

    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ss = ss + 1
        If ss >= 1 Then
            Form1.Close()
            Timer1.Stop()
            ss = 0
        End If

    End Sub
End Class