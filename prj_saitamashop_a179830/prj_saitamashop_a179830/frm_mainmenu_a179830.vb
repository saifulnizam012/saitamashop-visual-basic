Public Class frm_mainmenu_a179830
    Private Sub btn_products_MouseHover(sender As Object, e As EventArgs) Handles btn_products.MouseHover

        btn_products.BackColor = Color.Green

    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click

        frm_products_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click

        frm_customer_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

        frm_order_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        frm_staff_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click

        frm_orderdetails_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub frm_mainmenu_a179830_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

        lbl_welcome.Text = "Hi " & username & ",welcome to the main menu"

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click

        MsgBox("Thank you for purchasing with us :D")

        End

    End Sub

    Private Sub btn_products_MouseLeave(sender As Object, e As EventArgs) Handles btn_products.MouseLeave

        btn_products.BackColor = Color.White

    End Sub

    Private Sub btn_customer_MouseHover(sender As Object, e As EventArgs) Handles btn_customer.MouseHover

        btn_customer.BackColor = Color.Green

    End Sub

    Private Sub btn_customer_MouseLeave(sender As Object, e As EventArgs) Handles btn_customer.MouseLeave

        btn_customer.BackColor = Color.White

    End Sub

    Private Sub btn_order_MouseHover(sender As Object, e As EventArgs) Handles btn_order.MouseHover

        btn_order.BackColor = Color.Green

    End Sub

    Private Sub btn_order_MouseLeave(sender As Object, e As EventArgs) Handles btn_order.MouseLeave

        btn_order.BackColor = Color.White

    End Sub

    Private Sub btn_staff_MouseHover(sender As Object, e As EventArgs) Handles btn_staff.MouseHover

        btn_staff.BackColor = Color.Green

    End Sub

    Private Sub btn_staff_MouseLeave(sender As Object, e As EventArgs) Handles btn_staff.MouseLeave

        btn_staff.BackColor = Color.White

    End Sub

    Private Sub btn_details_MouseHover(sender As Object, e As EventArgs) Handles btn_details.MouseHover

        btn_details.BackColor = Color.Green

    End Sub

    Private Sub btn_details_MouseLeave(sender As Object, e As EventArgs) Handles btn_details.MouseLeave

        btn_details.BackColor = Color.White

    End Sub

    Private Sub btn_end_MouseHover(sender As Object, e As EventArgs) Handles btn_end.MouseHover

        btn_end.BackColor = Color.Red

    End Sub

    Private Sub btn_end_MouseLeave(sender As Object, e As EventArgs) Handles btn_end.MouseLeave

        btn_end.BackColor = Color.Yellow

    End Sub

    Private Sub btn_productlist_Click(sender As Object, e As EventArgs) Handles btn_productcatalog.Click

        frm_productcatalog_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_productcatalog_MouseHover(sender As Object, e As EventArgs) Handles btn_productcatalog.MouseHover

        btn_productcatalog.BackColor = Color.Green

    End Sub

    Private Sub btn_productcatalog_MouseLeave(sender As Object, e As EventArgs) Handles btn_productcatalog.MouseLeave

        btn_productcatalog.BackColor = Color.White

    End Sub

    Private Sub btn_productlist_Click_1(sender As Object, e As EventArgs) Handles btn_productlist.Click

        frm_productlist_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_custlist_Click(sender As Object, e As EventArgs) Handles btn_custlist.Click

        frm_customerlist_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_stafflist_Click(sender As Object, e As EventArgs) Handles btn_stafflist.Click

        frm_stafflist_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_productlist_MouseHover(sender As Object, e As EventArgs) Handles btn_productlist.MouseHover

        btn_productlist.BackColor = Color.Green

    End Sub

    Private Sub btn_productlist_MouseLeave(sender As Object, e As EventArgs) Handles btn_productlist.MouseLeave

        btn_productlist.BackColor = Color.White

    End Sub

    Private Sub btn_custlist_MouseHover(sender As Object, e As EventArgs) Handles btn_custlist.MouseHover

        btn_custlist.BackColor = Color.Green

    End Sub

    Private Sub btn_custlist_MouseLeave(sender As Object, e As EventArgs) Handles btn_custlist.MouseLeave

        btn_custlist.BackColor = Color.White

    End Sub

    Private Sub btn_stafflist_MouseHover(sender As Object, e As EventArgs) Handles btn_stafflist.MouseHover

        btn_stafflist.BackColor = Color.Green

    End Sub

    Private Sub btn_stafflist_MouseLeave(sender As Object, e As EventArgs) Handles btn_stafflist.MouseLeave

        btn_stafflist.BackColor = Color.White

    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click

        frm_vieworder_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_vieworder_MouseHover(sender As Object, e As EventArgs) Handles btn_vieworder.MouseHover

        btn_vieworder.BackColor = Color.Green

    End Sub

    Private Sub btn_vieworder_MouseLeave(sender As Object, e As EventArgs) Handles btn_vieworder.MouseLeave

        btn_vieworder.BackColor = Color.White

    End Sub

    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click

        frm_makeorder_a179830.Show()
        Me.Hide()

    End Sub

    Private Sub btn_addtocart_MouseHover(sender As Object, e As EventArgs) Handles btn_addtocart.MouseHover

        btn_addtocart.BackColor = Color.Green

    End Sub

    Private Sub btn_addtocart_MouseLeave(sender As Object, e As EventArgs) Handles btn_addtocart.MouseLeave

        btn_addtocart.BackColor = Color.White

    End Sub
End Class
