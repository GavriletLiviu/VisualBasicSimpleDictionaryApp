<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.listUsers = New System.Windows.Forms.ListBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.bntClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItemAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemRemoveUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemUpdateCredentials = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listUsers
        '
        Me.listUsers.FormattingEnabled = True
        Me.listUsers.Location = New System.Drawing.Point(51, 38)
        Me.listUsers.Name = "listUsers"
        Me.listUsers.Size = New System.Drawing.Size(184, 303)
        Me.listUsers.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(51, 384)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(328, 51)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "password"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(328, 82)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 5
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"user", "admin", "superadmin"})
        Me.cmbRole.Location = New System.Drawing.Point(328, 117)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(100, 21)
        Me.cmbRole.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Role"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(160, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'bntClear
        '
        Me.bntClear.Location = New System.Drawing.Point(328, 164)
        Me.bntClear.Name = "bntClear"
        Me.bntClear.Size = New System.Drawing.Size(75, 23)
        Me.bntClear.TabIndex = 10
        Me.bntClear.Text = "clear"
        Me.bntClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAdd, Me.MenuItemRemoveUser, Me.MenuItemUpdateCredentials})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuItemAdd
        '
        Me.MenuItemAdd.Name = "MenuItemAdd"
        Me.MenuItemAdd.Size = New System.Drawing.Size(67, 20)
        Me.MenuItemAdd.Text = "Add User"
        '
        'MenuItemRemoveUser
        '
        Me.MenuItemRemoveUser.Name = "MenuItemRemoveUser"
        Me.MenuItemRemoveUser.Size = New System.Drawing.Size(88, 20)
        Me.MenuItemRemoveUser.Text = "Remove User"
        '
        'MenuItemUpdateCredentials
        '
        Me.MenuItemUpdateCredentials.Name = "MenuItemUpdateCredentials"
        Me.MenuItemUpdateCredentials.Size = New System.Drawing.Size(119, 20)
        Me.MenuItemUpdateCredentials.Text = "Update Credentials"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.bntClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.listUsers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Edit User Database"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listUsers As ListBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents bntClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuItemAdd As ToolStripMenuItem
    Friend WithEvents MenuItemRemoveUser As ToolStripMenuItem
    Friend WithEvents MenuItemUpdateCredentials As ToolStripMenuItem
End Class
