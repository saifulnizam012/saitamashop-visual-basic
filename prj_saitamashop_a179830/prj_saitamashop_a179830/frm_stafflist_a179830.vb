Public Class frm_stafflist_a179830
    Private Sub frm_stafflist_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Phone Number"
        grd_staff.Columns(3).HeaderText = "Position"
        grd_staff.Columns(4).HeaderText = "Salary"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub
End Class