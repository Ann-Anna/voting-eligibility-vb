Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim nationality As String
        Dim age As Integer

        name = TextBox1.Text
        nationality = TextBox2.Text
        age = Val(TextBox3.Text)

        If nationality = "Kenyan" And age >= 18 Then
            Label4.Text = name & " is eligible to vote."
        ElseIf nationality <>"Kenyan" And age >= 18 Then
            Label4.Text = name & " is not eligible to vote because they are not Kenyan."
        ElseIf nationality = "Kenyan" And age < 18 Then
            Label4.Text = name & " is not eligible to vote because they are below 18."
        Else
            Label4.Text = name & " is not eligible to vote."
        End If
    End Sub
End Class
