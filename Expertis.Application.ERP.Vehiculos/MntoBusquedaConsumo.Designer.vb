<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoBusquedaConsumo
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
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoBusquedaConsumo))
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbConFInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbConFFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.advMatricula = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advEmpresa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advEmpresa)
        Me.FilterPanel.Controls.Add(Me.advMatricula)
        Me.FilterPanel.Controls.Add(Me.Label4)
        Me.FilterPanel.Controls.Add(Me.Label3)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.clbConFInicio)
        Me.FilterPanel.Controls.Add(Me.clbConFFin)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 228)
        Me.FilterPanel.Size = New System.Drawing.Size(806, 110)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(806, 228)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Consumo"
        Me.Grid.Size = New System.Drawing.Size(806, 228)
        Me.Grid.ViewName = "vBusquedaConsumo"
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
        Me.MainPanel.Size = New System.Drawing.Size(806, 338)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(806, 338)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(244, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha Fin Km"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(244, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha Inicio Km"
        '
        'clbConFInicio
        '
        Me.clbConFInicio.DisabledBackColor = System.Drawing.Color.White
        Me.clbConFInicio.Location = New System.Drawing.Point(363, 25)
        Me.clbConFInicio.Name = "clbConFInicio"
        Me.clbConFInicio.Size = New System.Drawing.Size(148, 21)
        Me.clbConFInicio.TabIndex = 7
        '
        'clbConFFin
        '
        Me.clbConFFin.DisabledBackColor = System.Drawing.Color.White
        Me.clbConFFin.Location = New System.Drawing.Point(363, 64)
        Me.clbConFFin.Name = "clbConFFin"
        Me.clbConFFin.Size = New System.Drawing.Size(148, 21)
        Me.clbConFFin.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Matricula"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(27, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Empresa"
        '
        'advMatricula
        '
        Me.advMatricula.DisabledBackColor = System.Drawing.Color.White
        Me.advMatricula.DisplayField = "Matricula"
        Me.advMatricula.EntityName = "Vehiculo"
        Me.advMatricula.Location = New System.Drawing.Point(90, 28)
        Me.advMatricula.Name = "advMatricula"
        Me.advMatricula.PrimaryDataFields = "Matricula"
        Me.advMatricula.Size = New System.Drawing.Size(100, 23)
        Me.advMatricula.TabIndex = 14
        Me.advMatricula.ViewName = "tbMaestroVehiculos"
        '
        'advEmpresa
        '
        Me.advEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.advEmpresa.DisplayField = "DescEmpresa"
        Me.advEmpresa.EntityName = "EmpresaVehiculo"
        Me.advEmpresa.Location = New System.Drawing.Point(90, 67)
        Me.advEmpresa.Name = "advEmpresa"
        Me.advEmpresa.PrimaryDataFields = "DescEmpresa"
        Me.advEmpresa.Size = New System.Drawing.Size(100, 23)
        Me.advEmpresa.TabIndex = 15
        Me.advEmpresa.ViewName = "tbVehiculoEmpresa"
        '
        'MntoBusquedaConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 426)
        Me.EntityName = "Consumo"
        Me.Name = "MntoBusquedaConsumo"
        Me.Text = "MntoBusquedaConsumo"
        Me.ViewName = "vBusquedaConsumo"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbConFInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbConFFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents advEmpresa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advMatricula As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
