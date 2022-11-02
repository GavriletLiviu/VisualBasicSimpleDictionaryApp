Imports System.IO
Public Class Form1
    Public words As New ArrayList
    Public definitions As New ArrayList
    Dim loginAttempt As Integer = 3
    Public fileName As String = "LoginData.txt"
    Public dictUsers As Dictionary(Of String, String)
    Public dictAccess As Dictionary(Of String, Integer)
    Public user = False
    Public admin = False
    Sub CreateDictUsers()
        dictUsers = New Dictionary(Of String, String)
        dictAccess = New Dictionary(Of String, Integer)
        If File.Exists(fileName) Then
            Dim lines As String()
            lines = File.ReadAllLines(fileName)
            For Each line As String In lines
                Dim info As String()
                info = line.Split("|")
                If info.Count = 3 Then
                    If Not dictUsers.ContainsKey(info(0)) Then
                        dictUsers.Add(info(0), info(1))
                        dictAccess.Add(info(0), info(2))
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text.Trim() <> Nothing And txtPassword.Text.Trim <> Nothing Then
            TryLoginBetter()
            If loginAttempt = 0 Then
                Me.Close()
            End If
        End If
    End Sub
    Sub TryLoginBetter()
        If dictUsers.ContainsKey(txtUser.Text) Then
            If dictUsers(txtUser.Text) = txtPassword.Text Then
                Me.Hide()
                Dim role As Integer
                role = dictAccess(txtUser.Text)
                Select Case role
                    Case 0
                        Form2.Show()
                        Me.Hide()
                        user = True
                    Case 1
                        Form3.Show()
                        Me.Hide()
                        admin = True
                    Case 2
                        Form5.Show()
                        Me.Hide()
                End Select
                loginAttempt = 3
            Else
                loginAttempt -= 1
                MsgBox("incorrect password" & vbCrLf & loginAttempt.ToString() & "atempts left")
                txtPassword.Clear()
            End If
        Else
            loginAttempt -= 1
            MsgBox("incorrect user" & vbCrLf & loginAttempt.ToString() & "atempts left")
            txtUser.Clear()
        End If
    End Sub
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temporaryLibraryWithEmpty As String()
        temporaryLibraryWithEmpty = File.ReadAllLines("library.txt")
        Dim temporaryLibrary As New ArrayList
        For Each item In temporaryLibraryWithEmpty
            If item <> Nothing Then
                temporaryLibrary.Add(item)
            End If
        Next
        temporaryLibrary.Sort()
        For i As Integer = 0 To temporaryLibrary.Count - 1
            Dim item As String()
            Dim separator As Char() = "="
            item = temporaryLibrary(i).Split(separator)
            If item.Length <> 2 Then
                MessageBox.Show("Corupt library! Could not load library!", "Corupt Library", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            words.Add(item(0))
            definitions.Add(item(1))
        Next
        txtUser.Clear()
        txtPassword.Clear()
        CreateDictUsers()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Form6.Show()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblShowPassword.LinkClicked
        If lblShowPassword.Text = "Show password" Then
            txtPassword.PasswordChar = ""
            lblShowPassword.Text = "Hide password"
        Else
            txtPassword.PasswordChar = "*"
            lblShowPassword.Text = "Show password"
        End If
    End Sub
End Class
