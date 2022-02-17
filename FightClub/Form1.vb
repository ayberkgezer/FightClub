Imports System.Data.SqlClient
Public Class Form1
    Public name1, user As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()
        If Len(Trim(TextBox1.Text)) = 0 Then
            MessageBox.Show("Lütfen Kullanıcı Adı Giriniz.", "Kullanıcı Adı Girin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Lütfen Şifre Giriniz", "Şifre Giriniz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            cmd = New SqlCommand("SELECT * FROM admin WHERE admin_name=@UserName AND admin_psw=@Password", con)
            Dim UParam As New SqlParameter("@UserName", Me.TextBox1.Text)
            Dim PassParam As New SqlParameter("@Password", Me.TextBox2.Text)
            cmd.Parameters.Add(UParam)
            cmd.Parameters.Add(PassParam)
            cmd.Connection = con
            cmd.Connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                name1 = TextBox1.Text
                con.Close()
                Me.Hide()

                mainpage.Show()

            Else
                MsgBox("Kullanıcı Adı veya Şifre Doğru Değil", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        End
    End Sub

End Class
