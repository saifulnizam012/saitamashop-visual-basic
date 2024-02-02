Public Class frm_productlist_a179830
    Private Sub frm_productlist_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable

        grd_product.Columns(0).HeaderText = "Product Code"
        grd_product.Columns(1).HeaderText = "Product Name"
        grd_product.Columns(2).HeaderText = "Price"
        grd_product.Columns(3).HeaderText = "Brand"
        grd_product.Columns(4).HeaderText = "Product Type"
        grd_product.Columns(5).HeaderText = "Product Benefits"
        grd_product.Columns(6).HeaderText = "Specification"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub
End Class