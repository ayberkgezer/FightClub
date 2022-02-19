Imports System.Data.SqlClient
Public Class trainertrash
    Dim dr As SqlDataReader
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Eğitmen Telefon NO Girin ", "input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            cmd.CommandText = "SELECT * FROM [trainer] WHERE [trainer_tel]='" & (TextBox3.Text) & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TextBox1.Text = dr.Item("trainer_name").ToString()
                TextBox2.Text = dr.Item("trainer_surname").ToString()
                TextBox4.Text = dr.Item("trainer_tel").ToString()
                RichTextBox1.Text = dr.Item("traniner_address").ToString()
                ComboBox1.Text = dr.Item("trainer_gender").ToString()
                DateTimePicker2.Value = dr.Item("trainer_date").ToString()
                DateTimePicker1.Value = dr.Item("trainer_birthday").ToString()
                Label11.Text = dr.Item("trainer_id").ToString()
            Else
                MessageBox.Show("Eğitmen Bulunamadı")
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally

            dr.Dispose()
            con.Close()

        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            cmd = New SqlCommand("UPDATE trainer SET trainer_name='" & TextBox1.Text & "',trainer_surname='" & TextBox2.Text & "',trainer_tel='" & TextBox4.Text & "',traniner_address='" & RichTextBox1.Text & "',trainer_gender='" & ComboBox1.Text & "',trainer_date='" & DateTimePicker2.Text & "',trainer_birthday='" & DateTimePicker1.Text & "' WHERE trainer_id='" & Label11.Text & "'", con)
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
                cmd = New SqlCommand("DELETE FROM trainer WHERE trainer_id='" & Label11.Text & "'", con)
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

End Class