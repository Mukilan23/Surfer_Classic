Imports System.Net.Mail

Public Class Mailer

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress(txtEmail.Text)
            MyMailMessage.To.Add(txtToEmail.Text)
            MyMailMessage.Subject = txtSubject.Text
            MyMailMessage.Body = txtBody.Text
            Dim SMTPServer As New SmtpClient("smtp.gmail.com")
            SMTPServer.Port = 587
            SMTPServer.Credentials = New System.Net.NetworkCredential(txtEmail.Text, txtPassword.Text)
            SMTPServer.EnableSsl = True
            SMTPServer.Send(MyMailMessage)
        Catch ex As Exception
        End Try
    End Sub
End Class