<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productcatalog_a179830
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
        Me.lbl_catalog = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_choose = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_spec = New System.Windows.Forms.Label()
        Me.cmb_spec = New System.Windows.Forms.ComboBox()
        Me.lbl_benefit = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_filter = New System.Windows.Forms.Label()
        Me.lbl_idvalue = New System.Windows.Forms.Label()
        Me.lbl_namevalue = New System.Windows.Forms.Label()
        Me.lbl_brandvalue = New System.Windows.Forms.Label()
        Me.lbl_benefitvalue = New System.Windows.Forms.Label()
        Me.lbl_pricevalue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_catalog
        '
        Me.lbl_catalog.AutoSize = True
        Me.lbl_catalog.BackColor = System.Drawing.Color.LightYellow
        Me.lbl_catalog.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_catalog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_catalog.Location = New System.Drawing.Point(93, 34)
        Me.lbl_catalog.Name = "lbl_catalog"
        Me.lbl_catalog.Size = New System.Drawing.Size(336, 36)
        Me.lbl_catalog.TabIndex = 4
        Me.lbl_catalog.Text = "PRODUCT CATALOG"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(578, 104)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(210, 193)
        Me.pic_product.TabIndex = 9
        Me.pic_product.TabStop = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(487, 434)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(64, 15)
        Me.lbl_price.TabIndex = 34
        Me.lbl_price.Text = "Price : RM"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(445, 338)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(92, 15)
        Me.lbl_name.TabIndex = 32
        Me.lbl_name.Text = "Product Name :"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(623, 78)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(64, 13)
        Me.lbl_id.TabIndex = 31
        Me.lbl_id.Text = "Product ID :"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(22, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(34, 23)
        Me.btn_back.TabIndex = 36
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_choose
        '
        Me.lbl_choose.AutoSize = True
        Me.lbl_choose.BackColor = System.Drawing.Color.Transparent
        Me.lbl_choose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_choose.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_choose.Location = New System.Drawing.Point(131, 219)
        Me.lbl_choose.Name = "lbl_choose"
        Me.lbl_choose.Size = New System.Drawing.Size(265, 16)
        Me.lbl_choose.TabIndex = 37
        Me.lbl_choose.Text = "Choose any product by click the list below :-"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(223, 180)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(160, 20)
        Me.txt_search.TabIndex = 41
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_search.ForeColor = System.Drawing.Color.White
        Me.lbl_search.Location = New System.Drawing.Point(96, 183)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(121, 26)
        Me.lbl_search.TabIndex = 42
        Me.lbl_search.Text = "Search product name   :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(within category above) "
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(134, 238)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(262, 199)
        Me.lst_product.TabIndex = 43
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(223, 129)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(160, 21)
        Me.cmb_type.TabIndex = 44
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.ForeColor = System.Drawing.Color.White
        Me.lbl_type.Location = New System.Drawing.Point(173, 132)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(44, 13)
        Me.lbl_type.TabIndex = 45
        Me.lbl_type.Text = "* Type :"
        '
        'lbl_spec
        '
        Me.lbl_spec.AutoSize = True
        Me.lbl_spec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_spec.ForeColor = System.Drawing.Color.White
        Me.lbl_spec.Location = New System.Drawing.Point(136, 156)
        Me.lbl_spec.Name = "lbl_spec"
        Me.lbl_spec.Size = New System.Drawing.Size(81, 13)
        Me.lbl_spec.TabIndex = 47
        Me.lbl_spec.Text = "* Specification :"
        '
        'cmb_spec
        '
        Me.cmb_spec.FormattingEnabled = True
        Me.cmb_spec.Location = New System.Drawing.Point(223, 153)
        Me.cmb_spec.Name = "cmb_spec"
        Me.cmb_spec.Size = New System.Drawing.Size(160, 21)
        Me.cmb_spec.TabIndex = 46
        '
        'lbl_benefit
        '
        Me.lbl_benefit.AutoSize = True
        Me.lbl_benefit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_benefit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_benefit.ForeColor = System.Drawing.Color.White
        Me.lbl_benefit.Location = New System.Drawing.Point(475, 402)
        Me.lbl_benefit.Name = "lbl_benefit"
        Me.lbl_benefit.Size = New System.Drawing.Size(57, 15)
        Me.lbl_benefit.TabIndex = 50
        Me.lbl_benefit.Text = "Benefits :"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.Color.White
        Me.lbl_brand.Location = New System.Drawing.Point(485, 370)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(46, 15)
        Me.lbl_brand.TabIndex = 49
        Me.lbl_brand.Text = "Brand :"
        '
        'lbl_filter
        '
        Me.lbl_filter.AutoSize = True
        Me.lbl_filter.BackColor = System.Drawing.Color.Transparent
        Me.lbl_filter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filter.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_filter.Location = New System.Drawing.Point(220, 104)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(141, 18)
        Me.lbl_filter.TabIndex = 52
        Me.lbl_filter.Text = "Click the box below :-"
        '
        'lbl_idvalue
        '
        Me.lbl_idvalue.AutoSize = True
        Me.lbl_idvalue.BackColor = System.Drawing.Color.White
        Me.lbl_idvalue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idvalue.Location = New System.Drawing.Point(690, 78)
        Me.lbl_idvalue.Name = "lbl_idvalue"
        Me.lbl_idvalue.Size = New System.Drawing.Size(11, 14)
        Me.lbl_idvalue.TabIndex = 53
        Me.lbl_idvalue.Text = "-"
        '
        'lbl_namevalue
        '
        Me.lbl_namevalue.AutoSize = True
        Me.lbl_namevalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_namevalue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namevalue.ForeColor = System.Drawing.Color.White
        Me.lbl_namevalue.Location = New System.Drawing.Point(529, 338)
        Me.lbl_namevalue.Name = "lbl_namevalue"
        Me.lbl_namevalue.Size = New System.Drawing.Size(12, 16)
        Me.lbl_namevalue.TabIndex = 54
        Me.lbl_namevalue.Text = "-"
        '
        'lbl_brandvalue
        '
        Me.lbl_brandvalue.AutoSize = True
        Me.lbl_brandvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brandvalue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brandvalue.ForeColor = System.Drawing.Color.White
        Me.lbl_brandvalue.Location = New System.Drawing.Point(529, 370)
        Me.lbl_brandvalue.Name = "lbl_brandvalue"
        Me.lbl_brandvalue.Size = New System.Drawing.Size(12, 16)
        Me.lbl_brandvalue.TabIndex = 55
        Me.lbl_brandvalue.Text = "-"
        '
        'lbl_benefitvalue
        '
        Me.lbl_benefitvalue.AutoSize = True
        Me.lbl_benefitvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_benefitvalue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_benefitvalue.ForeColor = System.Drawing.Color.White
        Me.lbl_benefitvalue.Location = New System.Drawing.Point(529, 402)
        Me.lbl_benefitvalue.Name = "lbl_benefitvalue"
        Me.lbl_benefitvalue.Size = New System.Drawing.Size(12, 16)
        Me.lbl_benefitvalue.TabIndex = 56
        Me.lbl_benefitvalue.Text = "-"
        '
        'lbl_pricevalue
        '
        Me.lbl_pricevalue.AutoSize = True
        Me.lbl_pricevalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pricevalue.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pricevalue.ForeColor = System.Drawing.Color.White
        Me.lbl_pricevalue.Location = New System.Drawing.Point(557, 434)
        Me.lbl_pricevalue.Name = "lbl_pricevalue"
        Me.lbl_pricevalue.Size = New System.Drawing.Size(21, 29)
        Me.lbl_pricevalue.TabIndex = 57
        Me.lbl_pricevalue.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.GYM_LOGO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(917, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 69)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'frm_productcatalog_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.free_beautiful_hi_res_wood
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1049, 560)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_pricevalue)
        Me.Controls.Add(Me.lbl_benefitvalue)
        Me.Controls.Add(Me.lbl_brandvalue)
        Me.Controls.Add(Me.lbl_namevalue)
        Me.Controls.Add(Me.lbl_idvalue)
        Me.Controls.Add(Me.lbl_filter)
        Me.Controls.Add(Me.lbl_benefit)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_spec)
        Me.Controls.Add(Me.cmb_spec)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.lbl_choose)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_catalog)
        Me.Name = "frm_productcatalog_a179830"
        Me.Text = "frm_productcatalog_a179830"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_catalog As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_choose As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents lst_product As ListBox
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_spec As Label
    Friend WithEvents cmb_spec As ComboBox
    Friend WithEvents lbl_benefit As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_filter As Label
    Friend WithEvents lbl_idvalue As Label
    Friend WithEvents lbl_namevalue As Label
    Friend WithEvents lbl_brandvalue As Label
    Friend WithEvents lbl_benefitvalue As Label
    Friend WithEvents lbl_pricevalue As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
