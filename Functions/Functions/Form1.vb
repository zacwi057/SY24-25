Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearall()
    End Sub
    Sub clearall()
        Label1.Text = ""
    End Sub
    Sub setall(s As String)
        Label1.Text = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        setall("---")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = add(TextBox1.Text, TextBox2.Text)
    End Sub
    Function add(n1 As Integer, n2 As Integer) As Integer
        Return n1 + n2
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        squareAreaTB.Text = squarearea(sideTB.Text)
        squarePerimTB.Text = sqaureperi(sideTB.Text)
    End Sub
    Function squarearea(s As Integer) As Integer
        Return s * s
    End Function
    Function sqaureperi(s As Integer) As Integer
        Return s * 4
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CirlcAreaTB.Text = circArea(CircRadiusTB.Text)
        CircPerimTB.Text = circperimeter(CircRadiusTB.Text)
    End Sub
    Function circArea(r As Decimal) As Decimal
        Return r * 3.14
    End Function
    Function circperimeter(r As Decimal) As Decimal
        Return (r * 2) * 3.14
    End Function


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RectAreaTB.Text = RectArea(RectLengthTB.Text, RectWidthTB.Text)
        RectPerimTB.Text = rectperim(RectLengthTB.Text, RectWidthTB.Text)
    End Sub

    Function RectArea(s1 As Integer, s2 As Integer) As Integer
        Return s1 * s2
    End Function
    Function rectperim(s1 As Integer, s2 As Integer) As Integer
        Return (s1 * 2) + (s1 * 2)
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TriAlt.Text = altsolve(TriSide.Text)
        TriAreaTB.Text = triarea(TriSide.Text, TriAlt.Text)
        TriPerimTB.Text = triperim(TriSide.Text)
    End Sub
    Function altsolve(s As Decimal) As Decimal
        Return Math.Sqrt((s ^ 2) - ((s / 2) ^ 2))
    End Function
    Function triarea(s As Integer, a As Decimal) As Decimal
        Return (a * s) / 2
    End Function
    Function triperim(s As Integer) As Integer
        Return s * 3
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        VolumeTB.Text = volume(PrismLength.Text, PrismWidth.Text, PrismHeight.Text)
        SaTB.Text = Surfacearea(PrismLength.Text, PrismWidth.Text, PrismHeight.Text)
    End Sub
    Function volume(l As Integer, w As Integer, h As Integer) As Integer
        Return l * w * h
    End Function
    Function Surfacearea(la As Integer, w As Integer, h As Integer)
        Return (la * w * 2) + (la * h * 2) + (h * w * 2)
    End Function
End Class