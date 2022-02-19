<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberslist
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
        Me.MemberidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembertelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembergenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberbirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GymDataSet = New FightClub.gymDataSet()
        Me.MemberTableAdapter = New FightClub.gymDataSetTableAdapters.memberTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GymDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 59)
        Me.Panel1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(312, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(306, 38)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tüm Üyeleri Listele"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberidDataGridViewTextBoxColumn, Me.MembernameDataGridViewTextBoxColumn, Me.MembersurnameDataGridViewTextBoxColumn, Me.MembertelDataGridViewTextBoxColumn, Me.MembergenderDataGridViewTextBoxColumn, Me.MemberbirthdayDataGridViewTextBoxColumn, Me.MemberdateDataGridViewTextBoxColumn, Me.MemberaddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MemberBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(67, 77)
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
        Me.DataGridView1.TabIndex = 18
        '
        'MemberidDataGridViewTextBoxColumn
        '
        Me.MemberidDataGridViewTextBoxColumn.DataPropertyName = "member_id"
        Me.MemberidDataGridViewTextBoxColumn.HeaderText = "Üye Kayıt No"
        Me.MemberidDataGridViewTextBoxColumn.Name = "MemberidDataGridViewTextBoxColumn"
        Me.MemberidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembernameDataGridViewTextBoxColumn
        '
        Me.MembernameDataGridViewTextBoxColumn.DataPropertyName = "member_name"
        Me.MembernameDataGridViewTextBoxColumn.HeaderText = "Ad"
        Me.MembernameDataGridViewTextBoxColumn.Name = "MembernameDataGridViewTextBoxColumn"
        Me.MembernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembersurnameDataGridViewTextBoxColumn
        '
        Me.MembersurnameDataGridViewTextBoxColumn.DataPropertyName = "member_surname"
        Me.MembersurnameDataGridViewTextBoxColumn.HeaderText = "Soyad"
        Me.MembersurnameDataGridViewTextBoxColumn.Name = "MembersurnameDataGridViewTextBoxColumn"
        Me.MembersurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembertelDataGridViewTextBoxColumn
        '
        Me.MembertelDataGridViewTextBoxColumn.DataPropertyName = "member_tel"
        Me.MembertelDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.MembertelDataGridViewTextBoxColumn.Name = "MembertelDataGridViewTextBoxColumn"
        Me.MembertelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembergenderDataGridViewTextBoxColumn
        '
        Me.MembergenderDataGridViewTextBoxColumn.DataPropertyName = "member_gender"
        Me.MembergenderDataGridViewTextBoxColumn.HeaderText = "Cinsiyet"
        Me.MembergenderDataGridViewTextBoxColumn.Name = "MembergenderDataGridViewTextBoxColumn"
        Me.MembergenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberbirthdayDataGridViewTextBoxColumn
        '
        Me.MemberbirthdayDataGridViewTextBoxColumn.DataPropertyName = "member_birthday"
        Me.MemberbirthdayDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi"
        Me.MemberbirthdayDataGridViewTextBoxColumn.Name = "MemberbirthdayDataGridViewTextBoxColumn"
        Me.MemberbirthdayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberdateDataGridViewTextBoxColumn
        '
        Me.MemberdateDataGridViewTextBoxColumn.DataPropertyName = "member_date"
        Me.MemberdateDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi"
        Me.MemberdateDataGridViewTextBoxColumn.Name = "MemberdateDataGridViewTextBoxColumn"
        Me.MemberdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberaddressDataGridViewTextBoxColumn
        '
        Me.MemberaddressDataGridViewTextBoxColumn.DataPropertyName = "member_address"
        Me.MemberaddressDataGridViewTextBoxColumn.HeaderText = "Adress"
        Me.MemberaddressDataGridViewTextBoxColumn.Name = "MemberaddressDataGridViewTextBoxColumn"
        Me.MemberaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "member"
        Me.MemberBindingSource.DataSource = Me.GymDataSet
        '
        'GymDataSet
        '
        Me.GymDataSet.DataSetName = "gymDataSet"
        Me.GymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'memberslist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(997, 508)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "memberslist"
        Me.Text = "memberslist"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GymDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GymDataSet As gymDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As gymDataSetTableAdapters.memberTableAdapter
    Friend WithEvents MemberidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembersurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembertelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembergenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberbirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
