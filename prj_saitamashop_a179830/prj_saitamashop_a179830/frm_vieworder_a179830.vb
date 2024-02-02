Public Class frm_vieworder_a179830
    Private Sub frm_vieworder_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub
    Private Sub refresh_grid()

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A179830 "
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_orderid.DataSource = mydatatable
        cmb_orderid.DisplayMember = "FLD_ORDER_ID"

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub


    Private Sub cmb_orderid_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_orderid.MouseClick

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A179830 WHERE FLD_ORDER_ID = '" & cmb_orderid.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lbl_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        lbl_custid.Text = mydatatable.Rows(0).Item("FLD_CUST_ID")
        lbl_dating.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")

        grd_invois.DataSource = run_sql_query("SELECT TBL_PRODUCTS_A179830.FLD_PRODUCT_NAME AS [Order Details], TBL_DETAILS_A179830.FLD_QUANTITY AS Quantity, TBL_PRODUCTS_A179830.FLD_PRICE AS [Price Per Unit], [FLD_QUANTITY]*[FLD_PRICE] AS [Total Price]
FROM TBL_PRODUCTS_A179830 INNER JOIN TBL_DETAILS_A179830 ON TBL_PRODUCTS_A179830.FLD_PRODUCT_ID = TBL_DETAILS_A179830.FLD_PRODUCT_ID WHERE FLD_ORDER_ID = '" & cmb_orderid.Text & "'")

        Dim total As Double = 0
        For Each row As DataGridViewRow In grd_invois.Rows
            total = total + row.Cells(3).Value
        Next
        lbl_grossprice.Text = total

        If (total > 1000) Then
            Dim discount As Double = 0
            discount = total * 10 / 100
            lbl_discount.Text = discount
            Dim netprice As Double = 0
            netprice = total - discount
            lbl_netprice.Text = netprice

        Else
            Dim netprice As Double = 0
            netprice = total
            lbl_netprice.Text = netprice
        End If

    End Sub

    Private Sub lbl_grossprice_Click(sender As Object, e As EventArgs) Handles lbl_grossprice.Click

    End Sub
End Class