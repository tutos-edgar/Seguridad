Public Class Seguridad_de_Datos


    ' String datos_generados[126]; 

    Private datos_generados As String() = {
    "KSKS", "sK89", "KIW8", "kchd", "kdu8", "8eiL", "8dkK", "S85&", "SU7#", "w_%$", "$58S", "22_2", "8_73",
    "M57*", "952+", "4D98", "D7E6", "kdUE", "DYsd", "7/WJ", "S7DH", "S7s7", "9DKs", "S6W3", "SSjj", "XIPX",
    "SKSs", "85DS", "S82S", "899D", "sYsk", "swop", "uyjd", "USY5", "F4C7", "SID8", "09EK", "Q183", "S78j",
    "ShDH", "GRI2", "SYFT", "eick", "duw9", "sprI", "djxy", "cjuw", "IDJ-", "E7XJ", "KDKS", "Skss", "D886",
    "S7FK", "kyr3", "2Dkl", "#$s$", "#sx/", "(/%R", "/rk)", "=f_S", "DXKx", "D&$!", "DI)(", "&fkl", "SKgh",
    "SXUn", "XJCW", "DOP5", "SDI&", "SIXC", "XLOO", "XKU$", "S%wS", "SlYt", "Sys%", "SK&/", "SK<_", "S72_",
    "XY$!", "SKhg", "SKZX", "XJbn", "FBXU", "NNCM", "KVMN", "KBX$", "ers%", "&$s/", "7FjF", "DIXz", "DU6%",
    "DFJ<", "SKJx", "XJ75", "S7$s", "SPG=", "=)(%", "S/&r", "(/fj", "f58S", ".CK;", "_v;_", "SKx!", "/dj:",
    "&fjK", "SLU$", "SUX<", "S(y/", "!sK%", "S(/_", "&$5S", "(dAL", "SKA5", "475_", "SBNH", "GHCN", "GKUT",
    "KSI°", "12#;", "87sk", "eSIU", "URJh", "$%L2", "SUV5", "SK/2", "S&w$", "k=3d", "+85-"}

    Private caracter As Char = ""   'private char caracter;
    Private texto As String = ""


    'boolean verificar_caracter(string candena) {  return false; }
    Public Function Verificar_Carater(cadena As String) As Boolean
        Dim verificar As Boolean = True    'boolean verificar = true;

        For i = 0 To cadena.Length - 1     ' for(int i = 0; i < cadena.length; í++){ }
            caracter = cadena.Substring(i, 1)  ' caracte = cadena.substrine(i, 1)
            '209 -> Ñ   241 -> ñ
            If Convert.ToInt32(caracter) > 125 And Convert.ToInt32(caracter) <> 209 And Convert.ToInt32(caracter) <> 241 Then
                verificar = False
            End If
        Next

        Return verificar
    End Function

    Public Function Encriptar(cadena As String) As String
        Dim dato As String = ""

        If cadena = "" Then
            MessageBox.Show("NO SE PUEDE ENCRIPTAR DATOS VACIOS")
            Return dato
        End If

        Try
            For i = 0 To cadena.Length - 1     ' for(int i = 0; i < cadena.length; í++){ }
                caracter = cadena.Substring(i, 1)
                If caracter = "Ñ" Then
                    dato += datos_generados(126)
                ElseIf caracter = "ñ" Then
                    dato += datos_generados(127)
                Else
                    dato += datos_generados(Convert.ToInt32(caracter))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dato
    End Function

    Public Function Desencriptar(cadena As String) As String
        Dim dato As String = ""

        If cadena = "" Then
            MessageBox.Show("NO SE PUEDE DESENCRIPTAR DATOS VACIOS")
            Return dato
        End If

        Try
            For i = 0 To cadena.Length - 1 Step 4    ' for(int i = 0; i < cadena.length; í++){ }
                texto = cadena.Substring(i, 4)
                For j = 0 To datos_generados.Length - 1
                    If texto = datos_generados(j) Then
                        If j < 126 Then
                            dato += Convert.ToChar(j)
                        ElseIf j = 126 Then
                            dato += "Ñ"
                        ElseIf j = 127 Then
                            dato += "ñ"
                        End If

                    End If
                Next

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dato
    End Function



    'If Convert.ToInt32(caracter) > 125 Then
    '    If caracter = "ñ" Then
    '        dato += datos_generados(126)
    '    ElseIf caracter = "Ñ" Then
    '        dato += datos_generados(127)
    '    End If
    'Else
    '    dato += datos_generados(Convert.ToInt32(caracter))
    'End If



End Class
