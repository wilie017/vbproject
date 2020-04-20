<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCustomer
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
        Me.firstnameTbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastnameTbx = New System.Windows.Forms.TextBox()
        Me.emailTbx = New System.Windows.Forms.TextBox()
        Me.phonTbx = New System.Windows.Forms.TextBox()
        Me.othertbx = New System.Windows.Forms.TextBox()
        Me.amountTbx = New System.Windows.Forms.TextBox()
        Me.addressTbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gendertCmbobx = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.CustomerDgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SrcBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.src_idTbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.src_nameTbx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.NewCustBtn = New System.Windows.Forms.Button()
        Me.CustID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomerDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'firstnameTbx
        '
        Me.firstnameTbx.Location = New System.Drawing.Point(149, 65)
        Me.firstnameTbx.Name = "firstnameTbx"
        Me.firstnameTbx.Size = New System.Drawing.Size(234, 20)
        Me.firstnameTbx.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Home Address"
        '
        'lastnameTbx
        '
        Me.lastnameTbx.Location = New System.Drawing.Point(149, 104)
        Me.lastnameTbx.Name = "lastnameTbx"
        Me.lastnameTbx.Size = New System.Drawing.Size(234, 20)
        Me.lastnameTbx.TabIndex = 15
        '
        'emailTbx
        '
        Me.emailTbx.Location = New System.Drawing.Point(149, 140)
        Me.emailTbx.Name = "emailTbx"
        Me.emailTbx.Size = New System.Drawing.Size(234, 20)
        Me.emailTbx.TabIndex = 16
        '
        'phonTbx
        '
        Me.phonTbx.Location = New System.Drawing.Point(504, 65)
        Me.phonTbx.Name = "phonTbx"
        Me.phonTbx.Size = New System.Drawing.Size(234, 20)
        Me.phonTbx.TabIndex = 17
        '
        'othertbx
        '
        Me.othertbx.Location = New System.Drawing.Point(504, 174)
        Me.othertbx.Name = "othertbx"
        Me.othertbx.Size = New System.Drawing.Size(234, 20)
        Me.othertbx.TabIndex = 21
        '
        'amountTbx
        '
        Me.amountTbx.Location = New System.Drawing.Point(504, 140)
        Me.amountTbx.Name = "amountTbx"
        Me.amountTbx.Size = New System.Drawing.Size(234, 20)
        Me.amountTbx.TabIndex = 20
        '
        'addressTbx
        '
        Me.addressTbx.Location = New System.Drawing.Point(504, 103)
        Me.addressTbx.Name = "addressTbx"
        Me.addressTbx.Size = New System.Drawing.Size(234, 20)
        Me.addressTbx.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Other"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(406, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Gender"
        '
        'gendertCmbobx
        '
        Me.gendertCmbobx.FormattingEnabled = True
        Me.gendertCmbobx.Items.AddRange(New Object() {"-Choose gender-", "Male", "Female"})
        Me.gendertCmbobx.Location = New System.Drawing.Point(149, 174)
        Me.gendertCmbobx.Name = "gendertCmbobx"
        Me.gendertCmbobx.Size = New System.Drawing.Size(234, 21)
        Me.gendertCmbobx.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CustID)
        Me.GroupBox1.Controls.Add(Me.NewCustBtn)
        Me.GroupBox1.Controls.Add(Me.ClearBtn)
        Me.GroupBox1.Controls.Add(Me.UpdateBtn)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 176)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(422, 150)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(70, 23)
        Me.ClearBtn.TabIndex = 37
        Me.ClearBtn.Text = "Clear All"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(329, 150)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(70, 23)
        Me.UpdateBtn.TabIndex = 36
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(239, 150)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(70, 23)
        Me.SaveBtn.TabIndex = 35
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DelBtn)
        Me.GroupBox2.Controls.Add(Me.EditBtn)
        Me.GroupBox2.Controls.Add(Me.RefreshBtn)
        Me.GroupBox2.Controls.Add(Me.CustomerDgv)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 253)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Records"
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(690, 113)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(70, 23)
        Me.EditBtn.TabIndex = 34
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(690, 72)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(70, 23)
        Me.RefreshBtn.TabIndex = 33
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'CustomerDgv
        '
        Me.CustomerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDgv.Location = New System.Drawing.Point(6, 56)
        Me.CustomerDgv.Name = "CustomerDgv"
        Me.CustomerDgv.Size = New System.Drawing.Size(680, 191)
        Me.CustomerDgv.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SrcBtn)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.src_idTbx)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.src_nameTbx)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(738, 35)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Records"
        '
        'SrcBtn
        '
        Me.SrcBtn.Location = New System.Drawing.Point(592, 9)
        Me.SrcBtn.Name = "SrcBtn"
        Me.SrcBtn.Size = New System.Drawing.Size(143, 23)
        Me.SrcBtn.TabIndex = 32
        Me.SrcBtn.Text = "search"
        Me.SrcBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "ID"
        '
        'src_idTbx
        '
        Me.src_idTbx.Location = New System.Drawing.Point(398, 9)
        Me.src_idTbx.Name = "src_idTbx"
        Me.src_idTbx.Size = New System.Drawing.Size(133, 20)
        Me.src_idTbx.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(115, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "First Name"
        '
        'src_nameTbx
        '
        Me.src_nameTbx.Location = New System.Drawing.Point(189, 10)
        Me.src_nameTbx.Name = "src_nameTbx"
        Me.src_nameTbx.Size = New System.Drawing.Size(133, 20)
        Me.src_nameTbx.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(338, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Customer Management"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(690, 156)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(70, 23)
        Me.DelBtn.TabIndex = 35
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'NewCustBtn
        '
        Me.NewCustBtn.Location = New System.Drawing.Point(519, 149)
        Me.NewCustBtn.Name = "NewCustBtn"
        Me.NewCustBtn.Size = New System.Drawing.Size(70, 23)
        Me.NewCustBtn.TabIndex = 38
        Me.NewCustBtn.Text = "New"
        Me.NewCustBtn.UseVisualStyleBackColor = True
        '
        'CustID
        '
        Me.CustID.Location = New System.Drawing.Point(657, 150)
        Me.CustID.Name = "CustID"
        Me.CustID.Size = New System.Drawing.Size(68, 20)
        Me.CustID.TabIndex = 29
        Me.CustID.Visible = False
        '
        'ManageCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gendertCmbobx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.othertbx)
        Me.Controls.Add(Me.amountTbx)
        Me.Controls.Add(Me.addressTbx)
        Me.Controls.Add(Me.phonTbx)
        Me.Controls.Add(Me.emailTbx)
        Me.Controls.Add(Me.lastnameTbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.firstnameTbx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManageCustomer"
        Me.Text = "Manage Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CustomerDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstnameTbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lastnameTbx As TextBox
    Friend WithEvents emailTbx As TextBox
    Friend WithEvents phonTbx As TextBox
    Friend WithEvents othertbx As TextBox
    Friend WithEvents amountTbx As TextBox
    Friend WithEvents addressTbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gendertCmbobx As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CustomerDgv As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SrcBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents src_idTbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents src_nameTbx As TextBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelBtn As Button
    Friend WithEvents NewCustBtn As Button
    Friend WithEvents CustID As TextBox
End Class
