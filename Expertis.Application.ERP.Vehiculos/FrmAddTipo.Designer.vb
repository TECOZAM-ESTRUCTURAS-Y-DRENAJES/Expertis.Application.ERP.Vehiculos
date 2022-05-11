<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddTipo
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

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
        Dim Grid3_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddTipo))
        Me.Grid3 = New Solmicro.Expertis.Engine.UI.Grid
        Me.txtTipoVehiculo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoVehiculo = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(465, 28)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 28)
        Me.MenuBar.Size = New System.Drawing.Size(1083, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.txtTipoVehiculo)
        Me.MainPanel.Controls.Add(Me.lblTipoVehiculo)
        Me.MainPanel.Controls.Add(Me.Grid3)
        Me.MainPanel.Size = New System.Drawing.Size(835, 484)
        Me.MainPanel.Controls.SetChildIndex(Me.Grid3, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.lblTipoVehiculo, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.txtTipoVehiculo, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.DataSource = Nothing
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "TipoVehiculo"
        Me.Grid.Size = New System.Drawing.Size(835, 484)
        Me.Grid.ViewName = "tbVehiculoTipo"
        '
        'Grid3
        '
        Grid3_DesignTimeLayout.LayoutString = resources.GetString("Grid3_DesignTimeLayout.LayoutString")
        Me.Grid3.DesignTimeLayout = Grid3_DesignTimeLayout
        Me.Grid3.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid3.EntityName = "TipoVehiculo"
        Me.Grid3.Location = New System.Drawing.Point(0, 107)
        Me.Grid3.Name = "Grid3"
        Me.Grid3.PrimaryDataFields = Nothing
        Me.Grid3.SecondaryDataFields = Nothing
        Me.Grid3.Size = New System.Drawing.Size(755, 283)
        Me.Grid3.TabIndex = 0
        Me.Grid3.ViewName = "tbVehiculoTipo"
        '
        'txtTipoVehiculo
        '
        Me.TryDataBinding(txtTipoVehiculo, New System.Windows.Forms.Binding("Text", Me, "TipoVehiculo", True))
        Me.txtTipoVehiculo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTipoVehiculo.Location = New System.Drawing.Point(123, 45)
        Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
        Me.txtTipoVehiculo.Size = New System.Drawing.Size(121, 21)
        Me.txtTipoVehiculo.TabIndex = 1
        '
        'lblTipoVehiculo
        '
        Me.lblTipoVehiculo.Location = New System.Drawing.Point(39, 49)
        Me.lblTipoVehiculo.Name = "lblTipoVehiculo"
        Me.lblTipoVehiculo.Size = New System.Drawing.Size(82, 13)
        Me.lblTipoVehiculo.TabIndex = 2
        Me.lblTipoVehiculo.Text = "Tipo Vehiculo"
        '
        'FrmAddTipo
        '
        Me.ClientSize = New System.Drawing.Size(1083, 572)
        Me.EntityName = "TipoVehiculo"
        Me.Name = "FrmAddTipo"
        Me.ViewName = "tbVehiculoTipo"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab1 As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox2 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Grid2 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Grid3 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtTipoVehiculo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTipoVehiculo As Solmicro.Expertis.Engine.UI.Label
End Class
