Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Business.ClasesTecozam

Public Class FrmAddPrecios
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

    Private Sub Grid_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellEdited
        Try
            With Grid
                Select Case e.Column.Index
                    Case .Columns("Empresa").Index
                        Dim busi As New Business.Vehiculos.EmpresaTipoPrecios
                        .SetValue("IDTarifa", busi.devuelveAuto())
                End Select
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargarLista()
        Dim Strsql As String
        Dim f As Filter
        Dim dt As DataTable
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        Dim i As Integer
        Dim n As Integer
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try

            jsCol = Grid.Columns("Empresa")
            If Not jsCol Is Nothing Then
                vl = jsCol.ValueList
                If Not vl Is Nothing Then
                    If vl.Count > 0 Then
                        vl.Clear()
                    End If
                End If
            End If

            Strsql = "SELECT DISTINCT(DescEmpresa) FROM tbVehiculoEmpresa"
            'dt = AdminData.Filter(Strsql, , , , False)
            'David Velasco 12/01/23
            Dim auxiliar As New ControlArticuloNSerie
            dt = auxiliar.EjecutarSqlSelect(Strsql)
            'David Velaco

            'FwConsulta = Nothing
            If Not dt Is Nothing Then
                If dt.Rows.Count <> 0 Then

                    jsCol = Grid.Columns("Empresa")
                    jsCol.HasValueList = True
                    'jsCol.ReplaceValues = True

                    vl = jsCol.ValueList
                    For Each dr As DataRow In dt.Rows
                        aux = New Janus.Windows.GridEX.GridEXValueListItem
                        aux.Value = Nz(dr("DescEmpresa"), DBNull.Value)
                        aux.Text = Nz(dr("DescEmpresa"), "")
                        vl.Add(aux)  ', rcsRdo!Estructura
                    Next
                Else
                    Grid.Columns("Empresa").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    Grid.Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.TextBox
                    Grid.Columns("Empresa").HasValueList = False

                End If

            End If

        Catch ex As Exception
            'Engine.UI.ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub cargarListaTipoVehiculo()
        Dim Strsql As String
        Dim f As Filter
        Dim dt As DataTable
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        Dim i As Integer
        Dim n As Integer
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try

            jsCol = Grid.Columns("TipoVehiculo")
            If Not jsCol Is Nothing Then
                vl = jsCol.ValueList
                If Not vl Is Nothing Then
                    If vl.Count > 0 Then
                        vl.Clear()
                    End If
                End If
            End If

            Strsql = "SELECT DISTINCT(TipoVehiculo) FROM tbVehiculoTipo"
            'dt = AdminData.Filter(Strsql, , , , False)
            'David Velasco 12/01/23
            Dim auxiliar As New ControlArticuloNSerie
            dt = auxiliar.EjecutarSqlSelect(Strsql)
            'David Velaco

            'FwConsulta = Nothing
            If Not dt Is Nothing Then
                If dt.Rows.Count <> 0 Then

                    jsCol = Grid.Columns("TipoVehiculo")
                    jsCol.HasValueList = True
                    'jsCol.ReplaceValues = True

                    vl = jsCol.ValueList
                    For Each dr As DataRow In dt.Rows
                        aux = New Janus.Windows.GridEX.GridEXValueListItem
                        aux.Value = Nz(dr("TipoVehiculo"), DBNull.Value)
                        aux.Text = Nz(dr("TipoVehiculo"), "")
                        vl.Add(aux)  ', rcsRdo!Estructura
                    Next
                Else
                    Grid.Columns("TipoVehiculo").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    Grid.Columns("TipoVehiculo").EditType = Janus.Windows.GridEX.EditType.TextBox
                    Grid.Columns("TipoVehiculo").HasValueList = False

                End If

            End If

        Catch ex As Exception
            'Engine.UI.ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub ControlarDesplegableEstructura()

        Dim dt As New DataTable
        Try

            With Grid
                dt = .DataSource

                If dt.Rows.Count <> 0 Then
                    .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    cargarLista()
                    .Refresh()
                Else
                    .Columns("Empresa").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.TextBox
                    .Columns("Empresa").HasValueList = False
                    .Refresh()
                End If
            End With
        Catch ex As Exception
            'Engine.UI.ExpertisApp.GenerateMessage(ex.Message)
        Finally
            dt = Nothing
        End Try
    End Sub


    Private Sub Grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        With Grid

            If .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.DropDownList
                cargarLista()
                .Refresh()
            End If
            If .Columns("TipoVehiculo").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                .Columns("TipoVehiculo").EditType = Janus.Windows.GridEX.EditType.DropDownList
                cargarListaTipoVehiculo()
                .Refresh()
            End If
        End With
    End Sub
End Class