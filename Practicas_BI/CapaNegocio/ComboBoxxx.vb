Imports CapaDatos
Public Class ComboBoxxx
    Public Function Verdata(ByVal sql As String) As DataTable
        Return Consultas.VerConsulta(sql)
    End Function
End Class
