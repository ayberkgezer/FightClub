Public Class mainpage
    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel3.Visible = True
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub closePanel()
        Panel3.Controls.Clear()
        Panel3.Visible = False
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Form1.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchPanel(members)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        switchPanel(trainer)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchPanel(payment)
    End Sub
End Class