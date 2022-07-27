Public Class frmMstStudent
    Public Shared intMenuFormId As Integer
    Public Shared strEntryType As String
    Public enformMode As GlobalVariables.FormMode
    Dim cnData As New SQLControl
    Dim Execption As String
    Public intKeyStudentId As Integer
    Public pgState As String


    Private Sub frmMstStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        enformMode = GlobalVariables.FormMode.fmView
        gboxStudentDtl.Enabled = False
        pgState = "V"
        AddData()
    End Sub
    Public Sub AddData()
        If frmMdiMain.NewToolBtn.Enabled = False Then
            MessageBox.Show("User does Not have rights to Add New entries ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        tctrlStudentMst.SelectedTab = TabStudentDtl
        gboxStudentDtl.Enabled = True
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
        If intKeyStudentId <> 0 Then
            tctrlStudentMst.SelectedTab = TabStudentDtl
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
            gboxStudentDtl.Enabled = True
            pgState = "U"
            enformMode = GlobalVariables.FormMode.fmEditData
        Else
            MessageBox.Show("Select a Student to Edit by double clicking on Row ...")
        End If
    End Sub

    Public Sub DeleteData()
        If frmMdiMain.DeleteToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Delete entry ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        'gboxProductDtl.Enabled = True
        If dtgdStudentLst.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a Student to Delete ...")
            Exit Sub
        End If
        pgState = "D"
        enformMode = GlobalVariables.FormMode.fmDeleteData
        intKeyStudentId = dtgdStudentLst.CurrentRow.Cells(0).Value
        If InputBox("Do you want to Delete the Student " & dtgdStudentLst.CurrentRow.Cells(1).Value, "Delete Confirmation", "Yes") = "Yes" Then
            '           MessageBox.Show("Deleting Entry ...")
            SaveData()
        Else
            CancelData()
        End If
    End Sub

    Private Sub FillBlanks()
        txtStudentName.Text = ""
        txtStudentCode.Text = ""
        txtParentContactNo.Text = ""
        txtStudentAddress.Text = ""
        txtStudentContactNo.Text = ""
        txtStudentEmail.Text = ""
        cmbxStudentYear.SelectedIndex = -1
        cmbxStudentYear.Text = ""
        cmbxStudentClass.SelectedIndex = -1
        cmbxStudentClass.Text = ""
    End Sub

    Private Sub FillCombos()
        Dim cnComboData As New SQLControl
        cnComboData.ExecQuery("Select Distinct class from Students Order by class;")
        If cnComboData.HasException = True Then Exit Sub
        If cnComboData.RecordCount > 0 Then
            cmbxStudentClass.DisplayMember = "class"
            cmbxStudentClass.ValueMember = "class"
            cmbxStudentClass.DataSource = cnComboData.DBDT
        End If
        cnComboData.ExecQuery("Select Distinct year_of_study from Students Order by year_of_study")
        If cnComboData.HasException = True Then Exit Sub
        If cnComboData.RecordCount > 0 Then
            cmbxStudentYear.DisplayMember = "year_of_study"
            cmbxStudentYear.ValueMember = "year_of_study"
            cmbxStudentYear.DataSource = cnComboData.DBDT
        End If
        cnComboData = Nothing
    End Sub

    Private Sub FillDetails()
        Dim cnGetData As New SQLControl
        cnGetData.AddParam("@in_StudentId", intKeyStudentId)
        cnGetData.ExecProcedure("StudentGet")
        If cnGetData.DBDT.Rows.Count > 0 Then
            txtStudentName.Text = cnGetData.DBDT.Rows(0)("Student_Name").ToString
            txtStudentCode.Text = cnGetData.DBDT.Rows(0)("Student_Code").ToString
            cmbxStudentClass.Text = cnGetData.DBDT.Rows(0)("Class").ToString
            cmbxStudentYear.Text = cnGetData.DBDT.Rows(0)("year_of_study").ToString
            txtStudentEmail.Text = cnGetData.DBDT.Rows(0)("email_id").ToString
            txtStudentContactNo.Text = cnGetData.DBDT.Rows(0)("contact_no").ToString
            txtParentContactNo.Text = cnGetData.DBDT.Rows(0)("parents_contact").ToString
            txtStudentAddress.Text = cnGetData.DBDT.Rows(0)("address").ToString
            dtpStudentDOB.Value = cnGetData.DBDT.Rows(0)("date_of_birth").ToString
        End If
        cnGetData = Nothing
    End Sub

    Public Sub CancelData()
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        gboxStudentDtl.Enabled = False
        tctrlStudentMst.SelectedTab = TabStudentLst
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
        Dim strErrMsg As String = ""
        Try
            cnData.AddParam("@in_SaveType", pgState)     ' SqlDbType.NVarChar, 1, ParameterDirection.Input,
            If pgState = "U" Or pgState = "D" Then
                cnData.AddParam("@in_StudentId", intKeyStudentId)
            End If
            cnData.AddParam("@in_StudentName", txtStudentName.Text)       ' SqlDbType.NVarChar, 150, ParameterDirection.Input,
            cnData.AddParam("@in_StudentCode", txtStudentCode.Text)
            cnData.AddParam("@in_Class", cmbxStudentClass.Text)
            cnData.AddParam("@in_Year", cmbxStudentYear.Text)
            cnData.AddParam("@in_Email", txtStudentEmail.Text)
            cnData.AddParam("@in_Contact", txtStudentContactNo.Text)
            cnData.AddParam("@in_ParentsContact", txtParentContactNo.Text)
            cnData.AddParam("@in_Address", txtStudentAddress.Text)
            cnData.AddParam("@in_DOB", dtpStudentDOB.Value)

            cnData.ExecProcedure("Student_AUD")
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
                tctrlStudentMst.SelectedTab = TabStudentLst
            End If
        Catch ex As Exception
            cnData.Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            '        Finally
            ' CLOSE CONNECTION
        End Try
    End Sub

    Private Sub tctrlProductMst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlStudentMst.SelectedIndexChanged
        If tctrlStudentMst.SelectedTab.Name = "TabStudentLst" Then
            cnData.ExecQuery("Select * from Students order by Student_Name;")
            If cnData.HasException = True Then Exit Sub

            dtgdStudentLst.DataSource = cnData.DBDT

            With dtgdStudentLst
                .DefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue

                .Columns(0).HeaderText = "Student_Id"
                .Columns(1).HeaderText = "Name"
                '.Columns(2).HeaderText = "ProdCategoryId"
                .Columns(2).HeaderText = "StudentCode"
                '.Columns(4).HeaderText = "Posting Ac. Group"
                '.Columns(5).HeaderText = "Maintain Item Stock"
                '.Columns(6).HeaderText = "Sale Qty Editable"
                '.Columns(7).HeaderText = "Sale Rate Editable"
                '.Columns(8).HeaderText = "Disabled"
                '.Columns(13).HeaderText = "Category"
                .Columns(3).HeaderText = "  "
                .Columns(0).Visible = False
                .Columns(1).Width = 200
                .Columns(2).Width = 100
                '.Columns(4).Width = 100
                '.Columns(5).Width = 200
                '.Columns(6).Width = 100
                '.Columns(7).Width = 100
                '.Columns(8).Width = 100
                '.Columns(13).Width = 100
                .Columns(3).Width = 100
                .ReadOnly = True
            End With
            '            cnData = Nothing
        ElseIf tctrlStudentMst.SelectedTab.Name = "TabStudentDtl" Then
            '            If dtgdProductLst.SelectedRows.Count <> 0 Then
            If intKeyStudentId <> 0 Then
                FillDetails()
            End If
        End If
    End Sub

    Private Sub dtgdProductLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgdStudentLst.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            Dim intSelectedRow = dtgdStudentLst.Rows(e.RowIndex)
            intKeyStudentId = dtgdStudentLst.Rows(e.RowIndex).Cells("Student_Id").Value.ToString
            tctrlStudentMst.SelectedTab = TabStudentDtl
        End If
    End Sub

    Public Sub PrintData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, False)
    End Sub
    Public Sub PreviewData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, True)
    End Sub

    Private Sub txtStudentContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentContactNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtParentContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParentContactNo.KeyPress
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