Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data
Imports System.IO

Public Class Frm_TelaPrincipal

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential(txtUser.Text, txtSenha.Text)
            SmtpServer.Host = txtSmtp.Text
            SmtpServer.Port = txtPort.Text

            If checkSSLL.Checked = True Then

                SmtpServer.EnableSsl = True
            Else
                SmtpServer.EnableSsl = False
            End If

            'SmtpServer.EnableSsl = False
            mail.From = New MailAddress(txtUser.Text)
            mail.To.Add(txtEmailRem.Text)
            mail.Subject = txtassunto.Text
            mail.Body = txtMSG.Text
            ' SmtpServer.UseDefaultCredentials = True


            SmtpServer.Send(mail)
            MsgBox("E-mail enviado com sucesso", MsgBoxStyle.Information, "Mensagem")

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(".\E-mailEnviado.txt", True)
            file.WriteLine("Validador de SMTP")
            file.WriteLine("---E-mail Envido---")
            file.WriteLine("Remetente: " + txtEmailRem.Text)
            file.WriteLine("Assunto: " + txtassunto.Text)
            file.WriteLine("Mensagem : " + txtMSG.Text)
            file.WriteLine("--- E-mail Envido ---")
            file.Close()



        Catch ex As Mail.SmtpException

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(".\Log.txt", True)
            file.WriteLine(ex)
            file.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Servidor não esta Respondendo")


        Catch ex As ArgumentException

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(".\Log.txt", True)
            file.WriteLine(ex.ToString)
            file.Close()
            If txtUser.Text = "" Then
                MsgBox("Favor informa usuario \n" + ex.ToString)
            End If

            If txtSenha.Text = "" Then


                MsgBox("Favor informa a Senha \n" + ex.ToString)

            End If


        Catch ex As ArgumentNullException

            MsgBox($"Argumento {ex} ")

        Catch ex As Exception
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(".\Log.txt", True)
            file.WriteLine(ex.ToString)
            file.Close()
            MsgBox("Erro Genérioco favor entra em contato com Dev")
        End Try


    End Sub


End Class
