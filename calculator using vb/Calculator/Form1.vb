Public Class Form1
    Dim currentInput As String
    Dim firstOperand As Double
    Dim secondOperand As Double
    Dim operation As String

    Private Sub NumericButton_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim button As Button = DirectCast(sender, Button)
        currentInput &= button.Text
        textBox.Text = currentInput
    End Sub

    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles addBtn.Click, minusBtn.Click, multiplyBtn.Click, divideBtn.Click
        Dim button As Button = DirectCast(sender, Button)

        If Not String.IsNullOrEmpty(currentInput) Then
            firstOperand = CDbl(currentInput)
            currentInput = ""
            operation = button.Text
        End If
    End Sub

    Private Sub equalsBtn_Click(sender As Object, e As EventArgs) Handles equalsBtn.Click
        If Not String.IsNullOrEmpty(currentInput) Then
            secondOperand = CDbl(currentInput)
            currentInput = ""

            Select Case operation
                Case "+"
                    currentInput = (firstOperand + secondOperand).ToString()
                Case "-"
                    currentInput = (firstOperand - secondOperand).ToString()
                Case "*"
                    currentInput = (firstOperand * secondOperand).ToString()
                Case "÷"
                    If secondOperand <> 0 Then
                        currentInput = (firstOperand / secondOperand).ToString()
                    Else
                        currentInput = "Error"
                    End If
            End Select

            textBox.Text = currentInput
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not currentInput.Contains(".") Then
            currentInput &= "."
            textBox.Text = currentInput
        End If
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        If currentInput.Length > 0 Then
            currentInput = currentInput.Substring(0, currentInput.Length - 1)
            textBox.Text = currentInput
        End If
    End Sub

    Private Sub delAllBtn_Click(sender As Object, e As EventArgs) Handles delAllBtn.Click
        currentInput = ""
        firstOperand = 0
        secondOperand = 0
        operation = ""
        textBox.Text = ""
    End Sub
End Class
