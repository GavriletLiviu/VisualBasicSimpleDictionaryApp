Imports System.IO
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateUserList()
    End Sub
    Sub updateUserList()
        listUsers.Items.Clear()
        For Each user As String In Form1.dictUsers.Keys
            listUsers.Items.Add(user)
        Next
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
        Form1.txtUser.Clear()
        Form1.txtPassword.Clear()
        Form1.user = False
        Form1.admin = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Close()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listUsers.SelectedIndexChanged
        If listUsers.SelectedIndex <> -1 Then
            Dim user, password As String
            user = listUsers.SelectedItem
            password = Form1.dictUsers(user)
            txtUser.Text = user
            txtPass.Text = password
            cmbRole.SelectedIndex = Form1.dictAccess(user)
            txtUser.ReadOnly = True
            txtPass.ReadOnly = True
        End If
    End Sub
    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click
        txtUser.ReadOnly = False
        txtPass.ReadOnly = False
        txtUser.Clear()
        txtPass.Clear()
        listUsers.SelectedIndex = -1
        cmbRole.SelectedIndex = -1
    End Sub
    Private Sub MenuItemAdd_Click(sender As Object, e As EventArgs) Handles MenuItemAdd.Click
        If txtUser.Text.Trim() <> Nothing And txtPass.Text.Trim() <> Nothing And cmbRole.SelectedIndex <> -1 Then
            If Form6.SaveInfoUser(txtUser.Text, txtPass.Text) Then
                Form1.txtUser.Text = txtUser.Text
                Form1.txtPassword.Text = txtPass.Text
            End If
            MsgBox("user added!")
            updateUserList()
            bntClear_Click(bntClear, e)
        Else
            MsgBox("invalid login information")
        End If
    End Sub
    Private Sub MenuItemUpdateCredentials_Click(sender As Object, e As EventArgs) Handles MenuItemUpdateCredentials.Click
        If cmbRole.SelectedIndex <> -1 And listUsers.SelectedIndex <> -1 Then
            Dim seluser As String
            seluser = listUsers.SelectedItem
            If Not Form1.dictAccess(seluser) = cmbRole.SelectedIndex Then
                Form1.dictAccess(seluser) = cmbRole.SelectedIndex
                MsgBox("credentials changed!")
            End If
            File.WriteAllText("LoginData.txt", "")
            For Each user In Form1.dictUsers.Keys
                File.AppendAllText(Form1.fileName, user & "|" & Form1.dictUsers(user) & "|" & Form1.dictAccess(user) & vbCrLf)
            Next
        End If
    End Sub
    Private Sub MenuItemRemoveUser_Click(sender As Object, e As EventArgs) Handles MenuItemRemoveUser.Click
        If listUsers.SelectedIndex <> -1 Then
            Dim removeUser As String
            removeUser = listUsers.SelectedItem
            Form1.dictUsers.Remove(removeUser)
            Form1.dictAccess.Remove(removeUser)
            updateUserList()
            File.WriteAllText(Form1.fileName, "")
            For Each user As String In Form1.dictUsers.Keys
                File.AppendAllText(Form1.fileName, user & "|" & Form1.dictUsers(user) & "|" & Form1.dictAccess(user) & vbCrLf)
            Next
            bntClear_Click(bntClear, e)
        End If
    End Sub
End Class