Public Class frmSeguridad

    Dim ET As New Seguridad_de_Datos()

    Private Sub frmSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEncriptar_Click(sender As Object, e As EventArgs) Handles btnEncriptar.Click
        ET = New Seguridad_de_Datos()
        If ET.Verificar_Carater(txtEncriptado.Text.Trim) Then
            txtResultado.Text = ET.Encriptar(txtEncriptado.Text.Trim)
            txtEncriptado.Clear()
        Else
            MessageBox.Show("LA CADENA DE TEXTO TIENE UN CARACTER INVALIDO ")
            txtEncriptado.Clear()
        End If
    End Sub

    Private Sub btnDesencriptar_Click(sender As Object, e As EventArgs) Handles btnDesencriptar.Click
        ET = New Seguridad_de_Datos()
        Try
            txtResultado.Text = ET.Desencriptar(txtDesencriptado.Text.Trim)
            txtDesencriptado.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmSeguridad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
End Class
