Public Class Updatedb
    Public connect As New SqlClient.SqlConnection

    Dim cmd As New SqlClient.SqlCommand

    Public Sub DBConnect()
        Try
            connect.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"
            connect.Open()
            MessageBox.Show("DB Connected")


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Updatedb()

        Try


            cmd.Connection = connect
            cmd.CommandText = "update Enverto set  Name='" & TextBox1.Text & "',Phone='" & TextBox2.Text & "',Project='" & TextBox4.Text & "',Date='" & DateTimePicker1.Text & "' where SNo='" & TextBox3.Text & "' "

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Updated")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()

        TextBox3.Clear()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        main.Show()

        Close()
    End Sub

    Private Sub Updatedb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBConnect()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Updatedb()


    End Sub
End Class