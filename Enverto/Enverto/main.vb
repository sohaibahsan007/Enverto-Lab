
Public Class main
    Public connect As New SqlClient.SqlConnection

    Dim cmd As New SqlClient.SqlCommand

    Private Sub dbconnect()
        Try
            connect.ConnectionString = "Data Source=KEVIN-PC;Integrated Security=True"
            connect.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub backup()
        Dim bac As String

        SaveFileDialog1.Filter = "Backup |*.bak"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            bac = SaveFileDialog1.FileName


        End If
        Try
            cmd.Connection = connect
            cmd.CommandText = "backup database Db to disk='" & bac & "'"

            cmd.ExecuteNonQuery()
            MessageBox.Show("Backup is Done ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub restore()
        Dim res As String

        OpenFileDialog1.Filter = "All Files |*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            res = OpenFileDialog1.FileName

        End If

        Try
            cmd.Connection = connect
            cmd.CommandText = "restore database Db from disk ='" & res & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Restore is Done ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub



    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnect()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub




    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://spothub.ml")

    End Sub



    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub



    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://sohaibahsan.ml")

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub






    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        entry.Show()

        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        client_entry.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        salery.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        backup()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        restore()

    End Sub
End Class