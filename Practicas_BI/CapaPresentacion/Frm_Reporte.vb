Public Class Frm_Reporte

    Private Sub Frm_Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''Text = GStrReporte_nombre
        If GStrReporte_nombre = "añosmes_diasemana" Then

            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

            SERVERREPORT = Me.ReportViewer1.ServerReport
            SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
            SERVERREPORT.ReportPath = ("/REPORTES/Rep01_Dia")
            Me.ReportViewer1.RefreshReport()
        End If

        If GStrReporte_nombre = "añosmes_perfiles" Then

            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

            SERVERREPORT = Me.ReportViewer1.ServerReport
            SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
            SERVERREPORT.ReportPath = ("/REPORTES/Rep02_Perfil_AnnoMes")
            Me.ReportViewer1.RefreshReport()
        End If

        If GStrReporte_nombre = "años_TramoMeses" Then

            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

            SERVERREPORT = Me.ReportViewer1.ServerReport
            SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
            SERVERREPORT.ReportPath = ("/REPORTES/Rep06_TramoMeses")
            Me.ReportViewer1.RefreshReport()
        End If

        If GStrReporte_nombre = "Dias_Parada" Then
            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

            SERVERREPORT = Me.ReportViewer1.ServerReport
            SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
            SERVERREPORT.ReportPath = ("/REPORTES/Rep05_FechaPerfilParada")
            Me.ReportViewer1.RefreshReport()
        End If




        If GStrReporte_nombre = "matriz_paradasXaños" Then
            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

            SERVERREPORT = Me.ReportViewer1.ServerReport
            SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
            SERVERREPORT.ReportPath = ("/REPORTES/Rep03_MatrizParadaAños")
            Me.ReportViewer1.RefreshReport()
        End If

        If GStrReporte_nombre = "matriz_TramosXparadas" Then
            Me.ReportViewer1.RefreshReport()

            Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            Dim SERVERREPORT As Microsoft.Reporting.WinForms.ServerReport

            SERVERREPORT = Me.ReportViewer1.ServerReport
            SERVERREPORT.ReportServerUrl = New Uri("http://hp14-u185la/ReportServer")
            SERVERREPORT.ReportPath = ("/REPORTES/Rep04_ArbolTramoParada")
            Me.ReportViewer1.RefreshReport()
        End If


    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class