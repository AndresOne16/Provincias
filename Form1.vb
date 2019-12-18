Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM ListBox1.Items.Add("La Provincia de: " & TextBox1.Text & "con codigo: " & TextBox2.Text & "tiene " & TextBox3.Text & "habitantes")
        ListBox1.Items.Add(TextBox1.Text & "--" & TextBox2.Text & "--" & TextBox3.Text & "N.-habitantes")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Sorted = True

    End Sub

End Class
