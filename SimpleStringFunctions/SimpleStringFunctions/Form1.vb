Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OutputTextBox.Text = InputTextBox.Text.Length


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OutputTextBox.Text = InputTextBox.Text.ToUpper

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OutputTextBox.Text = InputTextBox.Text.ToLower

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OutputTextBox.Text = InputTextBox.Text.IndexOf(IndexTextBox.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OutputTextBox.Text = InputTextBox.Text.Substring(startTB.Text, LengthTB.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim words() As String
        words = InputTextBox.Text.Split(",")
        wordsComboBox.Items.Clear()

        For Each w In words
            wordsComboBox.Items.Add(w)
        Next
    End Sub
End Class
