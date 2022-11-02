Imports System.IO
Public Class Form4
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If Form1.user Then
            Me.Hide()
            Form2.Show()
        End If
        If Form1.admin Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.user Then
            btnRemove.Hide()
        ElseIf Form1.admin Then
            btnRemove.Show()
        End If
        listWordsAndDefinitions.Items.Clear()
        For i As Integer = 0 To Form1.words.Count - 1
            listWordsAndDefinitions.Items.Add(Form1.words(i) & " = " & Form1.definitions(i))
        Next
        listWordsAndDefinitions.Sorted = True
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If listWordsAndDefinitions.SelectedIndex <> -1 Then
            listWordsAndDefinitions.Items.RemoveAt(listWordsAndDefinitions.SelectedIndex)
            Form1.words.Clear()
            Form1.definitions.Clear()
            For Each item In listWordsAndDefinitions.Items
                Dim reAddItem As String()
                Dim separator As Char = "="
                reAddItem = item.split(separator)
                Form1.words.Add(reAddItem(0))
                Form1.definitions.Add(reAddItem(1))
            Next
            File.WriteAllText("library.txt", "")
            For i As Integer = 0 To Form1.words.Count - 1
                File.AppendAllText("library.txt", vbCrLf & Form1.words(i) & "=" & Form1.definitions(i))
            Next
        End If
    End Sub
    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub
End Class