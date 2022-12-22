Imports MySql.Data.MySqlClient

Public Class Login


    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        'Dim servidor = "localhost"
        'Dim bancodados = "hotel"
        'Dim usuario = "root"
        'Dim senha = ""

        'Dim strCon = $"server={servidor}; User id={usuario};database={bancodados};password={senha}"


        'Try

        '    Using cn = New MySqlConnection(strCon)
        '        cn.Open()
        '        MsgBox("conseguiu conectar")
        '    End Using
        'Catch ex As Exception

        '    MsgBox(ex.ToString)
        'End Try

        If txtLoginL.Text = "admin" Then

            If txtSenhaL.Text = "admin" Then

                Dim condicao As Boolean = True

                If condicao Then
                    Frm_TelaPrincipal.ShowDialog()


                End If

            End If

        End If
        'Login.Close()


    End Sub


End Class