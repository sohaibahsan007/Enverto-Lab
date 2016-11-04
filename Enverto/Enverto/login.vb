Public Class login
    Public connec As New SqlClient.SqlConnection

    Dim cmd As New SqlClient.SqlCommand

    Dim j As Integer







    Private Sub dbConnect()
        Try
            connec.ConnectionString = "Data Source=KEVIN-PC;Initial Catalog=Db;Integrated Security=True"
            connec.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbConnect()

        Timer1.Enabled = True

    End Sub

    Public Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click



    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim red As SqlClient.SqlDataReader

        Try
            cmd.Connection = connec

            cmd.CommandText = "select * from login where User_Name='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "' "
            red = cmd.ExecuteReader
            Dim i As Integer = 0



            While red.Read
                i = i + 1


            End While

            If i = 1 Then
                Timer2.Start()
                clear()



                '    If j > 9 Then
                main.Show()
                Me.Hide()

                'End If




            ElseIf i > 1 Then
                MessageBox.Show("Duplicate  User name or password ")
                ProgressBar1.Value = 0

                red.Close()


            Else
                MessageBox.Show("Invalid User Name or Password  ")
                ProgressBar1.Value = 0

                red.Close()


            End If








        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            cmd.Dispose()

        End Try



    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = Date.Now.ToString("hh:mm:ss  dd-MM-yyyy ")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Public Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(4)


        Timer2.Interval = 10


        j = ProgressBar1.Value


    End Sub
End Class