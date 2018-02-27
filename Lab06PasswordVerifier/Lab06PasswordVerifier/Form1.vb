Public Class Form1
    Function IsValid(ByVal strPassword As String) As Boolean
        Dim part As String
        Dim count As Integer
        Dim length As Integer
        Dim lengthOK, ContainsNumber, ContainsAlpha As Boolean
        length = strPassword.Length

        If length < 6 Then
            lengthOK = False
            Return False
        End If

        count = 0
        For count = 1 To length
            part = Mid(strPassword, count, 1)
            If IsNumeric(part) = True Then
                ContainsNumber = True
                Exit For
            End If
        Next
        count = 0
        For count = 1 To length
            part = Mid(strPassword, count, 1)
            If IsNumeric(part) = False Then
                ContainsAlpha = True
                Exit For
            End If
        Next
        If ContainsAlpha = True And ContainsNumber = True Then
            Return True
        End If
    End Function

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim strPassword As String
        strPassword = txtPassword.Text

        If IsValid(strPassword) = True Then
            lblOutput.Text = "That password is valid"
        Else
            lblOutput.Text = "Password is not valid"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class