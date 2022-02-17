Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\gym.mdf;Integrated Security=True;Connect Timeout=30")
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet

    Public str As String
End Module
