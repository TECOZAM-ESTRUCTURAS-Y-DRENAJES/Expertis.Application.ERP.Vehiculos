Imports Expertis.Business.Vehiculos
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Application.ERP.GlobalActions
Imports Solmicro.Expertis
Imports Newtonsoft.Json

Public Class MntoBusquedaContratos

    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private Sub MntoBusquedaContratos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        Dim filtroTipo As New Filter(FilterUnionOperator.Or)
        If Not ComboBox1.Text = "" Then
            Dim cadena As DataTable = buscarConductor(ComboBox1.Value)

            If cadena.Rows.Count > 0 Then
                For Each dr As DataRow In cadena.Rows
                    filtroTipo.Add("IDContrato", FilterOperator.Equal, dr(0))
                Next
            Else
                filtroTipo.Add("LRecogida", FilterOperator.Equal, "Esto bloquea la busqueda")
            End If
        End If

        Dim filtroMarca As New Filter(FilterUnionOperator.Or)
        If Not txtMarcaModelo.Text = "" Then
            Dim cadena As DataTable = buscarMarcaModelo(txtMarcaModelo.Text)

            If cadena.Rows.Count > 0 Then
                For Each dr As DataRow In cadena.Rows
                    filtroMarca.Add("IDContrato", FilterOperator.Equal, dr(0))
                Next
            Else
                filtroMarca.Add("LRecogida", FilterOperator.Equal, "Esto bloquea la busqueda")
            End If
        End If

        AplicarFiltros(e)

        e.Filter.Add(filtroTipo)
        e.Filter.Add(filtroMarca)


    End Sub

    Protected Overridable Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)

        e.Filter.Add("Empresa", FilterOperator.Equal, cmbEmpresa.Value)
        e.Filter.Add("FInicio", FilterOperator.GreaterThanOrEqual, clbConFInicio.Value)
        e.Filter.Add("FFin", FilterOperator.LessThanOrEqual, clbConFFin.Value)

    End Sub

    Function buscarConductor(ByVal tipo As String)

        Dim cont As New Contratos
        Dim contrato As DataTable
        contrato = cont.EjecutarSqlSelect("SELECT IDCOntrato FROM tbVehiculoContrato WHERE IDVehiculo IN (SELECT IDVehiculo FROM tbMaestroVehiculos WHERE Tipo = (SELECT TipoVehiculo FROM tbVehiculoTipo WHERE IDTipo = '" & tipo & "'))")

        Return contrato


    End Function

    Function buscarMarcaModelo(ByVal marca As String)

        Dim cont As New Contratos
        Dim contrato As DataTable
        Dim sql As String = "SELECT IDCOntrato FROM vFrmBusquedaContratos WHERE MarcaModelo LIKE '%" & marca & "%'"
        contrato = cont.EjecutarSqlSelect(sql)

        Return contrato

    End Function

End Class