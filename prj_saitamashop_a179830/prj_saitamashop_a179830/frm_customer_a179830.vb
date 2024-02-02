Public Class frm_customer_a179830

    Dim current_code As String

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs)

        MsgBox("Thank you for purchasing with us :D")
        End

    End Sub

    Private Sub frm_customer_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Phone Number"
        grd_customer.Columns(3).HeaderText = "Address"

        refresh_grid()
        get_current_code()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_phone.Text = ""
        txt_address.Text = ""

    End Sub
    Private Sub get_current_code()

        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_customer(1, current_row).Value
        txt_phone.Text = grd_customer(2, current_row).Value
        txt_address.Text = grd_customer(3, current_row).Value

    End Sub

    Private Sub btn_back_MouseHover(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.Blue

    End Sub

    Private Sub btn_back_MouseLeave(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.White

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A179830 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_phone.Text & ", '" & txt_address.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub
    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A179830 SET FLD_CUST_NAME ='" & txt_name.Text & "' WHERE FLD_CUST_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A179830 SET FLD_PHONE_NUM =" & txt_phone.Text & " WHERE FLD_CUST_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A179830 SET FLD_ADDRESS ='" & txt_address.Text & "' WHERE FLD_CUST_ID ='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the customer """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A179830 WHERE FLD_CUST_ID='" & current_code & "'")

            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        txt_id.Clear()
        txt_name.Clear()
        txt_phone.Clear()
        txt_address.Clear()

    End Sub
End Class