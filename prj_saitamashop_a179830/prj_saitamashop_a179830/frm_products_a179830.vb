Public Class frm_products_a179830

    Dim current_code As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs)

        MsgBox("Thank you for purchasing with us :D")
        End

    End Sub

    Private Sub frm_products_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        txt_picture.Text = defaultpicture
        pic_student.BackgroundImage = Image.FromFile(defaultpicture)

        refresh_grid()
        get_current_code()

    End Sub
    Private Sub refresh_text(product As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A179830 WHERE FLD_PRODUCT_ID='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_benefit.Text = mydatatable.Rows(0).Item("FLD_BENEFITS")
        txt_spec.Text = mydatatable.Rows(0).Item("FLD_SPECIFICATION")

        Try
            pic_student.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_student.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_benefit.Text = ""
        txt_spec.Text = ""

    End Sub
    Private Sub get_current_code()

        Dim current_row As Integer = grd_product.CurrentRow.Index
        current_code = grd_product(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value
        txt_type.Text = grd_product(4, current_row).Value
        txt_benefit.Text = grd_product(5, current_row).Value
        txt_spec.Text = grd_product(6, current_row).Value

        Try
            pic_student.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_student.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub btn_end_MouseHover(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.Blue

    End Sub

    Private Sub btn_end_MouseLeave(sender As Object, e As EventArgs)

        btn_back.BackColor = Color.White

    End Sub
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A179830 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_price.Text & ", '" & txt_brand.Text & "', '" & txt_type.Text & "', '" & txt_benefit.Text & "', '" & txt_spec.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            refresh_grid()
            clear_fields()

            txt_picture.Text = defaultpicture
            pic_student.BackgroundImage = Image.FromFile(defaultpicture)

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCTS_A179830 SET FLD_PRODUCT_NAME ='" & txt_name.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A179830 SET FLD_PRICE =" & txt_price.Text & " WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A179830 SET FLD_BRAND ='" & txt_brand.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A179830 SET FLD_TYPE ='" & txt_type.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A179830 SET FLD_BENEFITS ='" & txt_benefit.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A179830 SET FLD_SPECIFICATION = '" & txt_spec.Text & "' WHERE FLD_PRODUCT_ID ='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        txt_id.Clear()
        txt_name.Clear()
        txt_price.Clear()
        txt_brand.Clear()
        txt_type.Clear()
        txt_benefit.Clear()
        txt_spec.Clear()
        txt_picture.Clear()

    End Sub
    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick

        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A179830 WHERE FLD_PRODUCT_ID='" & current_code & "'")

            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_student.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub
End Class