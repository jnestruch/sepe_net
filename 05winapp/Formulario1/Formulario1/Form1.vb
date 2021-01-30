Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Width = 640
            Height = 480
        Else
            If RadioButton2.Checked Then
                Width = 800
                Height = 600
            Else
                If RadioButton3.Checked Then
                    Width = 1024
                    Height = 800
                End If
            End If
        End If
    End Sub
End Class
