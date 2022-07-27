Public Class frmMstSubject
    Public Shared intMenuFormId As Integer
    Public Shared strEntryType As String
    Public enformMode As GlobalVariables.FormMode
    Dim cnData As New SQLControl
    Dim Execption As String
    Public intKeySubjectId As Integer
    Public pgState As String

    Private Sub frmMstStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        enformMode = GlobalVariables.FormMode.fmView
        gboxSubjectDtl.Enabled = False
        pgState = "V"
        AddData()
    End Sub
    Public Sub AddData()
        If frmMdiMain.NewToolBtn.Enabled = False Then
            MessageBox.Show("User does Not have rights to Add New entries ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        tctrlSubjectMst.SelectedTab = TabSubjectDtl
        gboxSubjectDtl.Enabled = True
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
        If intKeySubjectId <> 0 Then
            tctrlSubjectMst.SelectedTab = TabSubjectDtl
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
            gboxSubjectDtl.Enabled = True
            pgState = "U"
            enformMode = GlobalVariables.FormMode.fmEditData
        Else
            MessageBox.Show("Select a Subject to Edit by double clicking on Row ...")
        End If
    End Sub

    Public Sub DeleteData()
        If frmMdiMain.DeleteToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Delete entry ...")
            Exit Sub
        End If
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        'gboxProductDtl.Enabled = True
        If dtgdSubjectLst.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a Subject to Delete ...")
            Exit Sub
        End If
        pgState = "D"
        enformMode = GlobalVariables.FormMode.fmDeleteData
        intKeySubjectId = dtgdSubjectLst.CurrentRow.Cells(0).Value
        If InputBox("Do you want to Delete the Entry " & dtgdSubjectLst.CurrentRow.Cells(1).Value, "Delete Confirmation", "Yes") = "Yes" Then
            '           MessageBox.Show("Deleting Entry ...")
            SaveData()
        Else
            CancelData()
        End If
    End Sub

    Private Sub FillBlanks()
        txtSubjectName.Text = ""
    End Sub

    'Private Sub FillCombos()
    '    Dim cnComboDate As New SQLControl
    '    cnComboDate.ExecQuery("Select CategoryId,CategoryName from MstCategory Order by CategoryName;")
    '    If cnComboDate.HasException = True Then Exit Sub
    '    If cnComboDate.RecordCount > 0 Then
    '        cmbxCategory.DisplayMember = "CategoryName"
    '        cmbxCategory.ValueMember = "CategoryId"
    '        cmbxCategory.DataSource = cnComboDate.DBDT
    '    End If
    '    cnComboDate.ExecQuery("Select Distinct ProdPostingAcGroup as PostAcGroup from MstProduct Order by ProdPostingAcGroup")
    '    If cnComboDate.HasException = True Then Exit Sub
    '    If cnComboDate.RecordCount > 0 Then
    '        cmbxPostingAcGroup.DisplayMember = "PostAcGroup"
    '        cmbxPostingAcGroup.DataSource = cnComboDate.DBDT
    '    End If
    '    cnComboDate = Nothing
    'End Sub

    Private Sub FillDetails()
        Dim cnGetData As New SQLControl
        cnGetData.AddParam("@in_SubjectId", intKeySubjectId)
        cnGetData.ExecProcedure("SubjectGet")
        If cnGetData.DBDT.Rows.Count > 0 Then
            txtSubjectName.Text = cnGetData.DBDT.Rows(0)("Subject_Name").ToString
        End If
        cnGetData = Nothing
    End Sub

    Public Sub CancelData()
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        gboxSubjectDtl.Enabled = False
        tctrlSubjectMst.SelectedTab = TabSubjectLst
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
                cnData.AddParam("@in_SubjectId", intKeySubjectId)
            End If
            cnData.AddParam("@in_SubjectName", txtSubjectName.Text)       ' SqlDbType.NVarChar, 150, ParameterDirection.Input,
            cnData.ExecProcedure("Subject_AUD")
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
                tctrlSubjectMst.SelectedTab = TabSubjectLst
            End If
        Catch ex As Exception
            cnData.Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            '        Finally
            ' CLOSE CONNECTION
        End Try
    End Sub

    Private Sub tctrlProductMst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlSubjectMst.SelectedIndexChanged
        If tctrlSubjectMst.SelectedTab.Name = "TabSubjectLst" Then
            cnData.ExecQuery("Select * from Subjects order by Subject_Name;")
            If cnData.HasException = True Then Exit Sub

            dtgdSubjectLst.DataSource = cnData.DBDT

            With dtgdSubjectLst
                .DefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue

                .Columns(0).HeaderText = "Subject_Id"
                .Columns(1).HeaderText = "SubjectName"
                .Columns(0).Visible = False
                .Columns(1).Width = 200
                .ReadOnly = True
            End With
        ElseIf tctrlSubjectMst.SelectedTab.Name = "TabSubjectDtl" Then
            If intKeySubjectId <> 0 Then
                FillDetails()
            End If
        End If
    End Sub

    Private Sub dtgdProductLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgdSubjectLst.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            Dim intSelectedRow = dtgdSubjectLst.Rows(e.RowIndex)
            intKeySubjectId = dtgdSubjectLst.Rows(e.RowIndex).Cells("Subject_Id").Value.ToString
            tctrlSubjectMst.SelectedTab = TabSubjectDtl
        End If
    End Sub

    Public Sub PrintData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, False)
    End Sub
    Public Sub PreviewData()
        'frmReportPage.ShowRepo("rptProductLst.rpt",, True)
    End Sub

    'Private Sub frmMstProduct_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    If enformMode = GlobalVariables.FormMode.fmView Then
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
    '    Else
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
    '    End If
    'End Sub
End Class