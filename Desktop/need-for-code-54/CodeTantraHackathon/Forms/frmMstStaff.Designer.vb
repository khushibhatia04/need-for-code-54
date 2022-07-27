<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstStaff
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
        Me.tctrlStaffMst = New System.Windows.Forms.TabControl()
        Me.TabStaffDtl = New System.Windows.Forms.TabPage()
        Me.gboxStaffDtl = New System.Windows.Forms.GroupBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.cmbxPosition = New System.Windows.Forms.ComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.TabStaffLst = New System.Windows.Forms.TabPage()
        Me.dtgdStaffLst = New System.Windows.Forms.DataGridView()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tctrlStaffMst.SuspendLayout()
        Me.TabStaffDtl.SuspendLayout()
        Me.gboxStaffDtl.SuspendLayout()
        Me.TabStaffLst.SuspendLayout()
        CType(Me.dtgdStaffLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlStaffMst
        '
        Me.tctrlStaffMst.Controls.Add(Me.TabStaffDtl)
        Me.tctrlStaffMst.Controls.Add(Me.TabStaffLst)
        Me.tctrlStaffMst.Location = New System.Drawing.Point(12, 12)
        Me.tctrlStaffMst.Name = "tctrlStaffMst"
        Me.tctrlStaffMst.SelectedIndex = 0
        Me.tctrlStaffMst.Size = New System.Drawing.Size(1210, 604)
        Me.tctrlStaffMst.TabIndex = 5
        '
        'TabStaffDtl
        '
        Me.TabStaffDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabStaffDtl.Controls.Add(Me.gboxStaffDtl)
        Me.TabStaffDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabStaffDtl.Name = "TabStaffDtl"
        Me.TabStaffDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStaffDtl.Size = New System.Drawing.Size(1202, 578)
        Me.TabStaffDtl.TabIndex = 0
        Me.TabStaffDtl.Text = "Add/Update/Delete"
        '
        'gboxStaffDtl
        '
        Me.gboxStaffDtl.Controls.Add(Me.txtEmail)
        Me.gboxStaffDtl.Controls.Add(Me.lblEmail)
        Me.gboxStaffDtl.Controls.Add(Me.txtContact)
        Me.gboxStaffDtl.Controls.Add(Me.lblContact)
        Me.gboxStaffDtl.Controls.Add(Me.txtStaffName)
        Me.gboxStaffDtl.Controls.Add(Me.cmbxPosition)
        Me.gboxStaffDtl.Controls.Add(Me.lblPosition)
        Me.gboxStaffDtl.Controls.Add(Me.lblStaffName)
        Me.gboxStaffDtl.Location = New System.Drawing.Point(170, 79)
        Me.gboxStaffDtl.Name = "gboxStaffDtl"
        Me.gboxStaffDtl.Size = New System.Drawing.Size(853, 427)
        Me.gboxStaffDtl.TabIndex = 30
        Me.gboxStaffDtl.TabStop = False
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(262, 113)
        Me.txtStaffName.MaxLength = 125
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(227, 20)
        Me.txtStaffName.TabIndex = 52
        '
        'cmbxPosition
        '
        Me.cmbxPosition.AllowDrop = True
        Me.cmbxPosition.FormattingEnabled = True
        Me.cmbxPosition.Location = New System.Drawing.Point(262, 139)
        Me.cmbxPosition.MaxLength = 50
        Me.cmbxPosition.Name = "cmbxPosition"
        Me.cmbxPosition.Size = New System.Drawing.Size(177, 21)
        Me.cmbxPosition.TabIndex = 53
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ForeColor = System.Drawing.Color.Sienna
        Me.lblPosition.Location = New System.Drawing.Point(206, 142)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(50, 13)
        Me.lblPosition.TabIndex = 55
        Me.lblPosition.Text = "Position :"
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.ForeColor = System.Drawing.Color.Sienna
        Me.lblStaffName.Location = New System.Drawing.Point(190, 116)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(66, 13)
        Me.lblStaffName.TabIndex = 54
        Me.lblStaffName.Text = "Staff Name :"
        '
        'TabStaffLst
        '
        Me.TabStaffLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabStaffLst.Controls.Add(Me.dtgdStaffLst)
        Me.TabStaffLst.Location = New System.Drawing.Point(4, 22)
        Me.TabStaffLst.Name = "TabStaffLst"
        Me.TabStaffLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStaffLst.Size = New System.Drawing.Size(1202, 578)
        Me.TabStaffLst.TabIndex = 1
        Me.TabStaffLst.Text = "List"
        '
        'dtgdStaffLst
        '
        Me.dtgdStaffLst.Location = New System.Drawing.Point(6, 7)
        Me.dtgdStaffLst.Name = "dtgdStaffLst"
        Me.dtgdStaffLst.Size = New System.Drawing.Size(1190, 565)
        Me.dtgdStaffLst.TabIndex = 0
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(262, 166)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(177, 20)
        Me.txtContact.TabIndex = 56
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.ForeColor = System.Drawing.Color.Sienna
        Me.lblContact.Location = New System.Drawing.Point(206, 169)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(50, 13)
        Me.lblContact.TabIndex = 57
        Me.lblContact.Text = "Contact :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(262, 192)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 58
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.Color.Sienna
        Me.lblEmail.Location = New System.Drawing.Point(218, 195)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 59
        Me.lblEmail.Text = "Email :"
        '
        'frmMstStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 628)
        Me.Controls.Add(Me.tctrlStaffMst)
        Me.Name = "frmMstStaff"
        Me.Text = "Staff"
        Me.tctrlStaffMst.ResumeLayout(False)
        Me.TabStaffDtl.ResumeLayout(False)
        Me.gboxStaffDtl.ResumeLayout(False)
        Me.gboxStaffDtl.PerformLayout()
        Me.TabStaffLst.ResumeLayout(False)
        CType(Me.dtgdStaffLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlStaffMst As TabControl
    Friend WithEvents TabStaffDtl As TabPage
    Friend WithEvents gboxStaffDtl As GroupBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents cmbxPosition As ComboBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblStaffName As Label
    Friend WithEvents TabStaffLst As TabPage
    Friend WithEvents dtgdStaffLst As DataGridView
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
End Class
