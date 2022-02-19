Imports System.Data.SqlClient
Public Class paymenttype
    Public Sub paymenttype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'GymDataSet.paymenttype' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.PaymenttypeTableAdapter.Fill(Me.GymDataSet.paymenttype)
        'TODO: Bu kod satırı 'GymDataSet.paymenttype' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.PaymenttypeTableAdapter.Fill(Me.GymDataSet.paymenttype)

    End Sub
    Sub data_Load()
        Me.PaymenttypeTableAdapter.Fill(Me.GymDataSet.paymenttype)
    End Sub
    Private Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedGr As DataGridViewRow
        selectedGr = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = selectedGr.Cells(1).Value
        TextBox2.Text = selectedGr.Cells(2).Value
        Label4.Text = selectedGr.Cells(0).Value
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub

        Try
            con.Open()
            cmd = New SqlCommand("INSERT INTO paymenttype(paymenttype_name,paymentmoney) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then


                MsgBox("Başarıyla Kaydedildi! ", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                con.Close()
                clr()


            Else
                MsgBox("Kayıt Yapılamadı! ", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            con.Close()
            data_Load()
        End Try
    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            cmd = New SqlCommand("UPDATE paymenttype set paymenttype_name='" & TextBox1.Text & "',paymentmoney='" & TextBox2.Text & "' WHERE paymenttype_id = '" & Label4.Text & "'", con)
            con.Open()
            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Başarıyla Güncellendi!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clr()
            Else
                MessageBox.Show("Hata Oluştu Güncellenmedi!", "Error Updating", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            data_Load()

        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim result As Integer = MsgBox("Gerçekten silmek istiyor musun?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Try
                cmd = New SqlCommand("DELETE from paymenttype where paymenttype_id='" & Label4.Text & "'", con)
                con.Open()
                Dim i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Başarıyla Silindi!", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clr()
                Else
                    MessageBox.Show("Hata Oluştu Silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                data_Load()
            End Try
        End If
    End Sub


End Class