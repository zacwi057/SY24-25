Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ocean.Visibility = Visibility.Visible
        text1.Text = "1. Covers 71% of the Earth's surface 2. Many of our daily mineral can be found in the ocean. 3.The ocean floor can move! 4. There are millions of ocean life animals."
    End Sub

    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        desert.Visibility = Visibility.Visible
        text2.Text = "1.20% of deserts have sand 2. Not all deserts have sand dunes 3.Almost all of africa is within a desert 4. Plants and animals within deserts are adapted to survive in hard desert climates."
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        forest.Visibility = Visibility.Visible
        text3.Text = "1. Billions of people depend on forests. 2. Home to many natural remidies 3. Home to millions of species of wildlife 4. Most of our forests have been destroyed due to deforestation."
    End Sub
End Class
