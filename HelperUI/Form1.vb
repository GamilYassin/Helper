Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.ShowDialog()
    End Sub


    Private Sub mnuCMCalc_Click(sender As Object, e As EventArgs) Handles mnuCMCalc.Click
        frmCMCalc.Show()
    End Sub

    Private Sub mnuCalc_Click(sender As Object, e As EventArgs) Handles mnuCalc.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub mnuNotePad_Click(sender As Object, e As EventArgs) Handles mnuNotePad.Click
        Try
            System.Diagnostics.Process.Start("notepad++.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuQuote_Click(sender As Object, e As EventArgs) Handles mnuQuote.Click
        frmQuoteCalc.Show()
    End Sub
End Class
