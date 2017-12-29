<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 56)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_close_black_24dp_1x
        Me.Button2.Location = New System.Drawing.Point(730, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 26)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(418, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "UserName"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(357, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 440)
        Me.Panel2.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_account_circle_black_24dp_2x
        Me.Button5.Location = New System.Drawing.Point(143, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 58)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(131, 347)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(210, 16)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "if you dont have accont Sign up her"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.RoyalBlue
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(12, 223)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(365, 40)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.WordWrap = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(134, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Sign in"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(17, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UserName"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(12, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 42)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.WordWrap = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.f52cf6abadb0ccae560a23b237d51961__gas_station_hd_wallpaper
        Me.PictureBox1.Location = New System.Drawing.Point(0, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 440)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 380)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(87, 38)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.Visible = False
        '
        'LoginForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(769, 495)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "LoginForm"
        Me.RightToLeftLayout = True
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
