Imports System.IO
Public Class Form3
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Close()
    End Sub
    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click
        txtDefinition.Clear()
        txtWord.Clear()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim word, definition As String
        If txtWord.Text = Nothing Or IsNumeric(txtWord.Text) Then
            MessageBox.Show("Please input a valid word !", "wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            word = txtWord.Text
        End If
        If txtDefinition.Text = Nothing Or IsNumeric(txtDefinition.Text) Then
            MessageBox.Show("Please input a valid definition !", "wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            definition = txtDefinition.Text
        End If
        Dim verification = True
        For Each item In Form1.words
            If word = item Then
                MessageBox.Show("This word is already included in the library!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                verification = False
            End If
        Next
        If verification Then
            File.AppendAllText("library.txt", vbCrLf & word & "=" & definition)
            Form1.words.Add(word)
            Form1.definitions.Add(definition)
            MessageBox.Show("Word added successfully ! ")
        End If
        txtDefinition.Clear()
        txtWord.Clear()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exportLibrary As New SaveFileDialog
        exportLibrary.Filter = "text files|*.txt"
        exportLibrary.DefaultExt = ".txt"
        If exportLibrary.ShowDialog = DialogResult.OK Then
            Dim libraryName As String
            libraryName = exportLibrary.FileName
            For i As Integer = 0 To Form1.words.Count - 1
                File.AppendAllText(libraryName, Form1.words(i) & "=" & Form1.definitions(i) & vbCrLf)
            Next
            MessageBox.Show("Library of content exported successfully ", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnShowList_Click(sender As Object, e As EventArgs) Handles btnShowList.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Public wwords As New ArrayList
    Public ddefinitions As New ArrayList
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim newLibrary As New OpenFileDialog
        newLibrary.Filter = "text files|*.txt"
        Dim temporaryWords, temporaryDefinitions As New ArrayList
        If newLibrary.ShowDialog = DialogResult.OK Then
            Dim newLibraryName As String
            newLibraryName = newLibrary.FileName
            Dim newlibraryitems As String()
            newlibraryitems = File.ReadAllLines(newLibraryName)
            For i As Integer = 0 To newlibraryitems.Count - 1
                Dim item As String()
                Dim separator As Char() = "="
                item = newlibraryitems(i).Split(separator)
                If item.Length = 2 Then
                    temporaryWords.Add(item(0))
                    temporaryDefinitions.Add(item(1))
                End If
            Next
            Dim verification = True
            Dim duplicates As Integer = 0
            For i As Integer = 0 To temporaryWords.Count - 1
                For Each item In Form1.words
                    If temporaryWords.Item(i) = item Then
                        verification = False
                    End If
                Next
                If verification Then
                    Form1.words.Add(temporaryWords.Item(i))
                    Form1.definitions.Add(temporaryDefinitions.Item(i))
                    File.AppendAllText("library.txt", vbCrLf & temporaryWords(i) & "=" & temporaryDefinitions(i))
                Else
                    duplicates += 1
                End If
                verification = True
            Next
            If duplicates = temporaryWords.Count Then
                MessageBox.Show("All words are duplicates. No words imported!", "Duplicate entries detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf duplicates <> 0 Then
                MessageBox.Show("Duplicate words detected. " & duplicates.ToString & " words were not added", "Duplicate entries detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            MessageBox.Show("File imported successfully ! ", "import completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnLOGOUT_Click(sender As Object, e As EventArgs) Handles btnLOGOUT.Click
        Me.Hide()
        Form1.Show()
        Form1.txtPassword.Clear()
        Form1.txtUser.Clear()
        Form1.user = False
        Form1.admin = False
    End Sub
    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub
End Class