Imports Expertis.Business.Vehiculos
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Application.ERP.GlobalActions
Imports Solmicro.Expertis
Imports System.Text

'Imports Newtonsoft.Json

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

        'IITVCaducada()
        Dim sql As String = "SELECT * FROM vVehiculocompleta where FITV<GETDATE()"
        Dim contrato As New Business.Vehiculos.Contratos
        Dim dt As New DataTable
        Dim pila As New Stack

        dt = contrato.EjecutarSqlSelect(sql)
        For i As Integer = 0 To dt.Rows.Count - 1
            pila.Push("El coche " & dt.Rows(i)("Matricula") & " tiene la ITV caducada a fecha " & dt.Rows(i)("FITV") & ".")
            'builder.Append(i).Append(dt.Rows(i)("Matricula"))
        Next
        pila.Push("----------------------------------------")
        'ITV a 1 mes
        sql = "SELECT * FROM xtecozam50r2..vVehiculocompleta where FITV<GETDATE()+31 AND FITV>=GETDATE()"
        dt = contrato.EjecutarSqlSelect(sql)
        For i As Integer = 0 To dt.Rows.Count - 1
            pila.Push("Al coche " & dt.Rows(i)("Matricula") & " le caduca la ITV a fecha " & dt.Rows(i)("FITV") & ".")
            'builder.Append(i).Append(dt.Rows(i)("Matricula"))
        Next
        If (pila.Count = 1) Then
        Else
            Dim lista As New StringBuilder()
            For Each value As String In pila
                lista.Append(value & "" & vbCrLf)
            Next
            MessageBox.Show(lista.ToString, "Pero ven a vermeeee. Dile que venga", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
            'MsgBox(lista.ToString())
        End If
    End Sub
    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Vehiculos entres dos fechas.", AddressOf VehiculosEntreFechas, ExpertisApp.GetIcon("alarmclock_run.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Vehiculos ITV CADUCADA.", AddressOf ITVCaducada, ExpertisApp.GetIcon("calendar_down.ico"))
        Me.FormActions.Add("Vehiculos ITV EN 1 MES.", AddressOf ITVa1Mes, ExpertisApp.GetIcon("calendar_up.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Vehiculos dados de alta entre fechas.", AddressOf VEHIALTA, ExpertisApp.GetIcon("calendar_up.ico"))
        Me.FormActions.Add("Vehiculos dados de baja entre fechas.", AddressOf VEHIBAJA, ExpertisApp.GetIcon("calendar_up.ico"))
    End Sub

    Private Sub LoadGridActions()
        With Grid
            .Actions.Add("Abrir Vehiculo", AddressOf CargarVehiculo, ExpertisApp.GetIcon("wheel.ico"))
        End With
    End Sub

    Private Sub CargarVehiculo()
        With Grid
            If Length(.Value("Matricula")) > 0 Then
                ExpertisApp.OpenForm("VEHICULOS", New StringFilterItem("Matricula", .Value("Matricula")))
            End If
        End With
    End Sub

    Private Sub VEHIALTA()
        Dim Fecha1 As Date
        Dim Fecha2 As Date

        Dim frm As New frmInformeFecha
        frm.ShowDialog()

        Fecha1 = frm.FechaDesde.Value
        Fecha2 = frm.FechaHasta.Value
        Dim rp As New Report("INFVEHICULOS") 
        Dim str As String = "select * from vFrmBusquedaVehiculos where FInicio>='" & Fecha1 & "' AND FInicio<='" & Fecha2 & "'"
        Dim contrato As New Business.Vehiculos.Contratos
        Dim dt As New DataTable
        dt = contrato.EjecutarSqlSelect(str)

        rp.DataSource = dt
        rp.Formulas("Fecha1").Text = Fecha1
        rp.Formulas("Fecha2").Text = Fecha2
        rp.Formulas("AltOBaj").Text = "DADOS DE ALTA ENTRE:"

        ExpertisApp.OpenReport(rp)
    End Sub

    Private Sub VEHIBAJA()
        Dim Fecha1 As Date
        Dim Fecha2 As Date

        Dim frm As New frmInformeFecha
        frm.ShowDialog()

        Fecha1 = frm.FechaDesde.Value
        Fecha2 = frm.FechaHasta.Value
        Dim rp As New Report("INFVEHICULOS")
        Dim str As String = "select * from vFrmBusquedaVehiculos where FFin>='" & Fecha1 & "' AND FFin<='" & Fecha2 & "'"
        Dim contrato As New Business.Vehiculos.Contratos
        Dim dt As New DataTable
        dt = contrato.EjecutarSqlSelect(str)

        rp.DataSource = dt
        rp.Formulas("Fecha1").Text = Fecha1
        rp.Formulas("Fecha2").Text = Fecha2
        rp.Formulas("AltOBaj").Text = "DADOS DE BAJA ENTRE:"

        ExpertisApp.OpenReport(rp)
    End Sub

    Private Sub ITVCaducada()
        Dim sql As String = "SELECT * FROM vVehiculocompleta where FITV<GETDATE()"
        Dim contrato As New Business.Vehiculos.Contratos
        Dim dt As New DataTable
        dt = contrato.EjecutarSqlSelect(sql)

        Grid.DataSource = dt
    End Sub

    Private Sub ITVa1Mes()
        Dim sql As String = "SELECT * FROM vVehiculocompleta where FITV<GETDATE()+31 AND FITV>=GETDATE()"
        Dim contrato As New Business.Vehiculos.Contratos
        Dim dt As New DataTable
        dt = contrato.EjecutarSqlSelect(sql)

        Grid.DataSource = dt
    End Sub
    Private Sub VehiculosEntreFechas()
        Dim Fecha1 As Date
        Dim Fecha2 As Date

        Dim frm As New frmInformeFecha
        frm.ShowDialog()

        Fecha1 = frm.FechaDesde.Value
        Fecha2 = frm.FechaHasta.Value

        Dim sql As String = "SELECT * FROM vVehiculocompleta where FInicio<= '" & Fecha2 & "' AND ((FFin>= '" & Fecha1 & "' AND FFin<= '" & Fecha2 & "') OR FFin is null)"
        Dim contrato As New Business.Vehiculos.Contratos
        Dim dt As New DataTable
        dt = contrato.EjecutarSqlSelect(sql)


        Grid.DataSource = dt

    End Sub

    Protected Overridable Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)

        e.Filter.Add("IDVehiculo", FilterOperator.Equal, advIDVehiculo.Value)
        e.Filter.Add("FInicio", FilterOperator.GreaterThanOrEqual, clbCUAFInicio.Value)
        e.Filter.Add("FInicio", FilterOperator.LessThanOrEqual, clbCUAFInicioMenor.Value)

        e.Filter.Add("FFin", FilterOperator.GreaterThanOrEqual, clbCUAFFin.Value)
        e.Filter.Add("FFin", FilterOperator.LessThanOrEqual, clbCUAFFinMenor.Value)

    End Sub

    Function buscarConductor(ByVal conductor As String)

        Dim cuad As New Cuadrillas
        Dim cuadrilla As DataTable
        cuadrilla = cuad.EjecutarSqlSelect("SELECT IDCuadrilla FROM tbVehiculoCuadrilla WHERE Conductor1 = '" & conductor & "' OR Conductor2 = '" & conductor & "' OR Conductor3 = '" & conductor & "' OR Conductor4 = '" & conductor & "' OR Conductor5 = '" & conductor & "'")

        Return cuadrilla

    End Function

    Private Sub MntoBusquedaVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToolbarActions()
        LoadGridActions()
    End Sub
End Class