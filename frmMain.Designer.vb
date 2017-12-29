<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.cbShowSteps = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnOpenFile2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ibOriginal = New Emgu.CV.UI.ImageBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "OpenFileDialog1"
        '
        'cbShowSteps
        '
        Me.cbShowSteps.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbShowSteps.AutoSize = True
        Me.cbShowSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowSteps.Location = New System.Drawing.Point(28, 448)
        Me.cbShowSteps.Margin = New System.Windows.Forms.Padding(2)
        Me.cbShowSteps.Name = "cbShowSteps"
        Me.cbShowSteps.Size = New System.Drawing.Size(107, 22)
        Me.cbShowSteps.TabIndex = 0
        Me.cbShowSteps.Text = "Show Steps"
        Me.cbShowSteps.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnOpenFile2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(42, 471)
        Me.Panel1.TabIndex = 3
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_reorder_black_24dp_1x
        Me.Button9.Location = New System.Drawing.Point(192, 6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(30, 26)
        Me.Button9.TabIndex = 15
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_check_circle_black_24dp_1x
        Me.Button7.Location = New System.Drawing.Point(3, 183)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 30)
        Me.Button7.TabIndex = 14
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_folder_open_black_24dp_1x
        Me.Button6.Location = New System.Drawing.Point(0, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(33, 26)
        Me.Button6.TabIndex = 13
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_details_black_24dp_1x
        Me.Button5.Location = New System.Drawing.Point(3, 261)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 12
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(39, 261)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 30)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Detils"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnOpenFile2
        '
        Me.btnOpenFile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpenFile2.FlatAppearance.BorderSize = 0
        Me.btnOpenFile2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnOpenFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile2.ForeColor = System.Drawing.Color.Transparent
        Me.btnOpenFile2.Location = New System.Drawing.Point(39, 97)
        Me.btnOpenFile2.Name = "btnOpenFile2"
        Me.btnOpenFile2.Size = New System.Drawing.Size(190, 30)
        Me.btnOpenFile2.TabIndex = 10
        Me.btnOpenFile2.Text = "Open Image of car"
        Me.btnOpenFile2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpenFile2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_reorder_black_24dp_1x
        Me.Button3.Location = New System.Drawing.Point(3, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 26)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(39, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Chack"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(0, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(916, 45)
        Me.Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Home"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button8.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_home_black_24dp_2x
        Me.Button8.Location = New System.Drawing.Point(3, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(39, 44)
        Me.Button8.TabIndex = 10
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_close_black_24dp_1x
        Me.Button2.Location = New System.Drawing.Point(877, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 26)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.ibOriginal)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 471)
        Me.Panel2.TabIndex = 6
        '
        'ibOriginal
        '
        Me.ibOriginal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibOriginal.Enabled = False
        Me.ibOriginal.Location = New System.Drawing.Point(227, 0)
        Me.ibOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.ibOriginal.Name = "ibOriginal"
        Me.ibOriginal.Size = New System.Drawing.Size(689, 471)
        Me.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ibOriginal.TabIndex = 3
        Me.ibOriginal.TabStop = False
        '
        'frmMain
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(914, 518)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cbShowSteps)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Form1"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.LavenderBlush
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents cbShowSteps As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnOpenFile2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ibOriginal As Emgu.CV.UI.ImageBox
End Class
