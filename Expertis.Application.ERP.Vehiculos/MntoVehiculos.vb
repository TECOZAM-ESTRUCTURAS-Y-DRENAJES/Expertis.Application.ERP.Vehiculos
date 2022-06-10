Imports Expertis.Business.Vehiculos
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Application.ERP.GlobalActions

Public Class MntoVehiculos
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto


    Private Sub MntoVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadToolBarActions()
        LoadGridActions()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim hayContrato As Boolean = False
        Dim cont As New Contratos
        hayContrato = cont.recuperarContrato(Me.CurrentRow("idVehiculo"))
        If hayContrato Then
            ExpertisApp.GenerateMessage("Para crear un contrato nuevo debe tener fecha Fin el contrato actual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            NuevoContrato()
        End If


    End Sub

    Private Sub NuevoContrato()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim contrato As New Contratos

            Dim dt As New DataTable

            dt.Columns.Add("IDVehiculo")
            dt.Columns.Add("FInicio")
            dt.Columns.Add("FFin")
            dt.Columns.Add("LRecogida")
            dt.Columns.Add("LEntrega")
            dt.Columns.Add("Observaciones")
            dt.Columns.Add("Empresa")
            dt.Columns.Add("Precio")
            dt.Columns.Add("IDContrato")

            Dim dr As DataRow = dt.NewRow()

            dr("IDVehiculo") = Me.CurrentRow("IDVehiculo")
            dr("FInicio") = Me.cmbFInicio.Value
            dr("FFin") = Me.cmbFFin.Value
            dr("LRecogida") = Me.txtLRecogida.Text
            dr("LEntrega") = Me.txtLEntrega.Text
            dr("Observaciones") = ""
            dr("Empresa") = Me.CurrentRow("Empresa")
            dr("Precio") = Me.txtPrecio.Text

            dt.Rows.Add(dr)

            contrato.Update(dt)
            ' Limpiar memoria
            contrato = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub NuevaCuadrilla()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim cuadrilla As New Cuadrillas

            Dim dt As New DataTable

            dt.Columns.Add("IDCuadrilla")
            dt.Columns.Add("IDVehiculo")
            dt.Columns.Add("FInicio")
            dt.Columns.Add("FFin")
            dt.Columns.Add("Zona")
            dt.Columns.Add("Provincia")
            dt.Columns.Add("Obra")
            dt.Columns.Add("JProd")
            dt.Columns.Add("Encargado")
            dt.Columns.Add("Conductor1")
            dt.Columns.Add("Conductor2")
            dt.Columns.Add("Conductor3")
            dt.Columns.Add("Conductor4")
            dt.Columns.Add("Conductor5")

            Dim dr As DataRow = dt.NewRow()

            If Not Me.txtIDCuadrilla.Text = "" Then
                dr("IDCuadrilla") = Me.txtIDCuadrilla.Text
            End If
            dr("IDVehiculo") = Nz(Me.CurrentRow("IDVehiculo"), "")
            dr("FInicio") = Nz(Me.cmCFInicio.Value, "")
            dr("FFin") = Nz(Me.cmCFFin.Value, "")
            dr("Zona") = Nz(Me.txtZona.Text, "")
            dr("Provincia") = Me.txtProvincia.Text
            If Not Me.advObra.Text = "" Then
                dr("Obra") = Nz(Me.advObra.SelectedRow("IDObra"), "")
            Else
                dr("Obra") = 11984995
            End If

            If Not Me.advJProd.Text = "" Then
                dr("JProd") = Nz(Me.advJProd.SelectedRow("IDOperario"), "")
            End If
            If Not Me.advJProd.Text = "" Then
                dr("Encargado") = Nz(Me.advEncarg.SelectedRow("IDOperario"), "")
            End If

            dr("Conductor1") = Me.advCond1.SelectedRow("IDOperario")
            If Not Me.advCond2.Text = "" Then
                dr("Conductor2") = Me.advCond2.SelectedRow("IDOperario")
            End If
            If Not Me.advCond3.Text = "" Then
                dr("Conductor3") = Me.advCond3.SelectedRow("IDOperario")
            End If
            If Not Me.advCond4.Text = "" Then
                dr("Conductor4") = Me.advCond4.SelectedRow("IDOperario")
            End If
            If Not Me.advCond5.Text = "" Then
                dr("Conductor5") = Me.advCond5.SelectedRow("IDOperario")
            End If
            dt.Rows.Add(dr)

            cuadrilla.Update(dt)
            ' Limpiar memoria
            cuadrilla = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub NuevaObservacion()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim observ As New Observaciones
            Dim dt As New DataTable

            dt.Columns.Add("IDObservacion")
            dt.Columns.Add("IDVehiculo")
            dt.Columns.Add("Observacion")
            dt.Columns.Add("Fecha")

            Dim dr As DataRow = dt.NewRow()

            dr("IDVehiculo") = Me.CurrentRow("IDVehiculo")
            dr("Observacion") = Me.txtObservaciones.Text
            dr("Fecha") = Me.cmbFecha.Value

            dt.Rows.Add(dr)

            observ.Update(dt)
            ' Limpiar memoria
            observ = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub nuevoRegistroConsumo()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim cons As New Consumo
            Dim dt As New DataTable

            dt.Columns.Add("IDConsumo")
            dt.Columns.Add("IDVehiculo")
            dt.Columns.Add("Consumo")
            dt.Columns.Add("Kilometros")
            dt.Columns.Add("Fecha")

            Dim dr As DataRow = dt.NewRow()

            'dr("IDConsumo") = Me.CurrentRow("IDConsumo")
            dr("IDVehiculo") = Me.CurrentRow("IDVehiculo")
            dr("Consumo") = Me.txtconsumo.Text
            dr("Kilometros") = Me.txtkm.Text
            dr("Fecha") = Me.cbFechaCons.Value

            dt.Rows.Add(dr)

            cons.Update(dt)
            ' Limpiar memoria
            cons = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub Grid1_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid1.RowDoubleClick
        btnGuardar.Enabled = False
        btnActualizar.Enabled = True
        Me.txtIDContrato.Text = Nz(Grid1.GetValue("IDContrato"), "")
        Me.cmbFInicio.Value = Nz(Grid1.GetValue("FInicio"), "")
        Me.cmbFFin.Value = Nz(Grid1.GetValue("FFin"), "")
        Me.txtLRecogida.Text = Nz(Grid1.GetValue("LRecogida"), "")
        Me.txtLEntrega.Text = Nz(Grid1.GetValue("LEntrega"), "")
        Me.txtPrecio.Text = Nz(Grid1.GetValue("Precio"), "")

    End Sub

    Private Sub Grid2_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid2.RowDoubleClick
        Button2.Enabled = True
        Me.txtIDCuadrilla.Text = Grid2.GetValue("IDCuadrilla")
        Me.txtZona.Text = Nz(Grid2.GetValue("Zona"), "")
        Me.txtProvincia.Text = Nz(Grid2.GetValue("Provincia"), "")
        'Dim idObra As Integer = Grid2.GetValue("Obra")
        Me.advObra.Text = Nz(Grid2.GetValue("NObra"), "")
        If Not IsDBNull(Grid2.GetValue("JProd")) Then
            Me.advJProd.Value = Grid2.GetValue("JProd")
        End If
        Me.advEncarg.Text = Nz(Grid2.GetValue("Encargado"), "")
        Me.advCond1.Text = Grid2.GetValue("Conductor1")
        If Not IsDBNull(Grid2.GetValue("Conductor2")) Then
            Me.advCond2.Text = Grid2.GetValue("Conductor2")
        End If
        If Not IsDBNull(Grid2.GetValue("Conductor3")) Then
            Me.advCond3.Text = Grid2.GetValue("Conductor3")
        End If
        If Not IsDBNull(Grid2.GetValue("Conductor4")) Then
            Me.advCond4.Text = Grid2.GetValue("Conductor4")
        End If
        If Not IsDBNull(Grid2.GetValue("Conductor5")) Then
            Me.advCond5.Text = Grid2.GetValue("Conductor5")
        End If
        Me.cmCFInicio.Value = Nz(Grid2.GetValue("FInicio"), DBNull.Value)
        Me.cmCFFin.Value = Nz(Grid2.GetValue("FFin"), DBNull.Value)
        Button1.Enabled = False




    End Sub

    Private Sub Grid3_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid3.RowDoubleClick

        Me.txtObservaciones.Text = Grid3.GetValue("Observacion")
        Me.cmbFecha.Value = Grid3.GetValue("Fecha")
        Me.txtIDObservacion.Text = Grid3.GetValue("IDObservacion")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hayCuadrilla As Boolean = False
        Dim cuad As New Cuadrillas
        hayCuadrilla = cuad.recuperarCuadrilla(Me.CurrentRow("idVehiculo"))
        If hayCuadrilla Then
            ExpertisApp.GenerateMessage("Para crear una cuadrilla nueva debe tener fecha Fin la Cuadrilla actual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            NuevaCuadrilla()

        End If


        'NuevaCuadrilla()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ActualizarCuadrilla()
    End Sub

    Private Sub ActualizarCuadrilla()

        Dim obj As New Cuadrillas

        Dim cond2 As String = ""
        Dim cond3 As String = ""
        Dim cond4 As String = ""
        Dim cond5 As String = ""

        If advCond2.Text = "" Then
            cond2 = ""
        Else
            cond2 = Nz(advCond2.SelectedRow("IDOperario"), "")
        End If
        If advCond3.Text = "" Then
            cond3 = ""
        Else
            cond3 = Nz(advCond3.SelectedRow("IDOperario"), "")
        End If
        If advCond4.Text = "" Then
            cond4 = ""
        Else
            cond4 = Nz(advCond4.SelectedRow("IDOperario"), "")
        End If
        If advCond5.Text = "" Then
            cond5 = ""
        Else
            cond5 = Nz(advCond5.SelectedRow("IDOperario"), "")
        End If

        Dim sql As String = "UPDATE tbVehiculoCuadrilla SET Zona ='" & txtZona.Text & "', Provincia = '" & txtProvincia.Text & "', Obra = '" & advObra.SelectedRow("IDObra") & "', Jprod = '" & advJProd.Text & "', Encargado = '" & advEncarg.Text & "', Conductor1 = '" & advCond1.Text & "', Conductor2 = '" & cond2 & "', Conductor3 = '" & cond3 & "', Conductor4 = '" & cond4 & "', Conductor5 = '" & cond5 & "', FInicio = '" & cmCFInicio.Value & "', FFin = '" & cmCFFin.Value & "' WHERE IDCuadrilla = " & txtIDCuadrilla.Text

        obj.EjecutarSql(sql)

        Me.RequeryData()
        limpiarFormCuadrilla()

    End Sub

    Private Sub ActualizarContrato()

        Dim obj As New Contratos
        Dim sql As String
        If cmbFFin.Value.ToString.Length = 0 Then
            sql = "UPDATE tbVehiculoContrato SET Empresa = '" & Me.CurrentRow("Empresa") & "', FInicio ='" & cmbFInicio.Value & "', LRecogida = '" & txtLRecogida.Text & "', LEntrega = '" & txtLEntrega.Text & "', Precio = '" & txtPrecio.Text & "' WHERE IDContrato = '" & txtIDContrato.Text & "'"
        Else
            sql = "UPDATE tbVehiculoContrato SET Empresa = '" & Me.CurrentRow("Empresa") & "', FInicio ='" & cmbFInicio.Value & "', FFin = '" & cmbFFin.Value & "', LRecogida = '" & txtLRecogida.Text & "', LEntrega = '" & txtLEntrega.Text & "', Precio = '" & txtPrecio.Text & "' WHERE IDContrato = '" & txtIDContrato.Text & "'"
        End If


        obj.EjecutarSql(sql)

        Me.RequeryData()

    End Sub

    Private Sub ActualizarObservacion()

        Dim obj As New Observaciones

        Dim sql As String = "UPDATE tbVehiculoObservaciones SET Observacion ='" & txtObservaciones.Text & "', Fecha = '" & cmbFecha.Value & "' WHERE IDObservacion = " & txtIDObservacion.Text

        obj.EjecutarSql(sql)

        Me.RequeryData()

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        ActualizarContrato()
    End Sub


    Private Sub advJProd_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advJProd.SetPredefinedFilter
        e.Filter.Add("IDOficio", FilterOperator.Equal, "J. Prod")
    End Sub

    Private Sub advEncarg_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advEncarg.SetPredefinedFilter
        Dim FilOr As New Filter(FilterUnionOperator.Or)
        FilOr.Add("IDOficio", FilterOperator.Equal, "Encargado")
        FilOr.Add("IDOficio", FilterOperator.Equal, "Ingeniero")
        FilOr.Add("IDOficio", FilterOperator.Equal, "Capataz")
        e.Filter.Add(FilOr)
        'e.Filter.Compose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        NuevaObservacion()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ActualizarObservacion()
    End Sub

    Private Sub LoadGridActions()
        Grid1.Actions.Add("Alta documento", AddressOf AccionesGridRutasAlta, ExpertisApp.GetIcon("document_add.ico"))
        Grid1.Actions.Add("Documentos Relacionados", AddressOf AccionesGridRutasRelacionados, ExpertisApp.GetIcon("document_view.ico"))
        Grid1.Actions.Add("Vincular Documentos", AddressOf AccionesGridRutasVincular, ExpertisApp.GetIcon("document_out.ico"))
    End Sub


    Private Sub AccionesGridRutasAlta()
        Dim DtGrid As DataTable = Grid1.DataSource
        Dim DtFinal As DataTable = DtGrid.Clone
        Dim IntRutaOp As Integer = Grid1.GetValue("IDContrato")
        Dim DrGrid() As DataRow = DtGrid.Select("IDContrato = " & IntRutaOp)
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New ClsAltaDocumentosGD
        ClsGD.AltaDocumentos(Grid1.EntityName, DtFinal)
    End Sub

    Private Sub AccionesGridRutasRelacionados()
        Dim DtGrid As DataTable = Grid1.DataSource
        Dim DtFinal As DataTable = DtGrid.Clone
        Dim IntRutaOp As Integer = Grid1.GetValue("IDContrato")
        Dim DrGrid() As DataRow = DtGrid.Select("IDContrato = " & IntRutaOp)
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New clsDocusRelacionadosGD
        ClsGD.DocumentosRelacionados(Grid1.EntityName, DtFinal)
    End Sub

    Private Sub AccionesGridRutasVincular()
        Dim DtGrid As DataTable = Grid1.DataSource
        Dim DtFinal As DataTable = DtGrid.Clone
        Dim IntRutaOp As Integer = Grid1.GetValue("IDContrato")
        Dim DrGrid() As DataRow = DtGrid.Select("IDContrato = " & IntRutaOp)
        DtFinal.Rows.Add(DrGrid(0).ItemArray)
        Dim ClsGD As New clsVinculaDocumentoGD
        ClsGD.VinculaDocumentos(Grid1.EntityName, DtFinal)
    End Sub

    Public Sub LoadToolBarActions()

        Me.FormActions.Add("Añadir Empresa", AddressOf AccionNuevaEmpresa)
        Me.FormActions.Add("Añadir Tipo Vehiculo", AddressOf AccionNuevoTipo)
        Me.FormActions.Add("Añadir y/o Modificar Tarifa Vehiculo", AddressOf AccionNuevaTarifa)
        Me.AddSeparator()
        Me.FormActions.Add("Actualizar tarifas", AddressOf ActualizarTarifas)

    End Sub
    Public Sub ActualizarTarifas()
        'Tengo que recojer todos los contratos(tbVehiculoContrato) cuya
        'FFin sea nula, es decir, que el contrato siga en pie.
        Dim filtro As New Filter
        Dim obj As New Observaciones
        filtro.Add("FFin", FilterOperator.Equal, DBNull.Value)
        Dim dt As New DataTable
        dt = New BE.DataEngine().Filter("tbVehiculoContrato", filtro)

        Dim contador As Integer = 0
        'MsgBox(dt.Rows.Count)
        For Each dr As DataRow In dt.Rows
            '1.Saco según la empresa y el tipo, el precio
            Dim f As New Filter
            f.Add("IDVehiculo", FilterOperator.Equal, dt(contador)("IDVehiculo"))
            Dim dt2 As New DataTable
            dt2 = New BE.DataEngine().Filter("vVehiculoCompleta", f, "IDTipo, IDEmpresa")

            Try
                Dim f2 As New Filter
                f2.Add("IDtipo", FilterOperator.Equal, dt2(0)("IDTipo"))
                f2.Add("IDEmpresa", FilterOperator.Equal, dt2(0)("IDEmpresa"))

                Dim dt3 As New DataTable
                dt3 = New BE.DataEngine().Filter("vVehiculoTipoEmpresa", f2, "Precio")
                '2.Hago el update en tbVehiculoContrato del precio
                Dim sql As String = "UPDATE tbVehiculoContrato SET Precio ='" & dt3(0)("Precio") & "' WHERE IDVehiculo = " & dt(contador)("IDVehiculo")

                obj.EjecutarSql(sql)
            Catch ex As Exception

            End Try
            contador += 1
        Next
        MsgBox("Precios Actualizados Correctamente.")
    End Sub
    Public Sub AccionNuevaTarifa()
        Dim oFrm As Form = ExpertisApp.OpenForm("VEHITARI", , , Me)

    End Sub

    Public Sub AccionNuevaEmpresa()
        Dim oFrm As Form = ExpertisApp.OpenForm("NUEVAEMPRESA", , , Me)

    End Sub
    Public Sub AccionNuevoTipo()
        Dim oFrm As Form = ExpertisApp.OpenForm("NUEVOTIPO", , , Me)

    End Sub

#Region "Advanced Search Selection Changed"

    Private Sub advObra_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advObra.SelectionChanged
        ulObra.Text = Me.advObra.SelectedRow("DescObra")
    End Sub
    Private Sub advJProd_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advJProd.SelectionChanged
        ulJP.Text = Nz(Me.advJProd.SelectedRow("DescOperario"), "")
    End Sub
    Private Sub advEncargado_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advEncarg.SelectionChanged
        ulEnc.Text = Nz(Me.advEncarg.SelectedRow("DescOperario"), "")
    End Sub
    Private Sub advCond1_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCond1.SelectionChanged
        ulC1.Text = Nz(Me.advCond1.SelectedRow("DescOperario"), "")
    End Sub
    Private Sub advCond2_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCond2.SelectionChanged
        ulC2.Text = Nz(Me.advCond2.SelectedRow("DescOperario"), "")
    End Sub
    Private Sub advCond3_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCond3.SelectionChanged
        ulC3.Text = Nz(Me.advCond3.SelectedRow("DescOperario"), "")
    End Sub
    Private Sub advCond4_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCond4.SelectionChanged
        ulC4.Text = Nz(Me.advCond4.SelectedRow("DescOperario"), "")
    End Sub
    Private Sub advCond5_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCond5.SelectionChanged
        ulC5.Text = Nz(Me.advCond5.SelectedRow("DescOperario"), "")
    End Sub

#End Region

    Private Sub advObra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advObra.TextChanged
        'ulObra.Text = Me.advObra.SelectedRow("DescObra")
        'Me.advObra.ASSelectedFields("DescObra", ulObra.Text)
    End Sub

    Private Sub limpiarFormCuadrilla()
        txtZona.Clear()
        txtProvincia.Clear()
        advObra.Clear()
        advJProd.Clear()
        advEncarg.Clear()
        advCond1.Clear()
        advCond2.Clear()
        advCond3.Clear()
        advCond4.Clear()
        advCond5.Clear()
        cmCFFin.Value = DBNull.Value
        cmCFInicio.Value = DBNull.Value
        ulEnc.Text = ""
        ulObra.Text = ""
        ulJP.Text = ""
        ulC1.Text = ""
        ulC2.Text = ""
        ulC3.Text = ""
        ulC4.Text = ""
        ulC5.Text = ""
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub MntoVehiculos_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles Me.Navigated
        limpiarFormCuadrilla()
        limpiarFormContrato()
        limpiarFormConsumo()
    End Sub
    Private Sub limpiarFormContrato()
        cmbFInicio.Value = DBNull.Value
        cmbFFin.Value = DBNull.Value
        txtLEntrega.Clear()
        txtLRecogida.Clear()
        txtPrecio.Clear()
        txtIDContrato.Clear()
        btnGuardar.Enabled = True
        btnActualizar.Enabled = False

    End Sub
    Private Sub limpiarFormConsumo()
        txtconsumo.Clear()
        cbFechaCons.Value = DBNull.Value
        txtkm.Clear()


    End Sub


    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click
        nuevoRegistroConsumo()
        limpiarFormConsumo()

    End Sub

    Private Sub bActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bActualizar.Click
        Dim obj As New Observaciones

        Dim sql As String = "UPDATE tbVehiculoConsumo SET Consumo ='" & txtconsumo.Text & "', Fecha = '" & cbFechaCons.Value & "', Kilometros = '" & txtkm.Text & "' WHERE IDConsumo = " & txtIDConsumo.Text

        obj.EjecutarSql(sql)

        Me.RequeryData()
    End Sub

    Private Sub Grid4_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid4.RowDoubleClick
        Me.txtconsumo.Text = Grid4.GetValue("Consumo")
        Me.cbFechaCons.Value = Grid4.GetValue("Fecha")
        Me.txtkm.Text = Grid4.GetValue("Kilometros")
        Me.txtIDConsumo.Text = Grid4.GetValue("IDConsumo")

    End Sub

    Private Sub cmbTipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.ValueChanged
        Dim empresa As String
        Dim tipo As String
        empresa = cmbEmp.Text
        tipo = cmbTipo.Text

        Dim filtro As New Filter
        filtro.Add("Empresa", FilterOperator.Equal, empresa)
        filtro.Add("TipoVehiculo", FilterOperator.Equal, tipo)

        Dim dt As New DataTable
        dt = New BE.DataEngine().Filter("tbVehiculoTarifa", filtro)

        txtPrecio.Text = dt(0)("Precio")
        filtro.Clear()
        dt = Nothing
    End Sub
End Class
