Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmTrnResultEntry
    Public Shared intMenuFormId As Integer
    Public Shared strEntryType As String
    Public enFormMode As GlobalVariables.FormMode
    Dim pgState As String
    Dim cnData As New SQLControl
    Dim Exception As String
    Dim intKeyResultId As Integer

    Private Sub frmTrnResultEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        enFormMode = GlobalVariables.FormMode.fmView
        gboxResultEntryDtl.Enabled = False
        pgState = "V"
        AddData()
    End Sub

    Public Sub AddData()
        'If frmMdiMain.NewToolBtn.Enabled = False Then
        '    MessageBox.Show("User does Not have rights to Add New entries ...")
        '    Exit Sub
        'End If
        tctrlResultEntryTrn.SelectedTab = TabResultEntryDtl
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
        gboxResultEntryDtl.Enabled = True
        FillCombos()
        FillBlanks()
        Me.Refresh()
        pgState = "I"
        Me.Show()
        enFormMode = GlobalVariables.FormMode.fmAddData
    End Sub

    Public Sub EditData()
        If frmMdiMain.EditToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Edit entry ...")
            Exit Sub
        End If
        If intKeyResultId <> 0 Then
            tctrlResultEntryTrn.SelectedTab = TabResultEntryDtl
            'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
            gboxResultEntryDtl.Enabled = True
            pgState = "U"
            enFormMode = GlobalVariables.FormMode.fmEditData
        Else
            MessageBox.Show("Select an entry to Edit by double clicking on Row ...")
        End If
    End Sub

    Public Sub DeleteData()
        If frmMdiMain.DeleteToolBtn.Enabled = False Then
            MessageBox.Show(GlobalVariables.LoginName & "User does not have rights to Delete entry ...")
            Exit Sub
        End If
        If dtgdResultEntryLst.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a entry to Delete ...")
            Exit Sub
        End If
        pgState = "D"
        enFormMode = GlobalVariables.FormMode.fmDeleteData
        intKeyResultId = dtgdResultEntryLst.CurrentRow.Cells(0).Value
        If InputBox("Do you want to Delete the Entry " & dtgdResultEntryLst.CurrentRow.Cells(1).Value, "Delete Confirmation", "Yes") = "Yes" Then
            SaveData()
        Else
            CancelData()
        End If
    End Sub

    Public Sub SaveData()
        'enFormMode = GlobalVariables.FormMode.fmSaveData
        'Dim intSaveEntryNo As Integer
        'Dim intErrCode As Integer
        'Dim strErrMsg As String = ""
        'Dim lngRowCtr As Integer
        'Dim StrDtlSave As String
        'Dim dtEntry As Date
        'Dim dtExamDate As Date
        'Try
        '    StrDtlSave = ""
        '    lngRowCtr = 0
        '    Do While lngRowCtr < dtgResultEntryDtl.Rows.Count

        '        If String.IsNullOrEmpty(dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSubjectId").Value) = False _
        '            And dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSubjectId").Value IsNot Nothing Then

        '            StrDtlSave = StrDtlSave + dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgPerformanceDtlId").Value + "!"
        '            StrDtlSave = StrDtlSave + (dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSubjectId").Value).ToString + "!"
        '            StrDtlSave = StrDtlSave + dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgMarksScored").Value + "!"
        '            StrDtlSave = StrDtlSave + dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgTotalMarks").Value.ToString + "!"
        '            StrDtlSave = StrDtlSave + dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgFeedback").Value.ToString + "!"
        '            StrDtlSave = StrDtlSave + dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgRemarks").Value + "!"
        '            StrDtlSave = StrDtlSave + dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgExamType").Value + "!"
        '            If IsDate((dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgDateOfExam").Value).ToString) Then
        '                StrDtlSave = StrDtlSave + (dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgDateOfExam").Value).ToString + "!"
        '            End If
        '        End If
        '        lngRowCtr += 1
        '    Loop
        '    If IsDate(dtpExamDate.Text) Then
        '        dtExamDate = dtpExamDate.Text
        '    End If

        '    cnData.AddParam("@in_SaveType", pgState)
        '    If pgState = "U" Or pgState = "D" Then
        '        cnData.AddParam("@in_StockId", intKeyResultId)
        '    End If
        '    If IsDate(dtpExamDate.Text) Then
        '        cnData.AddParam("@in_ExamDate", dtExamDate)
        '    End If
        '    cnData.AddParam("@in_StudentId", cmbxStudent.SelectedValue)
        '    cnData.AddParam("@in_StockDtl", StrDtlSave)
        '    cnData.ExecProcedure("ResultEntry_AUD")
        '    If cnData.HasException = True Then
        '        MessageBox.Show("Entry did Not Save ...")
        '        Exit Sub
        '    End If
        '    intSaveEntryNo = cnData.intCtrlEntryNo
        '    intErrCode = cnData.intCtrlErrCode
        '    strErrMsg = cnData.strCtrlErrMsg
        '    If intErrCode < 0 Then
        '        Exit Sub
        '        MessageBox.Show("Entry did Not Saved ..." & vbCrLf & strErrMsg)
        '    Else
        '    End If

        '    FillBlanks()
        '    If pgState = "I" Then
        '        AddData()
        '    ElseIf pgState = "U" Or pgState = "D" Then
        '        pgState = "V"
        '        tctrlResultEntryTrn.SelectedTab = TabResultEntryLst
        '        gboxResultEntryDtl.Enabled = False
        '    End If
        'Catch ex As Exception
        '    cnData.Exception = "ExecQuery Error:   " & vbNewLine & ex.Message
        '    MessageBox.Show("Error in Saving Data " & ex.Message)
        '    '        Finally
        '    ' CLOSE CONNECTION
        'End Try
        AddData()
    End Sub

    Public Sub FillCombos()
        Dim cnComboGet As New SQLControl
        cnComboGet.ExecQuery("Select student_id,student_name from students Order by student_name;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            cmbxStudent.DisplayMember = "student_name"
            cmbxStudent.ValueMember = "student_id"
            cmbxStudent.DataSource = cnComboGet.DBDT
            cmbxStudent.SelectedIndex = -1
        End If
        cnComboGet.ExecQuery("Select staff_id,staff_name from staff Order by staff_name;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            cmbxStaff.DisplayMember = "staff_name"
            cmbxStaff.ValueMember = "staff_id"
            cmbxStaff.DataSource = cnComboGet.DBDT
            cmbxStaff.SelectedIndex = -1
        End If
        cnComboGet.ExecQuery("Select subject_id,subject_name from subjects Order by subject_name;")
        If cnComboGet.HasException = True Then Exit Sub
        If cnComboGet.RecordCount > 0 Then
            Dim cboExpCol = CType(dtgResultEntryDtl.Columns("dtgSubject"), DataGridViewComboBoxColumn)
            cboExpCol.DataSource = cnComboGet.DBDT
            cboExpCol.ValueMember = "subject_id"
            cboExpCol.DisplayMember = "subject_name"
        End If
        'cnComboGet.ExecQuery("Select BrandId,BrandName from MstBrand Order by BrandName;")
        'If cnComboGet.HasException = True Then Exit Sub
        'If cnComboGet.RecordCount > 0 Then
        '    Dim cboExpCol = CType(dtgPurchaseDtl.Columns("dtgBrand"), DataGridViewComboBoxColumn)
        '    cboExpCol.DataSource = cnComboGet.DBDT
        '    cboExpCol.ValueMember = "BrandId"
        '    cboExpCol.DisplayMember = "BrandName"
        '    '            cboExpCol.DisplayIndex = 0
        'End If
        cnComboGet = Nothing
    End Sub

    Public Sub FillBlanks()
        cmbxStudent.SelectedIndex = -1
        dtgResultEntryDtl.Rows.Clear()
        dtgResultEntryDtl.Rows.Add()
    End Sub

    Private Sub FillDetails()
        'Dim cnGetData As New SQLControl
        'Dim lngRowCtr As Integer
        'FillBlanks()
        'FillCombos()
        'cnGetData.AddParam("@in_Result", intKeyResultId)
        'cnGetData.ExecProcedure("RSS_TrnStockMstGet")
        'If cnGetData.DBDT.Rows.Count > 0 Then

        '    txtEntryNo.Text = cnGetData.DBDT.Rows(0)("TrnEntryNo").ToString
        '    dtpEntryDate.Value = cnGetData.DBDT.Rows(0)("TrnDate")
        '    cmbxStudent.SelectedValue = cnGetData.DBDT.Rows(0)("TrnClientId")
        '    txtBillNo.Text = cnGetData.DBDT.Rows(0)("TrnBillNo").ToString
        '    If IsDate(cnGetData.DBDT.Rows(0)("TrnBillDate").ToString) Then
        '        dtpExamDate.Value = DateTimePicker.MinimumDateTime
        '        dtpExamDate.Value = cnGetData.DBDT.Rows(0)("TrnDate")
        '    End If
        '    txtDetails.Text = cnGetData.DBDT.Rows(0)("TrnDetail").ToString
        '    txtTotNetAmt.Text = cnGetData.DBDT.Rows(0)("TrnNetAmt").ToString
        '    txtTotDiscAmt.Text = cnGetData.DBDT.Rows(0)("TrnDiscAmt").ToString
        '    txtTotCGSTAmt.Text = cnGetData.DBDT.Rows(0)("TrnCGSTAmt").ToString
        '    txtTotSGSTAmt.Text = cnGetData.DBDT.Rows(0)("TrnSGSTAmt").ToString
        '    txtTotIGSTAmt.Text = cnGetData.DBDT.Rows(0)("TrnIGSTAmt").ToString
        '    txtRoundOff.Text = cnGetData.DBDT.Rows(0)("TrnRoundOff").ToString
        '    txtBillAmt.Text = cnGetData.DBDT.Rows(0)("TrnBillAmt").ToString
        '    'lblPurchaseInvFileName.Text = cnGetData.DBDT.Rows(0)("TrnExpVisitReportScanFile").ToString
        '    'If Len(lblPurchaseInvFileName.Text) > 0 Then
        '    '    btnVwPurchaseInvoiceReportFile.Visible = True
        '    'Else
        '    '    btnVwPurchaseInvoiceReportFile.Visible = False
        '    'End If

        '    cnGetData.ClearDBDT()
        '    cnGetData.AddParam("@in_StockId", intKeyResultId)
        '    cnGetData.ExecProcedure("RSS_TrnStockDtlGet")
        '    If cnGetData.DBDT.Rows.Count > 0 Then
        '        lngRowCtr = 0
        '        '                dtgPurchaseDtl.Rows.Clear()
        '        dtgResultEntryDtl.Rows.Clear()
        '        dtgResultEntryDtl.Rows.Add()
        '        Do While lngRowCtr <= cnGetData.DBDT.Rows.Count - 1
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgTrnDtlId").Value = cnGetData.DBDT.Rows(lngRowCtr)("StockDtlId").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgProduct").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlProductId")
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSubjectId").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlProductId").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgHSNCode").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlHSNCode").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlGSTPerc").ToString
        '            If cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlBrandId") <> 0 Then
        '                dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgBrand").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlBrandId")
        '            End If
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSizeContent").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlSizeContent").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgPatternDesign").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlPatternDesign").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgQuantity").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlQuantity").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgRate").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlRate").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgAmount").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlAmount").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgDiscPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlDiscPerc").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgDiscAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlDiscAmt").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgTransport").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlTransport").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlSGSTPerc").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgSGSTAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlSGSTAmt").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgCGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlCGSTPerc").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgCGSTAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlCGSTAmt").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgIGSTPerc").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlIGSTPerc").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgIGSTAmt").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlIGSTAmt").ToString
        '            dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgMRP").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlMRP").ToString
        '            If cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlClientId") <> 0 Then
        '                dtgResultEntryDtl.Rows(lngRowCtr).Cells("dtgClientId").Value = cnGetData.DBDT.Rows(lngRowCtr)("TrnDtlClientId")
        '            End If
        '            dtgResultEntryDtl.Rows.Add()
        '            lngRowCtr += 1
        '        Loop
        '    End If
        'End If
        'cnGetData = Nothing
    End Sub

    Private Sub tctrlPurchaseTrn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tctrlResultEntryTrn.SelectedIndexChanged
        Dim intRowCtr As Integer = 0
        If cnData.HasException = True Then Exit Sub
        If tctrlResultEntryTrn.SelectedTab.Name = "TabResultEntryLst" Then
            cnData.ExecQuery("Select PerformanceId,Student_name,Staff_name,DateofEntry from TrnPerformanceMst
                INNER JOIN students ON student_id=StudentId
                INNER JOIN staff ON staff_id=StaffId")
            dtgdResultEntryLst.DataSource = cnData.DBDT

            With dtgdResultEntryLst
                .DefaultCellStyle.BackColor = Color.AliceBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue

                .Columns(0).HeaderText = "PerformanceId"
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Student Name"
                .Columns(2).HeaderText = "Staff Name"
                .Columns(3).HeaderText = "Date of Entry"
                .Columns(0).Width = 0
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 50
                .ReadOnly = True
            End With
        ElseIf tctrlResultEntryTrn.SelectedTab.Name = "TabResultEntryDtl" Then
            If intKeyResultId <> 0 Then
                FillDetails()
            End If
        End If

    End Sub

    Public Sub CancelData()
        'SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
        gboxResultEntryDtl.Enabled = False
        pgState = "V"
        tctrlResultEntryTrn.SelectedTab = TabResultEntryLst
        enFormMode = GlobalVariables.FormMode.fmView
    End Sub

    Public Sub CloseData()
        If enFormMode <> GlobalVariables.FormMode.fmAddData And
                    enFormMode <> GlobalVariables.FormMode.fmEditData And
                    enFormMode <> GlobalVariables.FormMode.fmDeleteData Then
            Me.Close()
        Else
            MessageBox.Show("Cannot close, Cancel the Current Mode to proceed ...")
        End If
    End Sub

    'Private Sub frmTrnPurchase_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, True)
    '    If enFormMode = GlobalVariables.FormMode.fmView Then
    '    Else
    '        SQLControl.GetUserRights(intMenuFormId, GlobalVariables.UserCode, False)
    '    End If
    'End Sub

    Private Sub setDateTimePickerBlank(ByVal dateTimePicker As DateTimePicker)
        dateTimePicker.Visible = True
        dateTimePicker.Value = DateTime.Now
        dateTimePicker.CustomFormat = "    "
        dateTimePicker.Format = DateTimePickerFormat.Custom
        'dateTimePicker.Checked = False
    End Sub
    Private Sub setDateTimePickerBlanktext(ByVal dateTimePicker As DateTimePicker)
        dateTimePicker.Visible = True
        dateTimePicker.CustomFormat = "    "
        dateTimePicker.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub dtgdResultEntryLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgdResultEntryLst.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            Dim intSelectedRow = dtgdResultEntryLst.Rows(e.RowIndex)
            intKeyResultId = dtgdResultEntryLst.Rows(e.RowIndex).Cells(0).Value.ToString
            tctrlResultEntryTrn.SelectedTab = TabResultEntryDtl
        End If
    End Sub

    Private Sub tctrlResultEntryTrn_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tctrlResultEntryTrn.Selecting
        If pgState = "I" Or pgState = "U" Then
            MessageBox.Show("Entry in Edit / Save mode cannot move ...")
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub dtgResultEntryDtl_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtgResultEntryDtl.CellBeginEdit
        '        MsgBox("Cell Begin Edit Event")
        If e.ColumnIndex = 1 Or e.ColumnIndex = 5 Then
            SendKeys.Send("%{DOWN}")
        ElseIf e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
        End If
    End Sub

    Private Sub dtgResultEntryDtl_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgResultEntryDtl.CellValueChanged
        RemoveHandler dtgResultEntryDtl.CellBeginEdit, AddressOf dtgResultEntryDtl_CellBeginEdit
        RemoveHandler dtgResultEntryDtl.CellValueChanged, AddressOf dtgResultEntryDtl_CellValueChanged
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = 1 Then
                If dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgSubject").Selected = True Then
                    dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgSubjectId").Value = dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgSubject").Value
                    dtgResultEntryDtl.CurrentCell = dtgResultEntryDtl(e.ColumnIndex + 2, e.RowIndex)
                    'dtgExpenseDtl.BeginEdit(True)
                    If dtgResultEntryDtl.Rows.Count - 1 = e.RowIndex Then
                        If dtgResultEntryDtl.Rows(dtgResultEntryDtl.Rows.Count - 1).Cells("dtgSubjectId").Value <> 0 Then
                            dtgResultEntryDtl.Rows.Add()
                        End If
                    End If
                    dtgResultEntryDtl.CurrentCell = dtgResultEntryDtl(e.ColumnIndex + 2, e.RowIndex)
                    dtgResultEntryDtl.BeginEdit(True)
                End If
            End If
        End If
        '    ElseIf e.ColumnIndex = 3 Then
        '        If dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgHSNCode").Value And dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgSubjectId").Value <> 0 Then
        '            If cnData.HasException = True Then Exit Sub
        '            cnData.ExecQuery("Select * from TrnStockDtl Where TrnDtlStkMovement = 'I' And TrnDtlHSNCode = '" + dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgHSNCode").Value + "' And TrnDtlProductId = " + (dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgProduct").Value).ToString + ";")
        '            If cnData.RecordCount > 0 Then
        '                dtgResultEntryDtl.CurrentCell = dtgResultEntryDtl(e.ColumnIndex + 2, e.RowIndex)
        '                dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value = cnData.DBDT.Rows(0)("TrnDtlGSTPerc").ToString
        '            Else
        '                dtgResultEntryDtl.CurrentCell = dtgResultEntryDtl(e.ColumnIndex + 1, e.RowIndex)
        '            End If
        '            dtgResultEntryDtl.BeginEdit(True)
        '        End If
        '        CalPurchaseTotal()
        '    ElseIf e.ColumnIndex = 4 Then
        '        If Val(dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value) > 0 Then
        '            If lblInOutState.Text = "Local" Then
        '                dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgSGSTPerc").Value = dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value / 2
        '                dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgCGSTPerc").Value = dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgSGSTPerc").Value
        '            ElseIf lblInOutState.Text = "Out State" Then
        '                dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgIGSTPerc").Value = dtgResultEntryDtl.Rows(e.RowIndex).Cells("dtgGSTPerc").Value
        '            End If
        '            dtgResultEntryDtl.CurrentCell = dtgResultEntryDtl(e.ColumnIndex + 1, e.RowIndex)
        '        End If
        '        dtgResultEntryDtl.BeginEdit(True)
        '    ElseIf e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Then
        '        CalPurchaseTotal()
        '        dtgResultEntryDtl.CurrentCell = dtgResultEntryDtl(e.ColumnIndex + 1, e.RowIndex)
        '        dtgResultEntryDtl.BeginEdit(True)
        '    End If
        'End If
        AddHandler dtgResultEntryDtl.CellBeginEdit, AddressOf dtgResultEntryDtl_CellBeginEdit
        AddHandler dtgResultEntryDtl.CellValueChanged, AddressOf dtgResultEntryDtl_CellValueChanged
    End Sub

    Private Sub dtpEntryDate_GotFocus(sender As Object, e As EventArgs)
        SendKeys.Send("%{DOWN}")
    End Sub

    Private Sub dtpBillDate_GotFocus(sender As Object, e As EventArgs)
        SendKeys.Send("%{DOWN}")
    End Sub

    Public Sub PrintData()
        'frmRepoViewer.ViewReport(Application.StartupPath & "\Reports\rptTrnExpenseLst.rpt",,,, True)
    End Sub

    'Public Sub CalPurchaseTotal()
    '    Dim intRowCtr As Integer = 0
    '    Dim decTaxable As Decimal = 0
    '    txtTotNetAmt.Text = ""
    '    txtTotDiscAmt.Text = ""
    '    txtTotSGSTAmt.Text = ""
    '    txtTotCGSTAmt.Text = ""
    '    txtTotIGSTAmt.Text = ""
    '    txtTotTransport.Text = ""
    '    txtBillAmt.Text = ""
    '    For intRowCtr = 0 To dtgResultEntryDtl.Rows.Count - 1
    '        If Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgRate").Value) <> 0 And Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgQuantity").Value) <> 0 Then
    '            dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgAmount").Value = Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgRate").Value) * Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgQuantity").Value)
    '            If Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgDiscPerc").Value) <> 0 Then
    '                dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgDiscAmt").Value = Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgAmount").Value) * Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgDiscPerc").Value) / 100
    '            End If
    '            decTaxable = (Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgAmount").Value) - Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgDiscAmt").Value) + Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgTransport").Value))
    '            dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgSGSTAmt").Value = decTaxable * Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgSGSTPerc").Value) / 100
    '            dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgCGSTAmt").Value = decTaxable * Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgCGSTPerc").Value) / 100
    '            dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgIGSTAmt").Value = decTaxable * Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgIGSTPerc").Value) / 100
    '            txtTotNetAmt.Text = Val(txtTotNetAmt.Text) + dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgAmount").Value
    '            txtTotDiscAmt.Text = Val(txtTotDiscAmt.Text) + dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgDiscAmt").Value
    '            txtTotSGSTAmt.Text = Val(txtTotSGSTAmt.Text) + Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgSGSTAmt").Value)
    '            txtTotCGSTAmt.Text = Val(txtTotCGSTAmt.Text) + Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgCGSTAmt").Value)
    '            txtTotIGSTAmt.Text = Val(txtTotIGSTAmt.Text) + Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgIGSTAmt").Value)
    '            txtTotTransport.Text = Val(txtTotTransport.Text) + Val(dtgResultEntryDtl.Rows(intRowCtr).Cells("dtgTransport").Value)
    '        End If
    '    Next
    '    txtTotNetAmt.Text = Format(Val(txtTotNetAmt.Text), "0.00")
    '    txtTotDiscAmt.Text = Format(Val(txtTotDiscAmt.Text), "0.00")
    '    txtTotTransport.Text = Format(Val(txtTotTransport.Text), "0.00")
    '    txtTotSGSTAmt.Text = Format(Val(txtTotSGSTAmt.Text), "0.00")
    '    txtTotCGSTAmt.Text = Format(Val(txtTotCGSTAmt.Text), "0.00")
    '    txtTotIGSTAmt.Text = Format(Val(txtTotIGSTAmt.Text), "0.00")
    '    txtRoundOff.Text = Format(txtRoundOff.Text, "0.00")
    '    txtBillAmt.Text = Format(Val(txtTotNetAmt.Text) - Val(txtTotDiscAmt.Text) + Val(txtTotSGSTAmt.Text) + Val(txtTotCGSTAmt.Text) + Val(txtTotIGSTAmt.Text) + Val(txtTotTransport.Text) + Val(txtRoundOff.Text), "0.00")
    'End Sub
End Class