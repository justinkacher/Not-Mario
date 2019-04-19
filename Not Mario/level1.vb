Public Class level1
    Dim charboxloc As Point
    Dim score As Integer
    Dim chosencharacter As String = Choose_Character.character
    Dim goomba1location As Point
    Dim goomba2location As Point
    Dim goomba3location As Point
    Dim goomba4location As Point
    Dim goomba5location As Point
    Private Sub game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        goomba1location.X = 0
        goomba1location.Y = 0
        goomba2location.X = 0
        goomba2location.Y = 0
        goomba3location.X = 0
        goomba3location.Y = 0
        goomba4location.X = 0
        goomba4location.Y = 0
        goomba5location.X = 0
        goomba5location.Y = 0
        'opens window in full screen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        ' setting ground size and location
        Dim ground As Point
        ground.X = 0
        ground.Y = Me.Height - Me.Height * 0.1
        brick.Location = ground
        brick.Width = Me.Width
        brick.Height = 0.1 * Me.Height
        'sets location of close (x) button
        Dim x As Point
        x.X = 0.975 * Me.Width
        x.Y = 5
        PictureBox1.Location = x
        'genblock()
        'size and location of character
        charbox.Height = Me.Height * 0.125
        charbox.Width = Me.Width * 0.06125
        If chosencharacter = "mario" Then
            charbox.Image = My.Resources.mario
        ElseIf chosencharacter = "luigi" Then
            charbox.Image = My.Resources.luigi
        ElseIf chosencharacter = "yoshi" Then
            charbox.Image = My.Resources.yoshi
        ElseIf chosencharacter = "koopa" Then
            charbox.Image = My.Resources.koopa
        End If
        charboxloc.X = 0
        charboxloc.Y = Me.Height * 0.775
        charbox.Location = charboxloc
        goomba1.Hide()
        goomba2.Hide()
        goomba3.Hide()
        goomba4.Hide()
        goomba5.Hide()
        goomba.Enabled = True
        spawngoomba.Enabled = True
        Dim scoreloc As Point
        scoreloc.X = Me.Width * 0.02
        scoreloc.Y = Me.Height * 0.04
        lblscore.Location = scoreloc
        tmrscore.Enabled = True
        score = 0
    End Sub


    Dim collision As Boolean
    Private Sub timera_Tick(sender As Object, e As EventArgs) Handles timera.Tick
        'timer for "a" key press
        charboxloc.X = charboxloc.X - 10
        charboxloc.Y = charboxloc.Y
        charbox.Location = charboxloc
        Dim collision As Boolean
        For Each PictureBox In Me.Controls
            If PictureBox IsNot charbox AndAlso charbox.Bounds.IntersectsWith(PictureBox.Bounds) Then
                collision = True
                gameover.Show()
                Me.Hide()
            Else
                collision = False
            End If
        Next
    End Sub
    Private Sub timerw_Tick(sender As Object, e As EventArgs) Handles timerw.Tick
        'timer for "w" key press
        charboxloc.X = charboxloc.X
        Static counter As Integer
        If counter = 0 Then
            charboxloc.Y = Me.Height * 0.75
            counter += 1
        ElseIf counter = 1 Then
            charboxloc.Y = Me.Height * 0.71
            counter += 1
        ElseIf counter = 2 Then
            charboxloc.Y = Me.Height * 0.65
            counter += 1
        ElseIf counter = 3 Then
            charboxloc.Y = Me.Height * 0.625
            counter += 1
        ElseIf counter = 4 Then
            charboxloc.Y = Me.Height * 0.575
            counter += 1
        ElseIf counter = 5 Then
            charboxloc.Y = Me.Height * 0.525
            counter += 1
        ElseIf counter = 6 Then
            charboxloc.Y = Me.Height * 0.575
            counter += 1
        ElseIf counter = 7 Then
            charboxloc.Y = Me.Height * 0.625
            counter += 1
        ElseIf counter = 8 Then
            charboxloc.Y = Me.Height * 0.65
            counter += 1
        ElseIf counter = 9 Then
            charboxloc.Y = Me.Height * 0.71
            counter += 1
        Else
            counter = 0
            charboxloc.Y = Me.Height * 0.775
            timerw.Enabled = False
        End If
        charbox.Location = charboxloc
        For Each PictureBox In Me.Controls
            If PictureBox IsNot charbox AndAlso charbox.Bounds.IntersectsWith(PictureBox.Bounds) Then
                collision = True
                gameover.Show()
                Me.Hide()
            Else
                collision = False
            End If
        Next
    End Sub
    Private Sub timerd_Tick(sender As Object, e As EventArgs) Handles timerd.Tick
        'timer for "d" key press
        charboxloc.X = charboxloc.X + 10
        charboxloc.Y = charboxloc.Y
        charbox.Location = charboxloc
        For Each PictureBox In Me.Controls
            If PictureBox IsNot charbox AndAlso charbox.Bounds.IntersectsWith(PictureBox.Bounds) Then
                collision = True
                gameover.Show()
                Me.Hide()
            Else
                collision = False
            End If
        Next
    End Sub
    Private Sub game_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'key press event
        If e.KeyChar = "a" Then
            timera.Enabled = True
        ElseIf e.KeyChar = "d" Then
            timerd.Enabled = True
        ElseIf e.KeyChar = "w" Then
            timerw.Enabled = True
        End If
    End Sub
    Private Sub game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'key up event
        If e.KeyCode = Keys.A Then
            timera.Enabled = False
        ElseIf e.KeyCode = Keys.D Then
            timerd.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub gengoomba()



    End Sub

    Private Sub goomba_Tick(sender As Object, e As EventArgs) Handles goomba.Tick
        If goom1 = True Then
            goomba1location.X -= 5
            goomba1.Location = goomba1location
        End If
        If goom2 = True Then
            goomba2location.X -= 5
            goomba2.Location = goomba2location
        End If
        If goom3 = True Then
            goomba3location.X -= 5
            goomba3.Location = goomba3location
        End If
        If goom4 = True Then
            goomba4location.X -= 5
            goomba4.Location = goomba4location
        End If
        If goom5 = True Then
            goomba5location.X -= 5
            goomba5.Location = goomba5location
        End If
    End Sub
    Dim goom1 As Boolean
    Dim goom2 As Boolean
    Dim goom3 As Boolean
    Dim goom4 As Boolean
    Dim goom5 As Boolean
    Private Sub spawngoomba_Tick(sender As Object, e As EventArgs) Handles spawngoomba.Tick
        Static goombacounter As Integer
        If goombacounter = 0 Then
            goombacounter += 1
            goomba1.Show()
            goomba1.Height = Me.Height * 0.05
            goomba1.Width = Me.Width * 0.025
            goomba1location.X = Me.Width
            goomba1location.Y = Me.Height * 0.85
            goomba1.Location = goomba1location
            goom1 = True

        ElseIf goombacounter = 1 Then
            goombacounter += 1
            goomba2.Show()
            goomba2.Height = Me.Height * 0.05
            goomba2.Width = Me.Width * 0.025
            goomba2location.X = Me.Width
            goomba2location.Y = Me.Height * 0.85
            goomba2.Location = goomba2location
            goom2 = True
        ElseIf goombacounter = 2 Then
            goombacounter += 1
            goomba3.Show()
            goomba3.Height = Me.Height * 0.05
            goomba3.Width = Me.Width * 0.025
            goomba3location.X = Me.Width
            goomba3location.Y = Me.Height * 0.85
            goomba3.Location = goomba3location
            goom3 = True
        ElseIf goombacounter = 3 Then
            goombacounter += 1
            goomba4.Show()
            goomba4.Height = Me.Height * 0.05
            goomba4.Width = Me.Width * 0.025
            goomba4location.X = Me.Width
            goomba4location.Y = Me.Height * 0.85
            goomba4.Location = goomba4location
            goom4 = True
        ElseIf goombacounter = 4 Then
            goombacounter += 1
            goomba5.Show()
            goomba5.Height = Me.Height * 0.05
            goomba5.Width = Me.Width * 0.025
            goomba5location.X = Me.Width
            goomba5location.Y = Me.Height * 0.85
            goomba5.Location = goomba5location
            goom5 = True
        Else
            spawngoomba.Enabled = False
        End If
    End Sub
    Dim scorecounter As Integer

    Private Sub tmrscore_Tick_1(sender As Object, e As EventArgs) Handles tmrscore.Tick
        If charboxloc.X > goomba1location.X And goomba1location.X <> 0 And scorecounter < 1 Then
            score += 500
            scorecounter += 1

        ElseIf charboxloc.X > goomba2location.X And goomba2location.X <> 0 And scorecounter < 2 Then
            score += 500
            scorecounter += 1

        ElseIf charboxloc.X > goomba3location.X And goomba3location.X <> 0 And scorecounter < 3 Then
            score += 500
            scorecounter += 1

        ElseIf charboxloc.X > goomba4location.X And goomba4location.X <> 0 And scorecounter < 4 Then
            score += 500
            scorecounter += 1

        ElseIf charboxloc.X > goomba5location.X And goomba5location.X <> 0 And scorecounter < 5 Then
            score += 500
            scorecounter += 1

        End If
        lblscore.Text = score
        characterloc.Text = "X: " & charboxloc.X & "   Y: " & charboxloc.Y
        goomba_1.Text = "goomba1  " & "X: " & goomba1location.X & "   Y: " & goomba1location.Y
        goomba_2.Text = "goomba2  " & "X: " & goomba2location.X & "   Y: " & goomba2location.Y
        goomba_3.Text = "goomba3  " & "X: " & goomba3location.X & "   Y: " & goomba3location.Y
        goomba_4.Text = "goomba4  " & "X: " & goomba4location.X & "   Y: " & goomba4location.Y
        goomba_5.Text = "goomba5  " & "X: " & goomba5location.X & "   Y: " & goomba5location.Y
    End Sub


End Class
