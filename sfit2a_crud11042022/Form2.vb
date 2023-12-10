Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim da1 As SqlClient.SqlDataAdapter
    Dim sqladd As String
    Dim dt As DataTable
    Dim firstname1, lastname1, gender1 As String
    Dim id1 As Int64
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_cruddb;User ID=sa;Password=1234;Pooling=False"
            con1.Open()

            firstname1 = TextBox1.Text.Trim()
            lastname1 = TextBox2.Text.Trim()
            gender1 = ComboBox1.SelectedItem
            cmd = New SqlClient.SqlCommand("insert1", con1)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@firstname1", SqlDbType.NVarChar).Value = firstname1
            cmd.Parameters.Add("@lastname1", SqlDbType.NVarChar).Value = lastname1
            cmd.Parameters.Add("@gender1", SqlDbType.NVarChar).Value = gender1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful inserted")
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub sponge()
        'Dim sql As String = "SELECT * FROM member"
        con1 = New SqlClient.SqlConnection
        con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_cruddb;User ID=sa;Password=1234;Pooling=False"
        cmd = New SqlClient.SqlCommand("getall1", con1)
        cmd.CommandType = CommandType.StoredProcedure
        da1 = New SqlClient.SqlDataAdapter()
        da1.SelectCommand = cmd
        dt = New DataTable
        da1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_cruddb;User ID=sa;Password=1234;Pooling=False"
            cmd = New SqlClient.SqlCommand("searching1", con1)
            Dim id1 As Int64 = TextBox3.Text
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@id1", SqlDbType.NVarChar).Value = id1
            da1 = New SqlClient.SqlDataAdapter()
            da1.SelectCommand = cmd
            dt = New DataTable
            da1.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox4.Text = dt.Rows(0)(0).ToString()
                TextBox1.Text = dt.Rows(0)(1).ToString()
                TextBox2.Text = dt.Rows(0)(2).ToString()
                ComboBox1.Text = dt.Rows(0)(3).ToString()
            Else
                TextBox4.Clear()
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        id1 = TextBox4.Text
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_cruddb;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            cmd = New SqlClient.SqlCommand("delete1", con1)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@id1", SqlDbType.Int).Value = id1
            cmd.ExecuteNonQuery()
            sponge()
            MessageBox.Show("Successful Deleted")
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.SelectedItem = -1
            TextBox4.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sponge()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        firstname1 = TextBox1.Text
        lastname1 = TextBox2.Text
        gender1 = ComboBox1.SelectedItem
        id1 = TextBox4.Text
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_cruddb;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            cmd = New SqlClient.SqlCommand("update1", con1)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@id1", SqlDbType.Int).Value = id1
            cmd.Parameters.Add("@firstname1", SqlDbType.NVarChar).Value = firstname1
            cmd.Parameters.Add("@lastname1", SqlDbType.NVarChar).Value = lastname1
            cmd.Parameters.Add("@gender1", SqlDbType.NVarChar).Value = gender1
            cmd.ExecuteNonQuery()
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.SelectedItem = -1
            TextBox4.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Class