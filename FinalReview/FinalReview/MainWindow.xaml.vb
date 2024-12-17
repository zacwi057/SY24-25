Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If Checkbox1.IsChecked Then
            Rectangle1.Fill = New SolidColorBrush(Colors.Green)
            TextBox1.Visibility = Visibility.Visible
        Else
            Rectangle1.Fill = New SolidColorBrush(Colors.SaddleBrown)
        End If
        If TextBox1.Text = "purple" Then
            Rectangle1.Fill = New SolidColorBrush(Colors.Purple)
        End If
    End Sub
End Class
