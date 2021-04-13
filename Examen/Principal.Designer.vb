<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Fecha_nacimientoLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim GradoLabel As System.Windows.Forms.Label
        Dim TurnoLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.ExamenDataSet = New Examen.ExamenDataSet()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Examen.ExamenDataSetTableAdapters.AlumnosTableAdapter()
        Me.TableAdapterManager = New Examen.ExamenDataSetTableAdapters.TableAdapterManager()
        Me.AlumnosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlumnosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AlumnosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NacionalidadTextBox = New System.Windows.Forms.TextBox()
        Me.GradoTextBox = New System.Windows.Forms.TextBox()
        Me.TurnoTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Fecha_nacimientoLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        GradoLabel = New System.Windows.Forms.Label()
        TurnoLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlumnosBindingNavigator.SuspendLayout()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(47, 275)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(50, 13)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(46, 311)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(51, 13)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "apellidos:"
        '
        'Fecha_nacimientoLabel
        '
        Fecha_nacimientoLabel.AutoSize = True
        Fecha_nacimientoLabel.Location = New System.Drawing.Point(6, 355)
        Fecha_nacimientoLabel.Name = "Fecha_nacimientoLabel"
        Fecha_nacimientoLabel.Size = New System.Drawing.Size(91, 13)
        Fecha_nacimientoLabel.TabIndex = 6
        Fecha_nacimientoLabel.Text = "fecha nacimiento:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(27, 389)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(70, 13)
        NacionalidadLabel.TabIndex = 8
        NacionalidadLabel.Text = "nacionalidad:"
        '
        'GradoLabel
        '
        GradoLabel.AutoSize = True
        GradoLabel.Location = New System.Drawing.Point(60, 415)
        GradoLabel.Name = "GradoLabel"
        GradoLabel.Size = New System.Drawing.Size(37, 13)
        GradoLabel.TabIndex = 10
        GradoLabel.Text = "grado:"
        '
        'TurnoLabel
        '
        TurnoLabel.AutoSize = True
        TurnoLabel.Location = New System.Drawing.Point(213, 418)
        TurnoLabel.Name = "TurnoLabel"
        TurnoLabel.Size = New System.Drawing.Size(34, 13)
        TurnoLabel.TabIndex = 12
        TurnoLabel.Text = "turno:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(576, 283)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 14
        IDLabel.Text = "ID:"
        '
        'ExamenDataSet
        '
        Me.ExamenDataSet.DataSetName = "ExamenDataSet"
        Me.ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.ExamenDataSet
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Examen.ExamenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlumnosBindingNavigator
        '
        Me.AlumnosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlumnosBindingNavigator.BindingSource = Me.AlumnosBindingSource
        Me.AlumnosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlumnosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AlumnosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AlumnosBindingNavigatorSaveItem})
        Me.AlumnosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AlumnosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlumnosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlumnosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlumnosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlumnosBindingNavigator.Name = "AlumnosBindingNavigator"
        Me.AlumnosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlumnosBindingNavigator.Size = New System.Drawing.Size(771, 25)
        Me.AlumnosBindingNavigator.TabIndex = 0
        Me.AlumnosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AlumnosBindingNavigatorSaveItem
        '
        Me.AlumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlumnosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AlumnosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AlumnosBindingNavigatorSaveItem.Name = "AlumnosBindingNavigatorSaveItem"
        Me.AlumnosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AlumnosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'AlumnosDataGridView
        '
        Me.AlumnosDataGridView.AutoGenerateColumns = False
        Me.AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlumnosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AlumnosDataGridView.DataSource = Me.AlumnosBindingSource
        Me.AlumnosDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.AlumnosDataGridView.Name = "AlumnosDataGridView"
        Me.AlumnosDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.AlumnosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombres"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nacionalidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nacionalidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "grado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "grado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "turno"
        Me.DataGridViewTextBoxColumn7.HeaderText = "turno"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(103, 272)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombresTextBox.TabIndex = 3
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(103, 311)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidosTextBox.TabIndex = 5
        '
        'Fecha_nacimientoDateTimePicker
        '
        Me.Fecha_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "fecha_nacimiento", True))
        Me.Fecha_nacimientoDateTimePicker.Location = New System.Drawing.Point(103, 351)
        Me.Fecha_nacimientoDateTimePicker.Name = "Fecha_nacimientoDateTimePicker"
        Me.Fecha_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_nacimientoDateTimePicker.TabIndex = 7
        '
        'NacionalidadTextBox
        '
        Me.NacionalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "nacionalidad", True))
        Me.NacionalidadTextBox.Location = New System.Drawing.Point(103, 386)
        Me.NacionalidadTextBox.Name = "NacionalidadTextBox"
        Me.NacionalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NacionalidadTextBox.TabIndex = 9
        '
        'GradoTextBox
        '
        Me.GradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "grado", True))
        Me.GradoTextBox.Location = New System.Drawing.Point(103, 412)
        Me.GradoTextBox.Name = "GradoTextBox"
        Me.GradoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GradoTextBox.TabIndex = 11
        '
        'TurnoTextBox
        '
        Me.TurnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "turno", True))
        Me.TurnoTextBox.Location = New System.Drawing.Point(253, 415)
        Me.TurnoTextBox.Name = "TurnoTextBox"
        Me.TurnoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TurnoTextBox.TabIndex = 13
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(603, 280)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(660, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cerrar Sesion"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 483)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(TurnoLabel)
        Me.Controls.Add(Me.TurnoTextBox)
        Me.Controls.Add(GradoLabel)
        Me.Controls.Add(Me.GradoTextBox)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadTextBox)
        Me.Controls.Add(Fecha_nacimientoLabel)
        Me.Controls.Add(Me.Fecha_nacimientoDateTimePicker)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(Me.AlumnosDataGridView)
        Me.Controls.Add(Me.AlumnosBindingNavigator)
        Me.Name = "Principal"
        Me.Text = "Registrode alumnos"
        CType(Me.ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlumnosBindingNavigator.ResumeLayout(False)
        Me.AlumnosBindingNavigator.PerformLayout()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExamenDataSet As Examen.ExamenDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As Examen.ExamenDataSetTableAdapters.AlumnosTableAdapter
    Friend WithEvents TableAdapterManager As Examen.ExamenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlumnosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlumnosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlumnosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_nacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NacionalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TurnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
