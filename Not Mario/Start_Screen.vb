Public Class Start_Screen
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'starts blinking start button
        tmrstart.Start()
        'size of "not mario
        Label1.Width = 0.8 * Me.Width
        Label1.Height = 0.2 * Me.Height
        'sizes start button
        btnstart.Width = 1 * Me.Width
        btnstart.Height = 1 * Me.Height
        'sets location of close (x) button
        Dim x As Point
        x.X = 0.975 * Me.Width
        x.Y = 5
        PictureBox1.Location = x
    End Sub
	Dim timer As Integer
	Private Sub tmrstart_Tick(sender As Object, e As EventArgs) Handles tmrstart.Tick
		timer += 1
		If timer Mod 2 = 0 Then
            btnstart.Text = "Click Anywhere to Start"
        Else
			btnstart.Text = ""
		End If
	End Sub

	Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
		Choose_Character.ShowDialog()
		Me.Hide()
	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Application.Exit()
	End Sub
End Class
