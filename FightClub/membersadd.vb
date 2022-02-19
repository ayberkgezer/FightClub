Imports System.Data.SqlClient
Public Class membersadd
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub
        If RichTextBox1.Text = "" Then RichTextBox1.Focus() : Exit Sub

        Try
            con.Open()
            cmd = New SqlCommand("INSERT INTO member(member_name,member_surname,member_tel,member_address,member_gender,member_date,member_birthday) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" + RichTextBox1.Text + "','" + ComboBox1.Text + "','" & DateTimePicker2.Text & "','" & DateTimePicker1.Text & "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then


                MsgBox("Başarıyla Kaydedildi! ", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                con.Close()


            Else
                MsgBox("Kayıt Yapılamadı! ", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class