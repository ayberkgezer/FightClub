Imports System.Data.SqlClient
Public Class memberstrash
    Dim dr As SqlDataReader
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            cmd = New SqlCommand("UPDATE member SET member_name='" & TextBox1.Text & "',member_surname='" & TextBox2.Text & "',member_tel='" & TextBox4.Text & "',member_address='" & RichTextBox1.Text & "',member_gender='" & ComboBox1.Text & "',member_date='" & DateTimePicker2.Text & "',member_birthday='" & DateTimePicker1.Text & "' WHERE member_id='" & Label11.Text & "'", con)
            con.Open()
            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Başarıyla Kaydedildi!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clr()
            Else
                MessageBox.Show("Hata Oluştu!", "Error Updating", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim result As Integer = MsgBox("Gerçekten silmek istiyor musun?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Try
                cmd = New SqlCommand("DELETE FROM member WHERE member_id='" & Label11.Text & "'SELECT * FROM groupcon", con)
                con.Open()
                Dim i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Başarıyla Silindi!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clr()
                Else
                    MessageBox.Show("Hata Oluştu Silinemedi!", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try
        End If
    End Sub
    Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Üye Telefon NO Girin ", "input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            cmd.CommandText = "SELECT * FROM [member] WHERE [member_tel]='" & (TextBox3.Text) & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TextBox1.Text = dr.Item("member_name").ToString()
                TextBox2.Text = dr.Item("member_surname").ToString()
                TextBox4.Text = dr.Item("member_tel").ToString()
                RichTextBox1.Text = dr.Item("member_address").ToString()
                ComboBox1.Text = dr.Item("member_gender").ToString()
                DateTimePicker2.Value = dr.Item("member_date").ToString()
                DateTimePicker1.Value = dr.Item("member_birthday").ToString()
                Label11.Text = dr.Item("member_id").ToString()
            Else
                MessageBox.Show("Üye Bulunamadı")
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally

            dr.Dispose()
            con.Close()

        End Try
    End Sub
End Class