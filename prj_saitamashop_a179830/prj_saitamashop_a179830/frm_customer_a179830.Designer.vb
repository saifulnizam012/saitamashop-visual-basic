<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_customer_a179830
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(37, 23)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grd_customer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_customer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_customer.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_customer.Location = New System.Drawing.Point(83, 80)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 30
        Me.grd_customer.Size = New System.Drawing.Size(299, 263)
        Me.grd_customer.TabIndex = 4
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_customer.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_customer.Location = New System.Drawing.Point(94, 29)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(199, 36)
        Me.lbl_customer.TabIndex = 3
        Me.lbl_customer.Text = "CUSTOMER"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Cyan
        Me.btn_insert.Location = New System.Drawing.Point(510, 236)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(89, 32)
        Me.btn_insert.TabIndex = 10
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_update.Location = New System.Drawing.Point(552, 274)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(79, 32)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Location = New System.Drawing.Point(637, 274)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 32)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_clear.Location = New System.Drawing.Point(605, 236)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(80, 32)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Black
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(417, 127)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(116, 19)
        Me.lbl_name.TabIndex = 25
        Me.lbl_name.Text = "Customer Name :"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(438, 95)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(95, 19)
        Me.lbl_id.TabIndex = 26
        Me.lbl_id.Text = "Customer ID :"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.ForeColor = System.Drawing.Color.White
        Me.lbl_phone.Location = New System.Drawing.Point(425, 158)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(108, 19)
        Me.lbl_phone.TabIndex = 27
        Me.lbl_phone.Text = "Phone Number :"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.White
        Me.lbl_address.Location = New System.Drawing.Point(466, 186)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(67, 19)
        Me.lbl_address.TabIndex = 28
        Me.lbl_address.Text = "Address :"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(539, 91)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(221, 24)
        Me.txt_id.TabIndex = 29
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(539, 123)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(221, 24)
        Me.txt_name.TabIndex = 30
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(539, 154)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(221, 24)
        Me.txt_phone.TabIndex = 31
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(539, 186)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(221, 24)
        Me.txt_address.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(549, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "*Click the clear button to insert the new data."
        '
        'frm_customer_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_customer)
        Me.Name = "frm_customer_a179830"
        Me.Text = "frm_customer_a179830"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_customer As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label1 As Label
End Class
