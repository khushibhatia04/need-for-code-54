<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstSubject
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
        Me.tctrlSubjectMst = New System.Windows.Forms.TabControl()
        Me.TabSubjectDtl = New System.Windows.Forms.TabPage()
        Me.gboxSubjectDtl = New System.Windows.Forms.GroupBox()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.TabSubjectLst = New System.Windows.Forms.TabPage()
        Me.dtgdSubjectLst = New System.Windows.Forms.DataGridView()
        Me.tctrlSubjectMst.SuspendLayout()
        Me.TabSubjectDtl.SuspendLayout()
        Me.gboxSubjectDtl.SuspendLayout()
        Me.TabSubjectLst.SuspendLayout()
        CType(Me.dtgdSubjectLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctrlSubjectMst
        '
        Me.tctrlSubjectMst.Controls.Add(Me.TabSubjectDtl)
        Me.tctrlSubjectMst.Controls.Add(Me.TabSubjectLst)
        Me.tctrlSubjectMst.Location = New System.Drawing.Point(12, 12)
        Me.tctrlSubjectMst.Name = "tctrlSubjectMst"
        Me.tctrlSubjectMst.SelectedIndex = 0
        Me.tctrlSubjectMst.Size = New System.Drawing.Size(1210, 604)
        Me.tctrlSubjectMst.TabIndex = 4
        '
        'TabSubjectDtl
        '
        Me.TabSubjectDtl.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabSubjectDtl.Controls.Add(Me.gboxSubjectDtl)
        Me.TabSubjectDtl.Location = New System.Drawing.Point(4, 22)
        Me.TabSubjectDtl.Name = "TabSubjectDtl"
        Me.TabSubjectDtl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSubjectDtl.Size = New System.Drawing.Size(1202, 578)
        Me.TabSubjectDtl.TabIndex = 0
        Me.TabSubjectDtl.Text = "Add/Update/Delete"
        '
        'gboxSubjectDtl
        '
        Me.gboxSubjectDtl.BackColor = System.Drawing.Color.Wheat
        Me.gboxSubjectDtl.Controls.Add(Me.txtSubjectName)
        Me.gboxSubjectDtl.Controls.Add(Me.lblSubjectName)
        Me.gboxSubjectDtl.Location = New System.Drawing.Point(170, 79)
        Me.gboxSubjectDtl.Name = "gboxSubjectDtl"
        Me.gboxSubjectDtl.Size = New System.Drawing.Size(853, 427)
        Me.gboxSubjectDtl.TabIndex = 30
        Me.gboxSubjectDtl.TabStop = False
        '
        'txtSubjectName
        '
        Me.txtSubjectName.Location = New System.Drawing.Point(262, 113)
        Me.txtSubjectName.MaxLength = 125
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(292, 20)
        Me.txtSubjectName.TabIndex = 52
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.ForeColor = System.Drawing.Color.Sienna
        Me.lblSubjectName.Location = New System.Drawing.Point(175, 116)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(80, 13)
        Me.lblSubjectName.TabIndex = 54
        Me.lblSubjectName.Text = "Subject Name :"
        '
        'TabSubjectLst
        '
        Me.TabSubjectLst.BackColor = System.Drawing.Color.MistyRose
        Me.TabSubjectLst.Controls.Add(Me.dtgdSubjectLst)
        Me.TabSubjectLst.Location = New System.Drawing.Point(4, 22)
        Me.TabSubjectLst.Name = "TabSubjectLst"
        Me.TabSubjectLst.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSubjectLst.Size = New System.Drawing.Size(1202, 578)
        Me.TabSubjectLst.TabIndex = 1
        Me.TabSubjectLst.Text = "List"
        '
        'dtgdSubjectLst
        '
        Me.dtgdSubjectLst.Location = New System.Drawing.Point(6, 7)
        Me.dtgdSubjectLst.Name = "dtgdSubjectLst"
        Me.dtgdSubjectLst.Size = New System.Drawing.Size(1190, 565)
        Me.dtgdSubjectLst.TabIndex = 0
        '
        'frmMstSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 628)
        Me.Controls.Add(Me.tctrlSubjectMst)
        Me.Name = "frmMstSubject"
        Me.Text = "Subjects"
        Me.tctrlSubjectMst.ResumeLayout(False)
        Me.TabSubjectDtl.ResumeLayout(False)
        Me.gboxSubjectDtl.ResumeLayout(False)
        Me.gboxSubjectDtl.PerformLayout()
        Me.TabSubjectLst.ResumeLayout(False)
        CType(Me.dtgdSubjectLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tctrlSubjectMst As TabControl
    Friend WithEvents TabSubjectDtl As TabPage
    Friend WithEvents gboxSubjectDtl As GroupBox
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents TabSubjectLst As TabPage
    Friend WithEvents dtgdSubjectLst As DataGridView
End Class
