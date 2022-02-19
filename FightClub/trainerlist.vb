Public Class trainerlist
    Private Sub trainerlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'GymDataSet.trainer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.TrainerTableAdapter.Fill(Me.GymDataSet.trainer)

    End Sub
End Class