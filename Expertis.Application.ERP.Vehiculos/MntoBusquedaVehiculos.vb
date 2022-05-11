Imports Expertis.Business.Vehiculos
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Application.ERP.GlobalActions
Imports Solmicro.Expertis
Imports Newtonsoft.Json

Public Class MntoBusquedaVehiculos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto



    Private Sub MntoBusquedaVehiculos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        Dim filtroCuadrillas As New Filter(FilterUnionOperator.Or)
        If Not advConductor1.Text = "" Then
            Dim cadena As DataTable = buscarConductor(advConductor1.Value)

            If cadena.Rows.Count > 0 Then
                For Each dr As DataRow In cadena.Rows
                    filtroCuadrillas.Add("IDCuadrilla", FilterOperator.Equal, dr(0))
                Next
            Else
                filtroCuadrillas.Add("Conductor1", FilterOperator.Equal, advConductor1.Value)
            End If
        End If

        AplicarFiltros(e)

        e.Filter.Add(filtroCuadrillas)


    End Sub

    Protected Overridable Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)

        e.Filter.Add("IDVehiculo", FilterOperator.Equal, advIDVehiculo.Value)
        e.Filter.Add("FInicio", FilterOperator.GreaterThanOrEqual, clbCUAFInicio.Value)
        e.Filter.Add("FFin", FilterOperator.LessThanOrEqual, clbCUAFFin.Value)

    End Sub

    Function buscarConductor(ByVal conductor As String)

        Dim cuad As New Cuadrillas
        Dim cuadrilla As DataTable
        cuadrilla = cuad.EjecutarSqlSelect("SELECT IDCuadrilla FROM tbVehiculoCuadrilla WHERE Conductor1 = '" & conductor & "' OR Conductor2 = '" & conductor & "' OR Conductor3 = '" & conductor & "' OR Conductor4 = '" & conductor & "' OR Conductor5 = '" & conductor & "'")
        
        Return cuadrilla


    End Function

End Class