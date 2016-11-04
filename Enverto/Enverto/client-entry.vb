Public Class client_entry

    Public Property getdata As Integer
    Public Property getdata1 As String
    Public Property getdata2 As String
    Public Property getdata3 As String
    Public Property getdata4 As String
    Public Property getdata5 As String
    Public Property getdata6 As String
    Public Property getdata7 As String



    Public connec As New SqlClient.SqlConnection



    Dim cmd As New SqlClient.SqlCommand


    Private Sub DbConnect()
        Try
            connec.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"

            connec.Open()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Cliententry()
        Try
            cmd.Connection = connec
            cmd.CommandText = "insert into clients (Name,Profession,CellNo,ProjectType,ProjectRequirment,Date,DueDate) values ('" & TextBox1.Text & "','" & TextBox5.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted")




        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Delete()
        Try
            cmd.Connection = connec
            cmd.CommandText = "delete from clients where ID= '" & Label13.Text & "' "

            cmd.ExecuteNonQuery()


            MessageBox.Show("Data Deleted ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Updatedb()

        Try


            cmd.Connection = connec
            cmd.CommandText = "update clients set Name='" & TextBox1.Text & "',Profession='" & TextBox5.Text & "',CellNo='" & TextBox2.Text & "',ProjectType='" & TextBox4.Text & "',ProjectRequirment='" & TextBox6.Text & "',Date='" & DateTimePicker1.Text & "',DueDate='" & DateTimePicker2.Text & "' where ID='" & Label13.Text & "'"

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Updated")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub datagrid()
        Dim dad As New SqlClient.SqlDataAdapter
        Dim dset As New DataTable


        Try
            cmd.Connection = connec
            cmd.CommandText = "select * from clients "
            dad.SelectCommand = cmd
            dad.Fill(dset)
            DataGridView1.DataSource = dset


            Label14.Text = DataGridView1.RowCount

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub clear()
        TextBox1.Clear()

        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        Label13.Text = " "

        datagrid()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        main.Show()

    End Sub
    Private Sub getgrid()
        Label13.Text = getdata
        TextBox1.Text = getdata1
        TextBox5.Text = getdata2
        TextBox2.Text = getdata3
        TextBox4.Text = getdata4
        TextBox6.Text = getdata5
        DateTimePicker1.Text = getdata6
        DateTimePicker2.Text = getdata7

    End Sub
    Private Sub sum()
        '   If DataGridView1.RowCount > 1 Then
        '  Dim iTax As Integer = 0


        ' For index As Integer = 0 To DataGridView1.RowCount - 1

        '                iTax += Convert.ToInt32(DataGridView1.Rows(index).Cells(3).Value)





        ' Next





        ' End If
    End Sub

    Private Sub client_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getgrid()



        DbConnect()
        datagrid()

        sum()


    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cliententry()
        datagrid()

        clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Updatedb()
        datagrid()
        clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Delete()
        datagrid()
        clear()
    End Sub

    Public Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        search.Show()

        Me.Hide()


    End Sub



    '  Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox1.TextChanged
    '     If e.KeyValue = Keys.Down Then
    '        search.Show()
    '       Me.Hide()

    '    End If



    'End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        clear()

    End Sub


End Class