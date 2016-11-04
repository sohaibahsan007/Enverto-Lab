
Public Class entry
    Public connec As New SqlClient.SqlConnection


    Dim dset As New DataTable

    Dim cmd As New SqlClient.SqlCommand


    Private Sub DbConnect()
        Try
            connec.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"
            'MessageBox.Show("Data base is connected")
            connec.Open()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub AddData()

        Try
            cmd.Connection = connec
            cmd.CommandText = "insert into Enverto (Name,Phone,Position,Date) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Updatedb()

        Try


            cmd.Connection = connec
            cmd.CommandText = "update Enverto set  Name='" & TextBox1.Text & "',Phone='" & TextBox2.Text & "',Position='" & TextBox4.Text & "',Date='" & DateTimePicker1.Text & "' where SNo='" & Label8.Text & "'"

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Updated")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Deletedb()
        Try
            cmd.Connection = connec
            cmd.CommandText = "delete from Enverto where SNo='" & Label8.Text & "' "
            MessageBox.Show("Data Deleted")
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub datagrid()
        Dim dad As New SqlClient.SqlDataAdapter


        Try
            cmd.Connection = connec
            cmd.CommandText = "select * from Enverto"
            dad.SelectCommand = cmd
            dad.Fill(dset)

            DataGridView1.DataSource = dset


            Label10.Text = DataGridView1.RowCount


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        TextBox4.Clear()
        Label8.Text = " "

    End Sub


  

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        DbConnect()
        datagrid()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        main.Show()

    End Sub

   

  

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddData()
        clear()
        datagrid()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Updatedb()

        clear()
        datagrid()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Deletedb()
        clear()
        datagrid()

    End Sub

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim t As Integer

        t = DataGridView1.CurrentRow.Index

        Me.Label8.Text = DataGridView1.Item(0, t).Value
        Me.TextBox1.Text = DataGridView1.Item(1, t).Value

        Me.TextBox2.Text = DataGridView1.Item(2, t).Value

        Me.TextBox4.Text = DataGridView1.Item(3, t).Value
        Me.DateTimePicker1.Text = DataGridView1.Item(4, t).Value
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        clear()

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim sear As New DataView(dset)

        sear.RowFilter = "Name Like '%" & TextBox3.Text & "%'"

        DataGridView1.DataSource = sear

    End Sub
End Class
