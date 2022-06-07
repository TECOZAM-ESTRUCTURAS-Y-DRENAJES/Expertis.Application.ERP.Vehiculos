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
End Class