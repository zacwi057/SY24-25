Public Class Form1
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        nameTextbox.Clear()
        nameListBox.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = nameTextbox.Text
        Dim first = s.Substring(0, 1).ToUpper()
        Dim fs = s.IndexOf(" ")
        Dim rest = s.Substring(1, fs - 1).ToLower
        Dim second = s.Substring(fs + 1, 1).ToUpper
        Dim rest2 = s.Substring(fs + 2).ToLower
        nameListBox.Items.Add(first & rest & " " & second & rest2)
        nameTextbox.Clear()
    End Sub
End Class
