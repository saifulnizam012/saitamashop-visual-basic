Public Class frm_order_a179830
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs)

        MsgBox("Thank you for purchasing with us :D")
        End

    End Sub

    Private Sub frm_order_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(1).HeaderText = "Staff ID"
        grd_order.Columns(2).HeaderText = "Customer ID"
        grd_order.Columns(3).HeaderText = "Order Date"

    End Sub

    Private Sub btn_back_MouseHover(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.Blue

    End Sub

    Private Sub btn_back_MouseLeave(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.White

    End Sub
End Class