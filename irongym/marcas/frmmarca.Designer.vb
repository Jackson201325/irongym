﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmarca
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmarca))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(272, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Buscar por:"
        '
        'cbo
        '
        Me.cbo.FormattingEnabled = True
        Me.cbo.Items.AddRange(New Object() {"Descripcion", "Proveedor"})
        Me.cbo.Location = New System.Drawing.Point(377, 102)
        Me.cbo.Name = "cbo"
        Me.cbo.Size = New System.Drawing.Size(195, 28)
        Me.cbo.TabIndex = 16
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txtbuscar.Font = New System.Drawing.Font("Nirmala UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(203, 57)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(523, 31)
        Me.txtbuscar.TabIndex = 14
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        Me.grilla.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla.GridColor = System.Drawing.Color.White
        Me.grilla.Location = New System.Drawing.Point(344, 192)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowTemplate.Height = 28
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla.Size = New System.Drawing.Size(561, 429)
        Me.grilla.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnsalir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btneditar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 721)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 673)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Salir"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Orange
        Me.btnsalir.BackgroundImage = CType(resources.GetObject("btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(39, 602)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(116, 68)
        Me.btnsalir.TabIndex = 7
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 554)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Eliminar"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Orange
        Me.btneliminar.BackgroundImage = CType(resources.GetObject("btneliminar.BackgroundImage"), System.Drawing.Image)
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(39, 459)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(116, 92)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Editar"
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.Orange
        Me.btneditar.BackgroundImage = CType(resources.GetObject("btneditar.BackgroundImage"), System.Drawing.Image)
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Location = New System.Drawing.Point(39, 324)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(116, 75)
        Me.btneditar.TabIndex = 3
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nuevo"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Orange
        Me.btnnuevo.BackgroundImage = CType(resources.GetObject("btnnuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnnuevo.FlatAppearance.BorderSize = 0
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(15, 192)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(161, 87)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Black
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Location = New System.Drawing.Point(744, 55)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(94, 39)
        Me.btnbuscar.TabIndex = 15
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.Black
        Me.btncerrar.BackgroundImage = CType(resources.GetObject("btncerrar.BackgroundImage"), System.Drawing.Image)
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.ForeColor = System.Drawing.Color.Black
        Me.btncerrar.Location = New System.Drawing.Point(1022, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(46, 44)
        Me.btncerrar.TabIndex = 18
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'frmmarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1080, 720)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmarca"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cbo As ComboBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btneditar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncerrar As Button
End Class
