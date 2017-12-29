<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 50)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign Up"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 456)
        Me.Panel2.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Image = Global.License_Plate_Recognition_VB.My.Resources.Resources.ic_account_circle_black_24dp_2x
        Me.Button5.Location = New System.Drawing.Point(189, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 58)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(78, 226)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
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
        Me.Button3.Location = New System.Drawing.Point(198, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Sign up"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(83, 192)
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
        Me.Label3.Location = New System.Drawing.Point(83, 84)
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
        Me.TextBox1.Location = New System.Drawing.Point(78, 116)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 42)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.WordWrap = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 503)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SignUp"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
