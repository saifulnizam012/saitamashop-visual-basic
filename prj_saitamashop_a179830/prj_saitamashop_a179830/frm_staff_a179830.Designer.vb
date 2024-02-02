<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_staff_a179830
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
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.lbl_salary = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.txt_salary = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(35, 23)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "<<<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grd_staff.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_staff.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_staff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_staff.DefaultCellStyle = DataGridViewCellStyle3
        Me.grd_staff.Location = New System.Drawing.Point(91, 73)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.RowHeadersWidth = 30
        Me.grd_staff.Size = New System.Drawing.Size(288, 267)
        Me.grd_staff.TabIndex = 4
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Poor Richard", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(97, 34)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(107, 36)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "STAFF "
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Cyan
        Me.btn_insert.Location = New System.Drawing.Point(518, 263)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(85, 33)
        Me.btn_insert.TabIndex = 10
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_update.Location = New System.Drawing.Point(566, 302)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(90, 39)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Location = New System.Drawing.Point(662, 302)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(81, 39)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(464, 86)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(64, 19)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Text = "Staff ID :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(443, 118)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(85, 19)
        Me.lbl_name.TabIndex = 14
        Me.lbl_name.Text = "Staff Name :"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.ForeColor = System.Drawing.Color.White
        Me.lbl_phone.Location = New System.Drawing.Point(420, 150)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(108, 19)
        Me.lbl_phone.TabIndex = 15
        Me.lbl_phone.Text = "Phone Number :"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.BackColor = System.Drawing.Color.Black
        Me.lbl_position.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.ForeColor = System.Drawing.Color.White
        Me.lbl_position.Location = New System.Drawing.Point(464, 182)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(64, 19)
        Me.lbl_position.TabIndex = 16
        Me.lbl_position.Text = "Position :"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.BackColor = System.Drawing.Color.Transparent
        Me.lbl_salary.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salary.ForeColor = System.Drawing.Color.White
        Me.lbl_salary.Location = New System.Drawing.Point(474, 210)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(54, 19)
        Me.lbl_salary.TabIndex = 17
        Me.lbl_salary.Text = "Salary :"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(534, 82)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(227, 24)
        Me.txt_id.TabIndex = 18
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(534, 114)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(227, 24)
        Me.txt_name.TabIndex = 19
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(534, 146)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(227, 24)
        Me.txt_phone.TabIndex = 20
        '
        'txt_position
        '
        Me.txt_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_position.Location = New System.Drawing.Point(534, 178)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(227, 24)
        Me.txt_position.TabIndex = 21
        '
        'txt_salary
        '
        Me.txt_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salary.Location = New System.Drawing.Point(534, 210)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.Size = New System.Drawing.Size(227, 24)
        Me.txt_salary.TabIndex = 22
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_clear.Location = New System.Drawing.Point(609, 263)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(81, 33)
        Me.btn_clear.TabIndex = 23
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(563, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "*Click the clear button to insert the new data."
        '
        'frm_staff_a179830
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_saitamashop_a179830.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_salary)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_salary)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_staff_a179830"
        Me.Text = "frm_staff_a179830"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_position As Label
    Friend WithEvents lbl_salary As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_position As TextBox
    Friend WithEvents txt_salary As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
End Class
