<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeguridad
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
        Label1 = New Label()
        lblEncriptado = New Label()
        lblDesencriptado = New Label()
        txtEncriptado = New TextBox()
        txtDesencriptado = New TextBox()
        txtResultado = New TextBox()
        lblResultado = New Label()
        btnEncriptar = New Button()
        btnDesencriptar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("hooge 05_53", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(195, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 46)
        Label1.TabIndex = 0
        Label1.Text = "ENCRIPTACION"
        ' 
        ' lblEncriptado
        ' 
        lblEncriptado.AutoSize = True
        lblEncriptado.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEncriptado.Location = New Point(88, 128)
        lblEncriptado.Name = "lblEncriptado"
        lblEncriptado.Size = New Size(96, 19)
        lblEncriptado.TabIndex = 1
        lblEncriptado.Text = "Encriptado"
        ' 
        ' lblDesencriptado
        ' 
        lblDesencriptado.AutoSize = True
        lblDesencriptado.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDesencriptado.Location = New Point(55, 180)
        lblDesencriptado.Name = "lblDesencriptado"
        lblDesencriptado.Size = New Size(134, 19)
        lblDesencriptado.TabIndex = 2
        lblDesencriptado.Text = "Descencriptado"
        ' 
        ' txtEncriptado
        ' 
        txtEncriptado.BackColor = Color.Black
        txtEncriptado.BorderStyle = BorderStyle.FixedSingle
        txtEncriptado.Font = New Font("Oswald", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtEncriptado.ForeColor = Color.Lime
        txtEncriptado.Location = New Point(195, 117)
        txtEncriptado.Name = "txtEncriptado"
        txtEncriptado.Size = New Size(353, 30)
        txtEncriptado.TabIndex = 3
        ' 
        ' txtDesencriptado
        ' 
        txtDesencriptado.BackColor = Color.Black
        txtDesencriptado.BorderStyle = BorderStyle.FixedSingle
        txtDesencriptado.Font = New Font("Oswald", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtDesencriptado.ForeColor = Color.Lime
        txtDesencriptado.Location = New Point(195, 176)
        txtDesencriptado.Name = "txtDesencriptado"
        txtDesencriptado.Size = New Size(353, 30)
        txtDesencriptado.TabIndex = 4
        ' 
        ' txtResultado
        ' 
        txtResultado.BackColor = Color.Black
        txtResultado.BorderStyle = BorderStyle.FixedSingle
        txtResultado.Font = New Font("Oswald", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtResultado.ForeColor = Color.Lime
        txtResultado.Location = New Point(195, 231)
        txtResultado.Multiline = True
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(353, 147)
        txtResultado.TabIndex = 5
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultado.Location = New Point(85, 235)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(99, 19)
        lblResultado.TabIndex = 6
        lblResultado.Text = "Resultados"
        ' 
        ' btnEncriptar
        ' 
        btnEncriptar.FlatStyle = FlatStyle.Flat
        btnEncriptar.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEncriptar.Location = New Point(580, 128)
        btnEncriptar.Name = "btnEncriptar"
        btnEncriptar.Size = New Size(123, 38)
        btnEncriptar.TabIndex = 7
        btnEncriptar.Text = "Encriptar"
        btnEncriptar.UseVisualStyleBackColor = True
        ' 
        ' btnDesencriptar
        ' 
        btnDesencriptar.FlatStyle = FlatStyle.Flat
        btnDesencriptar.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDesencriptar.Location = New Point(580, 180)
        btnDesencriptar.Name = "btnDesencriptar"
        btnDesencriptar.Size = New Size(123, 38)
        btnDesencriptar.TabIndex = 8
        btnDesencriptar.Text = "Desencriptar"
        btnDesencriptar.UseVisualStyleBackColor = True
        ' 
        ' frmSeguridad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(749, 450)
        Controls.Add(btnDesencriptar)
        Controls.Add(btnEncriptar)
        Controls.Add(lblResultado)
        Controls.Add(txtResultado)
        Controls.Add(txtDesencriptado)
        Controls.Add(txtEncriptado)
        Controls.Add(lblDesencriptado)
        Controls.Add(lblEncriptado)
        Controls.Add(Label1)
        ForeColor = Color.Lime
        Name = "frmSeguridad"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Seguridad"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblEncriptado As Label
    Friend WithEvents lblDesencriptado As Label
    Friend WithEvents txtEncriptado As TextBox
    Friend WithEvents txtDesencriptado As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnEncriptar As Button
    Friend WithEvents btnDesencriptar As Button
End Class
