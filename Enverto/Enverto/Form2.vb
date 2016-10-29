
Public Class Form2
    Public connec As New SqlClient.SqlConnection



    Dim cmd As New SqlClient.SqlCommand


    Private Sub DbConnect()
        Try
            connec.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"
            MessageBox.Show("Data base is connected")
            connec.Open()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub AddData()

        Try
            cmd.Connection = connec
            cmd.CommandText = "insert into Enverto (dname,dcell,dproject,dadm) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddData()
        clear()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DbConnect()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Form1.Show()

    End Sub
End Class
