Public Class frmMdiMain
    Private m_ChildFormNumber As Integer

    Private Sub frmMdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    'Private Sub mnuSysUsers_Click(sender As Object, e As EventArgs)
    '    Dim objSysUsers As New frmSysUsers
    '    objSysUsers.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objSysUsers.Show()
    'End Sub

    'Private Sub mnuMstProducts_Click(sender As Object, e As EventArgs)
    '    Dim objMstProduct As New frmMstProduct
    '    objMstProduct.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objMstProduct.intMenuFormId = SQLControl.GetMenuFormId("mnuMstProduct", "frmMstProduct")
    '    objMstProduct.Show()
    'End Sub

    Private Sub mnuMstStaff_Click(sender As Object, e As EventArgs) Handles mnuMstStaff.Click
        Dim objMstStaff As New frmMstStaff
        objMstStaff.MdiParent = Me
        m_ChildFormNumber += 1
        objMstStaff.strEntryType = "Staff"
        'objMstStaff.intMenuFormId = SQLControl.GetMenuFormId("mnuMstCategory", "frmMstCategory")
        objMstStaff.Show()
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MainToolBar.ItemClicked
        Dim strformname As String
        If ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        strformname = ActiveMdiChild.Name
        Select Case MainToolBar.Items.IndexOf(e.ClickedItem)
            Case 0
                If ActiveMdiChild.Name = "frmMstStudent" Then
                    DirectCast(ActiveMdiChild, frmMstStudent).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstSubject" Then
                    DirectCast(ActiveMdiChild, frmMstSubject).AddData()
                ElseIf ActiveMdiChild.Name = "frmMstStaff" Then
                    DirectCast(ActiveMdiChild, frmMstStaff).AddData()
                ElseIf ActiveMdiChild.Name = "frmTrnResultEntry" Then
                    DirectCast(ActiveMdiChild, frmTrnResultEntry).AddData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchase).AddData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    '    DirectCast(ActiveMdiChild, frmTrnReceipt).AddData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSale).AddData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSaleReturn).AddData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).AddData()
                End If
            Case 1
                If ActiveMdiChild.Name = "frmMstStudent" Then
                    DirectCast(ActiveMdiChild, frmMstStudent).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstSubject" Then
                    DirectCast(ActiveMdiChild, frmMstSubject).EditData()
                ElseIf ActiveMdiChild.Name = "frmMstStaff" Then
                    DirectCast(ActiveMdiChild, frmMstStaff).EditData()
                ElseIf ActiveMdiChild.Name = "frmTrnResultEntry" Then
                    DirectCast(ActiveMdiChild, frmTrnResultEntry).EditData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchase).EditData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    '    DirectCast(ActiveMdiChild, frmTrnReceipt).EditData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSale).EditData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSaleReturn).EditData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).EditData()
                End If
            Case 2
                If ActiveMdiChild.Name = "frmMstStudent" Then
                    DirectCast(ActiveMdiChild, frmMstStudent).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstSubject" Then
                    DirectCast(ActiveMdiChild, frmMstSubject).SaveData()
                ElseIf ActiveMdiChild.Name = "frmMstStaff" Then
                    DirectCast(ActiveMdiChild, frmMstStaff).SaveData()
                ElseIf ActiveMdiChild.Name = "frmTrnResultEntry" Then
                    DirectCast(ActiveMdiChild, frmTrnResultEntry).SaveData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchase).SaveData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    '    DirectCast(ActiveMdiChild, frmTrnReceipt).SaveData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSale).SaveData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSaleReturn).SaveData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).SaveData()
                End If
            Case 3
                If ActiveMdiChild.Name = "frmMstStudent" Then
                    DirectCast(ActiveMdiChild, frmMstStudent).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstSubject" Then
                    DirectCast(ActiveMdiChild, frmMstSubject).CancelData()
                ElseIf ActiveMdiChild.Name = "frmMstStaff" Then
                    DirectCast(ActiveMdiChild, frmMstStaff).CancelData()
                ElseIf ActiveMdiChild.Name = "frmTrnResultEntry" Then
                    DirectCast(ActiveMdiChild, frmTrnResultEntry).CancelData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchase).CancelData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    '    DirectCast(ActiveMdiChild, frmTrnReceipt).CancelData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSale).CancelData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSaleReturn).CancelData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).CancelData()
                End If
            Case 4
                If ActiveMdiChild.Name = "frmMstStudent" Then
                    DirectCast(ActiveMdiChild, frmMstStudent).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstSubject" Then
                    DirectCast(ActiveMdiChild, frmMstSubject).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmMstStaff" Then
                    DirectCast(ActiveMdiChild, frmMstStaff).DeleteData()
                ElseIf ActiveMdiChild.Name = "frmTrnResultEntry" Then
                    DirectCast(ActiveMdiChild, frmTrnResultEntry).DeleteData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchase).DeleteData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    '    DirectCast(ActiveMdiChild, frmTrnReceipt).DeleteData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSale).DeleteData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSaleReturn).DeleteData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).DeleteData()
                End If
            Case 9
                MessageBox.Show("There is no Help provided currently ...")
            Case 10
                If ActiveMdiChild.Name = "frmMstStudent" Then
                    DirectCast(ActiveMdiChild, frmMstStudent).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstSubject" Then
                    DirectCast(ActiveMdiChild, frmMstSubject).CloseData()
                ElseIf ActiveMdiChild.Name = "frmMstStaff" Then
                    DirectCast(ActiveMdiChild, frmMstStaff).CloseData()
                ElseIf ActiveMdiChild.Name = "frmTrnResultEntry" Then
                    DirectCast(ActiveMdiChild, frmTrnResultEntry).CloseData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchase" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchase).CloseData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnReceipt" Then
                    '    DirectCast(ActiveMdiChild, frmTrnReceipt).CloseData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSale" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSale).CloseData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnSaleReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnSaleReturn).CloseData()
                    'ElseIf ActiveMdiChild.Name = "frmTrnPurchaseReturn" Then
                    '    DirectCast(ActiveMdiChild, frmTrnPurchaseReturn).CloseData()
                    'ElseIf ActiveMdiChild.Name = "frmRepoListing" Then
                    '    DirectCast(ActiveMdiChild, frmRepoListing).CloseData()
                End If
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    'Private Sub mnuMstDebtor_Click(sender As Object, e As EventArgs)
    '    Dim objMstDebtor As New frmMstDebtor
    '    objMstDebtor.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objMstDebtor.intMenuFormId = SQLControl.GetMenuFormId("mnuMstDebtor"e, "frmMstDebtor")
    '    objMstDebtor.strEntryType = "D"
    '    objMstDebtor.Show()
    'End Sub

    'Private Sub mstMstSupplier_Click(sender As Object, e As EventArgs)
    '    Dim objMstCreditor As New frmMstDebtor
    '    objMstCreditor.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objMstCreditor.intMenuFormId = SQLControl.GetMenuFormId("mnuMstCreditor", "frmMstDebtor")
    '    objMstCreditor.strEntryType = "C"
    '    objMstCreditor.show()
    'End Sub

    'Private Sub mnuMstEmployee_Click(sender As Object, e As EventArgs)
    '    Dim objMstEmployee As New frmMstEmployee
    '    objMstEmployee.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objMstEmployee.intMenuFormId = SQLControl.GetMenuFormId("mnuMstEmployee", "frmMstEmployee")
    '    objMstEmployee.show()
    'End Sub

    Private Sub mnuTrnPurchase_Click(sender As Object, e As EventArgs) Handles mnuTrnResultEntry.Click
        Dim objTrnResultEntry As New frmTrnResultEntry
        objTrnResultEntry.MdiParent = Me
        m_ChildFormNumber += 1
        'objTrnResultEntry.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnPurchase", "frmTrnPurchase")
        objTrnResultEntry.strEntryType = "P"
        objTrnResultEntry.Show()
    End Sub

    Private Sub mnuMstSubjects_Click(sender As Object, e As EventArgs) Handles mnuMstSubjects.Click
        Dim objMstSubject As New frmMstSubject
        objMstSubject.MdiParent = Me
        m_ChildFormNumber += 1
        objMstSubject.strEntryType = "Subjects"
        'objMstSubject.intMenuFormId = SQLControl.GetMenuFormId("mnuMstBrand", "frmMstCategory")
        objMstSubject.Show()
    End Sub

    Private Sub mnuMstStudent_Click(sender As Object, e As EventArgs) Handles mnuMstStudent.Click
        Dim objMstStudent As New frmMstStudent
        objMstStudent.MdiParent = Me
        m_ChildFormNumber += 1
        objMstStudent.strEntryType = "Student"
        'objMstStudent.intMenuFormId = SQLControl.GetMenuFormId("mnuMstSalutation", "frmMstCategory")
        objMstStudent.Show()
    End Sub

    'Private Sub mnuMstExpense_Click(sender As Object, e As EventArgs)
    '    Dim objMstExpense As New frmMstCategory
    '    objMstExpense.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objMstExpense.strEntryType = "Expense"
    '    objMstExpense.intMenuFormId = SQLControl.GetMenuFormId("mnuMstExpense", "frmMstCategory")
    '    objMstExpense.Show()
    'End Sub

    'Private Sub ReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTrnReceipt.Click
    '    Dim objTrnReceipt As New frmTrnReceipt
    '    objTrnReceipt.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objTrnReceipt.strEntryType = "Receipt"
    '    objTrnReceipt.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnReceipt", "frmTrnReceipt")
    '    objTrnReceipt.Show()
    'End Sub

    'Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTrnSale.Click
    '    Dim objTrnSale As New frmTrnSale
    '    objTrnSale.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objTrnSale.strEntryType = "Sale"
    '    objTrnSale.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnSale", "frmTrnSale")
    '    objTrnSale.Show()
    'End Sub

    'Private Sub SaleReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTrnSaleReturn.Click
    '    Dim objTrnSaleReturn As New frmTrnSaleReturn
    '    objTrnSaleReturn.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objTrnSaleReturn.strEntryType = "Sale Return"
    '    objTrnSaleReturn.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnSaleReturn", "frmTrnSaleReturn")
    '    objTrnSaleReturn.Show()
    'End Sub

    'Private Sub mnuTrnPurchaseReturn_Click(sender As Object, e As EventArgs) Handles mnuTrnPurchaseReturn.Click
    '    Dim objTrnResultEntryReturn As New frmTrnPurchaseReturn
    '    objTrnResultEntryReturn.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objTrnResultEntryReturn.strEntryType = "Purchase Return"
    '    objTrnResultEntryReturn.intMenuFormId = SQLControl.GetMenuFormId("mnuTrnPurchaseReturn", "frmTrnPurchaseReturn")
    '    objTrnResultEntryReturn.Show()
    'End Sub

    'Private Sub mnuRepoBrand_Click(sender As Object, e As EventArgs) Handles mnuRepoBrand.Click
    '    Dim objRepoBrand As New frmRepoListing
    '    objRepoBrand.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoBrand.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoBrand", "frmRepoListing")
    '    objRepoBrand.strRepoType = "Brand List"
    '    objRepoBrand.Show()
    'End Sub

    'Private Sub mnuRepoCategory_Click(sender As Object, e As EventArgs) Handles mnuRepoCategory.Click
    '    Dim objRepoCategory As New frmRepoListing
    '    objRepoCategory.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoCategory.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoCategory", "frmRepoListing")
    '    objRepoCategory.strRepoType = "Category List"
    '    objRepoCategory.Show()
    'End Sub

    'Private Sub mnuRepoProduct_Click(sender As Object, e As EventArgs) Handles mnuRepoProduct.Click
    '    Dim objRepoProduct As New frmRepoListing
    '    objRepoProduct.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoProduct.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoProduct", "frmRepoListing")
    '    objRepoProduct.strRepoType = "Product List"
    '    objRepoProduct.Show()
    'End Sub

    'Private Sub mnuRepoCustomer_Click(sender As Object, e As EventArgs) Handles mnuRepoCustomer.Click
    '    Dim objRepoCustomer As New frmRepoListing
    '    objRepoCustomer.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoCustomer.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoCustomer", "frmRepoListing")
    '    objRepoCustomer.strRepoType = "Customer List"
    '    objRepoCustomer.Show()
    'End Sub

    'Private Sub mnuRepoSupplier_Click(sender As Object, e As EventArgs) Handles mnuRepoSupplier.Click
    '    Dim objRepoSupplier As New frmRepoListing
    '    objRepoSupplier.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoSupplier.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoSupplier", "frmRepoListing")
    '    objRepoSupplier.strRepoType = "Supplier List"
    '    objRepoSupplier.Show()
    'End Sub

    'Private Sub mnuRepoCurrentStk_Click(sender As Object, e As EventArgs) Handles mnuRepoCurrentStk.Click
    '    Dim objRepoItemCurrentStk As New frmRepoListing
    '    objRepoItemCurrentStk.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoItemCurrentStk.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoCurrentStk", "frmRepoListing")
    '    objRepoItemCurrentStk.strRepoType = "Item Current Stock"
    '    objRepoItemCurrentStk.Show()
    'End Sub

    'Private Sub mnuRepoOsReceivables_Click(sender As Object, e As EventArgs) Handles mnuRepoOsReceivables.Click
    '    Dim objRepoOsReceivables As New frmRepoListing
    '    objRepoOsReceivables.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoOsReceivables.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoOsReceivables", "frmRepoListing")
    '    objRepoOsReceivables.strRepoType = "O/s Receivables"
    '    objRepoOsReceivables.Show()
    'End Sub

    'Private Sub mnuRepoBatchwiseStk_Click(sender As Object, e As EventArgs) Handles mnuRepoBatchwiseStk.Click
    '    Dim objRepoBatchwiseStk As New frmRepoListing
    '    objRepoBatchwiseStk.MdiParent = Me
    '    m_ChildFormNumber += 1
    '    objRepoBatchwiseStk.intMenuFormId = SQLControl.GetMenuFormId("mnuRepoBatchwiseStk", "frmRepoListing")
    '    objRepoBatchwiseStk.strRepoType = "Batchwise Stock"
    '    objRepoBatchwiseStk.Show()
    'End Sub
End Class
