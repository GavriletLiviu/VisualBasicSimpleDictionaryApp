Imports System.IO
Public Class Form6
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUser.Text.Trim() <> Nothing And txtPassword.Text.Trim() <> Nothing And txtPassword.Text = txtConfirmPass.Text And cmbRole.SelectedIndex <> -1 Then
            If SaveInfoUser(txtUser.Text, txtPassword.Text) Then
                Form1.txtUser.Text = txtUser.Text
                Form1.txtPassword.Text = txtPassword.Text
            End If
        Else
            MsgBox("invalid login information")
        End If
    End Sub
    Public Function SaveInfoUser(user As String, pass As String) As Boolean
        If Form1.dictUsers.ContainsKey(user) Then
            MsgBox("username already exists")
            Return False
        Else
            Form1.dictUsers.Add(user, pass)
            Form1.dictAccess.Add(user, cmbRole.SelectedIndex + 1)
            File.AppendAllText(Form1.fileName, vbCrLf & user & "|" & pass & "|" & (cmbRole.SelectedIndex + 1))
            Return True
        End If
    End Function
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbShowPass.LinkClicked
        If lbShowPass.Text = "Show password" Then
            txtPassword.PasswordChar = ""
            txtConfirmPass.PasswordChar = ""
            lbShowPass.Text = "Hide password"
        Else
            lbShowPass.Text = "Show password"
            txtPassword.PasswordChar = "*"
            txtConfirmPass.PasswordChar = "*"
        End If
    End Sub
End Class