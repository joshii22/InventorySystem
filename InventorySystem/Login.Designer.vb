<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_uname = New System.Windows.Forms.TextBox()
        Me.txtb_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtb_uname
        '
        Me.txtb_uname.Location = New System.Drawing.Point(173, 37)
        Me.txtb_uname.Name = "txtb_uname"
        Me.txtb_uname.Size = New System.Drawing.Size(111, 20)
        Me.txtb_uname.TabIndex = 1
        '
        'txtb_pass
        '
        Me.txtb_pass.Location = New System.Drawing.Point(173, 74)
        Me.txtb_pass.Name = "txtb_pass"
        Me.txtb_pass.Size = New System.Drawing.Size(111, 20)
        Me.txtb_pass.TabIndex = 3
        Me.txtb_pass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(156, 113)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 139)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 160)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtb_pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtb_uname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtb_uname As System.Windows.Forms.TextBox
    Friend WithEvents txtb_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
