<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistaventa
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
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.cbopcion = New System.Windows.Forms.ComboBox()
        Me.anular = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(178, 103)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(345, 20)
        Me.txtbuscar.TabIndex = 0
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(134, 180)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(746, 352)
        Me.grilla.TabIndex = 2
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(719, 101)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'cbopcion
        '
        Me.cbopcion.FormattingEnabled = True
        Me.cbopcion.Location = New System.Drawing.Point(541, 102)
        Me.cbopcion.Name = "cbopcion"
        Me.cbopcion.Size = New System.Drawing.Size(159, 21)
        Me.cbopcion.TabIndex = 4
        '
        'anular
        '
        Me.anular.Location = New System.Drawing.Point(805, 589)
        Me.anular.Name = "anular"
        Me.anular.Size = New System.Drawing.Size(75, 23)
        Me.anular.TabIndex = 5
        Me.anular.Text = "Anular"
        Me.anular.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(541, 589)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnimprimir.TabIndex = 6
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(347, 589)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 7
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(134, 589)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 8
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'frmlistaventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.anular)
        Me.Controls.Add(Me.cbopcion)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.txtbuscar)
        Me.Name = "frmlistaventa"
        Me.Text = "frmlistaventa"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents btnbuscar As Button
    Friend WithEvents cbopcion As ComboBox
    Friend WithEvents anular As Button
    Friend WithEvents btnimprimir As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
End Class
