Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Allow only numeric input in TextBox1
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Allow only alphabetic input in TextBox2
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Function clear() As Boolean
        ' Replace the following logic with your actual logic to check if data is cleared
        If TextBox1.Text = "" AndAlso TextBox2.Text = "" Then
            Return True ' Data is cleared
        Else
            Return False ' Data is not cleared
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If clear() Then
            MsgBox("Enter data")
        Else
            MsgBox("Data saved")
        End If
    End Sub

End Class
