<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputFoto
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
		Me.GroupBoxInputGambar = New System.Windows.Forms.GroupBox()
		Me.LabelStatusDb = New System.Windows.Forms.Label()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonReset = New System.Windows.Forms.Button()
		Me.ButtonSimpan = New System.Windows.Forms.Button()
		Me.ButtonPilihGambar = New System.Windows.Forms.Button()
		Me.PBGambar = New System.Windows.Forms.PictureBox()
		Me.LabelPilihGambar = New System.Windows.Forms.Label()
		Me.TextBoxNoId = New System.Windows.Forms.TextBox()
		Me.LabelNoID = New System.Windows.Forms.Label()
		Me.OFDGambar = New System.Windows.Forms.OpenFileDialog()
		Me.GroupBoxInputGambar.SuspendLayout()
		CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBoxInputGambar
		'
		Me.GroupBoxInputGambar.Controls.Add(Me.LabelStatusDb)
		Me.GroupBoxInputGambar.Controls.Add(Me.ButtonExit)
		Me.GroupBoxInputGambar.Controls.Add(Me.ButtonReset)
		Me.GroupBoxInputGambar.Controls.Add(Me.ButtonSimpan)
		Me.GroupBoxInputGambar.Controls.Add(Me.ButtonPilihGambar)
		Me.GroupBoxInputGambar.Controls.Add(Me.PBGambar)
		Me.GroupBoxInputGambar.Controls.Add(Me.LabelPilihGambar)
		Me.GroupBoxInputGambar.Controls.Add(Me.TextBoxNoId)
		Me.GroupBoxInputGambar.Controls.Add(Me.LabelNoID)
		Me.GroupBoxInputGambar.Location = New System.Drawing.Point(12, 12)
		Me.GroupBoxInputGambar.Name = "GroupBoxInputGambar"
		Me.GroupBoxInputGambar.Size = New System.Drawing.Size(261, 362)
		Me.GroupBoxInputGambar.TabIndex = 0
		Me.GroupBoxInputGambar.TabStop = False
		Me.GroupBoxInputGambar.Text = "Input Gambar"
		'
		'LabelStatusDb
		'
		Me.LabelStatusDb.AutoSize = True
		Me.LabelStatusDb.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusDb.Location = New System.Drawing.Point(180, 346)
		Me.LabelStatusDb.Name = "LabelStatusDb"
		Me.LabelStatusDb.Size = New System.Drawing.Size(10, 8)
		Me.LabelStatusDb.TabIndex = 8
		Me.LabelStatusDb.Text = "."
		'
		'ButtonExit
		'
		Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonExit.Image = Global.InputFoto.My.Resources.Resources.exit_32px
		Me.ButtonExit.Location = New System.Drawing.Point(96, 252)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(100, 38)
		Me.ButtonExit.TabIndex = 7
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonReset
		'
		Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonReset.Image = Global.InputFoto.My.Resources.Resources.close_window_32px
		Me.ButtonReset.Location = New System.Drawing.Point(155, 208)
		Me.ButtonReset.Name = "ButtonReset"
		Me.ButtonReset.Size = New System.Drawing.Size(41, 38)
		Me.ButtonReset.TabIndex = 6
		Me.ButtonReset.UseVisualStyleBackColor = True
		'
		'ButtonSimpan
		'
		Me.ButtonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonSimpan.Image = Global.InputFoto.My.Resources.Resources.add_file_32px
		Me.ButtonSimpan.Location = New System.Drawing.Point(96, 208)
		Me.ButtonSimpan.Name = "ButtonSimpan"
		Me.ButtonSimpan.Size = New System.Drawing.Size(41, 38)
		Me.ButtonSimpan.TabIndex = 5
		Me.ButtonSimpan.UseVisualStyleBackColor = True
		'
		'ButtonPilihGambar
		'
		Me.ButtonPilihGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonPilihGambar.Image = Global.InputFoto.My.Resources.Resources.search_16px
		Me.ButtonPilihGambar.Location = New System.Drawing.Point(202, 81)
		Me.ButtonPilihGambar.Name = "ButtonPilihGambar"
		Me.ButtonPilihGambar.Size = New System.Drawing.Size(23, 23)
		Me.ButtonPilihGambar.TabIndex = 4
		Me.ButtonPilihGambar.UseVisualStyleBackColor = True
		'
		'PBGambar
		'
		Me.PBGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PBGambar.Location = New System.Drawing.Point(96, 81)
		Me.PBGambar.Name = "PBGambar"
		Me.PBGambar.Size = New System.Drawing.Size(100, 121)
		Me.PBGambar.TabIndex = 3
		Me.PBGambar.TabStop = False
		'
		'LabelPilihGambar
		'
		Me.LabelPilihGambar.AutoSize = True
		Me.LabelPilihGambar.Location = New System.Drawing.Point(15, 81)
		Me.LabelPilihGambar.Name = "LabelPilihGambar"
		Me.LabelPilihGambar.Size = New System.Drawing.Size(75, 13)
		Me.LabelPilihGambar.TabIndex = 2
		Me.LabelPilihGambar.Text = "Pilih Gambar : "
		'
		'TextBoxNoId
		'
		Me.TextBoxNoId.Location = New System.Drawing.Point(96, 44)
		Me.TextBoxNoId.Name = "TextBoxNoId"
		Me.TextBoxNoId.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxNoId.TabIndex = 1
		'
		'LabelNoID
		'
		Me.LabelNoID.AutoSize = True
		Me.LabelNoID.Location = New System.Drawing.Point(15, 47)
		Me.LabelNoID.Name = "LabelNoID"
		Me.LabelNoID.Size = New System.Drawing.Size(75, 13)
		Me.LabelNoID.TabIndex = 0
		Me.LabelNoID.Text = "No Id            : "
		'
		'OFDGambar
		'
		Me.OFDGambar.FileName = "Filename"
		'
		'FormInputFoto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(291, 450)
		Me.Controls.Add(Me.GroupBoxInputGambar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormInputFoto"
		Me.Opacity = 0.85R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form Input Foto"
		Me.GroupBoxInputGambar.ResumeLayout(False)
		Me.GroupBoxInputGambar.PerformLayout()
		CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBoxInputGambar As GroupBox
	Friend WithEvents ButtonPilihGambar As Button
	Friend WithEvents PBGambar As PictureBox
	Friend WithEvents LabelPilihGambar As Label
	Friend WithEvents TextBoxNoId As TextBox
	Friend WithEvents LabelNoID As Label
	Friend WithEvents ButtonSimpan As Button
	Friend WithEvents ButtonReset As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents LabelStatusDb As Label
	Friend WithEvents OFDGambar As OpenFileDialog
End Class
