Public Class delete
    Public Connection As New SqlClient.SqlConnection
    Dim command As New SqlClient.SqlCommand

    Private Sub DbConnection()
        Try
            Connection.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"
            Connection.Open()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Deletedb()
        Try
            command.Connection = Connection
            command.CommandText = "delete from Enverto where Sno='" & TextBox3.Text & "' "
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main.Show()

        Close()

    End Sub

    Private Sub delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DbConnection()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Deletedb()
        TextBox3.Clear()

    End Sub
End Class