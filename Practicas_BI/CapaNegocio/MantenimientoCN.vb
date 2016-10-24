Imports CapaDatos
Imports CapaEntidad
Public Class MantenimientoCN
    Dim MantenimientoCD As New MantenimientoCD
    Dim MantenimientoCE As New MantenimientoCE

    Public Function IniciaSesion(ByVal objUsuario As String, ByVal objPass As String) As DataTable
        Return MantenimientoCD.IniciaSesion(objUsuario, objPass)
    End Function
End Class
