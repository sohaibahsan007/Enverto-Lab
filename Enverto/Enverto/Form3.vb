Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet1.Enverto' table. You can move, or remove it, as needed.
        Me.EnvertoTableAdapter.Fill(Me.DbDataSet1.Enverto)
       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Form1.Show()

    End Sub
End Class