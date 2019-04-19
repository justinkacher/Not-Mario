Public Class Choose_Character
    Dim charcounter As Integer
    Public character As String
    Private Sub Choose_Character_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'opens window in full screen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        ' setting ground size and location
        Dim ground As Point
        ground.X = 0
        ground.Y = Me.Height
        PictureBox2.Location = ground
        PictureBox2.Width = Me.Width
        PictureBox2.Height = 0.1 * Me.Height
        'setting arrow sizes
        arrowleft.Width = 0.1 * Me.Width
        arrowleft.Height = 0.25 * Me.Height
        arrowright.Width = 0.1 * Me.Width
        arrowright.Height = 0.25 * Me.Height
        'left arrow location
        Dim left As Point
        left.X = Me.Width * 0.275
        left.Y = Me.Height * 0.5
        arrowleft.Location = left
        'right arrow location
        Dim right As Point
        right.X = Me.Width * 0.625
        right.Y = Me.Height * 0.5
        arrowright.Location = right
        'sets location of close (x) button
        Dim x As Point
        x.X = 0.975 * Me.Width
        x.Y = 5
        PictureBox1.Location = x
        'character box size
        characterbox.Width = Me.Width * 0.15
        characterbox.Height = Me.Height * 0.3
        'location of character box
        Dim character As Point
        character.X = Me.Width * 0.425
        character.Y = Me.Height * 0.6
        characterbox.Location = character
        'size of label
        lblchoose.Width = Me.Width * 0.5
        lblchoose.Height = Me.Height * 0.25
        'location of label
        Dim label As Point
        label.X = Me.Width * 0.25
		label.Y = Me.Height * 0.025
		lblchoose.Location = label
        'size of label
        lblgo.Width = Me.Width * 0.5
        lblgo.Height = Me.Height * 0.25
        'location of label
        Dim go As Point
        go.X = Me.Width * 0.25
        go.Y = Me.Height * 0.25
        lblgo.Location = go
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Application.Exit()
	End Sub

    Private Sub arrowright_Click(sender As Object, e As EventArgs) Handles arrowright.Click
        'if right arrow is clicked

        If charcounter = 0 Then
            charcounter += 1
            characterbox.Image = My.Resources.mario
            character = "mario"
        ElseIf charcounter = 1 Then
            charcounter += 1
            characterbox.Image = My.Resources.luigi
            character = "luigi"
        ElseIf charcounter = 2 Then
            charcounter += 1
            characterbox.Image = My.Resources.yoshi
            character = "yoshi"
        ElseIf charcounter = 3 Then
            characterbox.Image = My.Resources.koopa
            charcounter = 0
            character = "koopa"
        Else
            charcounter = 0
            MessageBox.Show("error")
        End If
    End Sub

    Private Sub arrowleft_Click(sender As Object, e As EventArgs) Handles arrowleft.Click
        'if left arrow is clicked

        If charcounter = 0 Then
            charcounter = 3
            characterbox.Image = My.Resources.mario
            character = "mario"
        ElseIf charcounter = 1 Then
            charcounter -= 1
            characterbox.Image = My.Resources.luigi
            character = "luigi"
        ElseIf charcounter = 2 Then
            charcounter -= 1
            characterbox.Image = My.Resources.yoshi
            character = "yoshi"
        ElseIf charcounter = 3 Then
            characterbox.Image = My.Resources.koopa
            charcounter -= 1
            character = "koopa"
        Else
            charcounter = 0
            MessageBox.Show("error")
        End If
    End Sub

    Private Sub lblgo_Click(sender As Object, e As EventArgs) Handles lblgo.Click
        If character = "" Then
            MessageBox.Show("please choose a character")
        Else
            level1.Show()
            Me.Hide()
        End If
    End Sub
End Class