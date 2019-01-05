





Public Class frmQuoteCalc
    Private Sub TakeScreenShot(ByVal Control As Control)
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Control.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Control.Width, Control.Height))
        End Using
        tmpImg.Save(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\test.bmp", Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TakeScreenShot(Me)
    End Sub
End Class