<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.listWordsAndDefinitions = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listWordsAndDefinitions
        '
        Me.listWordsAndDefinitions.FormattingEnabled = True
        Me.listWordsAndDefinitions.HorizontalScrollbar = True
        Me.listWordsAndDefinitions.Location = New System.Drawing.Point(54, 47)
        Me.listWordsAndDefinitions.Name = "listWordsAndDefinitions"
        Me.listWordsAndDefinitions.Size = New System.Drawing.Size(543, 316)
        Me.listWordsAndDefinitions.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnBack.Location = New System.Drawing.Point(0, 382)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(657, 57)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemove.Location = New System.Drawing.Point(0, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(657, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.listWordsAndDefinitions)
        Me.Name = "Form4"
        Me.Text = "Dictionary List Words"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listWordsAndDefinitions As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRemove As Button
End Class
