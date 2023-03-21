Public Class Form6
    Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim i, k, z As Integer

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = X
        Me.Height = Y
        i = 0
        k = 0
        z = 0
        PictureBox1.Top = 0
        PictureBox1.Left = 0
        PictureBox1.Height = Y
        PictureBox1.Width = X

        PictureBox2.Top = (730 / 900) * Y
        PictureBox2.Left = (75 / 1440) * X
        PictureBox2.Height = (82 / 900) * Y
        PictureBox2.Width = (97 / 1440) * X

        PictureBox3.Top = (78 / 900) * Y
        PictureBox3.Left = (55 / 1440) * X
        PictureBox3.Height = (106 / 900) * Y
        PictureBox3.Width = (105 / 1440) * X

        Label1.Top = (412 / 900) * Y
        Label1.Left = (475 / 1440) * X
        Label1.Height = (80 / 900) * Y
        Label1.Width = (581 / 1440) * X

        Label2.Top = (190 / 900) * Y
        Label2.Left = (72 / 1440) * X
        Label2.Height = (39 / 900) * Y
        Label2.Width = (37 / 1440) * X

        Label3.Top = (300 / 900) * Y
        Label3.Left = (72 / 1440) * X
        Label3.Height = (39 / 900) * Y
        Label3.Width = (37 / 1440) * X

        Label4.Top = (410 / 900) * Y
        Label4.Left = (72 / 1440) * X
        Label4.Height = (39 / 900) * Y
        Label4.Width = (37 / 1440) * X

        Label5.Top = (520 / 900) * Y
        Label5.Left = (72 / 1440) * X
        Label5.Height = (39 / 900) * Y
        Label5.Width = (37 / 1440) * X

        Label6.Top = (190 / 900) * Y
        Label6.Left = (115 / 1440) * X
        Label6.Height = (39 / 900) * Y
        Label6.Width = (37 / 1440) * X

        Label7.Top = (300 / 900) * Y
        Label7.Left = (115 / 1440) * X
        Label7.Height = (39 / 900) * Y
        Label7.Width = (37 / 1440) * X

        Label8.Top = (410 / 900) * Y
        Label8.Left = (115 / 1440) * X
        Label8.Height = (39 / 900) * Y
        Label8.Width = (37 / 1440) * X

        Label9.Top = (520 / 900) * Y
        Label9.Left = (115 / 1440) * X
        Label9.Height = (39 / 900) * Y
        Label9.Width = (37 / 1440) * X

        Label10.Top = (190 / 900) * Y
        Label10.Left = (384 / 1440) * X
        Label10.Height = (64 / 900) * Y
        Label10.Width = (871 / 1440) * X

        Label11.Top = (300 / 900) * Y
        Label11.Left = (384 / 1440) * X
        Label11.Height = (64 / 900) * Y
        Label11.Width = (871 / 1440) * X

        Label12.Top = (410 / 900) * Y
        Label12.Left = (384 / 1440) * X
        Label12.Height = (64 / 900) * Y
        Label12.Width = (871 / 1440) * X

        Label13.Top = (520 / 900) * Y
        Label13.Left = (384 / 1440) * X
        Label13.Height = (64 / 900) * Y
        Label13.Width = (871 / 1440) * X

        Label14.Top = (81 / 900) * Y
        Label14.Left = (1250 / 1440) * X
        Label14.Height = (49 / 900) * Y
        Label14.Width = (110 / 1440) * X

        Button1.Top = (469 / 900) * Y
        Button1.Left = (623 / 1440) * X
        Button1.Height = (64 / 900) * Y
        Button1.Width = (187 / 1440) * X

        Button2.Top = (744 / 900) * Y
        Button2.Left = (591 / 1440) * X
        Button2.Height = (68 / 900) * Y
        Button2.Width = (272 / 1440) * X

        PictureBox1.Image = My.Resources._0048

        PictureBox1.Controls.Add(Label1)
        PictureBox1.Controls.Add(PictureBox2)
        PictureBox1.Controls.Add(PictureBox3)
        PictureBox1.Controls.Add(Label2)
        PictureBox1.Controls.Add(Label3)
        PictureBox1.Controls.Add(Label4)
        PictureBox1.Controls.Add(Label5)
        PictureBox1.Controls.Add(Label6)
        PictureBox1.Controls.Add(Label7)
        PictureBox1.Controls.Add(Label8)
        PictureBox1.Controls.Add(Label9)
        PictureBox1.Controls.Add(Label10)
        PictureBox1.Controls.Add(Label12)
        PictureBox1.Controls.Add(Label11)
        PictureBox1.Controls.Add(Label13)
        PictureBox1.Controls.Add(Label14)


        PictureBox2.Visible = False
        Button2.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label14.Text = " " & i + 1 & " /12"
        Label10.Text = "A)Шелковый путь начинает функционировать как регулярная дипломатическая и торговая артерия"
        Label11.Text = "B)Наиболее оживленным становится путь, проходивший из Китая на запад через Семиречье и Южный Казахстан"
        Label12.Text = "C)Происходит оживление Шелкового пути на участке Семиречья и Южного Казахстана"
        Label13.Text = "D)Междоусобицы и войны, приведшие к гибели городской культуры, и освоение морских путей в Китай приводят ВШП к его угасанию"
        Label1.Visible = False
        Button1.Visible = False
        PictureBox2.Visible = True
        Button2.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        z = z + 1
        If z < 5 Then
            If z = 1 Then Label6.Text = "A"
            If z = 2 Then Label7.Text = "A"
            If z = 3 Then Label8.Text = "A"
            If z = 4 Then Label9.Text = "A"
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        z = z + 1
        If z < 5 Then
            If z = 1 Then Label6.Text = "B"
            If z = 2 Then Label7.Text = "B"
            If z = 3 Then Label8.Text = "B"
            If z = 4 Then Label9.Text = "B"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        z = 0
        Label6.Text = " "
        Label7.Text = " "
        Label8.Text = " "
        Label9.Text = " "

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        z = z + 1
        If z < 5 Then
            If z = 1 Then Label6.Text = "C"
            If z = 2 Then Label7.Text = "C"
            If z = 3 Then Label8.Text = "C"
            If z = 4 Then Label9.Text = "C"
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        z = z + 1
        If z < 5 Then
            If z = 1 Then Label6.Text = "D"
            If z = 2 Then Label7.Text = "D"
            If z = 3 Then Label8.Text = "D"
            If z = 4 Then Label9.Text = "D"
        End If
    End Sub

    Private Sub Label10_MouseMove(sender As Object, e As MouseEventArgs) Handles Label10.MouseMove
        Label10.ForeColor = Color.SeaGreen
    End Sub

    Private Sub Label11_MouseMove(sender As Object, e As MouseEventArgs) Handles Label11.MouseMove
        Label11.ForeColor = Color.SeaGreen
    End Sub

    Private Sub Label12_MouseMove(sender As Object, e As MouseEventArgs) Handles Label12.MouseMove
        Label12.ForeColor = Color.SeaGreen
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = i + 1
        If i - 1 = 0 Then
            If Label6.Text = "A" Then k = k + 1
            If Label7.Text = "B" Then k = k + 1
            If Label8.Text = "C" Then k = k + 1
            If Label9.Text = "D" Then k = k + 1
        End If
        If i = 1 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Смерть Чингисхана"
            Label11.Text = "B)На курултае монгольской знати Тимучин был провозглашен верховным правителем – Чингиз ханом"
            Label12.Text = "C)Территория Казахстана окончательно вошла в состав империи Чингисхана"
            Label13.Text = "D)Вторжение войск Чингисхана в Семиречье"
        End If
        If i - 1 = 1 Then
            If Label6.Text = "B" Then k = k + 1
            If Label7.Text = "D" Then k = k + 1
            If Label8.Text = "C" Then k = k + 1
            If Label9.Text = "A" Then k = k + 1
        End If
        If i = 2 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Тохтамыш – хан Золотой Орды"
            Label11.Text = "B)Решающая битва между Тамерланом и Тохтамышем; Разгром столицы золотой орды войсками Тимура"
            Label12.Text = "C)Европейский поход Батыя, территория Золотой орды простиралась от Алтайских гор до Дуная"
            Label13.Text = "D)Образование ханом Батыем гос-ва Золотой орды"
        End If
        If i - 1 = 2 Then
            If Label6.Text = "C" Then k = k + 1
            If Label7.Text = "D" Then k = k + 1
            If Label8.Text = "A" Then k = k + 1
            If Label9.Text = "B" Then k = k + 1
        End If
        If i = 3 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Начало образование Казахского ханства"
            Label11.Text = "B)Буйдаш хан присоединил восточную часть Ногайской орды к Казахскому ханству"
            Label12.Text = "C)Образовано Джунгарское ханство"
            Label13.Text = "D)Таукел захватил города Туркестан, Сауран, Сайрам"
        End If
        If i - 1 = 3 Then
            If Label6.Text = "A" Then k = k + 1
            If Label7.Text = "B" Then k = k + 1
            If Label8.Text = "D" Then k = k + 1
            If Label9.Text = "C" Then k = k + 1
        End If
        If i = 4 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Запрет России Среднему жузу переходить через Иртыш на правую сторону"
            Label11.Text = "B)Начало присоединение Казахстана к России , присяга Абулхаира на верность России в Ставке хана"
            Label12.Text = "C)Просьба хана Тауке военной помощи у России"
            Label13.Text = "D)Первый курултай трех казахс.жузов в районе Каракумы для создание единого ополчения против Джунгар"
        End If
        If i - 1 = 4 Then
            If Label6.Text = "D" Then k = k + 1
            If Label7.Text = "C" Then k = k + 1
            If Label8.Text = "B" Then k = k + 1
            If Label9.Text = "A" Then k = k + 1
        End If
        If i = 5 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Первая русская школа для казахских детей (школа Жангир хана)"
            Label11.Text = "B)Екатерина II утвердила Абылая ханом Среднего жуза"
            Label12.Text = "C)Ликвидирована ханская власть в Мл. жузе, создание пограничной комиссии"
            Label13.Text = "D)Образована «Степная комиссия»"
        End If
        If i - 1 = 5 Then
            If Label6.Text = "B" Then k = k + 1
            If Label7.Text = "C" Then k = k + 1
            If Label8.Text = "A" Then k = k + 1
            If Label9.Text = "D" Then k = k + 1
        End If
        If i = 6 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Издание газеты «Казах»"
            Label11.Text = "B)Оренбург первая столица в Каз.АССР"
            Label12.Text = "C)Открытие учительского института в Оренбурге"
            Label13.Text = "D)Начало заселения русскими крестьянами казахских земель"
        End If
        If i - 1 = 6 Then
            If Label6.Text = "C" Then k = k + 1
            If Label7.Text = "D" Then k = k + 1
            If Label8.Text = "A" Then k = k + 1
            If Label9.Text = "B" Then k = k + 1
        End If
        If i = 7 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"

            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Земельно-водная реформа, цель: возвратить земли казахам, отнятые царизмом"
            Label11.Text = "B)Столица республики перенесена из Оренбурга в Кызыл-орду"
            Label12.Text = "C)Принят декрет о введение делопроизводства на казахском языке"
            Label13.Text = "D)Голод, число голодающих 2,3 млн, население сократилось до 1 млн"
        End If
        If i - 1 = 7 Then
            If Label6.Text = "A" Then k = k + 1
            If Label7.Text = "D" Then k = k + 1
            If Label8.Text = "C" Then k = k + 1
            If Label9.Text = "B" Then k = k + 1
        End If
        If i = 8 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Прекращение наземных испытаний на Семипалатинском полигоне"
            Label11.Text = "B)Открыта академия наук Каз.ССР"
            Label12.Text = "C)Великая Отечественная Война"
            Label13.Text = "D)Ввод в действие космического комплекса Байконур"
        End If
        If i - 1 = 8 Then
            If Label6.Text = "C" Then k = k + 1
            If Label7.Text = "B" Then k = k + 1
            If Label8.Text = "D" Then k = k + 1
            If Label9.Text = "A" Then k = k + 1
        End If
        If i = 9 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Принята декларация о гос. суверенитете Каз.ССР"
            Label11.Text = "B)Подписан указ о закрытие Семипалатинского полигона"
            Label12.Text = "C)Назарбаев первый секретарь ЦК компартии Казахстана"
            Label13.Text = "D)Реабилитированы Байтурсынов, Жумабаев, Дулатов, Кудайбердиев"
        End If
        If i - 1 = 9 Then
            If Label6.Text = "D" Then k = k + 1
            If Label7.Text = "C" Then k = k + 1
            If Label8.Text = "A" Then k = k + 1
            If Label9.Text = "B" Then k = k + 1
        End If
        If i = 10 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Решение о переименовании КССР в РК"
            Label11.Text = "B)Принят закон о гос. независимости РК"
            Label12.Text = "C)Казахстан вступает ООН"
            Label13.Text = "D)Принятие новой конституции РК"
        End If
        If i - 1 = 10 Then
            If Label6.Text = "A" Then k = k + 1
            If Label7.Text = "B" Then k = k + 1
            If Label8.Text = "C" Then k = k + 1
            If Label9.Text = "D" Then k = k + 1
        End If
        If i = 11 Then
            z = 0
            Label14.Text = " " & i + 1 & " /12"
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = "A)Программная статья Главы государства «Рухани жангыру"
            Label11.Text = "B)Казахстан стал Председателем ОБСЕ"
            Label12.Text = "C)Программная статья Елбасы «Семь граней Великой степи»"
            Label13.Text = "D)Стратегия «Казахстан-2050»"
        End If
        If i - 1 = 11 Then
            If Label6.Text = "B" Then k = k + 1
            If Label7.Text = "D" Then k = k + 1
            If Label8.Text = "A" Then k = k + 1
            If Label9.Text = "C" Then k = k + 1
        End If
        If i = 12 Then
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label9.Visible = False
            PictureBox2.Visible = False
            Button2.Visible = False

            Label1.Text = "Вы завершили тестирование, ваш результат: " & k & " из 48"
        End If
    End Sub

    Private Sub Label13_MouseMove(sender As Object, e As MouseEventArgs) Handles Label13.MouseMove
        Label13.ForeColor = Color.SeaGreen
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Label10.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
    End Sub
    'Label1.Text = "Вы завершили тестирование, ваш результат: " & sum & " из 15"
End Class