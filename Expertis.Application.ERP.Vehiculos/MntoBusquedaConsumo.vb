Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.UI

Public Class MntoBusquedaConsumo

    Private Sub MntoBusquedaConsumo_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting

        e.Filter.Add("Matricula", FilterOperator.Equal, advMatricula.Text)
        e.Filter.Add("DescEmpresa", FilterOperator.Equal, advEmpresa.Text)
        e.Filter.Add("Fecha", FilterOperator.GreaterThanOrEqual, clbConFInicio.Value)
        e.Filter.Add("Fecha", FilterOperator.LessThanOrEqual, clbConFFin.Value)
    End Sub

    Private Sub CargarVehiculo()
        With Grid
            If Length(.Value("Matricula")) > 0 Then
                ExpertisApp.OpenForm("VEHICULOS", New StringFilterItem("Matricula", .Value("Matricula")))
            End If
        End With
    End Sub

    Private Sub LoadGridActions()
        With Grid
            .Actions.Add("Abrir Vehiculo", AddressOf CargarVehiculo, ExpertisApp.GetIcon("wheel.ico"))
        End With
    End Sub

    Private Sub MntoBusquedaConsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
    End Sub
End Class