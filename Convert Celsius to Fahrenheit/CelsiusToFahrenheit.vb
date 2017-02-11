Public Class CelsiusToFahrenheit

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear the form and return focus to celsius textbox
        Fahrenheit.Text = String.Empty
        ' set focus to the Celsius textbox and clear it
        Celsius.Clear()
        Celsius.Focus()
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        ' Declare Variables
        Dim TempCelsius As Double = 0
        Dim TempFahrenheit As Double = 0
        ' Clear any existing errors
        ErrorProvider1.SetError(Celsius, String.Empty)
        Try
            TempCelsius = Convert.ToDouble(Celsius.Text)

            TempFahrenheit = 1.8 * TempCelsius + 32
            Fahrenheit.Text = Convert.ToString(TempFahrenheit)
        Catch
            Celsius.Focus()
            Celsius.SelectionStart = 0
            Celsius.SelectionLength = Celsius.Text.Length
            ErrorProvider1.SetError(Celsius, "you must enter numeric data")
        End Try
    End Sub
End Class
