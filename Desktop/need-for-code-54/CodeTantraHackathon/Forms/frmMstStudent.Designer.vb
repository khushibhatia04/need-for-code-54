<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstStudent
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
        Me.tctrlStudentMst = New System.Windows.Forms.TabControl()
        Me.TabStudentDtl = New System.Windows.Forms.TabPage()
        Me.gboxStudentDtl = New System.Windows.Forms.GroupBox()
        Me.txtStudentAddress = New System.Windows.Forms.TextBox()
        Me.lblStudentAddress = New System.Windows.Forms.Label()
        Me.dtpStudentDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblStudentDOB = New System.Windows.Forms.Label()
        Me.cmbxStudentYear = New System.Windows.Forms.ComboBox()
        Me.lblStudentYear = New System.Windows.Forms.Label()
        Me.txtParentContactNo = New System.Windows.Forms.TextBox()
        Me.lblParentContactNo = New System.Windows.Forms.Label()
        Me.txtStudentContactNo = New System.Windows.Forms.TextBox()
        Me.lblStudentContactNo = New System.Windows.Forms.Label()
        Me.txtStudentEmail = New System.Windows.Forms.TextBox()
        Me.lblStudentEmail = New System.Windows.Forms.Label()
        Me.cmbxStudentClass = New System.Windows.Forms.ComboBox()
        Me.lblStudentClass = New System.Windows.Forms.Label()
        Me.txtStudentCode = New System.Windows.Forms.TextBox()
        Me.lblStudentCode = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabStudentLst = New System.Windows.Forms.TabPage()
        Me.dtgdStudentLst = New System.Windows.Forms.DataGridView()
        Me.tctrlStudentMst.SuspendLayout()
        Me.TabStudentDtl.SuspendLayout()
        Me.gboxStudentDtl.SuspendLayout()
        Me.TabStudentLst.SuspendLayout()
        CType(Me.dtgdStudentLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlStudentMst
        '
        Me.tctrlStudentMst.Controls.Add(Me.TabStudentDtl)
        Me.tctrlStudentMst.Controls.Add(Me.TabStudentLst)
        Me.tctrlStudentMst.Location = New System.Drawing.Point(12, 12)
        Me.tctrlStudentMst.Name = "tctrlStudentMst"
        Me.tctrlStudentMst.SelectedIndex = 0
        Me.tctrlStudentMst.Size = New System.Drawing.Size(1210, 604)
        Me.tctrlStudentMst.TabIndex = 3
        '
        'TabStudentDtl
        '
        Me.TabStudentDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabStudentDtl.Controls.Add(Me.gboxStudentDtl)
        Me.TabStudentDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabStudentDtl.Name = "TabStudentDtl"
        Me.TabStudentDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStudentDtl.Size = New System.Drawing.Size(1202, 578)
        Me.TabStudentDtl.TabIndex = 0
        Me.TabStudentDtl.Text = "Add/Update/Delete"
        '
        'gboxStudentDtl
        '
        Me.gboxStudentDtl.BackColor = System.Drawing.Color.Wheat
        Me.gboxStudentDtl.Controls.Add(Me.txtStudentAddress)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentAddress)
        Me.gboxStudentDtl.Controls.Add(Me.dtpStudentDOB)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentDOB)
        Me.gboxStudentDtl.Controls.Add(Me.cmbxStudentYear)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentYear)
        Me.gboxStudentDtl.Controls.Add(Me.txtParentContactNo)
        Me.gboxStudentDtl.Controls.Add(Me.lblParentContactNo)
        Me.gboxStudentDtl.Controls.Add(Me.txtStudentContactNo)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentContactNo)
        Me.gboxStudentDtl.Controls.Add(Me.txtStudentEmail)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentEmail)
        Me.gboxStudentDtl.Controls.Add(Me.cmbxStudentClass)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentClass)
        Me.gboxStudentDtl.Controls.Add(Me.txtStudentCode)
        Me.gboxStudentDtl.Controls.Add(Me.lblStudentCode)
        Me.gboxStudentDtl.Controls.Add(Me.txtStudentName)
        Me.gboxStudentDtl.Controls.Add(Me.lblName)
        Me.gboxStudentDtl.Location = New System.Drawing.Point(170, 79)
        Me.gboxStudentDtl.Name = "gboxStudentDtl"
        Me.gboxStudentDtl.Size = New System.Drawing.Size(853, 427)
        Me.gboxStudentDtl.TabIndex = 30
        Me.gboxStudentDtl.TabStop = False
        '
        'txtStudentAddress
        '
        Me.txtStudentAddress.Location = New System.Drawing.Point(244, 275)
        Me.txtStudentAddress.MaxLength = 4000
        Me.txtStudentAddress.Multiline = True
        Me.txtStudentAddress.Name = "txtStudentAddress"
        Me.txtStudentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudentAddress.Size = New System.Drawing.Size(292, 58)
        Me.txtStudentAddress.TabIndex = 81
        '
        'lblStudentAddress
        '
        Me.lblStudentAddress.AutoSize = True
        Me.lblStudentAddress.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentAddress.Location = New System.Drawing.Point(147, 278)
        Me.lblStudentAddress.Name = "lblStudentAddress"
        Me.lblStudentAddress.Size = New System.Drawing.Size(91, 13)
        Me.lblStudentAddress.TabIndex = 82
        Me.lblStudentAddress.Text = "Student Address :"
        '
        'dtpStudentDOB
        '
        Me.dtpStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStudentDOB.Location = New System.Drawing.Point(244, 249)
        Me.dtpStudentDOB.Name = "dtpStudentDOB"
        Me.dtpStudentDOB.Size = New System.Drawing.Size(109, 20)
        Me.dtpStudentDOB.TabIndex = 80
        Me.dtpStudentDOB.Value = New Date(2022, 7, 26, 13, 17, 23, 0)
        '
        'lblStudentDOB
        '
        Me.lblStudentDOB.AutoSize = True
        Me.lblStudentDOB.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentDOB.Location = New System.Drawing.Point(162, 252)
        Me.lblStudentDOB.Name = "lblStudentDOB"
        Me.lblStudentDOB.Size = New System.Drawing.Size(76, 13)
        Me.lblStudentDOB.TabIndex = 79
        Me.lblStudentDOB.Text = "Student DOB :"
        '
        'cmbxStudentYear
        '
        Me.cmbxStudentYear.AllowDrop = True
        Me.cmbxStudentYear.FormattingEnabled = True
        Me.cmbxStudentYear.Location = New System.Drawing.Point(244, 222)
        Me.cmbxStudentYear.MaxLength = 50
        Me.cmbxStudentYear.Name = "cmbxStudentYear"
        Me.cmbxStudentYear.Size = New System.Drawing.Size(93, 21)
        Me.cmbxStudentYear.TabIndex = 78
        '
        'lblStudentYear
        '
        Me.lblStudentYear.AutoSize = True
        Me.lblStudentYear.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentYear.Location = New System.Drawing.Point(163, 225)
        Me.lblStudentYear.Name = "lblStudentYear"
        Me.lblStudentYear.Size = New System.Drawing.Size(75, 13)
        Me.lblStudentYear.TabIndex = 77
        Me.lblStudentYear.Text = "Student Year :"
        '
        'txtParentContactNo
        '
        Me.txtParentContactNo.Location = New System.Drawing.Point(244, 196)
        Me.txtParentContactNo.MaxLength = 10
        Me.txtParentContactNo.Name = "txtParentContactNo"
        Me.txtParentContactNo.Size = New System.Drawing.Size(292, 20)
        Me.txtParentContactNo.TabIndex = 75
        '
        'lblParentContactNo
        '
        Me.lblParentContactNo.AutoSize = True
        Me.lblParentContactNo.ForeColor = System.Drawing.Color.Sienna
        Me.lblParentContactNo.Location = New System.Drawing.Point(134, 199)
        Me.lblParentContactNo.Name = "lblParentContactNo"
        Me.lblParentContactNo.Size = New System.Drawing.Size(104, 13)
        Me.lblParentContactNo.TabIndex = 76
        Me.lblParentContactNo.Text = "Parent Contact No. :"
        '
        'txtStudentContactNo
        '
        Me.txtStudentContactNo.Location = New System.Drawing.Point(244, 170)
        Me.txtStudentContactNo.MaxLength = 10
        Me.txtStudentContactNo.Name = "txtStudentContactNo"
        Me.txtStudentContactNo.Size = New System.Drawing.Size(292, 20)
        Me.txtStudentContactNo.TabIndex = 73
        '
        'lblStudentContactNo
        '
        Me.lblStudentContactNo.AutoSize = True
        Me.lblStudentContactNo.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentContactNo.Location = New System.Drawing.Point(128, 173)
        Me.lblStudentContactNo.Name = "lblStudentContactNo"
        Me.lblStudentContactNo.Size = New System.Drawing.Size(110, 13)
        Me.lblStudentContactNo.TabIndex = 74
        Me.lblStudentContactNo.Text = "Student Contact No. :"
        '
        'txtStudentEmail
        '
        Me.txtStudentEmail.Location = New System.Drawing.Point(244, 144)
        Me.txtStudentEmail.MaxLength = 100
        Me.txtStudentEmail.Name = "txtStudentEmail"
        Me.txtStudentEmail.Size = New System.Drawing.Size(292, 20)
        Me.txtStudentEmail.TabIndex = 71
        '
        'lblStudentEmail
        '
        Me.lblStudentEmail.AutoSize = True
        Me.lblStudentEmail.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentEmail.Location = New System.Drawing.Point(160, 147)
        Me.lblStudentEmail.Name = "lblStudentEmail"
        Me.lblStudentEmail.Size = New System.Drawing.Size(78, 13)
        Me.lblStudentEmail.TabIndex = 72
        Me.lblStudentEmail.Text = "Student Email :"
        '
        'cmbxStudentClass
        '
        Me.cmbxStudentClass.AllowDrop = True
        Me.cmbxStudentClass.FormattingEnabled = True
        Me.cmbxStudentClass.Location = New System.Drawing.Point(244, 117)
        Me.cmbxStudentClass.MaxLength = 50
        Me.cmbxStudentClass.Name = "cmbxStudentClass"
        Me.cmbxStudentClass.Size = New System.Drawing.Size(93, 21)
        Me.cmbxStudentClass.TabIndex = 70
        '
        'lblStudentClass
        '
        Me.lblStudentClass.AutoSize = True
        Me.lblStudentClass.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentClass.Location = New System.Drawing.Point(160, 120)
        Me.lblStudentClass.Name = "lblStudentClass"
        Me.lblStudentClass.Size = New System.Drawing.Size(78, 13)
        Me.lblStudentClass.TabIndex = 69
        Me.lblStudentClass.Text = "Student Class :"
        '
        'txtStudentCode
        '
        Me.txtStudentCode.Location = New System.Drawing.Point(244, 91)
        Me.txtStudentCode.MaxLength = 10
        Me.txtStudentCode.Name = "txtStudentCode"
        Me.txtStudentCode.Size = New System.Drawing.Size(93, 20)
        Me.txtStudentCode.TabIndex = 57
        '
        'lblStudentCode
        '
        Me.lblStudentCode.AutoSize = True
        Me.lblStudentCode.ForeColor = System.Drawing.Color.Sienna
        Me.lblStudentCode.Location = New System.Drawing.Point(160, 94)
        Me.lblStudentCode.Name = "lblStudentCode"
        Me.lblStudentCode.Size = New System.Drawing.Size(78, 13)
        Me.lblStudentCode.TabIndex = 58
        Me.lblStudentCode.Text = "Student Code :"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(244, 65)
        Me.txtStudentName.MaxLength = 125
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(292, 20)
        Me.txtStudentName.TabIndex = 52
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Sienna
        Me.lblName.Location = New System.Drawing.Point(157, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 13)
        Me.lblName.TabIndex = 54
        Me.lblName.Text = "Student Name :"
        '
        'TabStudentLst
        '
        Me.TabStudentLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabStudentLst.Controls.Add(Me.dtgdStudentLst)
        Me.TabStudentLst.Location = New System.Drawing.Point(4, 22)
        Me.TabStudentLst.Name = "TabStudentLst"
        Me.TabStudentLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStudentLst.Size = New System.Drawing.Size(1202, 578)
        Me.TabStudentLst.TabIndex = 1
        Me.TabStudentLst.Text = "List"
        '
        'dtgdStudentLst
        '
        Me.dtgdStudentLst.Location = New System.Drawing.Point(6, 7)
        Me.dtgdStudentLst.Name = "dtgdStudentLst"
        Me.dtgdStudentLst.Size = New System.Drawing.Size(1190, 565)
        Me.dtgdStudentLst.TabIndex = 0
        '
        'frmMstStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 628)
        Me.Controls.Add(Me.tctrlStudentMst)
        Me.Name = "frmMstStudent"
        Me.Text = "Students"
        Me.tctrlStudentMst.ResumeLayout(False)
        Me.TabStudentDtl.ResumeLayout(False)
        Me.gboxStudentDtl.ResumeLayout(False)
        Me.gboxStudentDtl.PerformLayout()
        Me.TabStudentLst.ResumeLayout(False)
        CType(Me.dtgdStudentLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlStudentMst As TabControl
    Friend WithEvents TabStudentDtl As TabPage
    Friend WithEvents gboxStudentDtl As GroupBox
    Friend WithEvents txtStudentCode As TextBox
    Friend WithEvents lblStudentCode As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents TabStudentLst As TabPage
    Friend WithEvents dtgdStudentLst As DataGridView
    Friend WithEvents dtpStudentDOB As DateTimePicker
    Friend WithEvents lblStudentDOB As Label
    Friend WithEvents cmbxStudentYear As ComboBox
    Friend WithEvents lblStudentYear As Label
    Friend WithEvents txtParentContactNo As TextBox
    Friend WithEvents lblParentContactNo As Label
    Friend WithEvents txtStudentContactNo As TextBox
    Friend WithEvents lblStudentContactNo As Label
    Friend WithEvents txtStudentEmail As TextBox
    Friend WithEvents lblStudentEmail As Label
    Friend WithEvents cmbxStudentClass As ComboBox
    Friend WithEvents lblStudentClass As Label
    Friend WithEvents txtStudentAddress As TextBox
    Friend WithEvents lblStudentAddress As Label
End Class
