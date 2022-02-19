<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trainerlist
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GymDataSet = New FightClub.gymDataSet()
        Me.TrainerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrainerTableAdapter = New FightClub.gymDataSetTableAdapters.trainerTableAdapter()
        Me.TraineridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainersurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainertelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainergenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainerdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainerbirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranineraddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GymDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 59)
        Me.Panel1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(279, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(371, 38)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tüm Eğitmenleri Listele"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TraineridDataGridViewTextBoxColumn, Me.TrainernameDataGridViewTextBoxColumn, Me.TrainersurnameDataGridViewTextBoxColumn, Me.TrainertelDataGridViewTextBoxColumn, Me.TrainergenderDataGridViewTextBoxColumn, Me.TrainerdateDataGridViewTextBoxColumn, Me.TrainerbirthdayDataGridViewTextBoxColumn, Me.TranineraddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrainerBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(70, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(848, 419)
        Me.DataGridView1.TabIndex = 19
        '
        'GymDataSet
        '
        Me.GymDataSet.DataSetName = "gymDataSet"
        Me.GymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainerBindingSource
        '
        Me.TrainerBindingSource.DataMember = "trainer"
        Me.TrainerBindingSource.DataSource = Me.GymDataSet
        '
        'TrainerTableAdapter
        '
        Me.TrainerTableAdapter.ClearBeforeFill = True
        '
        'TraineridDataGridViewTextBoxColumn
        '
        Me.TraineridDataGridViewTextBoxColumn.DataPropertyName = "trainer_id"
        Me.TraineridDataGridViewTextBoxColumn.HeaderText = "Eğitmen No"
        Me.TraineridDataGridViewTextBoxColumn.Name = "TraineridDataGridViewTextBoxColumn"
        Me.TraineridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainernameDataGridViewTextBoxColumn
        '
        Me.TrainernameDataGridViewTextBoxColumn.DataPropertyName = "trainer_name"
        Me.TrainernameDataGridViewTextBoxColumn.HeaderText = "Eğitmen Ad"
        Me.TrainernameDataGridViewTextBoxColumn.Name = "TrainernameDataGridViewTextBoxColumn"
        Me.TrainernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainersurnameDataGridViewTextBoxColumn
        '
        Me.TrainersurnameDataGridViewTextBoxColumn.DataPropertyName = "trainer_surname"
        Me.TrainersurnameDataGridViewTextBoxColumn.HeaderText = "Soyad"
        Me.TrainersurnameDataGridViewTextBoxColumn.Name = "TrainersurnameDataGridViewTextBoxColumn"
        Me.TrainersurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainertelDataGridViewTextBoxColumn
        '
        Me.TrainertelDataGridViewTextBoxColumn.DataPropertyName = "trainer_tel"
        Me.TrainertelDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.TrainertelDataGridViewTextBoxColumn.Name = "TrainertelDataGridViewTextBoxColumn"
        Me.TrainertelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainergenderDataGridViewTextBoxColumn
        '
        Me.TrainergenderDataGridViewTextBoxColumn.DataPropertyName = "trainer_gender"
        Me.TrainergenderDataGridViewTextBoxColumn.HeaderText = "Cinsiyet"
        Me.TrainergenderDataGridViewTextBoxColumn.Name = "TrainergenderDataGridViewTextBoxColumn"
        Me.TrainergenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainerdateDataGridViewTextBoxColumn
        '
        Me.TrainerdateDataGridViewTextBoxColumn.DataPropertyName = "trainer_date"
        Me.TrainerdateDataGridViewTextBoxColumn.HeaderText = "Başlangıç Tarihi"
        Me.TrainerdateDataGridViewTextBoxColumn.Name = "TrainerdateDataGridViewTextBoxColumn"
        Me.TrainerdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainerbirthdayDataGridViewTextBoxColumn
        '
        Me.TrainerbirthdayDataGridViewTextBoxColumn.DataPropertyName = "trainer_birthday"
        Me.TrainerbirthdayDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi"
        Me.TrainerbirthdayDataGridViewTextBoxColumn.Name = "TrainerbirthdayDataGridViewTextBoxColumn"
        Me.TrainerbirthdayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TranineraddressDataGridViewTextBoxColumn
        '
        Me.TranineraddressDataGridViewTextBoxColumn.DataPropertyName = "traniner_address"
        Me.TranineraddressDataGridViewTextBoxColumn.HeaderText = "Adres"
        Me.TranineraddressDataGridViewTextBoxColumn.Name = "TranineraddressDataGridViewTextBoxColumn"
        Me.TranineraddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'trainerlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(997, 508)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "trainerlist"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GymDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GymDataSet As gymDataSet
    Friend WithEvents TrainerBindingSource As BindingSource
    Friend WithEvents TrainerTableAdapter As gymDataSetTableAdapters.trainerTableAdapter
    Friend WithEvents TraineridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainersurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainertelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainergenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainerdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainerbirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TranineraddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
