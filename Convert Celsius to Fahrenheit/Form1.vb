Public Class Form1

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear the form and return focus to celsius textbox
        Fahrenheit.Text = String.Empty
        StatusLabel.Text = String.Empty

        Celsius.Clear()

        Celsius.Focus()
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        ' Declare Variables
        Dim TempCelsius As Double = 0
        Dim TempFahrenheit As Double = 0
        Try
            TempCelsius = Convert.ToDouble(Celsius.Text)

            TempFahrenheit = 1.8 * TempCelsius + 32
            Fahrenheit.Text = Convert.ToString(TempFahrenheit)
        Catch
            StatusLabel.Text = "you must enter numeric data"
        End Try
    End Sub
End Class
