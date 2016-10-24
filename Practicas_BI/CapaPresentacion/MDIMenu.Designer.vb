<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMenu
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Menu_añomes = New System.Windows.Forms.ToolStripMenuItem()
        Me.añomes_diassemana = New System.Windows.Forms.ToolStripMenuItem()
        Me.añomes_perfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Años = New System.Windows.Forms.ToolStripMenuItem()
        Me.Años_tramos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Dia = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dia_paradasperfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Matriz = New System.Windows.Forms.ToolStripMenuItem()
        Me.matriz_paradasXaños = New System.Windows.Forms.ToolStripMenuItem()
        Me.Matriz_TramosXparadas = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TipoPrendaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaseMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_añomes, Me.Menu_Años, Me.Menu_Dia, Me.Menu_Matriz, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.Menu_Dia
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Menu_añomes
        '
        Me.Menu_añomes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.añomes_diassemana, Me.añomes_perfiles, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.Menu_añomes.Image = CType(resources.GetObject("Menu_añomes.Image"), System.Drawing.Image)
        Me.Menu_añomes.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.Menu_añomes.Name = "Menu_añomes"
        Me.Menu_añomes.Size = New System.Drawing.Size(141, 20)
        Me.Menu_añomes.Text = "Filtro por Año - Mes"
        '
        'añomes_diassemana
        '
        Me.añomes_diassemana.Image = CType(resources.GetObject("añomes_diassemana.Image"), System.Drawing.Image)
        Me.añomes_diassemana.ImageTransparentColor = System.Drawing.Color.Black
        Me.añomes_diassemana.Name = "añomes_diassemana"
        Me.añomes_diassemana.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.añomes_diassemana.Size = New System.Drawing.Size(366, 22)
        Me.añomes_diassemana.Text = "Cantidad de validaciones por dias de la semana"
        '
        'añomes_perfiles
        '
        Me.añomes_perfiles.Image = CType(resources.GetObject("añomes_perfiles.Image"), System.Drawing.Image)
        Me.añomes_perfiles.ImageTransparentColor = System.Drawing.Color.Black
        Me.añomes_perfiles.Name = "añomes_perfiles"
        Me.añomes_perfiles.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.añomes_perfiles.Size = New System.Drawing.Size(366, 22)
        Me.añomes_perfiles.Text = "Cantidad de validaciones por Perfiles de usuario"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(363, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'Menu_Años
        '
        Me.Menu_Años.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Años_tramos})
        Me.Menu_Años.Image = CType(resources.GetObject("Menu_Años.Image"), System.Drawing.Image)
        Me.Menu_Años.Name = "Menu_Años"
        Me.Menu_Años.Size = New System.Drawing.Size(113, 20)
        Me.Menu_Años.Text = "Filtro por Años"
        '
        'Años_tramos
        '
        Me.Años_tramos.Image = CType(resources.GetObject("Años_tramos.Image"), System.Drawing.Image)
        Me.Años_tramos.Name = "Años_tramos"
        Me.Años_tramos.Size = New System.Drawing.Size(269, 22)
        Me.Años_tramos.Text = "Cantidad de validaciones por Tramos"
        '
        'Menu_Dia
        '
        Me.Menu_Dia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Dia_paradasperfiles})
        Me.Menu_Dia.Image = CType(resources.GetObject("Menu_Dia.Image"), System.Drawing.Image)
        Me.Menu_Dia.Name = "Menu_Dia"
        Me.Menu_Dia.Size = New System.Drawing.Size(103, 20)
        Me.Menu_Dia.Text = "Filtro por Dia"
        '
        'Dia_paradasperfiles
        '
        Me.Dia_paradasperfiles.Image = CType(resources.GetObject("Dia_paradasperfiles.Image"), System.Drawing.Image)
        Me.Dia_paradasperfiles.Name = "Dia_paradasperfiles"
        Me.Dia_paradasperfiles.Size = New System.Drawing.Size(400, 22)
        Me.Dia_paradasperfiles.Text = "Cantidad de validaciones de Paradas entre Perfiles de usuarios"
        '
        'Menu_Matriz
        '
        Me.Menu_Matriz.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.matriz_paradasXaños, Me.Matriz_TramosXparadas})
        Me.Menu_Matriz.Image = CType(resources.GetObject("Menu_Matriz.Image"), System.Drawing.Image)
        Me.Menu_Matriz.Name = "Menu_Matriz"
        Me.Menu_Matriz.Size = New System.Drawing.Size(68, 20)
        Me.Menu_Matriz.Text = "Matriz"
        '
        'matriz_paradasXaños
        '
        Me.matriz_paradasXaños.Image = CType(resources.GetObject("matriz_paradasXaños.Image"), System.Drawing.Image)
        Me.matriz_paradasXaños.ImageTransparentColor = System.Drawing.Color.Black
        Me.matriz_paradasXaños.Name = "matriz_paradasXaños"
        Me.matriz_paradasXaños.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.matriz_paradasXaños.Size = New System.Drawing.Size(351, 22)
        Me.matriz_paradasXaños.Text = "Cantidad de validaciones por Paradas y Años"
        '
        'Matriz_TramosXparadas
        '
        Me.Matriz_TramosXparadas.Image = CType(resources.GetObject("Matriz_TramosXparadas.Image"), System.Drawing.Image)
        Me.Matriz_TramosXparadas.Name = "Matriz_TramosXparadas"
        Me.Matriz_TramosXparadas.Size = New System.Drawing.Size(351, 22)
        Me.Matriz_TramosXparadas.Text = "Cantidad de validaciones por Tramos X Paradas"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Image = CType(resources.GetObject("HelpMenu.Image"), System.Drawing.Image)
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(69, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoPrendaMenuItem, Me.ClaseMenuItem, Me.ToolStripMenuItem1, Me.MarcaMenuItem, Me.ConsultarMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 391)
        Me.MenuStrip1.MdiWindowListItem = Me.ConsultarMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 40)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TipoPrendaMenuItem
        '
        Me.TipoPrendaMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoPrendaMenuItem.Image = CType(resources.GetObject("TipoPrendaMenuItem.Image"), System.Drawing.Image)
        Me.TipoPrendaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TipoPrendaMenuItem.Name = "TipoPrendaMenuItem"
        Me.TipoPrendaMenuItem.Size = New System.Drawing.Size(116, 36)
        Me.TipoPrendaMenuItem.Text = "Dia Semana"
        '
        'ClaseMenuItem
        '
        Me.ClaseMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaseMenuItem.Image = CType(resources.GetObject("ClaseMenuItem.Image"), System.Drawing.Image)
        Me.ClaseMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClaseMenuItem.Name = "ClaseMenuItem"
        Me.ClaseMenuItem.Size = New System.Drawing.Size(93, 36)
        Me.ClaseMenuItem.Text = "Paradas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AccessibleDescription = ""
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(94, 36)
        Me.ToolStripMenuItem1.Tag = ""
        Me.ToolStripMenuItem1.Text = "Perfiles"
        Me.ToolStripMenuItem1.ToolTipText = "Registrar Marcas Para Tramitar"
        '
        'MarcaMenuItem
        '
        Me.MarcaMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaMenuItem.Image = CType(resources.GetObject("MarcaMenuItem.Image"), System.Drawing.Image)
        Me.MarcaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MarcaMenuItem.Name = "MarcaMenuItem"
        Me.MarcaMenuItem.Size = New System.Drawing.Size(74, 36)
        Me.MarcaMenuItem.Text = "Mes"
        '
        'ConsultarMenuItem
        '
        Me.ConsultarMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarMenuItem.Image = CType(resources.GetObject("ConsultarMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultarMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ConsultarMenuItem.Name = "ConsultarMenuItem"
        Me.ConsultarMenuItem.ShowShortcutKeys = False
        Me.ConsultarMenuItem.Size = New System.Drawing.Size(91, 36)
        Me.ConsultarMenuItem.Text = "Tramos"
        '
        'lblusuario
        '
        Me.lblusuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblusuario.AutoSize = True
        Me.lblusuario.BackColor = System.Drawing.Color.AliceBlue
        Me.lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.Blue
        Me.lblusuario.Location = New System.Drawing.Point(412, 402)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(389, 20)
        Me.lblusuario.TabIndex = 41
        Me.lblusuario.Text = "Bienvenido : Juvenal Quispe Tapia | 22/06/2016"
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MDIMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.DataMart
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(813, 431)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIMenu - DataMart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_añomes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents añomes_diassemana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents añomes_perfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Matriz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents matriz_paradasXaños As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Dia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dia_paradasperfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Matriz_TramosXparadas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TipoPrendaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClaseMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Años As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Años_tramos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblusuario As System.Windows.Forms.Label
End Class
