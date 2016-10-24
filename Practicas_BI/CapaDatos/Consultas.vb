Imports System.Data.SqlClient
Imports System.Data
Public Class Consultas
    Public Shared Function VerConsulta(ByVal Sql As String) As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = Sql
        Dim Dap As New SqlDataAdapter(_com)
        Dim Dt As New DataTable
        Dap.Fill(Dt)
        Return Dt
    End Function
End Class
