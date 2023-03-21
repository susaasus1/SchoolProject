
Public Class Form3
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim qorder(15) As Integer
    Dim anorder(4) As Integer
    Dim a As Integer
    Dim r As New Random
    Dim j As Integer
    Dim i As Integer
    Dim check As Boolean
    Public sum As Integer
    Dim num As Integer
    Dim q(15) As String
    Dim ans(15, 4) As String
    Dim ran(15) As String
    Dim fsizeq As Integer
    Dim fsizeab As Integer
    Dim fsizen As Integer
    Public c As Integer
    Dim ss As Integer
    Public k5, r5





    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.PictureBox13.Visible = False Then
            k5 = 1
        Else
            k5 = 0
        End If

        Me.Width = X
        Me.Height = Y

        Button1.Left = (X / 2) - (146.5 / 1440 * X)
        Button1.Top = (Y / 2) - (30.5 / 900 * Y)
        Button1.Height = (61 / 900) * Y
        Button1.Width = (293 / 1440) * X

        Label7.Left = (X / 2) - (334 / 1440 * X)
        Label7.Top = (Y / 2) - (45.5 / 900 * Y)
        Label7.Height = (91 / 900) * Y
        Label7.Width = (668 / 1440) * X

        Label1.Left = (X / 2) - (292 / 1440 * X)
        Label1.Top = (97 / 900) * Y
        Label1.Height = (120 / 900) * Y
        Label1.Width = (700 / 1440) * X

        Label6.Left = (X / 2) - (328.5 / 1440 * X)
        Label6.Top = (97 / 900) * Y
        Label6.Height = (46 / 900) * Y
        Label6.Width = (43 / 1440) * X

        Label2.Left = (945 / 1440) * X
        Label2.Top = (591 / 900) * Y
        Label2.Height = (119 / 900) * Y
        Label2.Width = (265 / 1440) * X

        Label3.Left = (135 / 1440) * X
        Label3.Top = (271 / 900) * Y
        Label3.Height = (119 / 900) * Y
        Label3.Width = (265 / 1440) * X

        Label4.Left = (135 / 1440) * X
        Label4.Top = (591 / 900) * Y
        Label4.Height = (119 / 900) * Y
        Label4.Width = (265 / 1440) * X

        Label5.Left = (945 / 1440) * X
        Label5.Top = (271 / 900) * Y
        Label5.Height = (119 / 900) * Y
        Label5.Width = (265 / 1440) * X
        PictureBox1.Top = 0
        PictureBox1.Left = 0
        PictureBox1.Height = Y
        PictureBox1.Width = X

        PictureBox2.Top = (78 / 900) * Y
        PictureBox2.Left = (55 / 1440) * X
        PictureBox2.Height = (106 / 900) * Y
        PictureBox2.Width = (105 / 1440) * X

        PictureBox1.Image = My.Resources._0048

        PictureBox1.Controls.Add(PictureBox2)
        PictureBox1.Controls.Add(Label1)
        PictureBox1.Controls.Add(Label2)
        PictureBox1.Controls.Add(Label3)
        PictureBox1.Controls.Add(Label4)
        PictureBox1.Controls.Add(Label5)
        PictureBox1.Controls.Add(Label6)
        PictureBox1.Controls.Add(Label7)

        sum = 0
        num = 1
        While sum <> 15
            check = False
            a = r.Next(1, 16)
            For j = 1 To 15
                If qorder(j) = a Then
                    check = True
                End If
            Next
            If check <> True Then
                qorder(num) = a
                sum += 1
                num += 1
            End If
        End While

        sum = 0
        num = 1

        While sum <> 4
            check = False
            a = r.Next(1, 5)
            For j = 1 To 4
                If anorder(j) = a Then
                    check = True
                End If
            Next
            If check <> True Then
                anorder(num) = a
                sum += 1
                num += 1
            End If
        End While

        sum = 0
        num = 1

        Dim s() As String = IO.File.ReadAllLines("Test/voprosy.txt", System.Text.Encoding.Default)


        For i = 1 To 15
            q(qorder(i)) = s(qorder(i) - 1)
        Next

        Dim s1() As String = IO.File.ReadAllLines("Test/otvety.txt", System.Text.Encoding.Default)


        For i = 1 To 15
            For j = 1 To 4
                ans(qorder(i), anorder(j)) = s1(qorder(i) * 4 - j)
            Next
        Next

        Dim s2() As String = IO.File.ReadAllLines("Test/Pravilnye_otvety.txt", System.Text.Encoding.Default)

        For i = 1 To 15
            ran(qorder(i)) = s2(qorder(i) - 1)
        Next

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False

        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label1.Visible = True
        Label6.Visible = True

        c = 1
        Label6.Visible = False
        Label6.Text = c
        Label1.Text = q(qorder(c))
        Label2.Text = ans(qorder(c), 1)
        Label3.Text = ans(qorder(c), 2)
        Label4.Text = ans(qorder(c), 3)
        Label5.Text = ans(qorder(c), 4)
        sum = 0

    End Sub
    Private Sub label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.Text = ran(qorder(c)) Then
            sum += 1
        End If
        c += 1
        If c >= 16 Then

            Label7.Text = "Вы завершили тестирование, ваш результат: " & sum & " из 15"
            Label7.Visible = True

            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label1.Visible = False
            Label6.Visible = False
        Else
            Label6.Visible = False
            Label6.Text = c
            Label1.Text = q(qorder(c))
            Label2.Text = ans(qorder(c), 1)
            Label3.Text = ans(qorder(c), 2)
            Label4.Text = ans(qorder(c), 3)
            Label5.Text = ans(qorder(c), 4)

        End If
    End Sub
    Private Sub label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label3.Text = ran(qorder(c)) Then
            sum += 1
        End If
        c += 1
        If c >= 16 Then

            Label7.Text = "Вы завершили тестирование, ваш результат: " & sum & " из 15"
            Label7.Visible = True

            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label1.Visible = False
            Label6.Visible = False
        Else
            Label6.Visible = False
            Label6.Text = c
            Label1.Text = q(qorder(c))
            Label2.Text = ans(qorder(c), 1)
            Label3.Text = ans(qorder(c), 2)
            Label4.Text = ans(qorder(c), 3)
            Label5.Text = ans(qorder(c), 4)

        End If
    End Sub
    Private Sub label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Label4.Text = ran(qorder(c)) Then
            sum += 1
        End If
        c += 1
        If c >= 16 Then

            Label7.Text = "Вы завершили тестирование, ваш результат: " & sum & " из 15"
            Label7.Visible = True

            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label1.Visible = False
            Label6.Visible = False
        Else
            Label6.Visible = False
            Label6.Text = c
            Label1.Text = q(qorder(c))
            Label2.Text = ans(qorder(c), 1)
            Label3.Text = ans(qorder(c), 2)
            Label4.Text = ans(qorder(c), 3)
            Label5.Text = ans(qorder(c), 4)

        End If
    End Sub
    Private Sub label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label5.Text = ran(qorder(c)) Then
            sum += 1
        End If
        c += 1
        If c >= 16 Then

            Label7.Text = "Вы завершили тестирование, ваш результат: " & sum & " из 15"
            Label7.Visible = True

            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label1.Visible = False
            Label6.Visible = False
        Else
            Label6.Visible = False
            Label6.Text = c
            Label1.Text = q(qorder(c))
            Label2.Text = ans(qorder(c), 1)
            Label3.Text = ans(qorder(c), 2)
            Label4.Text = ans(qorder(c), 3)
            Label5.Text = ans(qorder(c), 4)

        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()

        If k5 = 1 Then
            Form1.PictureBox13.Visible = False
            Form1.PictureBox12.Visible = True
            Form1.PictureBox15.Visible = False
            Form1.PictureBox17.Visible = False
        Else
            Form1.PictureBox13.Visible = True
            Form1.PictureBox12.Visible = False
        End If
        r5 = 1
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        Label2.ForeColor = Color.SeaGreen
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        Label3.ForeColor = Color.SeaGreen
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.SeaGreen
    End Sub

    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        Label5.ForeColor = Color.SeaGreen
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

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