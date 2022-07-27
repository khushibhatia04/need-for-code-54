
Public Class frmLogin
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim MyConn As New SQLControl
        Dim strSysName As String

        MyConn.AddParam("@Login", txtLogin.Text)
        MyConn.AddParam("@Pswd", txtPassword.Text)
        MyConn.ExecQuery("Select * from Users Where LoginName = @login And Password = @pswd;")
        If MyConn.HasException = True Then Exit Sub

        If MyConn.RecordCount = 0 Then
            MessageBox.Show("Login Name / Password does not match, try again ...")
        Else
            'GlobalVariables.UserCode = MyConn.DBDT.Rows(0)("StaffCode").ToString
            GlobalVariables.UserId = MyConn.DBDT.Rows(0)("UserId").ToString
            'GlobalVariables.UsrName = MyConn.DBDT.Rows(0)("StaffName").ToString
            MyConn.DBDT.Clear()
            strSysName = System.Windows.Forms.SystemInformation.ComputerName
            frmMdiMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        MsgBox("Key Press event")
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        MsgBox("Key press event fired")
        If e.KeyCode = 13 Then
            btnLogin_Click(sender, e)
        ElseIf e.KeyCode = 27 Then
            btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        MsgBox("Key Up event")
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strINIFilePathName As String
        ' get Server Connection Details
        strINIFilePathName = "C:\Users\etash\source\repos\etashd2002\need-for-code-54\team54.INI"
        GlobalVariables.strServer = SQLControl.GetIniValue("Database", "Server", strINIFilePathName)
        GlobalVariables.strDatabase = SQLControl.GetIniValue("Database", "Database", strINIFilePathName)
        GlobalVariables.strUser = SQLControl.GetIniValue("Database", "User", strINIFilePathName)
        GlobalVariables.strPswd = SQLControl.GetIniValue("Database", "Pswd", strINIFilePathName)
        GlobalVariables.strDSN = SQLControl.GetIniValue("Database", "DSN", strINIFilePathName)
        GlobalVariables.strReportPath = SQLControl.GetIniValue("Database", "ReportPath", strINIFilePathName)
        GlobalVariables.strConnString = "Server=" & GlobalVariables.strServer & ";Database=" & GlobalVariables.strDatabase & ";User=" & GlobalVariables.strUser & ";Pwd=" & GlobalVariables.strPswd & ";"
        If String.IsNullOrEmpty(GlobalVariables.strServer) Or String.IsNullOrEmpty(GlobalVariables.strDatabase) Or String.IsNullOrEmpty(GlobalVariables.strUser) Or String.IsNullOrEmpty(GlobalVariables.strPswd) Then
            MessageBox.Show("Server Details not available, cannot proceed with running the Application ...")
            Application.Exit()
        End If
    End Sub
End Class