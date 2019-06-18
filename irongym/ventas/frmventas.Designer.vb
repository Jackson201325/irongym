<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmventas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FiltroDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F5BuscarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F6BuscarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcomprobante = New System.Windows.Forms.TextBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.txtTgs = New System.Windows.Forms.TextBox()
        Me.txtTus = New System.Windows.Forms.TextBox()
        Me.txtTrs = New System.Windows.Forms.TextBox()
        Me.txtTps = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtps = New System.Windows.Forms.TextBox()
        Me.txtrs = New System.Windows.Forms.TextBox()
        Me.txtus = New System.Windows.Forms.TextBox()
        Me.txtgs = New System.Windows.Forms.TextBox()
        Me.txtcodigocliente = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltroDeBusquedaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1064, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FiltroDeBusquedaToolStripMenuItem
        '
        Me.FiltroDeBusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F5BuscarProductoToolStripMenuItem, Me.F6BuscarClienteToolStripMenuItem})
        Me.FiltroDeBusquedaToolStripMenuItem.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroDeBusquedaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.FiltroDeBusquedaToolStripMenuItem.Name = "FiltroDeBusquedaToolStripMenuItem"
        Me.FiltroDeBusquedaToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.FiltroDeBusquedaToolStripMenuItem.Text = "Filtro de Busqueda"
        '
        'F5BuscarProductoToolStripMenuItem
        '
        Me.F5BuscarProductoToolStripMenuItem.Name = "F5BuscarProductoToolStripMenuItem"
        Me.F5BuscarProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.F5BuscarProductoToolStripMenuItem.Text = "F5-Buscar Producto"
        '
        'F6BuscarClienteToolStripMenuItem
        '
        Me.F6BuscarClienteToolStripMenuItem.Name = "F6BuscarClienteToolStripMenuItem"
        Me.F6BuscarClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.F6BuscarClienteToolStripMenuItem.Text = "F6-Buscar Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(35, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FACTURA DE VENTA"
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Location = New System.Drawing.Point(146, 66)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(429, 20)
        Me.txtcomprobante.TabIndex = 2
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(38, 240)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(993, 280)
        Me.grilla.TabIndex = 3
        '
        'txtTgs
        '
        Me.txtTgs.Location = New System.Drawing.Point(789, 51)
        Me.txtTgs.Name = "txtTgs"
        Me.txtTgs.Size = New System.Drawing.Size(98, 20)
        Me.txtTgs.TabIndex = 4
        '
        'txtTus
        '
        Me.txtTus.Location = New System.Drawing.Point(789, 103)
        Me.txtTus.Name = "txtTus"
        Me.txtTus.Size = New System.Drawing.Size(98, 20)
        Me.txtTus.TabIndex = 5
        '
        'txtTrs
        '
        Me.txtTrs.Location = New System.Drawing.Point(789, 77)
        Me.txtTrs.Name = "txtTrs"
        Me.txtTrs.Size = New System.Drawing.Size(98, 20)
        Me.txtTrs.TabIndex = 6
        '
        'txtTps
        '
        Me.txtTps.Location = New System.Drawing.Point(789, 129)
        Me.txtTps.Name = "txtTps"
        Me.txtTps.Size = New System.Drawing.Size(98, 20)
        Me.txtTps.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(762, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "GS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(762, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "RS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(762, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "US"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(762, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "PS"
        '
        'txtps
        '
        Me.txtps.Location = New System.Drawing.Point(903, 129)
        Me.txtps.Name = "txtps"
        Me.txtps.Size = New System.Drawing.Size(98, 20)
        Me.txtps.TabIndex = 15
        '
        'txtrs
        '
        Me.txtrs.Location = New System.Drawing.Point(903, 77)
        Me.txtrs.Name = "txtrs"
        Me.txtrs.Size = New System.Drawing.Size(98, 20)
        Me.txtrs.TabIndex = 14
        '
        'txtus
        '
        Me.txtus.Location = New System.Drawing.Point(903, 103)
        Me.txtus.Name = "txtus"
        Me.txtus.Size = New System.Drawing.Size(98, 20)
        Me.txtus.TabIndex = 13
        '
        'txtgs
        '
        Me.txtgs.Location = New System.Drawing.Point(903, 51)
        Me.txtgs.Name = "txtgs"
        Me.txtgs.Size = New System.Drawing.Size(98, 20)
        Me.txtgs.TabIndex = 12
        '
        'txtcodigocliente
        '
        Me.txtcodigocliente.Location = New System.Drawing.Point(146, 106)
        Me.txtcodigocliente.Name = "txtcodigocliente"
        Me.txtcodigocliente.Size = New System.Drawing.Size(59, 20)
        Me.txtcodigocliente.TabIndex = 16
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Location = New System.Drawing.Point(224, 106)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(360, 20)
        Me.txtnombrecliente.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(93, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CLIENTE"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(146, 154)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(438, 20)
        Me.txtdescripcion.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Orange
        Me.Label7.Location = New System.Drawing.Point(63, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DESCRIPCION"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(146, 196)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(84, 20)
        Me.txtstock.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Orange
        Me.Label8.Location = New System.Drawing.Point(100, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "STOCK"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(81, 551)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(124, 20)
        Me.txtcodigo.TabIndex = 23
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(224, 551)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(124, 20)
        Me.txtcantidad.TabIndex = 24
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(366, 551)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(114, 20)
        Me.txtprecio.TabIndex = 25
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(887, 571)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(114, 20)
        Me.txtsubtotal.TabIndex = 26
        '
        'txtiva
        '
        Me.txtiva.Location = New System.Drawing.Point(887, 597)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(114, 20)
        Me.txtiva.TabIndex = 27
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(887, 623)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(114, 20)
        Me.txttotal.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Orange
        Me.Label9.Location = New System.Drawing.Point(78, 578)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "CODIGO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Orange
        Me.Label10.Location = New System.Drawing.Point(221, 578)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "CANTIDAD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Orange
        Me.Label11.Location = New System.Drawing.Point(363, 578)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "PRECIO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Orange
        Me.Label12.Location = New System.Drawing.Point(820, 578)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "SUB TOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Orange
        Me.Label13.Location = New System.Drawing.Point(858, 600)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "IVA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Orange
        Me.Label14.Location = New System.Drawing.Point(813, 626)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "TOTAL NETO"
        '
        'frmventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnombrecliente)
        Me.Controls.Add(Me.txtcodigocliente)
        Me.Controls.Add(Me.txtps)
        Me.Controls.Add(Me.txtrs)
        Me.Controls.Add(Me.txtus)
        Me.Controls.Add(Me.txtgs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTps)
        Me.Controls.Add(Me.txtTrs)
        Me.Controls.Add(Me.txtTus)
        Me.Controls.Add(Me.txtTgs)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.txtcomprobante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FiltroDeBusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F5BuscarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F6BuscarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcomprobante As TextBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents txtTgs As TextBox
    Friend WithEvents txtTus As TextBox
    Friend WithEvents txtTrs As TextBox
    Friend WithEvents txtTps As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtps As TextBox
    Friend WithEvents txtrs As TextBox
    Friend WithEvents txtus As TextBox
    Friend WithEvents txtgs As TextBox
    Friend WithEvents txtcodigocliente As TextBox
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtiva As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
