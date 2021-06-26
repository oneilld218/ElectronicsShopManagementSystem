<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

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
        Me.uname = New System.Windows.Forms.Label()
        Me.pwd = New System.Windows.Forms.Label()
        Me.unameTextBox = New System.Windows.Forms.TextBox()
        Me.pwdTextBox = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.AutoSize = True
        Me.uname.BackColor = System.Drawing.Color.Transparent
        Me.uname.Font = New System.Drawing.Font("Swis721 BlkEx BT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.ForeColor = System.Drawing.Color.Yellow
        Me.uname.Location = New System.Drawing.Point(531, 238)
        Me.uname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(95, 18)
        Me.uname.TabIndex = 0
        Me.uname.Text = "Login ID"
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.BackColor = System.Drawing.Color.Transparent
        Me.pwd.Font = New System.Drawing.Font("Swis721 BlkEx BT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.ForeColor = System.Drawing.Color.Yellow
        Me.pwd.Location = New System.Drawing.Point(531, 324)
        Me.pwd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(115, 18)
        Me.pwd.TabIndex = 1
        Me.pwd.Text = "Password"
        '
        'unameTextBox
        '
        Me.unameTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.unameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.unameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.unameTextBox.Location = New System.Drawing.Point(534, 269)
        Me.unameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.unameTextBox.Multiline = True
        Me.unameTextBox.Name = "unameTextBox"
        Me.unameTextBox.Size = New System.Drawing.Size(234, 28)
        Me.unameTextBox.TabIndex = 2
        '
        'pwdTextBox
        '
        Me.pwdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdTextBox.Location = New System.Drawing.Point(534, 355)
        Me.pwdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.pwdTextBox.Multiline = True
        Me.pwdTextBox.Name = "pwdTextBox"
        Me.pwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwdTextBox.Size = New System.Drawing.Size(234, 29)
        Me.pwdTextBox.TabIndex = 3
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.submit.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(534, 421)
        Me.submit.Margin = New System.Windows.Forms.Padding(4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(234, 38)
        Me.submit.TabIndex = 4
        Me.submit.Text = "LOGIN"
        Me.submit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(93, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(893, 45)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Welcome to Electronic Shop Management System"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.ElectronicsShopManagementSystem.My.Resources.Resources._1119975
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.pwdTextBox)
        Me.Controls.Add(Me.unameTextBox)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.uname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Electronic Shop Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uname As Label
    Friend WithEvents pwd As Label
    Friend WithEvents unameTextBox As TextBox
    Friend WithEvents pwdTextBox As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Label1 As Label
End Class
