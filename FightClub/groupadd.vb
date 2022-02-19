Public Class groupadd
    Private Sub groupadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'GymDataSet.group' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.GroupTableAdapter.Fill(Me.GymDataSet.group)
        'TODO: Bu kod satırı 'GymDataSet.trainer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.TrainerTableAdapter.Fill(Me.GymDataSet.trainer)

    End Sub
End Class