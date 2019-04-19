<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose_Character
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choose_Character))
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.arrowright = New System.Windows.Forms.PictureBox()
		Me.arrowleft = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.characterbox = New System.Windows.Forms.PictureBox()
		Me.lblchoose = New System.Windows.Forms.Label()
		Me.lblgo = New System.Windows.Forms.Label()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.arrowright, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.arrowleft, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.characterbox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox2
		'
		Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.PictureBox2.Image = Global.Not_Mario.My.Resources.Resources.ground
		Me.PictureBox2.Location = New System.Drawing.Point(0, 594)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(1123, 76)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 2
		Me.PictureBox2.TabStop = False
		'
		'arrowright
		'
		Me.arrowright.Image = Global.Not_Mario.My.Resources.Resources.arrowright
		Me.arrowright.Location = New System.Drawing.Point(711, 195)
		Me.arrowright.Name = "arrowright"
		Me.arrowright.Size = New System.Drawing.Size(200, 195)
		Me.arrowright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.arrowright.TabIndex = 3
		Me.arrowright.TabStop = False
		'
		'arrowleft
		'
		Me.arrowleft.Image = Global.Not_Mario.My.Resources.Resources.arrowleft
		Me.arrowleft.Location = New System.Drawing.Point(155, 195)
		Me.arrowleft.Name = "arrowleft"
		Me.arrowleft.Size = New System.Drawing.Size(200, 195)
		Me.arrowleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.arrowleft.TabIndex = 4
		Me.arrowleft.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Not_Mario.My.Resources.Resources.X
		Me.PictureBox1.Location = New System.Drawing.Point(1083, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'characterbox
		'
		Me.characterbox.Location = New System.Drawing.Point(385, 207)
		Me.characterbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.characterbox.Name = "characterbox"
		Me.characterbox.Size = New System.Drawing.Size(333, 390)
		Me.characterbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.characterbox.TabIndex = 6
		Me.characterbox.TabStop = False
		'
		'lblchoose
		'
		Me.lblchoose.Font = New System.Drawing.Font("Matura MT Script Capitals", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblchoose.ForeColor = System.Drawing.Color.Crimson
		Me.lblchoose.Location = New System.Drawing.Point(117, 22)
		Me.lblchoose.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblchoose.Name = "lblchoose"
		Me.lblchoose.Size = New System.Drawing.Size(866, 124)
		Me.lblchoose.TabIndex = 7
		Me.lblchoose.Text = "choose your fighter!"
		Me.lblchoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblgo
		'
		Me.lblgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lblgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblgo.ForeColor = System.Drawing.Color.DarkBlue
		Me.lblgo.Location = New System.Drawing.Point(453, 133)
		Me.lblgo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblgo.Name = "lblgo"
		Me.lblgo.Size = New System.Drawing.Size(287, 136)
		Me.lblgo.TabIndex = 8
		Me.lblgo.Text = "Click Here To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Go!"
		Me.lblgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Choose_Character
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SkyBlue
		Me.ClientSize = New System.Drawing.Size(1123, 670)
		Me.Controls.Add(Me.characterbox)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.arrowleft)
		Me.Controls.Add(Me.arrowright)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.lblgo)
		Me.Controls.Add(Me.lblchoose)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Choose_Character"
		Me.Text = "Choose Character"
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.arrowright, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.arrowleft, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.characterbox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents arrowright As PictureBox
	Friend WithEvents arrowleft As PictureBox
	Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents characterbox As PictureBox
    Friend WithEvents lblchoose As Label
    Friend WithEvents lblgo As Label
End Class
