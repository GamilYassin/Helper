Imports System.Globalization

Public Class frmCMCalc
    Private Sub frmCMCalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCMd1.Enabled = False
        txtCMP1.Enabled = False
        txtRev2.Enabled = False
        txtCost3.Enabled = False
    End Sub

    Private Sub CalculateCM()
        Dim Cost As Single
        Dim Rev As Single

        If IsNumeric(txtCost1.Text, Cost) Then
            If IsNumeric(txtRev1.Text, Rev) Then
                Cost = Single.Parse(txtCost1.Text)
                Rev = Single.Parse(txtRev1.Text)
                txtCMd1.Text = ((Rev - Cost)).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                txtCMP1.Text = ((1 - Cost / Rev) * 1).ToString("P1")
                'txtCost1.Text = Cost.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                'txtRev1.Text = Rev.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            End If
        End If
    End Sub

    Private Sub CalculateRev()
        Dim Cost As Single
        Dim CM As Single

        If IsNumeric(txtCost2.Text, Cost) Then
            If IsNumeric(txtCMP2.Text, CM) Then
                Cost = Single.Parse(txtCost2.Text)
                CM = Single.Parse(txtCMP2.Text)
                txtRev2.Text = (Cost / (100 - CM) * 100).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            End If
        End If
    End Sub

    Private Sub CalculateCost()
        Dim Rev As Single
        Dim CM As Single

        If IsNumeric(txtRev3.Text, Rev) Then
            If IsNumeric(txtCMP3.Text, CM) Then
                Rev = Single.Parse(txtRev3.Text)
                CM = Single.Parse(txtCMP3.Text)
                txtCost3.Text = (Rev * (1 - CM / 100)).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
            End If
        End If
    End Sub


    Private Function IsNumeric(Text As String, Value As Single) As Boolean
        Return Single.TryParse(Text, Value)
    End Function

    Private Sub txtCost1_TextChanged(sender As Object, e As EventArgs) Handles txtCost1.TextChanged
        CalculateCM()
    End Sub

    Private Sub txtRev1_TextChanged(sender As Object, e As EventArgs) Handles txtRev1.TextChanged
        CalculateCM()
    End Sub

    Private Sub txtCost2_TextChanged(sender As Object, e As EventArgs) Handles txtCost2.TextChanged
        CalculateRev()
    End Sub

    Private Sub txtCMP2_TextChanged(sender As Object, e As EventArgs) Handles txtCMP2.TextChanged
        CalculateRev()
    End Sub

    Private Sub txtRev3_TextChanged(sender As Object, e As EventArgs) Handles txtRev3.TextChanged
        CalculateCost()
    End Sub

    Private Sub txtCMP3_TextChanged(sender As Object, e As EventArgs) Handles txtCMP3.TextChanged
        CalculateCost()
    End Sub
End Class