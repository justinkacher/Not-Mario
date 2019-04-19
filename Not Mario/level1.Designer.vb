<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.charbox = New System.Windows.Forms.PictureBox()
        Me.goomba5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.goomba4 = New System.Windows.Forms.PictureBox()
        Me.goomba1 = New System.Windows.Forms.PictureBox()
        Me.goomba2 = New System.Windows.Forms.PictureBox()
        Me.goomba3 = New System.Windows.Forms.PictureBox()
        Me.timera = New System.Windows.Forms.Timer(Me.components)
        Me.timerd = New System.Windows.Forms.Timer(Me.components)
        Me.timerw = New System.Windows.Forms.Timer(Me.components)
        Me.goomba = New System.Windows.Forms.Timer(Me.components)
        Me.spawngoomba = New System.Windows.Forms.Timer(Me.components)
        Me.characterloc = New System.Windows.Forms.Label()
        Me.goomba_2 = New System.Windows.Forms.Label()
        Me.goomba_4 = New System.Windows.Forms.Label()
        Me.goomba_1 = New System.Windows.Forms.Label()
        Me.goomba_5 = New System.Windows.Forms.Label()
        Me.goomba_3 = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.tmrscore = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.charbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goomba5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goomba4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goomba1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goomba2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goomba3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Not_Mario.My.Resources.Resources.ground
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 1202)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(3071, 116)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'charbox
        '
        Me.charbox.BackColor = System.Drawing.Color.Transparent
        Me.charbox.Location = New System.Drawing.Point(25, 894)
        Me.charbox.Name = "charbox"
        Me.charbox.Size = New System.Drawing.Size(281, 323)
        Me.charbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.charbox.TabIndex = 1
        Me.charbox.TabStop = False
        '
        'goomba5
        '
        Me.goomba5.BackColor = System.Drawing.Color.Transparent
        Me.goomba5.Image = CType(resources.GetObject("goomba5.Image"), System.Drawing.Image)
        Me.goomba5.Location = New System.Drawing.Point(2739, 852)
        Me.goomba5.Name = "goomba5"
        Me.goomba5.Size = New System.Drawing.Size(136, 121)
        Me.goomba5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goomba5.TabIndex = 2
        Me.goomba5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Not_Mario.My.Resources.Resources.X
        Me.PictureBox1.Location = New System.Drawing.Point(2984, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'goomba4
        '
        Me.goomba4.BackColor = System.Drawing.Color.Transparent
        Me.goomba4.Image = CType(resources.GetObject("goomba4.Image"), System.Drawing.Image)
        Me.goomba4.Location = New System.Drawing.Point(1512, 601)
        Me.goomba4.Name = "goomba4"
        Me.goomba4.Size = New System.Drawing.Size(136, 121)
        Me.goomba4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goomba4.TabIndex = 7
        Me.goomba4.TabStop = False
        '
        'goomba1
        '
        Me.goomba1.BackColor = System.Drawing.Color.Transparent
        Me.goomba1.Image = CType(resources.GetObject("goomba1.Image"), System.Drawing.Image)
        Me.goomba1.Location = New System.Drawing.Point(1475, 420)
        Me.goomba1.Name = "goomba1"
        Me.goomba1.Size = New System.Drawing.Size(136, 121)
        Me.goomba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goomba1.TabIndex = 8
        Me.goomba1.TabStop = False
        '
        'goomba2
        '
        Me.goomba2.BackColor = System.Drawing.Color.Transparent
        Me.goomba2.Image = CType(resources.GetObject("goomba2.Image"), System.Drawing.Image)
        Me.goomba2.Location = New System.Drawing.Point(1655, 403)
        Me.goomba2.Name = "goomba2"
        Me.goomba2.Size = New System.Drawing.Size(136, 121)
        Me.goomba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goomba2.TabIndex = 9
        Me.goomba2.TabStop = False
        '
        'goomba3
        '
        Me.goomba3.BackColor = System.Drawing.Color.Transparent
        Me.goomba3.Image = CType(resources.GetObject("goomba3.Image"), System.Drawing.Image)
        Me.goomba3.Location = New System.Drawing.Point(1918, 515)
        Me.goomba3.Name = "goomba3"
        Me.goomba3.Size = New System.Drawing.Size(136, 121)
        Me.goomba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goomba3.TabIndex = 10
        Me.goomba3.TabStop = False
        '
        'timera
        '
        '
        'timerd
        '
        '
        'timerw
        '
        '
        'goomba
        '
        '
        'spawngoomba
        '
        Me.spawngoomba.Interval = 1000
        '
        'characterloc
        '
        Me.characterloc.AutoSize = True
        Me.characterloc.Location = New System.Drawing.Point(21, 14)
        Me.characterloc.Name = "characterloc"
        Me.characterloc.Size = New System.Drawing.Size(0, 20)
        Me.characterloc.TabIndex = 11
        '
        'goomba_2
        '
        Me.goomba_2.AutoSize = True
        Me.goomba_2.Location = New System.Drawing.Point(895, 56)
        Me.goomba_2.Name = "goomba_2"
        Me.goomba_2.Size = New System.Drawing.Size(0, 20)
        Me.goomba_2.TabIndex = 12
        '
        'goomba_4
        '
        Me.goomba_4.AutoSize = True
        Me.goomba_4.Location = New System.Drawing.Point(895, 125)
        Me.goomba_4.Name = "goomba_4"
        Me.goomba_4.Size = New System.Drawing.Size(0, 20)
        Me.goomba_4.TabIndex = 13
        '
        'goomba_1
        '
        Me.goomba_1.AutoSize = True
        Me.goomba_1.Location = New System.Drawing.Point(895, 27)
        Me.goomba_1.Name = "goomba_1"
        Me.goomba_1.Size = New System.Drawing.Size(0, 20)
        Me.goomba_1.TabIndex = 14
        '
        'goomba_5
        '
        Me.goomba_5.AutoSize = True
        Me.goomba_5.Location = New System.Drawing.Point(895, 162)
        Me.goomba_5.Name = "goomba_5"
        Me.goomba_5.Size = New System.Drawing.Size(0, 20)
        Me.goomba_5.TabIndex = 15
        '
        'goomba_3
        '
        Me.goomba_3.AutoSize = True
        Me.goomba_3.Location = New System.Drawing.Point(895, 88)
        Me.goomba_3.Name = "goomba_3"
        Me.goomba_3.Size = New System.Drawing.Size(0, 20)
        Me.goomba_3.TabIndex = 16
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(21, 116)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(0, 108)
        Me.lblscore.TabIndex = 17
        '
        'tmrscore
        '
        '
        'level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(3057, 1345)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.goomba_3)
        Me.Controls.Add(Me.goomba_5)
        Me.Controls.Add(Me.goomba_1)
        Me.Controls.Add(Me.goomba_4)
        Me.Controls.Add(Me.goomba_2)
        Me.Controls.Add(Me.characterloc)
        Me.Controls.Add(Me.goomba3)
        Me.Controls.Add(Me.goomba2)
        Me.Controls.Add(Me.goomba1)
        Me.Controls.Add(Me.goomba4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.goomba5)
        Me.Controls.Add(Me.charbox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "level1"
        Me.Text = "level_1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.charbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goomba5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goomba4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goomba1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goomba2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goomba3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents charbox As PictureBox
    Friend WithEvents goomba5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents goomba4 As PictureBox
    Friend WithEvents goomba1 As PictureBox
    Friend WithEvents goomba2 As PictureBox
    Friend WithEvents goomba3 As PictureBox
    Friend WithEvents timera As Timer
    Friend WithEvents timerd As Timer
    Friend WithEvents timerw As Timer
    Friend WithEvents goomba As Timer
    Friend WithEvents spawngoomba As Timer
    Friend WithEvents characterloc As Label
    Friend WithEvents goomba_2 As Label
    Friend WithEvents goomba_4 As Label
    Friend WithEvents goomba_1 As Label
    Friend WithEvents goomba_5 As Label
    Friend WithEvents goomba_3 As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents tmrscore As Timer
End Class
