<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a179830
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
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.lbl_benefit = New System.Windows.Forms.Label()
        Me.txt_benefit = New System.Windows.Forms.TextBox()
        Me.lbl_specification = New System.Windows.Forms.Label()
        Me.txt_spec = New System.Windows.Forms.TextBox()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.lbl_file = New System.Windows.Forms.Label()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(34, 23)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grd_product.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_product.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_product.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_product.Location = New System.Drawing.Point(80, 89)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 30
        Me.grd_product.Size = New System.Drawing.Size(652, 208)
        Me.grd_product.TabIndex = 4
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(80, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(186, 47)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "PRODUCT"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(147, 330)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(272, 24)
        Me.txt_id.TabIndex = 7
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Cyan
        Me.btn_insert.Location = New System.Drawing.Point(657, 370)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(85, 37)
        Me.btn_insert.TabIndex = 9
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_update.Location = New System.Drawing.Point(657, 408)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(85, 35)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Location = New System.Drawing.Point(657, 443)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(85, 33)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(48, 333)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(84, 19)
        Me.lbl_id.TabIndex = 12
        Me.lbl_id.Text = "Product ID :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(27, 364)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(105, 19)
        Me.lbl_name.TabIndex = 13
        Me.lbl_name.Text = "Product Name :"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(147, 362)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(272, 24)
        Me.txt_name.TabIndex = 14
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(84, 398)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(47, 19)
        Me.lbl_price.TabIndex = 15
        Me.lbl_price.Text = "Price :"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(147, 394)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(272, 24)
        Me.txt_price.TabIndex = 16
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(79, 427)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(53, 19)
        Me.lbl_brand.TabIndex = 17
        Me.lbl_brand.Text = "Brand :"
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(147, 427)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(272, 24)
        Me.txt_brand.TabIndex = 18
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(84, 459)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(46, 19)
        Me.lbl_type.TabIndex = 19
        Me.lbl_type.Text = "Type :"
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(146, 459)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(272, 24)
        Me.txt_type.TabIndex = 20
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_clear.Location = New System.Drawing.Point(657, 333)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(85, 36)
        Me.btn_clear.TabIndex = 25
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'lbl_benefit
        '
        Me.lbl_benefit.AutoSize = True
        Me.lbl_benefit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_benefit.Location = New System.Drawing.Point(68, 491)
        Me.lbl_benefit.Name = "lbl_benefit"
        Me.lbl_benefit.Size = New System.Drawing.Size(64, 19)
        Me.lbl_benefit.TabIndex = 26
        Me.lbl_benefit.Text = "Benefits :"
        '
        'txt_benefit
        '
        Me.txt_benefit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_benefit.Location = New System.Drawing.Point(146, 491)
        Me.txt_benefit.Name = "txt_benefit"
        Me.txt_benefit.Size = New System.Drawing.Size(272, 24)
        Me.txt_benefit.TabIndex = 27
        '
        'lbl_specification
        '
        Me.lbl_specification.AutoSize = True
        Me.lbl_specification.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_specification.Location = New System.Drawing.Point(39, 524)
        Me.lbl_specification.Name = "lbl_specification"
        Me.lbl_specification.Size = New System.Drawing.Size(93, 19)
        Me.lbl_specification.TabIndex = 28
        Me.lbl_specification.Text = "Specification :"
        '
        'txt_spec
        '
        Me.txt_spec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_spec.Location = New System.Drawing.Point(146, 521)
        Me.txt_spec.Name = "txt_spec"
        Me.txt_spec.Size = New System.Drawing.Size(272, 24)
        Me.txt_spec.TabIndex = 29
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(478, 330)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(135, 113)
        Me.pic_student.TabIndex = 30
        Me.pic_student.TabStop = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_picture.Location = New System.Drawing.Point(478, 503)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(93, 36)
        Me.btn_picture.TabIndex = 33
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'lbl_file
        '
        Me.lbl_file.AutoSize = True
        Me.lbl_file.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_file.Location = New System.Drawing.Point(480, 455)
        Me.lbl_file.Name = "lbl_file"
        Me.lbl_file.Size = New System.Drawing.Size(91, 17)
        Me.lbl_file.TabIndex = 32
        Me.lbl_file.Text = "File Location :"
        '
        'txt_picture
        '
        Me.txt_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_picture.Location = New System.Drawing.Point(478, 475)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(124, 22)
        Me.txt_picture.TabIndex = 31
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(480, 552)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "*Click the clear button to insert the new data."
        '
        'frm_products_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.Gym5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 609)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.lbl_file)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.txt_spec)
        Me.Controls.Add(Me.lbl_specification)
        Me.Controls.Add(Me.txt_benefit)
        Me.Controls.Add(Me.lbl_benefit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_products_a179830"
        Me.Text = "frm_products_a179830"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents txt_type As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_benefit As Label
    Friend WithEvents txt_benefit As TextBox
    Friend WithEvents lbl_specification As Label
    Friend WithEvents txt_spec As TextBox
    Friend WithEvents pic_student As PictureBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents lbl_file As Label
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
End Class
