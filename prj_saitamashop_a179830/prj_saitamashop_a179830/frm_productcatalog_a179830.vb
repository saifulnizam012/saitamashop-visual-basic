Public Class frm_productcatalog_a179830

    Dim current_code As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_productcatalog_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_type.Items.Add("Weight Bench & Dip Stations")
        cmb_type.Items.Add("Pull Up Bar")
        cmb_type.Items.Add("Resistant Bands")
        cmb_type.Items.Add("Skipping Ropes")
        cmb_type.Items.Add("Push Up Bars & Sit Up Bars")
        cmb_type.Items.Add("Abdominal Trainers")
        cmb_type.Items.Add("Exercise bike & Elliptical")
        cmb_type.Items.Add("Trampoline")
        cmb_type.Items.Add("Kettlebells")
        cmb_type.Items.Add("Dumbbells")
        cmb_type.Items.Add("Barbells")
        cmb_type.Items.Add("Recovery & Support")
        cmb_type.Items.Add("Medicine Balls")
        cmb_type.Items.Add("Apparels")

        cmb_spec.Items.Add("Gym Workout")
        cmb_spec.Items.Add("Home Workout")
        cmb_spec.Items.Add("Gym Workout, Home Workout")

        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        take_value()

    End Sub

    Private Sub refresh_grid(type As String, spec As String)

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * from TBL_PRODUCTS_A179830 where FLD_TYPE = '" & type & "' and FLD_SPECIFICATION = '" & spec & "' and FLD_PRODUCT_NAME like '%" & txt_search.Text & "%'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_NAME"

    End Sub
    Private Sub take_value()

        refresh_grid(cmb_type.Text, cmb_spec.Text)

    End Sub
    Private Sub cmb_spec_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_spec.SelectedIndexChanged

        take_value()

    End Sub
    Private Sub cmb_brand_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_spec.SelectedIndexChanged

        take_value()

    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

        take_value()

    End Sub

    Private Sub refresh_text(product As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A179830 WHERE FLD_PRODUCT_NAME='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_idvalue.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_namevalue.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_pricevalue.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        lbl_brandvalue.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        lbl_benefitvalue.Text = mydatatable.Rows(0).Item("FLD_BENEFITS")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & lbl_idvalue.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick

        refresh_text(lst_product.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub
End Class