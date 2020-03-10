Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randgen As New Random
        Dim leftindex As Integer
        Dim rightindex As Integer
        Dim centerindex As Integer

        Button1.Enabled = False
        For spins As Integer = 1 To 10
            leftindex = randgen.Next(0, 6)
            PictureBox1.Image = ImageList1.Images.Item(leftindex)
            Me.Refresh()
            System.Threading.Thread.Sleep(50)
            centerindex = randgen.Next(0, 6)
            PictureBox4.Image = ImageList1.Images.Item(centerindex)
            Me.Refresh()
            System.Threading.Thread.Sleep(50)
            rightindex = randgen.Next(0, 6)
            PictureBox5.Image = ImageList1.Images.Item(rightindex)
            Me.Refresh()
            System.Threading.Thread.Sleep(50)
        Next spins
        If leftindex = centerindex AndAlso
           leftindex = rightindex Then
            MessageBox.Show("Congratulations!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Button1.Enabled = True
    End Sub
End Class
