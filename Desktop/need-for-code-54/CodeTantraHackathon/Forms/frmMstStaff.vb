Public Class frmMstStaff
    Public Shared intMenuFormId As Integer
    Public Shared strEntryType As String
    Public enformMode As GlobalVariables.FormMode
    Dim cnData As New SQLControl
    Dim Execption As String
    Public intKeyStaffId As Integer
    Public pgState As String
    Private Sub frmMstStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        enformMode = GlobalVariables.FormMode.fmView
        gboxStaffDtl.Enabled = False
        pgState = "V"
        AddData()
    End Sub
    Public Sub AddData()
        If frmMdiMain.NewToolBtn.Enabled = False Then
            MessageBox.Show("User does Not have rights to Add New entries ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        tctrlStaffMst.SelectedTab = TabStaffDtl
        gboxStaffDtl.Enabled = True
        FillCombos()
        FillBlanks()
        Me.Refresh()
        pgState = "I"
        enformMode = GlobalVariables.FormMode.fmAddData
    End Sub

    Public Sub EditData()
        If frmMdiMain.EditToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Edit entry ...")
            Exit Sub
        End If
        If intKeyStaffId <> 0 Then
            tctrlStaffMst.SelectedTab = TabStaffDtl
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
            gboxStaffDtl.Enabled = True
            pgState = "U"
            enformMode = GlobalVariables.FormMode.fmEditData
        Else
            MessageBox.Show("Select a Staff to Edit by double clicking on Row ...")
        End If
    End Sub

    Public Sub DeleteData()
        If frmMdiMain.DeleteToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Delete entry ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        'gboxProductDtl.Enabled = True
        If dtgdStaffLst.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a Staff to Delete ...")
            Exit Sub
        End If
        pgState = "D"
        enformMode = GlobalVariables.FormMode.fmDeleteData
        intKeyStaffId = dtgdStaffLst.CurrentRow.Cells(0).Value
        If InputBox("Do you want to Delete the Entry " & dtgdStaffLst.CurrentRow.Cells(1).Value, "Delete Confirmation", "Yes") = "Yes" Then
            '           MessageBox.Show("Deleting Entry ...")
            SaveData()
        Else
            CancelData()
        End If
    End Sub

    Private Sub FillBlanks()
        txtStaffName.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        cmbxPosition.SelectedIndex = -1
        cmbxPosition.ResetText()
    End Sub

    Private Sub FillCombos()
        Dim cnComboDate As New SQLControl
        cnComboDate.ExecQuery("Select position from staff Order by position;")
        If cnComboDate.HasException = True Then Exit Sub
        If cnComboDate.RecordCount > 0 Then
            cmbxPosition.DisplayMember = "position"
            cmbxPosition.ValueMember = "position"
            cmbxPosition.DataSource = cnComboDate.DBDT
        End If
        cnComboDate = Nothing
    End Sub

    Private Sub FillDetails()
        Dim cnGetData As New SQLControl
        cnGetData.AddParam("@in_StaffId", intKeyStaffId)
        cnGetData.ExecProcedure("StaffGet")
        If cnGetData.HasException = True Then Exit Sub
        If cnGetData.DBDT.Rows.Count > 0 Then
            txtStaffName.Text = cnGetData.DBDT.Rows(0)("Staff_Name").ToString
            cmbxPosition.SelectedValue = cnGetData.DBDT.Rows(0)("position").ToString
            txtContact.Text = cnGetData.DBDT.Rows(0)("staff_contact").ToString
            txtEmail.Text = cnGetData.DBDT.Rows(0)("staff_email").ToString
        End If
        cnGetData = Nothing
    End Sub

    Public Sub CancelData()
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        gboxStaffDtl.Enabled = False
        tctrlStaffMst.SelectedTab = TabStaffLst
        pgState = "V"
        enformMode = GlobalVariables.FormMode.fmView
    End Sub

    Public Sub CloseData()
        If enformMode <> GlobalVariables.FormMode.fmAddData And
                enformMode <> GlobalVariables.FormMode.fmEditData And
                enformMode <> GlobalVariables.FormMode.fmDeleteData Then
            Me.Close()
        Else
            MessageBox.Show("Cannot close, Cancel the Current Mode to proceed ...")
        End If
    End Sub

    Public Sub SaveData()
        enformMode = GlobalVariables.FormMode.fmSaveData
        Dim intErrCode As Integer
        Dim strErrMsg As String
        Try
            cnData.AddParam("@in_SaveType", pgState)     ' SqlDbType.NVarChar, 1, ParameterDirection.Input,
            If pgState = "U" Or pgState = "D" Then
                cnData.AddParam("@in_StaffId", intKeyStaffId)
            End If
            cnData.AddParam("@in_StaffName", txtStaffName.Text)       ' SqlDbType.NVarChar, 150, ParameterDirection.Input,
            cnData.AddParam("@in_Position", cmbxPosition.Text)
            cnData.AddParam("@in_Contact", txtContact.Text)
            cnData.AddParam("@in_Email", txtEmail.Text)
            cnData.ExecProcedure("Staff_AUD")
            intErrCode = cnData.intCtrlErrCode
            strErrMsg = cnData.strCtrlErrMsg
            If cnData.HasException = True Then
                MessageBox.Show("Entry did not Save ...")
                Exit Sub
            End If

            If intErrCode < 0 Then
                MessageBox.Show("Entry did not Saved ..." & vbCrLf & strErrMsg)
                Exit Sub
            End If
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
            FillBlanks()
            If pgState = "I" Then
                AddData()
            ElseIf pgState = "U" Or pgState = "D" Then
                tctrlStaffMst.SelectedTab = TabStaffLst
            End If
        Catch ex As Exception
            cnData.Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            '        Finally
            ' CLOSE CONNECTION
        End Try
    End Sub

    Private Sub tctrlProductMst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlStaffMst.SelectedIndexChanged
        If tctrlStaffMst.SelectedTab.Name = "TabStaffLst" Then
            cnData.ExecQuery("Select * from staff Order by staff_name;")
            If cnData.HasException = True Then Exit Sub

            dtgdStaffLst.DataSource = cnData.DBDT

            With dtgdStaffLst
                .DefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue

                .Columns(0).HeaderText = "staff_id"
                .Columns(1).HeaderText = "staff_name"
                .Columns(0).Visible = False
                .Columns(1).Width = 200
                .ReadOnly = True
            End With
            '            cnData = Nothing
        ElseIf tctrlStaffMst.SelectedTab.Name = "TabStaffDtl" Then
            '            If dtgdProductLst.SelectedRows.Count <> 0 Then
            If intKeyStaffId <> 0 Then
                FillDetails()
            End If
        End If
    End Sub

    Private Sub dtgdProductLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgdStaffLst.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            Dim intSelectedRow = dtgdStaffLst.Rows(e.RowIndex)
            intKeyStaffId = dtgdStaffLst.Rows(e.RowIndex).Cells("staff_Id").Value.ToString
            tctrlStaffMst.SelectedTab = TabStaffDtl
        End If
    End Sub

    Public Sub PrintData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, False)
    End Sub
    Public Sub PreviewData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, True)
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Private Sub frmMstProduct_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    If enformMode = GlobalVariables.FormMode.fmView Then
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
    '    Else
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
    '    End If
    'End Sub
End Class