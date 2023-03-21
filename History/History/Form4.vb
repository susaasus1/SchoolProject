Public Class Form4
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim p, s As Integer
    Dim z As String
    Dim ss As Integer
    Dim i As Integer = 0
    Public k3, r3 As Integer



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.PictureBox13.Visible = False Then
            k3 = 1
        Else
            k3 = 0
        End If

        Me.Width = X
        Me.Height = Y
        p = 284
        s = 353
        Timer1.Start()

        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
        PictureBox25.Visible = False
        PictureBox26.Visible = False
        PictureBox27.Visible = False
        PictureBox28.Visible = False
        PictureBox29.Visible = False
        PictureBox30.Visible = False
        PictureBox31.Visible = False
        PictureBox32.Visible = False
        PictureBox33.Visible = False



        PictureBox34.Top = 29 / 900 * Y
        PictureBox34.Left = 28 / 1440 * X
        PictureBox34.Width = 93 / 1440 * X
        PictureBox34.Height = 89 / 900 * Y
        PictureBox34.Image = My.Resources.comeback
        PictureBox34.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Controls.Add(PictureBox34)

        PictureBox36.Visible = False


        PictureBox1.Top = 0
        PictureBox1.Left = 0
        PictureBox1.Height = Y
        PictureBox1.Width = X

        PictureBox34.Top = (29 / 900) * Y
        PictureBox34.Left = (28 / 1440) * X
        PictureBox34.Height = (89 / 900) * Y
        PictureBox34.Width = (93 / 1440) * X

        PictureBox35.Top = (809 / 900) * Y
        PictureBox35.Left = (1311 / 1440) * X
        PictureBox35.Height = (78 / 900) * Y
        PictureBox35.Width = (121 / 1440) * X

        PictureBox36.Top = (809 / 900) * Y
        PictureBox36.Left = (28 / 1440) * X
        PictureBox36.Height = (78 / 900) * Y
        PictureBox36.Width = (121 / 1440) * X

        '1134 29
        PictureBox2.Top = (29 / 900) * Y
        PictureBox2.Left = (228 / 1440) * X
        PictureBox2.Height = (244 / 900) * Y
        PictureBox2.Width = (253 / 1440) * X

        PictureBox4.Left = ((228 + 2 * s) / 1440) * X
        PictureBox4.Top = (29 / 900) * Y
        PictureBox4.Height = (244 / 900) * Y
        PictureBox4.Width = (253 / 1440) * X

        PictureBox3.Left = ((228 + s) / 1440) * X
        PictureBox3.Top = (29 / 900) * Y
        PictureBox3.Height = (244 / 900) * Y
        PictureBox3.Width = (253 / 1440) * X

        PictureBox5.Top = ((p + 29) / 900) * Y
        PictureBox5.Left = (228 / 1440) * X
        PictureBox5.Height = (244 / 900) * Y
        PictureBox5.Width = (253 / 1440) * X

        PictureBox6.Top = ((29 + p) / 900) * Y
        PictureBox6.Left = ((228 + s) / 1440) * X
        PictureBox6.Height = (244 / 900) * Y
        PictureBox6.Width = (253 / 1440) * X

        PictureBox7.Top = ((29 + p) / 900) * Y
        PictureBox7.Left = ((228 + s * 2) / 1440) * X
        PictureBox7.Height = (244 / 900) * Y
        PictureBox7.Width = (253 / 1440) * X

        PictureBox8.Top = ((2 * p + 29) / 900) * Y
        PictureBox8.Left = (228 / 1440) * X
        PictureBox8.Height = (244 / 900) * Y
        PictureBox8.Width = (253 / 1440) * X

        PictureBox9.Top = ((29 + p * 2) / 900) * Y
        PictureBox9.Left = ((228 + s) / 1440) * X
        PictureBox9.Height = (244 / 900) * Y
        PictureBox9.Width = (253 / 1440) * X

        PictureBox10.Top = ((29 + p * 2) / 900) * Y
        PictureBox10.Left = ((228 + s * 2) / 1440) * X
        PictureBox10.Height = (244 / 900) * Y
        PictureBox10.Width = (253 / 1440) * X

        PictureBox11.Top = (29 / 900) * Y
        PictureBox11.Left = (228 / 1440) * X
        PictureBox11.Height = (244 / 900) * Y
        PictureBox11.Width = (253 / 1440) * X

        PictureBox12.Left = ((228 + s) / 1440) * X
        PictureBox12.Top = (29 / 900) * Y
        PictureBox12.Height = (244 / 900) * Y
        PictureBox12.Width = (253 / 1440) * X

        PictureBox13.Left = ((228 + 2 * s) / 1440) * X
        PictureBox13.Top = (29 / 900) * Y
        PictureBox13.Height = (244 / 900) * Y
        PictureBox13.Width = (253 / 1440) * X

        PictureBox14.Top = ((p + 29) / 900) * Y
        PictureBox14.Left = (228 / 1440) * X
        PictureBox14.Height = (244 / 900) * Y
        PictureBox14.Width = (253 / 1440) * X

        PictureBox15.Top = ((29 + p) / 900) * Y
        PictureBox15.Left = ((228 + s) / 1440) * X
        PictureBox15.Height = (244 / 900) * Y
        PictureBox15.Width = (253 / 1440) * X

        PictureBox16.Top = ((29 + p) / 900) * Y
        PictureBox16.Left = ((228 + s * 2) / 1440) * X
        PictureBox16.Height = (244 / 900) * Y
        PictureBox16.Width = (253 / 1440) * X

        PictureBox17.Top = ((2 * p + 29) / 900) * Y
        PictureBox17.Left = (228 / 1440) * X
        PictureBox17.Height = (244 / 900) * Y
        PictureBox17.Width = (253 / 1440) * X

        PictureBox18.Top = ((29 + p * 2) / 900) * Y
        PictureBox18.Left = ((228 + s) / 1440) * X
        PictureBox18.Height = (244 / 900) * Y
        PictureBox18.Width = (253 / 1440) * X

        PictureBox19.Top = ((29 + p * 2) / 900) * Y
        PictureBox19.Left = ((228 + s * 2) / 1440) * X
        PictureBox19.Height = (244 / 900) * Y
        PictureBox19.Width = (253 / 1440) * X

        PictureBox11.Top = (29 / 900) * Y
        PictureBox11.Left = (228 / 1440) * X
        PictureBox11.Height = (244 / 900) * Y
        PictureBox11.Width = (253 / 1440) * X

        PictureBox12.Left = ((228 + s) / 1440) * X
        PictureBox12.Top = (29 / 900) * Y
        PictureBox12.Height = (244 / 900) * Y
        PictureBox12.Width = (253 / 1440) * X

        PictureBox13.Left = ((228 + 2 * s) / 1440) * X
        PictureBox13.Top = (29 / 900) * Y
        PictureBox13.Height = (244 / 900) * Y
        PictureBox13.Width = (253 / 1440) * X

        PictureBox14.Top = ((p + 29) / 900) * Y
        PictureBox14.Left = (228 / 1440) * X
        PictureBox14.Height = (244 / 900) * Y
        PictureBox14.Width = (253 / 1440) * X

        PictureBox15.Top = ((29 + p) / 900) * Y
        PictureBox15.Left = ((228 + s) / 1440) * X
        PictureBox15.Height = (244 / 900) * Y
        PictureBox15.Width = (253 / 1440) * X

        PictureBox16.Top = ((29 + p) / 900) * Y
        PictureBox16.Left = ((228 + s * 2) / 1440) * X
        PictureBox16.Height = (244 / 900) * Y
        PictureBox16.Width = (253 / 1440) * X

        PictureBox17.Top = ((2 * p + 29) / 900) * Y
        PictureBox17.Left = (228 / 1440) * X
        PictureBox17.Height = (244 / 900) * Y
        PictureBox17.Width = (253 / 1440) * X

        PictureBox18.Top = ((29 + p * 2) / 900) * Y
        PictureBox18.Left = ((228 + s) / 1440) * X
        PictureBox18.Height = (244 / 900) * Y
        PictureBox18.Width = (253 / 1440) * X

        PictureBox19.Top = ((29 + p * 2) / 900) * Y
        PictureBox19.Left = ((228 + s * 2) / 1440) * X
        PictureBox19.Height = (244 / 900) * Y
        PictureBox19.Width = (253 / 1440) * X

        PictureBox20.Top = (29 / 900) * Y
        PictureBox20.Left = (228 / 1440) * X
        PictureBox20.Height = (244 / 900) * Y
        PictureBox20.Width = (253 / 1440) * X

        PictureBox21.Left = ((228 + s) / 1440) * X
        PictureBox21.Top = (29 / 900) * Y
        PictureBox21.Height = (244 / 900) * Y
        PictureBox21.Width = (253 / 1440) * X

        PictureBox22.Left = ((228 + 2 * s) / 1440) * X
        PictureBox22.Top = (29 / 900) * Y
        PictureBox22.Height = (244 / 900) * Y
        PictureBox22.Width = (253 / 1440) * X

        PictureBox23.Top = ((p + 29) / 900) * Y
        PictureBox23.Left = (228 / 1440) * X
        PictureBox23.Height = (244 / 900) * Y
        PictureBox23.Width = (253 / 1440) * X

        PictureBox24.Top = ((29 + p) / 900) * Y
        PictureBox24.Left = ((228 + s) / 1440) * X
        PictureBox24.Height = (244 / 900) * Y
        PictureBox24.Width = (253 / 1440) * X

        PictureBox25.Top = ((29 + p) / 900) * Y
        PictureBox25.Left = ((228 + s * 2) / 1440) * X
        PictureBox25.Height = (244 / 900) * Y
        PictureBox25.Width = (253 / 1440) * X

        PictureBox26.Top = ((2 * p + 29) / 900) * Y
        PictureBox26.Left = (228 / 1440) * X
        PictureBox26.Height = (244 / 900) * Y
        PictureBox26.Width = (253 / 1440) * X

        PictureBox27.Top = ((29 + p * 2) / 900) * Y
        PictureBox27.Left = ((228 + s) / 1440) * X
        PictureBox27.Height = (244 / 900) * Y
        PictureBox27.Width = (253 / 1440) * X

        PictureBox28.Top = ((29 + p * 2) / 900) * Y
        PictureBox28.Left = ((228 + s * 2) / 1440) * X
        PictureBox28.Height = (244 / 900) * Y
        PictureBox28.Width = (253 / 1440) * X

        PictureBox29.Top = (29 / 900) * Y
        PictureBox29.Left = (228 / 1440) * X
        PictureBox29.Height = (244 / 900) * Y
        PictureBox29.Width = (253 / 1440) * X

        PictureBox30.Left = ((228 + s) / 1440) * X
        PictureBox30.Top = (29 / 900) * Y
        PictureBox30.Height = (244 / 900) * Y
        PictureBox30.Width = (253 / 1440) * X

        PictureBox31.Left = ((228 + 2 * s) / 1440) * X
        PictureBox31.Top = (29 / 900) * Y
        PictureBox31.Height = (244 / 900) * Y
        PictureBox31.Width = (253 / 1440) * X

        PictureBox32.Top = ((p + 29) / 900) * Y
        PictureBox32.Left = (228 / 1440) * X
        PictureBox32.Height = (244 / 900) * Y
        PictureBox32.Width = (253 / 1440) * X

        PictureBox33.Top = ((29 + p) / 900) * Y
        PictureBox33.Left = ((228 + s) / 1440) * X
        PictureBox33.Height = (244 / 900) * Y
        PictureBox33.Width = (253 / 1440) * X

        PictureBox1.Image = My.Resources.phootttnenp
        PictureBox2.Image = My.Resources._11
        PictureBox3.Image = My.Resources._22
        PictureBox4.Image = My.Resources._33
        PictureBox5.Image = My.Resources._44
        PictureBox6.Image = My.Resources._55
        PictureBox7.Image = My.Resources._66
        PictureBox8.Image = My.Resources._77
        PictureBox9.Image = My.Resources._88
        PictureBox10.Image = My.Resources._99
        PictureBox11.Image = My.Resources._1111
        PictureBox12.Image = My.Resources._2222
        PictureBox13.Image = My.Resources._3333
        PictureBox14.Image = My.Resources._4444
        PictureBox15.Image = My.Resources._5555
        PictureBox16.Image = My.Resources._6666
        PictureBox17.Image = My.Resources._7777
        PictureBox18.Image = My.Resources._8888
        PictureBox19.Image = My.Resources._9999
        PictureBox20.Image = My.Resources._11111
        PictureBox21.Image = My.Resources._22222
        PictureBox22.Image = My.Resources._33333
        PictureBox23.Image = My.Resources._44444
        PictureBox24.Image = My.Resources._55555
        PictureBox25.Image = My.Resources._66666
        PictureBox26.Image = My.Resources._77777
        PictureBox27.Image = My.Resources._88888
        PictureBox28.Image = My.Resources._99999
        PictureBox29.Image = My.Resources._111111
        PictureBox30.Image = My.Resources._222222
        PictureBox31.Image = My.Resources._333333
        PictureBox32.Image = My.Resources._444444
        PictureBox33.Image = My.Resources._555555

        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox17.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox18.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox19.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox20.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox21.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox22.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox23.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox24.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox25.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox26.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox27.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox28.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox29.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox30.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox31.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox32.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox33.SizeMode = PictureBoxSizeMode.StretchImage


        PictureBox1.Controls.Add(PictureBox35)
        PictureBox1.Controls.Add(PictureBox36)
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._22
        z = IO.File.ReadAllText("arhiv/2.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = False

    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._55
        z = IO.File.ReadAllText("arhiv/5.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = False
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._7777
        z = IO.File.ReadAllText("arhiv/16.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 400 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100

    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._555555
        z = IO.File.ReadAllText("arhiv/32.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._44
        z = IO.File.ReadAllText("arhiv/4.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 650 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._33
        z = IO.File.ReadAllText("arhiv/3.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 8900 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._66
        z = IO.File.ReadAllText("arhiv/6.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1600 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._77
        z = IO.File.ReadAllText("arhiv/7.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1400 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._88
        z = IO.File.ReadAllText("arhiv/8.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 450 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._99
        z = IO.File.ReadAllText("arhiv/9.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 11600 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._1111
        z = IO.File.ReadAllText("arhiv/10.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1400 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._2222
        z = IO.File.ReadAllText("arhiv/11.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 3800 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._3333
        z = IO.File.ReadAllText("arhiv/12.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 3500 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._4444
        z = IO.File.ReadAllText("arhiv/13.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 3800 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._5555
        z = IO.File.ReadAllText("arhiv/14.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1400 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._6666
        z = IO.File.ReadAllText("arhiv/15.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 6900 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._8888
        z = IO.File.ReadAllText("arhiv/17.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 4500 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._9999
        z = IO.File.ReadAllText("arhiv/18.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 4300 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._11111
        z = IO.File.ReadAllText("arhiv/19.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1000 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._22222
        z = IO.File.ReadAllText("arhiv/20.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 2200 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._33333
        z = IO.File.ReadAllText("arhiv/21.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 4500 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._44444
        z = IO.File.ReadAllText("arhiv/22.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 2450 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._55555
        z = IO.File.ReadAllText("arhiv/23.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 4400 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._66666
        z = IO.File.ReadAllText("arhiv/24.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 8700 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._77777
        z = IO.File.ReadAllText("arhiv/25.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1400 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._88888
        z = IO.File.ReadAllText("arhiv/26.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 2500 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._99999
        z = IO.File.ReadAllText("arhiv/27.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1200 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._111111
        z = IO.File.ReadAllText("arhiv/28.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 6000 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._222222
        z = IO.File.ReadAllText("arhiv/29.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 1000 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._333333
        z = IO.File.ReadAllText("arhiv/30.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 2300 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._444444
        z = IO.File.ReadAllText("arhiv/31.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 2000 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form5.Show()
        Form5.PictureBox2.Image = My.Resources._11
        z = IO.File.ReadAllText("arhiv/1.txt", System.Text.Encoding.UTF8)
        Form5.Label1.Text = z
        Form5.VScrollBar1.Visible = True
        Form5.VScrollBar1.LargeChange = 100
        Form5.VScrollBar1.Maximum = 11000 / 900 * Y
        Form5.VScrollBar1.Minimum = 0
        Form5.VScrollBar1.SmallChange = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ss = ss + 1
        If ss >= 1 Then
            Form1.Close()

            Timer1.Stop()
            ss = 0
        End If

    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        i = i + 1
        If i = 3 Then PictureBox35.Visible = False
        If i = 1 Then PictureBox36.Visible = True
        If i = 0 Then
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            PictureBox18.Visible = False
            PictureBox19.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
        End If

        If i = 1 Then
            PictureBox11.Visible = True
            PictureBox12.Visible = True
            PictureBox13.Visible = True
            PictureBox14.Visible = True
            PictureBox15.Visible = True
            PictureBox16.Visible = True
            PictureBox17.Visible = True
            PictureBox18.Visible = True
            PictureBox19.Visible = True

            PictureBox20.Visible = False
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
            PictureBox26.Visible = False
            PictureBox27.Visible = False
            PictureBox28.Visible = False

            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
        End If
        If i = 2 Then
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            PictureBox18.Visible = False
            PictureBox19.Visible = False

            PictureBox29.Visible = False
            PictureBox30.Visible = False
            PictureBox31.Visible = False
            PictureBox32.Visible = False
            PictureBox33.Visible = False

            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            PictureBox25.Visible = True
            PictureBox26.Visible = True
            PictureBox27.Visible = True
            PictureBox28.Visible = True
        End If
        If i = 3 Then
            PictureBox20.Visible = False
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
            PictureBox26.Visible = False
            PictureBox27.Visible = False
            PictureBox28.Visible = False

            PictureBox29.Visible = True
            PictureBox30.Visible = True
            PictureBox31.Visible = True
            PictureBox32.Visible = True
            PictureBox33.Visible = True
        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        i = i - 1
        If i = 0 Then PictureBox36.Visible = False
        If i = 2 Then PictureBox35.Visible = True
        If i = 0 Then
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            PictureBox18.Visible = False
            PictureBox19.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
        End If

        If i = 1 Then
            PictureBox11.Visible = True
            PictureBox12.Visible = True
            PictureBox13.Visible = True
            PictureBox14.Visible = True
            PictureBox15.Visible = True
            PictureBox16.Visible = True
            PictureBox17.Visible = True
            PictureBox18.Visible = True
            PictureBox19.Visible = True

            PictureBox20.Visible = False
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
            PictureBox26.Visible = False
            PictureBox27.Visible = False
            PictureBox28.Visible = False

            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
        End If
        If i = 2 Then
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            PictureBox18.Visible = False
            PictureBox19.Visible = False

            PictureBox29.Visible = False
            PictureBox30.Visible = False
            PictureBox31.Visible = False
            PictureBox32.Visible = False
            PictureBox33.Visible = False

            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            PictureBox25.Visible = True
            PictureBox26.Visible = True
            PictureBox27.Visible = True
            PictureBox28.Visible = True
        End If
        If i = 3 Then
            PictureBox20.Visible = False
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
            PictureBox26.Visible = False
            PictureBox27.Visible = False
            PictureBox28.Visible = False

            PictureBox29.Visible = True
            PictureBox30.Visible = True
            PictureBox31.Visible = True
            PictureBox32.Visible = True
            PictureBox33.Visible = True
        End If
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Form1.Show()
        If k3 = 1 Then
            Form1.PictureBox13.Visible = False
            Form1.PictureBox12.Visible = True
            Form1.PictureBox15.Visible = False
            Form1.PictureBox17.Visible = False
        Else
            Form1.PictureBox13.Visible = True
            Form1.PictureBox12.Visible = False
        End If
        r3 = 1
    End Sub
End Class
