Public Class Form1
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim ss As Integer
    Dim p As Integer
    Public c As Integer = 1
    Dim z, r, r2, r4 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox9.Visible = False
        PictureBox7.Visible = False
        PictureBox4.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False

        Me.Width = X
        Me.Height = Y
        c = zastvka.k
        r = Form2.r1
        z = z + 1
        r2 = Form4.r3
        r4 = Form3.r5

        Timer1.Start()

        PictureBox1.Top = 0
        PictureBox1.Left = 0
        PictureBox1.Height = Y
        PictureBox1.Width = X

        PictureBox2.Top = (775 / 900) * Y
        PictureBox2.Left = (1300 / 1440) * X
        PictureBox2.Height = (120 / 900) * Y
        PictureBox2.Width = (120 / 1440) * X

        PictureBox3.Top = (775 / 900) * Y
        PictureBox3.Left = (1300 / 1440) * X
        PictureBox3.Height = (120 / 900) * Y
        PictureBox3.Width = (120 / 1440) * X

        PictureBox4.Top = (20 / 900) * Y
        PictureBox4.Left = (23 / 1440) * X
        PictureBox4.Height = (160 / 900) * Y
        PictureBox4.Width = (500 / 1440) * X

        PictureBox5.Top = (20 / 900) * Y
        PictureBox5.Left = (23 / 1440) * X
        PictureBox5.Height = (160 / 900) * Y
        PictureBox5.Width = (500 / 1440) * X

        PictureBox6.Top = (220 / 900) * Y
        PictureBox6.Left = (23 / 1440) * X
        PictureBox6.Height = (120 / 900) * Y
        PictureBox6.Width = (400 / 1440) * X

        PictureBox7.Top = (220 / 900) * Y
        PictureBox7.Left = (23 / 1440) * X
        PictureBox7.Height = (120 / 900) * Y
        PictureBox7.Width = (400 / 1440) * X

        PictureBox8.Top = (420 / 900) * Y
        PictureBox8.Left = (20 / 1440) * X
        PictureBox8.Height = (120 / 900) * Y
        PictureBox8.Width = (283 / 1440) * X

        PictureBox9.Top = (420 / 900) * Y
        PictureBox9.Left = (20 / 1440) * X
        PictureBox9.Height = (120 / 900) * Y
        PictureBox9.Width = (283 / 1440) * X

        PictureBox10.Top = (760 / 900) * Y
        PictureBox10.Left = (23 / 1440) * X
        PictureBox10.Height = (120 / 900) * Y
        PictureBox10.Width = (120 / 1440) * X

        PictureBox11.Top = (760 / 900) * Y
        PictureBox11.Left = (23 / 1440) * X
        PictureBox11.Height = (120 / 900) * Y
        PictureBox11.Width = (120 / 1440) * X

        PictureBox12.Top = (15 / 900) * Y
        PictureBox12.Left = (1340 / 1440) * X
        PictureBox12.Height = (49 / 900) * Y
        PictureBox12.Width = (83 / 1440) * X

        PictureBox13.Top = (15 / 900) * Y
        PictureBox13.Left = (1340 / 1440) * X
        PictureBox13.Height = (49 / 900) * Y
        PictureBox13.Width = (83 / 1440) * X

        PictureBox14.Top = (20 / 900) * Y
        PictureBox14.Left = (23 / 1440) * X
        PictureBox14.Height = (131 / 900) * Y
        PictureBox14.Width = (300 / 1440) * X

        PictureBox15.Top = (20 / 900) * Y
        PictureBox15.Left = (23 / 1440) * X
        PictureBox15.Height = (131 / 900) * Y
        PictureBox15.Width = (300 / 1440) * X


        PictureBox16.Top = (220 / 900) * Y
        PictureBox16.Left = (30 / 1440) * X
        PictureBox16.Height = (145 / 900) * Y
        PictureBox16.Width = (480 / 1440) * X

        PictureBox17.Top = (220 / 900) * Y
        PictureBox17.Left = (30 / 1440) * X
        PictureBox17.Height = (145 / 900) * Y
        PictureBox17.Width = (480 / 1440) * X

        PictureBox18.Top = (620 / 900) * Y
        PictureBox18.Left = (23 / 1440) * X
        PictureBox18.Height = (100 / 900) * Y
        PictureBox18.Width = (500 / 1440) * X

        PictureBox19.Top = (620 / 900) * Y
        PictureBox19.Left = (23 / 1440) * X
        PictureBox19.Height = (100 / 900) * Y
        PictureBox19.Width = (500 / 1440) * X

        PictureBox20.Top = (620 / 900) * Y
        PictureBox20.Left = (23 / 1440) * X
        PictureBox20.Height = (100 / 900) * Y
        PictureBox20.Width = (500 / 1440) * X

        PictureBox21.Top = (620 / 900) * Y
        PictureBox21.Left = (23 / 1440) * X
        PictureBox21.Height = (100 / 900) * Y
        PictureBox21.Width = (500 / 1440) * X

        PictureBox10.Image = My.Resources.icon1
        PictureBox11.Image = My.Resources.icon2
        PictureBox14.Image = My.Resources.bas1
        PictureBox15.Image = My.Resources.bas
        PictureBox16.Image = My.Resources.mur2
        PictureBox17.Image = My.Resources.mur
        PictureBox7.Image = My.Resources.ar1
        PictureBox6.Image = My.Resources.ar
        PictureBox4.Image = My.Resources.kor1
        PictureBox5.Image = My.Resources.kor

        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox10.Visible = False

        PictureBox1.Controls.Add(PictureBox3)
        PictureBox1.Controls.Add(PictureBox2)
        PictureBox1.Controls.Add(PictureBox4)
        PictureBox1.Controls.Add(PictureBox5)
        PictureBox1.Controls.Add(PictureBox7)
        PictureBox1.Controls.Add(PictureBox6)
        PictureBox1.Controls.Add(PictureBox8)
        PictureBox1.Controls.Add(PictureBox9)
        PictureBox1.Controls.Add(PictureBox10)
        PictureBox1.Controls.Add(PictureBox11)
        PictureBox1.Controls.Add(PictureBox14)
        PictureBox1.Controls.Add(PictureBox15)
        PictureBox1.Controls.Add(PictureBox16)
        PictureBox1.Controls.Add(PictureBox17)
        PictureBox1.Controls.Add(PictureBox18)
        PictureBox1.Controls.Add(PictureBox19)
        PictureBox1.Controls.Add(PictureBox20)
        PictureBox1.Controls.Add(PictureBox21)
        ' Label1.Text = Form3.sum
        If z = 1 Then

            If c = 1 Then
                PictureBox5.Visible = True
                PictureBox6.Visible = True
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox12.Visible = True
                PictureBox13.Visible = False
                PictureBox18.Visible = True
                PictureBox19.Visible = False
                PictureBox20.Visible = False
                PictureBox21.Visible = False
            Else
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = True
                PictureBox16.Visible = False
                PictureBox17.Visible = True
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox13.Visible = True
                PictureBox12.Visible = False
                PictureBox20.Visible = True
                PictureBox21.Visible = False
            End If
        End If
        If r = 1 Then
            If Form2.k1 = 1 Then
                PictureBox5.Visible = True
                PictureBox6.Visible = True
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox12.Visible = True
                PictureBox13.Visible = False
                PictureBox18.Visible = True
                PictureBox19.Visible = False
                PictureBox20.Visible = False
                PictureBox21.Visible = False
            Else
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = True
                PictureBox16.Visible = False
                PictureBox17.Visible = True
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox13.Visible = True
                PictureBox12.Visible = False
                PictureBox20.Visible = True
                PictureBox21.Visible = False
            End If
        End If

        If r2 = 1 Then
            If Form4.k3 = 1 Then
                PictureBox5.Visible = True
                PictureBox6.Visible = True
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox12.Visible = True
                PictureBox13.Visible = False
                PictureBox18.Visible = True
                PictureBox19.Visible = False
                PictureBox20.Visible = False
                PictureBox21.Visible = False

            Else
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = True
                PictureBox16.Visible = False
                PictureBox17.Visible = True
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox13.Visible = True
                PictureBox12.Visible = False
                PictureBox20.Visible = True
                PictureBox21.Visible = False
            End If
        End If

        If r4 = 1 Then
            If Form3.k5 = 1 Then
                PictureBox5.Visible = True
                PictureBox6.Visible = True
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox4.Visible = False
                PictureBox12.Visible = True
                PictureBox13.Visible = False
                PictureBox18.Visible = True
                PictureBox19.Visible = False
                PictureBox20.Visible = False
                PictureBox21.Visible = False

            Else
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox8.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = True
                PictureBox16.Visible = False
                PictureBox17.Visible = True
                PictureBox9.Visible = False
                PictureBox7.Visible = False
                PictureBox18.Visible = False
                PictureBox4.Visible = False
                PictureBox13.Visible = True
                PictureBox12.Visible = False
                PictureBox20.Visible = True
                PictureBox21.Visible = False

            End If
        End If

        If PictureBox13.Visible = False Then
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            PictureBox20.Visible = False
            PictureBox21.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox11.Visible = True
        PictureBox10.Visible = False
        PictureBox3.Visible = True
        PictureBox2.Visible = False
        PictureBox8.Visible = True
        PictureBox9.Visible = False
        If PictureBox13.Visible = False Then
            PictureBox5.Visible = True
            PictureBox4.Visible = False
            PictureBox6.Visible = True
            PictureBox7.Visible = False
            PictureBox17.Visible = False
            PictureBox15.Visible = False
            PictureBox18.Visible = True
            PictureBox19.Visible = False
            PictureBox20.Visible = False
            PictureBox21.Visible = False
        Else

            PictureBox5.Visible = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = True
            PictureBox16.Visible = False
            PictureBox17.Visible = True
            PictureBox18.Visible = False
            PictureBox19.Visible = False
            PictureBox20.Visible = True


        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End

    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox6.Visible = False
        PictureBox7.Visible = True
    End Sub
    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove
        PictureBox8.Visible = False
        PictureBox9.Visible = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Form2.Show()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form4.Show()

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ss = ss + 1
        If ss >= 1 Then
            zastvka.Close()
            Form2.Close()
            Form3.Close()
            Form4.Close()
            info.Close()

            Timer1.Stop()
            ss = 0
        End If

    End Sub

    Private Sub PictureBox11_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseMove
        PictureBox11.Visible = False
        PictureBox10.Visible = True
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        info.Show()

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = False
        PictureBox15.Visible = False
        PictureBox17.Visible = False
        PictureBox16.Visible = False
        PictureBox14.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox18.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        c = 1

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        PictureBox12.Visible = False
        PictureBox13.Visible = True
        PictureBox15.Visible = True
        PictureBox17.Visible = True
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = True

        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        c = 0

    End Sub

    Private Sub PictureBox15_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox15.MouseMove
        PictureBox14.Visible = True
        PictureBox15.Visible = False
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub PictureBox17_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox17.MouseMove
        PictureBox16.Visible = True
        PictureBox17.Visible = False
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Form4.Show()

    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove

    End Sub

    Private Sub PictureBox18_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox18.MouseMove
        PictureBox18.Visible = False
        PictureBox19.Visible = True

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Form6.Show()
    End Sub

    Private Sub PictureBox20_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox20.MouseMove
        PictureBox20.Visible = False
        PictureBox21.Visible = True
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Form6.Show()
    End Sub
End Class
