Public Class frm_makeorder_a179830

    Dim current_code As String
    'untuk update quantity
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_addtocart_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_date.Text = DateTime.Now.ToString("dd/MM/yyyy")

        txt_orderid.Text = generate_orderid()
        txt_quantity.Text = 1

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

        'problem
        'cmb_staffid.Items.Add("S101")
        'cmb_staffid.Items.Add("S102")
        'cmb_staffid.Items.Add("S103")
        'cmb_staffid.Items.Add("S104")

        'problem
        'cmb_custid.Items.Add("C201")
        'cmb_custid.Items.Add("C202")
        'cmb_custid.Items.Add("C203")

        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        take_value()

        grd_newaddtocart.ColumnCount = 5
        grd_newaddtocart.Columns(0).HeaderText = "Order ID"
        grd_newaddtocart.Columns(1).HeaderText = "Product ID"
        grd_newaddtocart.Columns(2).HeaderText = "Quantity"
        grd_newaddtocart.Columns(3).HeaderText = "Price Per Unit"
        grd_newaddtocart.Columns(4).HeaderText = "Total Price"

    End Sub
    Private Function generate_orderid() As String
        Dim lastorderid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTORDERID FROM TBL_ORDER_A179830").Rows(0).Item("LASTORDERID")
        Dim neworderid As String = "R" & Mid(lastorderid, 2) + 1
        Return neworderid
    End Function

    Private Sub refresh_grid(type As String, spec As String, staffid As String, custid As String)

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_SAITAMASHOP_A179830.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * from TBL_PRODUCTS_A179830 where FLD_TYPE = '" & type & "' and FLD_SPECIFICATION = '" & spec & "' and FLD_PRODUCT_NAME like '%" & txt_search.Text & "%'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_NAME"

    End Sub
    Private Sub take_value()

        refresh_grid(cmb_type.Text, cmb_spec.Text, cmb_staffid.Text, cmb_custid.Text)

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
    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click

        Try
            Dim found As Boolean = False

            For Each row As DataGridViewRow In grd_newaddtocart.Rows
                If row.Cells(1).Value = lbl_idvalue.Text Then
                    row.Cells(2).Value = Int32.Parse(txt_quantity.Text) + row.Cells(2).Value
                    row.Cells(4).Value = row.Cells(2).Value * row.Cells(3).Value
                    found = True
                End If
            Next

            If found = False Then
                grd_newaddtocart.RowCount = grd_newaddtocart.RowCount + 1

                Dim i As Integer = grd_newaddtocart.RowCount - 1
                grd_newaddtocart(0, i).Value = txt_orderid.Text
                grd_newaddtocart(1, i).Value = lbl_idvalue.Text
                grd_newaddtocart(2, i).Value = Int32.Parse(txt_quantity.Text)
                grd_newaddtocart(3, i).Value = Int32.Parse(lbl_pricevalue.Text)

                Dim a1 As Double = grd_newaddtocart.Rows(i).Cells(2).Value
                Dim b1 As Double = grd_newaddtocart.Rows(i).Cells(3).Value
                Dim c1 As Double = a1 * b1
                grd_newaddtocart(4, i).Value = c1

                Dim a2 As Double = grd_newaddtocart.Rows(i).Cells(4).Value

            End If
            Dim total As Double = 0
            For Each row As DataGridViewRow In grd_newaddtocart.Rows
                total = total + row.Cells(4).Value
                lbl_total.Text = total
            Next


        Catch ex As Exception

            Beep()
            MsgBox("Order cannot add to cart")

            For i As Integer = 0 To grd_newaddtocart.RowCount - 1
                'Dim index As Integer
                'i = grd_newaddtocart.CurrentCell.RowIndex
                grd_newaddtocart.Rows.RemoveAt(i)
            Next

        End Try

    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try
            For i As Integer = 0 To grd_newaddtocart.RowCount - 1

                Dim orderID As String = grd_newaddtocart(0, i).Value
                Dim productID As String = grd_newaddtocart(1, i).Value
                Dim quantity As String = grd_newaddtocart(2, i).Value

                Dim mysql As String = "INSERT INTO TBL_DETAILS_A179830 VALUES ('" & orderID & "', '" & productID & "', '" & quantity & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()

            Next

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Checkout successful!")
            take_value()
            grd_newaddtocart.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with checkout:" & vbCrLf & vbCrLf & ex.Message)

            mytransaction.Rollback()
            myconnection2.Close()

            take_value()

        End Try

        clear_fieldsss()

    End Sub
    Private Sub clear_fieldsss()
        lbl_total.Text = ""
    End Sub
    Private Sub clear_fields()

        Dim total As Double = 0
        For Each row As DataGridViewRow In grd_newaddtocart.Rows
            total = total + row.Cells(4).Value
            lbl_total.Text = total
        Next

    End Sub

    Private Sub btn_decrease_Click(sender As Object, e As EventArgs) Handles btn_decrease.Click

        txt_quantity.Text = txt_quantity.Text - 1

    End Sub

    Private Sub btn_increase_Click(sender As Object, e As EventArgs) Handles btn_increase.Click

        txt_quantity.Text = txt_quantity.Text + 1

    End Sub
    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click

        If grd_newaddtocart.RowCount = 0 Then
            MsgBox("No item selected")
            Return
        Else
            Dim delete_confirmation = MsgBox("Are you sure you would like to delete the order """ & current_code & "?", MsgBoxStyle.YesNo)
            If delete_confirmation = MsgBoxResult.Yes Then
                Dim index As Integer
                index = grd_newaddtocart.CurrentCell.RowIndex
                grd_newaddtocart.Rows.RemoveAt(index)

                clear_fields()
            End If
        End If

    End Sub
    Private Sub btn_orderdetails_Click(sender As Object, e As EventArgs) Handles btn_orderdetails.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try

            Dim orderID As String = txt_orderid.Text
            Dim staffID As String = cmb_staffid.Text
            Dim custID As String = cmb_custid.Text
            Dim orderdate As Date = txt_date.Text

            Dim mysql As String = "INSERT INTO TBL_ORDER_A179830 VALUES ('" & orderID & "', '" & staffID & "', '" & custID & "', '" & orderdate & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
            mywriter.ExecuteNonQuery()

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Order add successful!")
            take_value()
            grd_newaddtocart.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with order details:" & vbCrLf & vbCrLf & ex.Message)

            mytransaction.Rollback()
            myconnection2.Close()

            take_value()

        End Try

    End Sub

    Private Sub cmb_staffid_MouseClick(sender As Object, e As EventArgs) Handles cmb_staffid.MouseClick

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_staffid.DataSource = mydatatable
        cmb_staffid.DisplayMember = "FLD_STAFF_ID"

        'take_value()

    End Sub

    Private Sub cmb_custid_MouseClick(sender As Object, e As EventArgs) Handles cmb_custid.MouseClick

        Dim mysql As String = "SELECT FLD_CUST_ID FROM TBL_CUSTOMER_A179830"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_custid.DataSource = mydatatable
        cmb_custid.DisplayMember = "FLD_CUST_ID"

        'take_value()

    End Sub

    Private Sub cmb_custid_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_custid.MouseClick

    End Sub
End Class