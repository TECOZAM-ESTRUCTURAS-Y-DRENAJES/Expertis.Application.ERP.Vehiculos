<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoBusquedaVehiculos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoBusquedaVehiculos))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.advIDVehiculo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMatricula = New Solmicro.Expertis.Engine.UI.Label
        Me.advConductor1 = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblConductor1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbCUAFFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFFin = New Solmicro.Expertis.Engine.UI.Label
        Me.clbCUAFInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.clbCUAFInicio)
        Me.FilterPanel.Controls.Add(Me.lblFInicio)
        Me.FilterPanel.Controls.Add(Me.clbCUAFFin)
        Me.FilterPanel.Controls.Add(Me.lblFFin)
        Me.FilterPanel.Controls.Add(Me.advConductor1)
        Me.FilterPanel.Controls.Add(Me.lblConductor1)
        Me.FilterPanel.Controls.Add(Me.lblMatricula)
        Me.FilterPanel.Controls.Add(Me.advIDVehiculo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 482)
        Me.FilterPanel.Size = New System.Drawing.Size(1199, 106)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(1199, 482)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(1199, 482)
        Me.Grid.ViewName = "vVehiculoCompleta"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(1199, 588)
        Me.MainPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.FilterPanel, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.CIMntoGridPanel, 0)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(1199, 588)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Grid1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1201, 424)
        Me.Panel1.TabIndex = 20
        '
        'Grid1
        '
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = Nothing
        Me.Grid1.Location = New System.Drawing.Point(0, -1)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(1200, 422)
        Me.Grid1.TabIndex = 1
        Me.Grid1.ViewName = Nothing
        '
        'advIDVehiculo
        '
        Me.TryDataBinding(advIDVehiculo, New System.Windows.Forms.Binding("Text", Me, "IDVehiculo", True))
        Me.advIDVehiculo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDVehiculo.DisplayField = "Matricula"
        Me.advIDVehiculo.EntityName = "Vehiculo"
        Me.advIDVehiculo.Location = New System.Drawing.Point(120, 46)
        Me.advIDVehiculo.Name = "advIDVehiculo"
        Me.advIDVehiculo.PrimaryDataFields = "IDVehiculo"
        Me.advIDVehiculo.SecondaryDataFields = "idVehiculo"
        Me.advIDVehiculo.Size = New System.Drawing.Size(121, 23)
        Me.advIDVehiculo.TabIndex = 0
        '
        'lblMatricula
        '
        Me.lblMatricula.Location = New System.Drawing.Point(44, 51)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(58, 13)
        Me.lblMatricula.TabIndex = 2
        Me.lblMatricula.Text = "Matricula"
        '
        'advConductor1
        '
        Me.TryDataBinding(advConductor1, New System.Windows.Forms.Binding("Text", Me, "Conductor1", True))
        Me.advConductor1.DisabledBackColor = System.Drawing.Color.White
        Me.advConductor1.DisplayField = "DescOperario"
        Me.advConductor1.EntityName = "Operario"
        Me.advConductor1.Location = New System.Drawing.Point(389, 47)
        Me.advConductor1.Name = "advConductor1"
        Me.advConductor1.SecondaryDataFields = "IDOperario"
        Me.advConductor1.Size = New System.Drawing.Size(121, 23)
        Me.advConductor1.TabIndex = 3
        '
        'lblConductor1
        '
        Me.lblConductor1.Location = New System.Drawing.Point(310, 51)
        Me.lblConductor1.Name = "lblConductor1"
        Me.lblConductor1.Size = New System.Drawing.Size(66, 13)
        Me.lblConductor1.TabIndex = 4
        Me.lblConductor1.Text = "Conductor"
        '
        'clbCUAFFin
        '
        Me.TryDataBinding(clbCUAFFin, New System.Windows.Forms.Binding("BindableValue", Me, "FFin", True))
        Me.clbCUAFFin.DisabledBackColor = System.Drawing.Color.White
        Me.clbCUAFFin.Location = New System.Drawing.Point(859, 48)
        Me.clbCUAFFin.Name = "clbCUAFFin"
        Me.clbCUAFFin.Size = New System.Drawing.Size(121, 21)
        Me.clbCUAFFin.TabIndex = 6
        '
        'lblFFin
        '
        Me.lblFFin.Location = New System.Drawing.Point(824, 52)
        Me.lblFFin.Name = "lblFFin"
        Me.lblFFin.Size = New System.Drawing.Size(29, 13)
        Me.lblFFin.TabIndex = 7
        Me.lblFFin.Text = "FFin"
        '
        'clbCUAFInicio
        '
        Me.TryDataBinding(clbCUAFInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FInicio", True))
        Me.clbCUAFInicio.DisabledBackColor = System.Drawing.Color.White
        Me.clbCUAFInicio.Location = New System.Drawing.Point(635, 49)
        Me.clbCUAFInicio.Name = "clbCUAFInicio"
        Me.clbCUAFInicio.Size = New System.Drawing.Size(121, 21)
        Me.clbCUAFInicio.TabIndex = 8
        '
        'lblFInicio
        '
        Me.lblFInicio.Location = New System.Drawing.Point(585, 52)
        Me.lblFInicio.Name = "lblFInicio"
        Me.lblFInicio.Size = New System.Drawing.Size(44, 13)
        Me.lblFInicio.TabIndex = 9
        Me.lblFInicio.Text = "FInicio"
        '
        'MntoBusquedaVehiculos
        '
        Me.ClientSize = New System.Drawing.Size(1207, 676)
        Me.Name = "MntoBusquedaVehiculos"
        Me.ViewName = "vVehiculoCompleta"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbCuadrillaFDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cmbCuadrillaFHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cmbEmp As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmbTipo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents advCuadrilla As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Tab1 As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblMatricula As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDVehiculo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advConductor1 As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblConductor1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbCUAFInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbCUAFFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFFin As Solmicro.Expertis.Engine.UI.Label
End Class
