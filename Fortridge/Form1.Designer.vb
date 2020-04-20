<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Footridge
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
        Me.COname = New System.Windows.Forms.Label()
        Me.loginLbl = New System.Windows.Forms.Label()
        Me.lginUname = New System.Windows.Forms.TextBox()
        Me.lginPwdtbx = New System.Windows.Forms.TextBox()
        Me.unametbx = New System.Windows.Forms.Label()
        Me.pwdtbx = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'COname
        '
        Me.COname.AutoSize = True
        Me.COname.Location = New System.Drawing.Point(168, 22)
        Me.COname.Name = "COname"
        Me.COname.Size = New System.Drawing.Size(122, 13)
        Me.COname.TabIndex = 0
        Me.COname.Text = "Footridge Manufacturing"
        '
        'loginLbl
        '
        Me.loginLbl.AutoSize = True
        Me.loginLbl.Location = New System.Drawing.Point(208, 64)
        Me.loginLbl.Name = "loginLbl"
        Me.loginLbl.Size = New System.Drawing.Size(37, 13)
        Me.loginLbl.TabIndex = 1
        Me.loginLbl.Text = "Log In"
        '
        'lginUname
        '
        Me.lginUname.Location = New System.Drawing.Point(211, 103)
        Me.lginUname.Name = "lginUname"
        Me.lginUname.Size = New System.Drawing.Size(165, 20)
        Me.lginUname.TabIndex = 2
        '
        'lginPwdtbx
        '
        Me.lginPwdtbx.Location = New System.Drawing.Point(211, 151)
        Me.lginPwdtbx.Name = "lginPwdtbx"
        Me.lginPwdtbx.Size = New System.Drawing.Size(165, 20)
        Me.lginPwdtbx.TabIndex = 3
        '
        'unametbx
        '
        Me.unametbx.AutoSize = True
        Me.unametbx.Location = New System.Drawing.Point(125, 103)
        Me.unametbx.Name = "unametbx"
        Me.unametbx.Size = New System.Drawing.Size(55, 13)
        Me.unametbx.TabIndex = 4
        Me.unametbx.Text = "Username"
        '
        'pwdtbx
        '
        Me.pwdtbx.AutoSize = True
        Me.pwdtbx.Location = New System.Drawing.Point(125, 158)
        Me.pwdtbx.Name = "pwdtbx"
        Me.pwdtbx.Size = New System.Drawing.Size(56, 13)
        Me.pwdtbx.TabIndex = 5
        Me.pwdtbx.Text = "Password "
        '
        'loginbtn
        '
        Me.loginbtn.Location = New System.Drawing.Point(155, 210)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 23)
        Me.loginbtn.TabIndex = 6
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(282, 210)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 7
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'Footridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 259)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.pwdtbx)
        Me.Controls.Add(Me.unametbx)
        Me.Controls.Add(Me.lginPwdtbx)
        Me.Controls.Add(Me.lginUname)
        Me.Controls.Add(Me.loginLbl)
        Me.Controls.Add(Me.COname)
        Me.Name = "Footridge"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents COname As Label
    Friend WithEvents loginLbl As Label
    Friend WithEvents lginUname As TextBox
    Friend WithEvents lginPwdtbx As TextBox
    Friend WithEvents unametbx As Label
    Friend WithEvents pwdtbx As Label
    Friend WithEvents loginbtn As Button
    Friend WithEvents cancelbtn As Button
End Class
