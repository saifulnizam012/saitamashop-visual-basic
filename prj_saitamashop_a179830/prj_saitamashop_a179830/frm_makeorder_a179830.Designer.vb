<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a179830
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_pricevalue = New System.Windows.Forms.Label()
        Me.lbl_benefitvalue = New System.Windows.Forms.Label()
        Me.lbl_brandvalue = New System.Windows.Forms.Label()
        Me.lbl_namevalue = New System.Windows.Forms.Label()
        Me.lbl_idvalue = New System.Windows.Forms.Label()
        Me.lbl_filter = New System.Windows.Forms.Label()
        Me.lbl_benefit = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_spec = New System.Windows.Forms.Label()
        Me.cmb_spec = New System.Windows.Forms.ComboBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_choose = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_addtocart = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.grd_newaddtocart = New System.Windows.Forms.DataGridView()
        Me.btn_increase = New System.Windows.Forms.Button()
        Me.btn_decrease = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_totalprice = New System.Windows.Forms.Label()
        Me.cmb_staffid = New System.Windows.Forms.ComboBox()
        Me.cmb_custid = New System.Windows.Forms.ComboBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.btn_orderdetails = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        CType(Me.grd_newaddtocart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pricevalue
        '
        Me.lbl_pricevalue.AutoSize = True
        Me.lbl_pricevalue.BackColor = System.Drawing.Color.Black
        Me.lbl_pricevalue.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pricevalue.ForeColor = System.Drawing.Color.White
        Me.lbl_pricevalue.Location = New System.Drawing.Point(549, 477)
        Me.lbl_pricevalue.Name = "lbl_pricevalue"
        Me.lbl_pricevalue.Size = New System.Drawing.Size(24, 32)
        Me.lbl_pricevalue.TabIndex = 80
        Me.lbl_pricevalue.Text = "-"
        '
        'lbl_benefitvalue
        '
        Me.lbl_benefitvalue.AutoSize = True
        Me.lbl_benefitvalue.BackColor = System.Drawing.Color.Black
        Me.lbl_benefitvalue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_benefitvalue.ForeColor = System.Drawing.Color.White
        Me.lbl_benefitvalue.Location = New System.Drawing.Point(521, 445)
        Me.lbl_benefitvalue.Name = "lbl_benefitvalue"
        Me.lbl_benefitvalue.Size = New System.Drawing.Size(12, 16)
        Me.lbl_benefitvalue.TabIndex = 79
        Me.lbl_benefitvalue.Text = "-"
        '
        'lbl_brandvalue
        '
        Me.lbl_brandvalue.AutoSize = True
        Me.lbl_brandvalue.BackColor = System.Drawing.Color.Black
        Me.lbl_brandvalue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brandvalue.ForeColor = System.Drawing.Color.White
        Me.lbl_brandvalue.Location = New System.Drawing.Point(521, 413)
        Me.lbl_brandvalue.Name = "lbl_brandvalue"
        Me.lbl_brandvalue.Size = New System.Drawing.Size(12, 16)
        Me.lbl_brandvalue.TabIndex = 78
        Me.lbl_brandvalue.Text = "-"
        '
        'lbl_namevalue
        '
        Me.lbl_namevalue.AutoSize = True
        Me.lbl_namevalue.BackColor = System.Drawing.Color.Black
        Me.lbl_namevalue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namevalue.ForeColor = System.Drawing.Color.White
        Me.lbl_namevalue.Location = New System.Drawing.Point(521, 381)
        Me.lbl_namevalue.Name = "lbl_namevalue"
        Me.lbl_namevalue.Size = New System.Drawing.Size(12, 16)
        Me.lbl_namevalue.TabIndex = 77
        Me.lbl_namevalue.Text = "-"
        '
        'lbl_idvalue
        '
        Me.lbl_idvalue.AutoSize = True
        Me.lbl_idvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_idvalue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idvalue.ForeColor = System.Drawing.Color.White
        Me.lbl_idvalue.Location = New System.Drawing.Point(507, 168)
        Me.lbl_idvalue.Name = "lbl_idvalue"
        Me.lbl_idvalue.Size = New System.Drawing.Size(11, 14)
        Me.lbl_idvalue.TabIndex = 76
        Me.lbl_idvalue.Text = "-"
        '
        'lbl_filter
        '
        Me.lbl_filter.AutoSize = True
        Me.lbl_filter.BackColor = System.Drawing.Color.Transparent
        Me.lbl_filter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filter.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_filter.Location = New System.Drawing.Point(216, 165)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(141, 18)
        Me.lbl_filter.TabIndex = 75
        Me.lbl_filter.Text = "Click the box below :-"
        '
        'lbl_benefit
        '
        Me.lbl_benefit.AutoSize = True
        Me.lbl_benefit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_benefit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_benefit.ForeColor = System.Drawing.Color.White
        Me.lbl_benefit.Location = New System.Drawing.Point(467, 445)
        Me.lbl_benefit.Name = "lbl_benefit"
        Me.lbl_benefit.Size = New System.Drawing.Size(57, 15)
        Me.lbl_benefit.TabIndex = 74
        Me.lbl_benefit.Text = "Benefits :"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.Color.White
        Me.lbl_brand.Location = New System.Drawing.Point(477, 413)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(46, 15)
        Me.lbl_brand.TabIndex = 73
        Me.lbl_brand.Text = "Brand :"
        '
        'lbl_spec
        '
        Me.lbl_spec.AutoSize = True
        Me.lbl_spec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_spec.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_spec.ForeColor = System.Drawing.Color.White
        Me.lbl_spec.Location = New System.Drawing.Point(124, 243)
        Me.lbl_spec.Name = "lbl_spec"
        Me.lbl_spec.Size = New System.Drawing.Size(93, 14)
        Me.lbl_spec.TabIndex = 72
        Me.lbl_spec.Text = "* Specification :"
        '
        'cmb_spec
        '
        Me.cmb_spec.FormattingEnabled = True
        Me.cmb_spec.Location = New System.Drawing.Point(219, 240)
        Me.cmb_spec.Name = "cmb_spec"
        Me.cmb_spec.Size = New System.Drawing.Size(160, 21)
        Me.cmb_spec.TabIndex = 71
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.Color.White
        Me.lbl_type.Location = New System.Drawing.Point(161, 219)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(50, 14)
        Me.lbl_type.TabIndex = 70
        Me.lbl_type.Text = "* Type :"
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(219, 216)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(160, 21)
        Me.cmb_type.TabIndex = 69
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(130, 325)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(262, 199)
        Me.lst_product.TabIndex = 68
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_search.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.ForeColor = System.Drawing.Color.White
        Me.lbl_search.Location = New System.Drawing.Point(80, 270)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(137, 28)
        Me.lbl_search.TabIndex = 67
        Me.lbl_search.Text = "Search product name   :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(within category above) "
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(219, 267)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(160, 20)
        Me.txt_search.TabIndex = 66
        '
        'lbl_choose
        '
        Me.lbl_choose.AutoSize = True
        Me.lbl_choose.BackColor = System.Drawing.Color.Transparent
        Me.lbl_choose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_choose.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_choose.Location = New System.Drawing.Point(127, 306)
        Me.lbl_choose.Name = "lbl_choose"
        Me.lbl_choose.Size = New System.Drawing.Size(265, 16)
        Me.lbl_choose.TabIndex = 65
        Me.lbl_choose.Text = "Choose any product by click the list below :-"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(24, 25)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(34, 23)
        Me.btn_back.TabIndex = 64
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(479, 477)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(64, 15)
        Me.lbl_price.TabIndex = 63
        Me.lbl_price.Text = "Price : RM"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(437, 381)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(92, 15)
        Me.lbl_name.TabIndex = 62
        Me.lbl_name.Text = "Product Name :"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(437, 168)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(64, 13)
        Me.lbl_id.TabIndex = 61
        Me.lbl_id.Text = "Product ID :"
        '
        'lbl_addtocart
        '
        Me.lbl_addtocart.AutoSize = True
        Me.lbl_addtocart.BackColor = System.Drawing.Color.Maroon
        Me.lbl_addtocart.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addtocart.ForeColor = System.Drawing.Color.White
        Me.lbl_addtocart.Location = New System.Drawing.Point(135, 25)
        Me.lbl_addtocart.Name = "lbl_addtocart"
        Me.lbl_addtocart.Size = New System.Drawing.Size(239, 36)
        Me.lbl_addtocart.TabIndex = 59
        Me.lbl_addtocart.Text = "MAKE ORDER"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.White
        Me.lbl_quantity.Location = New System.Drawing.Point(135, 539)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(64, 13)
        Me.lbl_quantity.TabIndex = 83
        Me.lbl_quantity.Text = "* Quantity :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(241, 539)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(51, 20)
        Me.txt_quantity.TabIndex = 84
        Me.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_addtocart.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.Location = New System.Drawing.Point(230, 682)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(82, 32)
        Me.btn_addtocart.TabIndex = 85
        Me.btn_addtocart.Text = "Add To Cart"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.White
        Me.lbl_orderid.Location = New System.Drawing.Point(148, 194)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(69, 14)
        Me.lbl_orderid.TabIndex = 88
        Me.lbl_orderid.Text = "*Order ID :"
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(219, 191)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Size = New System.Drawing.Size(160, 20)
        Me.txt_orderid.TabIndex = 89
        '
        'btn_checkout
        '
        Me.btn_checkout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_checkout.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.Location = New System.Drawing.Point(510, 715)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(74, 34)
        Me.btn_checkout.TabIndex = 90
        Me.btn_checkout.Text = "Checkout"
        Me.btn_checkout.UseVisualStyleBackColor = False
        '
        'grd_newaddtocart
        '
        Me.grd_newaddtocart.AllowUserToAddRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grd_newaddtocart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grd_newaddtocart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_newaddtocart.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_newaddtocart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grd_newaddtocart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_newaddtocart.DefaultCellStyle = DataGridViewCellStyle8
        Me.grd_newaddtocart.Location = New System.Drawing.Point(130, 581)
        Me.grd_newaddtocart.Name = "grd_newaddtocart"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_newaddtocart.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grd_newaddtocart.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.grd_newaddtocart.Size = New System.Drawing.Size(571, 85)
        Me.grd_newaddtocart.TabIndex = 91
        '
        'btn_increase
        '
        Me.btn_increase.BackColor = System.Drawing.Color.White
        Me.btn_increase.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_increase.Location = New System.Drawing.Point(298, 537)
        Me.btn_increase.Name = "btn_increase"
        Me.btn_increase.Size = New System.Drawing.Size(34, 23)
        Me.btn_increase.TabIndex = 92
        Me.btn_increase.Text = "+"
        Me.btn_increase.UseVisualStyleBackColor = False
        '
        'btn_decrease
        '
        Me.btn_decrease.BackColor = System.Drawing.Color.White
        Me.btn_decrease.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decrease.Location = New System.Drawing.Point(205, 536)
        Me.btn_decrease.Name = "btn_decrease"
        Me.btn_decrease.Size = New System.Drawing.Size(30, 23)
        Me.btn_decrease.TabIndex = 93
        Me.btn_decrease.Text = "-"
        Me.btn_decrease.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.Coral
        Me.btn_remove.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.Location = New System.Drawing.Point(334, 683)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(76, 31)
        Me.btn_remove.TabIndex = 94
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(625, 685)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(21, 29)
        Me.lbl_total.TabIndex = 95
        Me.lbl_total.Text = "-"
        '
        'lbl_totalprice
        '
        Me.lbl_totalprice.AutoSize = True
        Me.lbl_totalprice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalprice.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalprice.ForeColor = System.Drawing.Color.White
        Me.lbl_totalprice.Location = New System.Drawing.Point(507, 690)
        Me.lbl_totalprice.Name = "lbl_totalprice"
        Me.lbl_totalprice.Size = New System.Drawing.Size(112, 15)
        Me.lbl_totalprice.TabIndex = 96
        Me.lbl_totalprice.Text = "Total Price : RM"
        '
        'cmb_staffid
        '
        Me.cmb_staffid.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staffid.FormattingEnabled = True
        Me.cmb_staffid.Location = New System.Drawing.Point(141, 102)
        Me.cmb_staffid.Name = "cmb_staffid"
        Me.cmb_staffid.Size = New System.Drawing.Size(121, 21)
        Me.cmb_staffid.TabIndex = 97
        '
        'cmb_custid
        '
        Me.cmb_custid.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_custid.FormattingEnabled = True
        Me.cmb_custid.Location = New System.Drawing.Point(289, 102)
        Me.cmb_custid.Name = "cmb_custid"
        Me.cmb_custid.Size = New System.Drawing.Size(121, 21)
        Me.cmb_custid.TabIndex = 98
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.White
        Me.lbl_staffid.Location = New System.Drawing.Point(140, 86)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(48, 13)
        Me.lbl_staffid.TabIndex = 99
        Me.lbl_staffid.Text = "Staff ID :"
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_custid.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.ForeColor = System.Drawing.Color.White
        Me.lbl_custid.Location = New System.Drawing.Point(286, 86)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(76, 13)
        Me.lbl_custid.TabIndex = 100
        Me.lbl_custid.Text = "Customer ID :"
        '
        'btn_orderdetails
        '
        Me.btn_orderdetails.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_orderdetails.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdetails.Location = New System.Drawing.Point(608, 93)
        Me.btn_orderdetails.Name = "btn_orderdetails"
        Me.btn_orderdetails.Size = New System.Drawing.Size(87, 39)
        Me.btn_orderdetails.TabIndex = 102
        Me.btn_orderdetails.Text = "Add Order Details"
        Me.btn_orderdetails.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(437, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Date :"
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(440, 103)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(130, 20)
        Me.txt_date.TabIndex = 104
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.GYM_LOGO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(917, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 69)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(440, 191)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(187, 164)
        Me.pic_product.TabIndex = 60
        Me.pic_product.TabStop = False
        '
        'frm_makeorder_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources._92_929835_gym_wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 761)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_orderdetails)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.cmb_custid)
        Me.Controls.Add(Me.cmb_staffid)
        Me.Controls.Add(Me.lbl_totalprice)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_decrease)
        Me.Controls.Add(Me.btn_increase)
        Me.Controls.Add(Me.grd_newaddtocart)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.btn_addtocart)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_quantity)
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
        Me.Controls.Add(Me.lbl_addtocart)
        Me.Name = "frm_makeorder_a179830"
        Me.Text = "frm_makeorder_a179830"
        CType(Me.grd_newaddtocart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_pricevalue As Label
    Friend WithEvents lbl_benefitvalue As Label
    Friend WithEvents lbl_brandvalue As Label
    Friend WithEvents lbl_namevalue As Label
    Friend WithEvents lbl_idvalue As Label
    Friend WithEvents lbl_filter As Label
    Friend WithEvents lbl_benefit As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_spec As Label
    Friend WithEvents cmb_spec As ComboBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lst_product As ListBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_choose As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_addtocart As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents btn_addtocart As Button
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents btn_checkout As Button
    Friend WithEvents grd_newaddtocart As DataGridView
    Friend WithEvents btn_increase As Button
    Friend WithEvents btn_decrease As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents cmb_staffid As ComboBox
    Friend WithEvents cmb_custid As ComboBox
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_custid As Label
    Friend WithEvents btn_orderdetails As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_date As TextBox
End Class
