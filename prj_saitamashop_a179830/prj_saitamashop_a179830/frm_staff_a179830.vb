Public Class frm_staff_a179830

    Dim current_code As String

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs)

        MsgBox("Thank you for purchasing with us :D")
        End

    End Sub

    Private Sub frm_staff_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        refresh_grid()
        get_current_code()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_phone.Text = ""
        txt_position.Text = ""
        txt_salary.Text = ""

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value
        txt_phone.Text = grd_staff(2, current_row).Value
        txt_position.Text = grd_staff(3, current_row).Value
        txt_salary.Text = grd_staff(4, current_row).Value

    End Sub

    Private Sub btn_end_MouseHover(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.Blue

    End Sub

    Private Sub btn_end_MouseLeave(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.White

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_STAFF_A179830 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_phone.Text & ", '" & txt_position.Text & "', '" & txt_salary.Text & "')"
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

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A179830 SET FLD_STAFF_NAME ='" & txt_name.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_STAFF_A179830 SET FLD_PHONE_NUM =" & txt_phone.Text & " WHERE FLD_STAFF_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_STAFF_A179830 SET FLD_POSITION ='" & txt_position.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_STAFF_A179830 SET FLD_SALARY ='" & txt_salary.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A179830 WHERE FLD_STAFF_ID='" & current_code & "'")

            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        txt_id.Clear()
        txt_name.Clear()
        txt_phone.Clear()
        txt_position.Clear()
        txt_salary.Clear()

    End Sub
End Class