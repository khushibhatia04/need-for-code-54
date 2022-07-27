<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.picb = New System.Windows.Forms.PictureBox()
        Me.lblWorkingDisplay = New System.Windows.Forms.Label()
        CType(Me.picb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(469, 209)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogin.MaxLength = 15
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(153, 26)
        Me.txtLogin.TabIndex = 0
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLogin.ForeColor = System.Drawing.Color.Maroon
        Me.lblLogin.Location = New System.Drawing.Point(409, 213)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(51, 18)
        Me.lblLogin.TabIndex = 1
        Me.lblLogin.Text = "Login :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblPassword.Location = New System.Drawing.Point(384, 245)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(79, 18)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(469, 241)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(153, 26)
        Me.txtPassword.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Wheat
        Me.btnLogin.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLogin.Location = New System.Drawing.Point(424, 284)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 37)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Wheat
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancel.Location = New System.Drawing.Point(505, 284)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 37)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'picb
        '
        Me.picb.Image = CType(resources.GetObject("picb.Image"), System.Drawing.Image)
        Me.picb.InitialImage = CType(resources.GetObject("picb.InitialImage"), System.Drawing.Image)
        Me.picb.Location = New System.Drawing.Point(17, 42)
        Me.picb.Margin = New System.Windows.Forms.Padding(4)
        Me.picb.Name = "picb"
        Me.picb.Size = New System.Drawing.Size(303, 279)
        Me.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picb.TabIndex = 6
        Me.picb.TabStop = False
        '
        'lblWorkingDisplay
        '
        Me.lblWorkingDisplay.AutoSize = True
        Me.lblWorkingDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWorkingDisplay.ForeColor = System.Drawing.Color.Blue
        Me.lblWorkingDisplay.Location = New System.Drawing.Point(321, 337)
        Me.lblWorkingDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWorkingDisplay.Name = "lblWorkingDisplay"
        Me.lblWorkingDisplay.Size = New System.Drawing.Size(0, 18)
        Me.lblWorkingDisplay.TabIndex = 7
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 364)
        Me.Controls.Add(Me.lblWorkingDisplay)
        Me.Controls.Add(Me.picb)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtLogin)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.Text = "Login Screen"
        CType(Me.picb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLogin As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents picb As PictureBox
    Friend WithEvents lblWorkingDisplay As Label
End Class
