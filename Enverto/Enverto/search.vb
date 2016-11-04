

Public Class search
    Public connec As New SqlClient.SqlConnection

    Dim cmd As New SqlClient.SqlCommand

    Dim dsett As New DataTable
    Private Sub DbConnect()
        Try
            connec.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"


            connec.Open()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

  
    Private Sub datagrid()
        Dim dadap As New SqlClient.SqlDataAdapter
        Dim dset As New DataTable

        Try
            cmd.Connection = connec
            cmd.CommandText = "select * from clients"
            dadap.SelectCommand = cmd
            dadap.Fill(dset)

            DataGridView1.DataSource = dset
            dadap.Update(dset)
            dsett = dset


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
  
    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DbConnect()

        datagrid()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim obj As New client_entry
     


        Dim sav As Integer

        sav = DataGridView1.CurrentRow.Index
        obj.getdata = DataGridView1.Item(0, sav).Value
        obj.getdata1 = DataGridView1.Item(1, sav).Value
        obj.getdata2 = DataGridView1.Item(2, sav).Value
        obj.getdata3 = DataGridView1.Item(3, sav).Value
        obj.getdata4 = DataGridView1.Item(4, sav).Value
        obj.getdata5 = DataGridView1.Item(5, sav).Value
        obj.getdata6 = DataGridView1.Item(6, sav).Value
        obj.getdata7 = DataGridView1.Item(7, sav).Value




        obj.Show()



        Me.Close()

  





    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dev As New DataView(dsett)



        dev.RowFilter = "Name Like '%" & TextBox1.Text & "%' "



        DataGridView1.DataSource = dev


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        client_entry.Show()

    End Sub
End Class