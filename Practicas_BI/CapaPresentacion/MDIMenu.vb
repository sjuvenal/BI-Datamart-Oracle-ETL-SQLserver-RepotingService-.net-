Public Class MDIMenu

    
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añomes_diassemana.Click
        GStrReporte_nombre = "añosmes_diasemana"
        Dim frm As New Frm_Reporte
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub añomes_perfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añomes_perfiles.Click
        GStrReporte_nombre = "añosmes_perfiles"
        Dim frm As New Frm_Reporte
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub Años_tramos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Años_tramos.Click
        GStrReporte_nombre = "años_TramoMeses"
        Dim frm As New Frm_Reporte
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CantiadPorParadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GStrReporte_nombre = "Matriz_ArbolTramoParada"
        Dim frm As New Frm_Reporte
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Desarrollado por Juvenal Quispe Tapia", vbInformation, "DataMart")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Esta seguro que Desea Salir del Sistema:", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If

    End Sub


   

    

    

    


    Private Sub FiltroTramoMesesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GStrReporte_nombre = "Filtros_TramoMeses"
        Dim frm As New Frm_Reporte
        frm.MdiParent = Me
        frm.Show()
    End Sub

  
    Private Sub Dia_paradasperfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dia_paradasperfiles.Click
        GStrReporte_nombre = "Dias_Parada"
        Dim frm As New Frm_Reporte
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub matriz_paradasXaños_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles matriz_paradasXaños.Click
        GStrReporte_nombre = "matriz_paradasXaños"

        Dim frm As New Frm_Reporte

        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub Matriz_TramosXparadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Matriz_TramosXparadas.Click
        GStrReporte_nombre = "matriz_TramosXparadas"

        Dim frm As New Frm_Reporte

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MDIMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblusuario.Text = "Bienvenido : " & GIntUsuNom & " | " & DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
End Class