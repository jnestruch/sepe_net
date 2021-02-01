Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbMistral.CheckedChanged
        TextBox1.Font = New Font(rbMistral.Text, TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbTahoma.CheckedChanged
        TextBox1.Font = New Font(rbTahoma.Text, TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbVerdana.CheckedChanged
        TextBox1.Font = New Font(rbVerdana.Text, TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItalic.CheckedChanged
        If chkItalic.Checked Then
            TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style Or FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        If chkBold.Checked Then
            TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style Or FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkStrike.CheckedChanged
        If chkStrike.Checked Then
            TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style Or FontStyle.Strikeout)
        Else
            TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblRed.Click
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblGreen.Click
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblBlue.Click
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSize.SelectedIndexChanged
        TextBox1.Font = New Font(TextBox1.Font.Name, cmbSize.SelectedItem, TextBox1.Font.Style)
    End Sub
End Class
