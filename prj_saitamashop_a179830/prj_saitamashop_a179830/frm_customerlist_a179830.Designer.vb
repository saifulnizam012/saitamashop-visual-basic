<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerlist_a179830
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_customer = New System.Windows.Forms.Label()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(8, 12)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(37, 23)
        Me.btn_back.TabIndex = 8
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grd_customer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.Color.White
        Me.grd_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_customer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_customer.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_customer.Location = New System.Drawing.Point(80, 80)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 30
        Me.grd_customer.Size = New System.Drawing.Size(620, 329)
        Me.grd_customer.TabIndex = 7
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_customer.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_customer.Location = New System.Drawing.Point(83, 32)
        Me.lbl_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(278, 36)
        Me.lbl_customer.TabIndex = 6
        Me.lbl_customer.Text = "CUSTOMER LIST"
        '
        'frm_customerlist_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.gym_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_customer)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm_customerlist_a179830"
        Me.Text = "frm_customerlist_a179830"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_customer As Label
End Class
