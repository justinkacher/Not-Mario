Public Class gameover
    Private Sub gameover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'opens window in full screen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        'creates ground
        Dim ground As Point
        ground.X = 0
        ground.Y = Me.Height - Me.Height * 0.1
        PictureBox1.Location = ground
        PictureBox1.Width = Me.Width
        PictureBox1.Height = 0.1 * Me.Height
        'sets location of close (x) button
        Dim x As Point
        x.X = 0.975 * Me.Width
        x.Y = 5
        PictureBox2.Location = x
        'size of label
        lblover.Height = Me.Height
        lblover.Width = Me.Width

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub tmrover_Tick(sender As Object, e As EventArgs) Handles tmrover.Tick
        Static counter As Integer
        counter += 1
        If counter Mod 2 = 0 Then
            lblover.Text = "Game Over"
        Else
            lblover.Text = ""
        End If
    End Sub
End Class