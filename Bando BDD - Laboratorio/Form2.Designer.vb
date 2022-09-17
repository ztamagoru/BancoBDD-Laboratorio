<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbttnSuma = New System.Windows.Forms.RadioButton()
        Me.RbttnResta = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbttnSelected = New System.Windows.Forms.RadioButton()
        Me.RbttnAll = New System.Windows.Forms.RadioButton()
        Me.bttnConfirm = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(44, 49)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(107, 34)
        Me.txt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "%"
        '
        'RbttnSuma
        '
        Me.RbttnSuma.AutoSize = True
        Me.RbttnSuma.Checked = True
        Me.RbttnSuma.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbttnSuma.Location = New System.Drawing.Point(3, 3)
        Me.RbttnSuma.Name = "RbttnSuma"
        Me.RbttnSuma.Size = New System.Drawing.Size(43, 32)
        Me.RbttnSuma.TabIndex = 9
        Me.RbttnSuma.TabStop = True
        Me.RbttnSuma.Text = "+"
        Me.RbttnSuma.UseVisualStyleBackColor = True
        '
        'RbttnResta
        '
        Me.RbttnResta.AutoSize = True
        Me.RbttnResta.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbttnResta.Location = New System.Drawing.Point(3, 41)
        Me.RbttnResta.Name = "RbttnResta"
        Me.RbttnResta.Size = New System.Drawing.Size(38, 32)
        Me.RbttnResta.TabIndex = 10
        Me.RbttnResta.Text = "-"
        Me.RbttnResta.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbttnSuma)
        Me.Panel1.Controls.Add(Me.RbttnResta)
        Me.Panel1.Location = New System.Drawing.Point(212, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(48, 73)
        Me.Panel1.TabIndex = 11
        '
        'RbttnSelected
        '
        Me.RbttnSelected.AutoSize = True
        Me.RbttnSelected.Checked = True
        Me.RbttnSelected.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbttnSelected.Location = New System.Drawing.Point(44, 134)
        Me.RbttnSelected.Name = "RbttnSelected"
        Me.RbttnSelected.Size = New System.Drawing.Size(222, 32)
        Me.RbttnSelected.TabIndex = 11
        Me.RbttnSelected.TabStop = True
        Me.RbttnSelected.Text = "Apply to selected client"
        Me.RbttnSelected.UseVisualStyleBackColor = True
        '
        'RbttnAll
        '
        Me.RbttnAll.AutoSize = True
        Me.RbttnAll.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbttnAll.Location = New System.Drawing.Point(44, 172)
        Me.RbttnAll.Name = "RbttnAll"
        Me.RbttnAll.Size = New System.Drawing.Size(180, 32)
        Me.RbttnAll.TabIndex = 12
        Me.RbttnAll.Text = "Apply to all clients"
        Me.RbttnAll.UseVisualStyleBackColor = True
        '
        'bttnConfirm
        '
        Me.bttnConfirm.Location = New System.Drawing.Point(60, 229)
        Me.bttnConfirm.Name = "bttnConfirm"
        Me.bttnConfirm.Size = New System.Drawing.Size(88, 23)
        Me.bttnConfirm.TabIndex = 17
        Me.bttnConfirm.Text = "Confirm"
        Me.bttnConfirm.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(159, 229)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(88, 23)
        Me.bttnCancel.TabIndex = 18
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 276)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnConfirm)
        Me.Controls.Add(Me.RbttnAll)
        Me.Controls.Add(Me.RbttnSelected)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RbttnSuma As RadioButton
    Friend WithEvents RbttnResta As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbttnSelected As RadioButton
    Friend WithEvents RbttnAll As RadioButton
    Public WithEvents bttnConfirm As Button
    Public WithEvents bttnCancel As Button
End Class
