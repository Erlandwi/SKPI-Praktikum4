Public Class Form1

    Private Sub Bkeluar_Click(sender As Object, e As EventArgs) Handles Bkeluar.Click
        End
    End Sub

    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        Txtteks.Clear()
        Txtjumlah.Clear()
        Listbox1.Items.Clear()
    End Sub

    Private Sub Bproses_Click(sender As Object, e As EventArgs) Handles Bproses.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = Txtteks.Text
        jumlah = Txtjumlah.Text
        For i = 1 To jumlah
            Listbox1.Items.Add(teks)
        Next
    End Sub
End Class
