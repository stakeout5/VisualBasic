Public Class Form1

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        Dim ans As Double = subtract(TextBox1.Text, TextBox2.Text)
        MessageBox.Show(ans)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim ans As Double = add(TextBox1.Text, TextBox2.Text)
        MessageBox.Show(ans)
    End Sub
    Private Sub btnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult.Click
        Dim ans As Double = multiply(TextBox1.Text, TextBox2.Text)
        MessageBox.Show(ans)
    End Sub
    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        Dim ans As Double = divide(TextBox1.Text, TextBox2.Text)
        MessageBox.Show(ans)
    End Sub

    'subtract
    Private Function subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function'end

    'add
    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function
    'multiply
    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    'divide function
    Private Function divide(ByVal num1 As Double, ByVal num2 As Double)
        Return num1 / num2
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
