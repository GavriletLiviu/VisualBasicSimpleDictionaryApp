Imports System.IO
Public Class Form2
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        For i As Integer = 0 To Form1.words.Count - 1
            If txtSearch.Text = Form1.words(i) Then
                txtResult.Text = Form1.definitions(i)
            End If
        Next
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Close()
    End Sub
    Private Sub btnShowItems_Click(sender As Object, e As EventArgs) Handles btnShowItems.Click
        Me.Close()
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
        Form1.txtPassword.Clear()
        Form1.txtUser.Clear()
        Form1.user = False
        Form1.admin = False
    End Sub
End Class