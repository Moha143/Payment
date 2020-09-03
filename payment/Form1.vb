Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim payment, interst As Double
        Dim duration, amount As Integer
        amount = Convert.ToInt32(TextBox1.Text)
        interst = 0.01 * Convert.ToDecimal(TextBox3.Text) / 12
        duration = Convert.ToInt32(TextBox2.Text)
        Dim payearly As DueDate
        If CheckBox1.Checked = False Then
            payearly = DueDate.BegOfPeriod
        Else
            payearly = DueDate.EndOfPeriod
        End If
        payment = Pmt(interst, duration, -amount, 0, payearly)
        TextBox4.Text = payment.ToString



    End Sub
End Class
