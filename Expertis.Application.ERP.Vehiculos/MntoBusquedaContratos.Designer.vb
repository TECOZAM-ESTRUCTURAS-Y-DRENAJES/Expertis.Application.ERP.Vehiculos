<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoBusquedaContratos
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
        Dim ComboBox1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbEmpresa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoBusquedaContratos))
        Me.clbConFFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbConFInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.ComboBox1 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label8 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label9 = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtMarcaModelo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblMarcaModelo = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtMarcaModelo)
        Me.FilterPanel.Controls.Add(Me.lblMarcaModelo)
        Me.FilterPanel.Controls.Add(Me.cmbEmpresa)
        Me.FilterPanel.Controls.Add(Me.Label9)
        Me.FilterPanel.Controls.Add(Me.Label8)
        Me.FilterPanel.Controls.Add(Me.ComboBox1)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.clbConFInicio)
        Me.FilterPanel.Controls.Add(Me.clbConFFin)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 359)
        Me.FilterPanel.Size = New System.Drawing.Size(1055, 129)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(1055, 359)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Contratos"
        Me.Grid.Size = New System.Drawing.Size(1055, 359)
        Me.Grid.ViewName = "vFrmBusquedaContratos"
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
        Me.MainPanel.Size = New System.Drawing.Size(1055, 488)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(1055, 488)
        '
        'clbConFFin
        '
        Me.clbConFFin.DisabledBackColor = System.Drawing.Color.White
        Me.clbConFFin.Location = New System.Drawing.Point(413, 81)
        Me.clbConFFin.Name = "clbConFFin"
        Me.clbConFFin.Size = New System.Drawing.Size(148, 21)
        Me.clbConFFin.TabIndex = 2
        '
        'clbConFInicio
        '
        Me.clbConFInicio.DisabledBackColor = System.Drawing.Color.White
        Me.clbConFInicio.Location = New System.Drawing.Point(413, 32)
        Me.clbConFInicio.Name = "clbConFInicio"
        Me.clbConFInicio.Size = New System.Drawing.Size(148, 21)
        Me.clbConFInicio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(323, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Inicio"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(338, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Fin"
        '
        'ComboBox1
        '
        ComboBox1_DesignTimeLayout.LayoutString = resources.GetString("ComboBox1_DesignTimeLayout.LayoutString")
        Me.ComboBox1.DesignTimeLayout = ComboBox1_DesignTimeLayout
        Me.ComboBox1.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox1.EntityName = "TipoVehiculo"
        Me.ComboBox1.Location = New System.Drawing.Point(117, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.SecondaryDataFields = "TipoVehiculo"
        Me.ComboBox1.SelectedIndex = -1
        Me.ComboBox1.SelectedItem = Nothing
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(19, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo Vehiculo"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(22, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Empresa"
        '
        'cmbEmpresa
        '
        Me.TryDataBinding(cmbEmpresa, New System.Windows.Forms.Binding("Value", Me, "Empresa", True))
        cmbEmpresa_DesignTimeLayout.LayoutString = resources.GetString("cmbEmpresa_DesignTimeLayout.LayoutString")
        Me.cmbEmpresa.DesignTimeLayout = cmbEmpresa_DesignTimeLayout
        Me.cmbEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.cmbEmpresa.EntityName = "EmpresaVehiculo"
        Me.cmbEmpresa.Location = New System.Drawing.Point(117, 35)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.PrimaryDataFields = "Empresa"
        Me.cmbEmpresa.SecondaryDataFields = "DescEmpresa"
        Me.cmbEmpresa.SelectedIndex = -1
        Me.cmbEmpresa.SelectedItem = Nothing
        Me.cmbEmpresa.Size = New System.Drawing.Size(155, 21)
        Me.cmbEmpresa.TabIndex = 10
        Me.cmbEmpresa.ValueMember = "DescEmpresa"
        '
        'txtMarcaModelo
        '
        Me.TryDataBinding(txtMarcaModelo, New System.Windows.Forms.Binding("Text", Me, "MarcaModelo", True))
        Me.txtMarcaModelo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMarcaModelo.Location = New System.Drawing.Point(738, 32)
        Me.txtMarcaModelo.Name = "txtMarcaModelo"
        Me.txtMarcaModelo.Size = New System.Drawing.Size(121, 21)
        Me.txtMarcaModelo.TabIndex = 11
        '
        'lblMarcaModelo
        '
        Me.lblMarcaModelo.Location = New System.Drawing.Point(652, 36)
        Me.lblMarcaModelo.Name = "lblMarcaModelo"
        Me.lblMarcaModelo.Size = New System.Drawing.Size(81, 13)
        Me.lblMarcaModelo.TabIndex = 12
        Me.lblMarcaModelo.Text = "MarcaModelo"
        '
        'MntoBusquedaContratos
        '
        Me.ClientSize = New System.Drawing.Size(1063, 576)
        Me.EntityName = "Contratos"
        Me.Name = "MntoBusquedaContratos"
        Me.ViewName = "vFrmBusquedaContratos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtIDCuadrilla As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents clbFInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ComboBox1 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbConFInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbConFFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label8 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label9 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtMarcaModelo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblMarcaModelo As Solmicro.Expertis.Engine.UI.Label
End Class
