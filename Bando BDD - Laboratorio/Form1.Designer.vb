<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBoxidClient = New System.Windows.Forms.TextBox()
        Me.TBoxName = New System.Windows.Forms.TextBox()
        Me.TBoxDNI = New System.Windows.Forms.TextBox()
        Me.TBoxCellphone = New System.Windows.Forms.TextBox()
        Me.TBoxDescubierto = New System.Windows.Forms.TextBox()
        Me.bttnInsertar = New System.Windows.Forms.Button()
        Me.bttnConsultar = New System.Windows.Forms.Button()
        Me.bttnModificar = New System.Windows.Forms.Button()
        Me.bttnBorrar = New System.Windows.Forms.Button()
        Me.bttnAjustar = New System.Windows.Forms.Button()
        Me.bttnVaciar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 255)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(907, 359)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "id Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cellphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descubierto"
        '
        'TBoxidClient
        '
        Me.TBoxidClient.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxidClient.Location = New System.Drawing.Point(261, 28)
        Me.TBoxidClient.Name = "TBoxidClient"
        Me.TBoxidClient.ReadOnly = True
        Me.TBoxidClient.Size = New System.Drawing.Size(374, 34)
        Me.TBoxidClient.TabIndex = 6
        '
        'TBoxName
        '
        Me.TBoxName.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxName.Location = New System.Drawing.Point(261, 69)
        Me.TBoxName.Name = "TBoxName"
        Me.TBoxName.Size = New System.Drawing.Size(374, 34)
        Me.TBoxName.TabIndex = 7
        '
        'TBoxDNI
        '
        Me.TBoxDNI.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxDNI.Location = New System.Drawing.Point(261, 110)
        Me.TBoxDNI.Name = "TBoxDNI"
        Me.TBoxDNI.Size = New System.Drawing.Size(374, 34)
        Me.TBoxDNI.TabIndex = 8
        '
        'TBoxCellphone
        '
        Me.TBoxCellphone.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxCellphone.Location = New System.Drawing.Point(261, 151)
        Me.TBoxCellphone.Name = "TBoxCellphone"
        Me.TBoxCellphone.Size = New System.Drawing.Size(374, 34)
        Me.TBoxCellphone.TabIndex = 9
        '
        'TBoxDescubierto
        '
        Me.TBoxDescubierto.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxDescubierto.Location = New System.Drawing.Point(261, 192)
        Me.TBoxDescubierto.Name = "TBoxDescubierto"
        Me.TBoxDescubierto.Size = New System.Drawing.Size(374, 34)
        Me.TBoxDescubierto.TabIndex = 10
        '
        'bttnInsertar
        '
        Me.bttnInsertar.Location = New System.Drawing.Point(700, 68)
        Me.bttnInsertar.Name = "bttnInsertar"
        Me.bttnInsertar.Size = New System.Drawing.Size(173, 23)
        Me.bttnInsertar.TabIndex = 11
        Me.bttnInsertar.Text = "Insert"
        Me.bttnInsertar.UseVisualStyleBackColor = True
        '
        'bttnConsultar
        '
        Me.bttnConsultar.Location = New System.Drawing.Point(700, 97)
        Me.bttnConsultar.Name = "bttnConsultar"
        Me.bttnConsultar.Size = New System.Drawing.Size(173, 23)
        Me.bttnConsultar.TabIndex = 12
        Me.bttnConsultar.Text = "Consult"
        Me.bttnConsultar.UseVisualStyleBackColor = True
        '
        'bttnModificar
        '
        Me.bttnModificar.Location = New System.Drawing.Point(700, 126)
        Me.bttnModificar.Name = "bttnModificar"
        Me.bttnModificar.Size = New System.Drawing.Size(173, 23)
        Me.bttnModificar.TabIndex = 13
        Me.bttnModificar.Text = "Modify"
        Me.bttnModificar.UseVisualStyleBackColor = True
        '
        'bttnBorrar
        '
        Me.bttnBorrar.Location = New System.Drawing.Point(700, 155)
        Me.bttnBorrar.Name = "bttnBorrar"
        Me.bttnBorrar.Size = New System.Drawing.Size(173, 23)
        Me.bttnBorrar.TabIndex = 14
        Me.bttnBorrar.Text = "Remove"
        Me.bttnBorrar.UseVisualStyleBackColor = True
        '
        'bttnAjustar
        '
        Me.bttnAjustar.Location = New System.Drawing.Point(700, 184)
        Me.bttnAjustar.Name = "bttnAjustar"
        Me.bttnAjustar.Size = New System.Drawing.Size(173, 23)
        Me.bttnAjustar.TabIndex = 15
        Me.bttnAjustar.Text = "Adjust descubierto"
        Me.bttnAjustar.UseVisualStyleBackColor = True
        '
        'bttnVaciar
        '
        Me.bttnVaciar.Location = New System.Drawing.Point(700, 39)
        Me.bttnVaciar.Name = "bttnVaciar"
        Me.bttnVaciar.Size = New System.Drawing.Size(173, 23)
        Me.bttnVaciar.TabIndex = 16
        Me.bttnVaciar.Text = "Clear"
        Me.bttnVaciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 626)
        Me.Controls.Add(Me.bttnVaciar)
        Me.Controls.Add(Me.bttnAjustar)
        Me.Controls.Add(Me.bttnBorrar)
        Me.Controls.Add(Me.bttnModificar)
        Me.Controls.Add(Me.bttnConsultar)
        Me.Controls.Add(Me.bttnInsertar)
        Me.Controls.Add(Me.TBoxDescubierto)
        Me.Controls.Add(Me.TBoxCellphone)
        Me.Controls.Add(Me.TBoxDNI)
        Me.Controls.Add(Me.TBoxName)
        Me.Controls.Add(Me.TBoxidClient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBoxidClient As TextBox
    Friend WithEvents TBoxName As TextBox
    Friend WithEvents TBoxDNI As TextBox
    Friend WithEvents TBoxCellphone As TextBox
    Friend WithEvents TBoxDescubierto As TextBox
    Public WithEvents bttnVaciar As Button
    Public WithEvents bttnInsertar As Button
    Public WithEvents bttnConsultar As Button
    Public WithEvents bttnModificar As Button
    Public WithEvents bttnBorrar As Button
    Public WithEvents bttnAjustar As Button
End Class
