Imports System.Data.SqlClient
Imports CapaNegocio
Public Class Utilitarios
    'Public cn As New SqlConnection("server=JUVENAL; user id=sa;password=123456;database=Base")
    Public Shared Sub LlenarCombo(ByVal CB As ComboBox, ByRef SQL As String, ByVal VALOR As String, ByVal Nombre As String)
        Dim objAL As New ComboBoxxx
        CB.DataSource = objAL.Verdata(SQL)
        CB.DisplayMember = Nombre
        CB.ValueMember = VALOR
    End Sub
End Class
