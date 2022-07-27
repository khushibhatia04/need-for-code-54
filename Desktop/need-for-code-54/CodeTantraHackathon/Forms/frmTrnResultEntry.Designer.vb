<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrnResultEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tctrlResultEntryTrn = New System.Windows.Forms.TabControl()
        Me.TabResultEntryDtl = New System.Windows.Forms.TabPage()
        Me.gboxResultEntryDtl = New System.Windows.Forms.GroupBox()
        Me.cmbxStaff = New System.Windows.Forms.ComboBox()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.cmbxStudent = New System.Windows.Forms.ComboBox()
        Me.dtgResultEntryDtl = New System.Windows.Forms.DataGridView()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.TabResultEntryLst = New System.Windows.Forms.TabPage()
        Me.dtgdResultEntryLst = New System.Windows.Forms.DataGridView()
        Me.dtgPerformanceDtlId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgSubject = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtgSubjectId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgMarksScored = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgTotalMarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgFeedback = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgExamType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgDateOfExam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tctrlResultEntryTrn.SuspendLayout()
        Me.TabResultEntryDtl.SuspendLayout()
        Me.gboxResultEntryDtl.SuspendLayout()
        CType(Me.dtgResultEntryDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResultEntryLst.SuspendLayout()
        CType(Me.dtgdResultEntryLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlResultEntryTrn
        '
        Me.tctrlResultEntryTrn.Controls.Add(Me.TabResultEntryDtl)
        Me.tctrlResultEntryTrn.Controls.Add(Me.TabResultEntryLst)
        Me.tctrlResultEntryTrn.Location = New System.Drawing.Point(3, 2)
        Me.tctrlResultEntryTrn.Name = "tctrlResultEntryTrn"
        Me.tctrlResultEntryTrn.SelectedIndex = 0
        Me.tctrlResultEntryTrn.Size = New System.Drawing.Size(1367, 674)
        Me.tctrlResultEntryTrn.TabIndex = 4
        '
        'TabResultEntryDtl
        '
        Me.TabResultEntryDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabResultEntryDtl.Controls.Add(Me.gboxResultEntryDtl)
        Me.TabResultEntryDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabResultEntryDtl.Name = "TabResultEntryDtl"
        Me.TabResultEntryDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultEntryDtl.Size = New System.Drawing.Size(1359, 648)
        Me.TabResultEntryDtl.TabIndex = 0
        Me.TabResultEntryDtl.Text = "Add/Update/Delete"
        '
        'gboxResultEntryDtl
        '
        Me.gboxResultEntryDtl.Controls.Add(Me.cmbxStaff)
        Me.gboxResultEntryDtl.Controls.Add(Me.lblStaff)
        Me.gboxResultEntryDtl.Controls.Add(Me.cmbxStudent)
        Me.gboxResultEntryDtl.Controls.Add(Me.dtgResultEntryDtl)
        Me.gboxResultEntryDtl.Controls.Add(Me.lblStudent)
        Me.gboxResultEntryDtl.Location = New System.Drawing.Point(18, 16)
        Me.gboxResultEntryDtl.Name = "gboxResultEntryDtl"
        Me.gboxResultEntryDtl.Size = New System.Drawing.Size(1322, 607)
        Me.gboxResultEntryDtl.TabIndex = 30
        Me.gboxResultEntryDtl.TabStop = False
        '
        'cmbxStaff
        '
        Me.cmbxStaff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxStaff.FormattingEnabled = True
        Me.cmbxStaff.Location = New System.Drawing.Point(608, 12)
        Me.cmbxStaff.Name = "cmbxStaff"
        Me.cmbxStaff.Size = New System.Drawing.Size(321, 26)
        Me.cmbxStaff.TabIndex = 159
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStaff.Location = New System.Drawing.Point(553, 15)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(49, 18)
        Me.lblStaff.TabIndex = 160
        Me.lblStaff.Text = "Staff :"
        '
        'cmbxStudent
        '
        Me.cmbxStudent.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxStudent.FormattingEnabled = True
        Me.cmbxStudent.Location = New System.Drawing.Point(128, 12)
        Me.cmbxStudent.Name = "cmbxStudent"
        Me.cmbxStudent.Size = New System.Drawing.Size(321, 26)
        Me.cmbxStudent.TabIndex = 2
        '
        'dtgResultEntryDtl
        '
        Me.dtgResultEntryDtl.AllowUserToAddRows = False
        Me.dtgResultEntryDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResultEntryDtl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgPerformanceDtlId, Me.dtgSubject, Me.dtgSubjectId, Me.dtgMarksScored, Me.dtgTotalMarks, Me.dtgFeedback, Me.dtgRemarks, Me.dtgExamType, Me.dtgDateOfExam})
        Me.dtgResultEntryDtl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgResultEntryDtl.Location = New System.Drawing.Point(6, 101)
        Me.dtgResultEntryDtl.Name = "dtgResultEntryDtl"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgResultEntryDtl.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgResultEntryDtl.Size = New System.Drawing.Size(1310, 356)
        Me.dtgResultEntryDtl.TabIndex = 6
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStudent.Location = New System.Drawing.Point(55, 15)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(68, 18)
        Me.lblStudent.TabIndex = 46
        Me.lblStudent.Text = "Student :"
        '
        'TabResultEntryLst
        '
        Me.TabResultEntryLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabResultEntryLst.Controls.Add(Me.dtgdResultEntryLst)
        Me.TabResultEntryLst.Location = New System.Drawing.Point(4, 22)
        Me.TabResultEntryLst.Name = "TabResultEntryLst"
        Me.TabResultEntryLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResultEntryLst.Size = New System.Drawing.Size(1359, 648)
        Me.TabResultEntryLst.TabIndex = 1
        Me.TabResultEntryLst.Text = "List"
        '
        'dtgdResultEntryLst
        '
        Me.dtgdResultEntryLst.Location = New System.Drawing.Point(6, 6)
        Me.dtgdResultEntryLst.Name = "dtgdResultEntryLst"
        Me.dtgdResultEntryLst.Size = New System.Drawing.Size(1347, 636)
        Me.dtgdResultEntryLst.TabIndex = 0
        '
        'dtgPerformanceDtlId
        '
        Me.dtgPerformanceDtlId.HeaderText = "PerformanceDtlId"
        Me.dtgPerformanceDtlId.Name = "dtgPerformanceDtlId"
        Me.dtgPerformanceDtlId.ReadOnly = True
        Me.dtgPerformanceDtlId.Visible = False
        '
        'dtgSubject
        '
        Me.dtgSubject.HeaderText = "Subject"
        Me.dtgSubject.Name = "dtgSubject"
        Me.dtgSubject.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgSubject.Width = 250
        '
        'dtgSubjectId
        '
        Me.dtgSubjectId.HeaderText = "SubjectId"
        Me.dtgSubjectId.Name = "dtgSubjectId"
        Me.dtgSubjectId.ReadOnly = True
        Me.dtgSubjectId.Visible = False
        '
        'dtgMarksScored
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dtgMarksScored.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgMarksScored.HeaderText = "Marks Scored"
        Me.dtgMarksScored.Name = "dtgMarksScored"
        Me.dtgMarksScored.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgTotalMarks
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dtgTotalMarks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgTotalMarks.HeaderText = "Total Marks"
        Me.dtgTotalMarks.Name = "dtgTotalMarks"
        Me.dtgTotalMarks.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTotalMarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgFeedback
        '
        Me.dtgFeedback.HeaderText = "Feedback"
        Me.dtgFeedback.Name = "dtgFeedback"
        '
        'dtgRemarks
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dtgRemarks.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgRemarks.HeaderText = "Remarks"
        Me.dtgRemarks.Name = "dtgRemarks"
        Me.dtgRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtgExamType
        '
        Me.dtgExamType.HeaderText = "Exam Type"
        Me.dtgExamType.Name = "dtgExamType"
        Me.dtgExamType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dtgDateOfExam
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dtgDateOfExam.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgDateOfExam.HeaderText = "Date of Exam"
        Me.dtgDateOfExam.Name = "dtgDateOfExam"
        '
        'frmTrnResultEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.tctrlResultEntryTrn)
        Me.Name = "frmTrnResultEntry"
        Me.Text = "Result Entry"
        Me.tctrlResultEntryTrn.ResumeLayout(False)
        Me.TabResultEntryDtl.ResumeLayout(False)
        Me.gboxResultEntryDtl.ResumeLayout(False)
        Me.gboxResultEntryDtl.PerformLayout()
        CType(Me.dtgResultEntryDtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResultEntryLst.ResumeLayout(False)
        CType(Me.dtgdResultEntryLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlResultEntryTrn As TabControl
    Friend WithEvents TabResultEntryDtl As TabPage
    Friend WithEvents gboxResultEntryDtl As GroupBox
    Friend WithEvents cmbxStudent As ComboBox
    Friend WithEvents dtgResultEntryDtl As DataGridView
    Friend WithEvents lblStudent As Label
    Friend WithEvents TabResultEntryLst As TabPage
    Friend WithEvents dtgdResultEntryLst As DataGridView
    Friend WithEvents cmbxStaff As ComboBox
    Friend WithEvents lblStaff As Label
    Friend WithEvents dtgPerformanceDtlId As DataGridViewTextBoxColumn
    Friend WithEvents dtgSubject As DataGridViewComboBoxColumn
    Friend WithEvents dtgSubjectId As DataGridViewTextBoxColumn
    Friend WithEvents dtgMarksScored As DataGridViewTextBoxColumn
    Friend WithEvents dtgTotalMarks As DataGridViewTextBoxColumn
    Friend WithEvents dtgFeedback As DataGridViewTextBoxColumn
    Friend WithEvents dtgRemarks As DataGridViewTextBoxColumn
    Friend WithEvents dtgExamType As DataGridViewTextBoxColumn
    Friend WithEvents dtgDateOfExam As DataGridViewTextBoxColumn
End Class
