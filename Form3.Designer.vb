<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDefinition = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.bntClear = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnShowList = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnLOGOUT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(90, 28)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "word : "
        '
        'txtDefinition
        '
        Me.txtDefinition.Location = New System.Drawing.Point(90, 71)
        Me.txtDefinition.Multiline = True
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(277, 63)
        Me.txtDefinition.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "definition : "
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(29, 163)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(292, 163)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'bntClear
        '
        Me.bntClear.Location = New System.Drawing.Point(161, 163)
        Me.bntClear.Name = "bntClear"
        Me.bntClear.Size = New System.Drawing.Size(75, 23)
        Me.bntClear.TabIndex = 6
        Me.bntClear.Text = "Clear"
        Me.bntClear.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(292, 192)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnShowList
        '
        Me.btnShowList.Location = New System.Drawing.Point(161, 192)
        Me.btnShowList.Name = "btnShowList"
        Me.btnShowList.Size = New System.Drawing.Size(75, 23)
        Me.btnShowList.TabIndex = 9
        Me.btnShowList.Text = "Show List"
        Me.btnShowList.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(29, 193)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnLOGOUT
        '
        Me.btnLOGOUT.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLOGOUT.Location = New System.Drawing.Point(0, 0)
        Me.btnLOGOUT.Name = "btnLOGOUT"
        Me.btnLOGOUT.Size = New System.Drawing.Size(394, 23)
        Me.btnLOGOUT.TabIndex = 11
        Me.btnLOGOUT.Text = "Logout"
        Me.btnLOGOUT.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLOGOUT)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnShowList)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.bntClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWord)
        Me.Name = "Form3"
        Me.Text = "Dictionary Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWord As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDefinition As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents bntClear As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnShowList As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnLOGOUT As Button
End Class
