Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MantenimientoCD
    Public Function IniciaSesion(ByVal StrUsuario As String, ByVal StrPass As String) As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "[IniciaSesion] '" & StrUsuario & "','" & StrPass & "'"
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function
End Class
