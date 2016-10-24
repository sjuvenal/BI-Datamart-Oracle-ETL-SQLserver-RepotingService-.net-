Imports System.Data.SqlClient
Public Class Conexion
    Dim con As SqlConnection
    Public Sub Cerrar()
        con.Close()
    End Sub
    Public Function Abrir() As SqlConnection
        Dim sql As String
        'sql = "Server=.;Database=DB_Hospedaje"
        'sql = "server=X3650; user id=sa;password=2113;database=Base"
        sql = "Data Source = (Local); Initial Catalog = DataMartSisEst; Integrated Security = true"

        con = New SqlConnection(sql)
        con.Open()
        Return con
    End Function
End Class
