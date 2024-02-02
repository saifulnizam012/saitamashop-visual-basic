<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a179830
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.lbl_title3 = New System.Windows.Forms.Label()
        Me.lbl_title4 = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_cust = New System.Windows.Forms.Label()
        Me.cmb_orderid = New System.Windows.Forms.ComboBox()
        Me.grd_invois = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.lbl_dating = New System.Windows.Forms.Label()
        Me.lbl_grossprice = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_netprice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_invois, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(307, 16)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(114, 33)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "INVOIS"
        '
        'lbl_title2
        '
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(200, 183)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(329, 33)
        Me.lbl_title2.TabIndex = 1
        Me.lbl_title2.Text = "Saitama Shop Sdn. Bhd."
        '
        'lbl_title3
        '
        Me.lbl_title3.AutoSize = True
        Me.lbl_title3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title3.ForeColor = System.Drawing.Color.White
        Me.lbl_title3.Location = New System.Drawing.Point(288, 233)
        Me.lbl_title3.Name = "lbl_title3"
        Me.lbl_title3.Size = New System.Drawing.Size(157, 39)
        Me.lbl_title3.TabIndex = 2
        Me.lbl_title3.Text = "LOT 1883, JALAN BAHAGIA ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   KG LABOHAN DAGANG ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "42700 BANTING, SELANGOR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_title4
        '
        Me.lbl_title4.AutoSize = True
        Me.lbl_title4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title4.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title4.ForeColor = System.Drawing.Color.White
        Me.lbl_title4.Location = New System.Drawing.Point(267, 281)
        Me.lbl_title4.Name = "lbl_title4"
        Me.lbl_title4.Size = New System.Drawing.Size(197, 26)
        Me.lbl_title4.TabIndex = 3
        Me.lbl_title4.Text = "Tel : 012-7362987  Faks : 089-2617283" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    E-mel : saitamashop@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.ForeColor = System.Drawing.Color.White
        Me.lbl_order.Location = New System.Drawing.Point(501, 29)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(69, 16)
        Me.lbl_order.TabIndex = 85
        Me.lbl_order.Text = "Order ID : "
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(464, 356)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(45, 16)
        Me.lbl_date.TabIndex = 86
        Me.lbl_date.Text = "Date : "
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(12, 16)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(35, 23)
        Me.btn_back.TabIndex = 87
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.ForeColor = System.Drawing.Color.White
        Me.lbl_staff.Location = New System.Drawing.Point(73, 354)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(60, 16)
        Me.lbl_staff.TabIndex = 90
        Me.lbl_staff.Text = "Staff ID : "
        '
        'lbl_cust
        '
        Me.lbl_cust.AutoSize = True
        Me.lbl_cust.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cust.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust.ForeColor = System.Drawing.Color.White
        Me.lbl_cust.Location = New System.Drawing.Point(251, 354)
        Me.lbl_cust.Name = "lbl_cust"
        Me.lbl_cust.Size = New System.Drawing.Size(91, 16)
        Me.lbl_cust.TabIndex = 92
        Me.lbl_cust.Text = "Customer ID : "
        '
        'cmb_orderid
        '
        Me.cmb_orderid.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_orderid.FormattingEnabled = True
        Me.cmb_orderid.Location = New System.Drawing.Point(574, 26)
        Me.cmb_orderid.Name = "cmb_orderid"
        Me.cmb_orderid.Size = New System.Drawing.Size(121, 24)
        Me.cmb_orderid.TabIndex = 94
        '
        'grd_invois
        '
        Me.grd_invois.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grd_invois.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_invois.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_invois.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.grd_invois.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_invois.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_invois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_invois.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_invois.Location = New System.Drawing.Point(76, 390)
        Me.grd_invois.Name = "grd_invois"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_invois.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grd_invois.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grd_invois.Size = New System.Drawing.Size(588, 224)
        Me.grd_invois.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 627)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Gross Price : RM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 655)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "10% Discount : RM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(464, 687)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Net Price : RM"
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.White
        Me.lbl_staffid.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(139, 354)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(27, 19)
        Me.lbl_staffid.TabIndex = 105
        Me.lbl_staffid.Text = "---"
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.BackColor = System.Drawing.Color.White
        Me.lbl_custid.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.Location = New System.Drawing.Point(348, 354)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(27, 19)
        Me.lbl_custid.TabIndex = 106
        Me.lbl_custid.Text = "---"
        '
        'lbl_dating
        '
        Me.lbl_dating.AutoSize = True
        Me.lbl_dating.BackColor = System.Drawing.Color.White
        Me.lbl_dating.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dating.Location = New System.Drawing.Point(515, 354)
        Me.lbl_dating.Name = "lbl_dating"
        Me.lbl_dating.Size = New System.Drawing.Size(27, 19)
        Me.lbl_dating.TabIndex = 107
        Me.lbl_dating.Text = "---"
        '
        'lbl_grossprice
        '
        Me.lbl_grossprice.AutoSize = True
        Me.lbl_grossprice.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grossprice.Location = New System.Drawing.Point(559, 627)
        Me.lbl_grossprice.Name = "lbl_grossprice"
        Me.lbl_grossprice.Size = New System.Drawing.Size(27, 19)
        Me.lbl_grossprice.TabIndex = 108
        Me.lbl_grossprice.Text = "---"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.Location = New System.Drawing.Point(559, 655)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(27, 19)
        Me.lbl_discount.TabIndex = 109
        Me.lbl_discount.Text = "---"
        '
        'lbl_netprice
        '
        Me.lbl_netprice.AutoSize = True
        Me.lbl_netprice.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_netprice.Location = New System.Drawing.Point(555, 687)
        Me.lbl_netprice.Name = "lbl_netprice"
        Me.lbl_netprice.Size = New System.Drawing.Size(39, 27)
        Me.lbl_netprice.TabIndex = 110
        Me.lbl_netprice.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(73, 627)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "*Discount 10% for purchase over RM1000.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.GYM_LOGO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(265, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 128)
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'frm_vieworder_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.gymbesi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(727, 752)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_netprice)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.lbl_grossprice)
        Me.Controls.Add(Me.lbl_dating)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_invois)
        Me.Controls.Add(Me.cmb_orderid)
        Me.Controls.Add(Me.lbl_cust)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_title4)
        Me.Controls.Add(Me.lbl_title3)
        Me.Controls.Add(Me.lbl_title2)
        Me.Controls.Add(Me.lbl_title)
        Me.DoubleBuffered = True
        Me.Name = "frm_vieworder_a179830"
        Me.Text = "frm_vieworder_a179830"
        CType(Me.grd_invois, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_title2 As Label
    Friend WithEvents lbl_title3 As Label
    Friend WithEvents lbl_title4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_order As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_staff As Label
    Friend WithEvents lbl_cust As Label
    Friend WithEvents cmb_orderid As ComboBox
    Friend WithEvents grd_invois As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_custid As Label
    Friend WithEvents lbl_dating As Label
    Friend WithEvents lbl_grossprice As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents lbl_netprice As Label
    Friend WithEvents Label4 As Label
End Class
