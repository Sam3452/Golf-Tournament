Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class Form1
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sammy\OneDrive\Documents\Computer coursewokr\designs\golfdbdb.accdb")

    Private Sub datagridshow()
        connection.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from tbltournaments", connection)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        connection.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridshow()
        password.UseSystemPasswordChar = True
        loginpanel.Location = New Point(38, 23)
        loginpanel.Size = New Size(305, 407)
        dashpanel.Location = New Point(124, 0)
        dashpanel.Size = New Size(734, 54)
        menupanel.Location = New Point(0, 0)
        menupanel.Size = New Size(124, 486)
        Me.Size = New Size(874, 525)
        Try
            connection.Open()
            MsgBox("Database Connected")
            connection.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try





    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim checker As Integer
        Try
            connection.Open()
            cmd = connection.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from tblplayers where email = '" + email.Text + "' And Password = '" + password.Text + "'"
            dr = cmd.ExecuteReader()
            checker = 0
            Do While (dr.Read())
                checker += 1
            Loop
            If (checker = 1) Then
                loginpanel.Visible = False
                menupanel.Visible = True
                dashpanel.Visible = True
            ElseIf (checker > 1) Then
                MsgBox("Duplicate Log in details")
            Else
                loginfail.Visible = True
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        btn1.Text = "Create Account"
        password.UseSystemPasswordChar = False

    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        tournamentcrea.Visible = True
        tournamentcrea.Location = New Point(148, 72)
        tournamentcrea.Size = New Size(322, 387)
        dashpanel.Visible = False
        createpanel.Visible = True
        createpanel.Location = New Point(124, 0)
        createpanel.Size = New Size(734, 54)
        calendar.Visible = False
        calendarpanel.Visible = False
        Panel4.Visible = True

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dashpanel.Visible = True
        createpanel.Visible = False
        tournamentcrea.Visible = False
        calendar.Visible = False
        calendarpanel.Visible = False
        Panel4.Visible = False

    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        calendar.Visible = True
        calendarpanel.Visible = True
        calendar.Location = New Point(153, 63)
        calendar.Size = New Size(632, 413)
        calendarpanel.Location = New Point(124, 0)
        calendarpanel.Size = New Size(734, 54)
        dashpanel.Visible = False
        tournamentcrea.Visible = False
        createpanel.Visible = False
        Panel4.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As OleDbCommand
        connection.Open()
        cmd = connection.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into tbltournaments ([name], [startdate]) values ('" & nametxt.Text & "','" & datebox.Text & "')"
        Dim cmd1 As OleDbCommand = New OleDbCommand(Command, connection)
        cmd.Parameters.Add(New OleDbParameter("name", CType(nametxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("startdate", CType(nametxt.Text, String)))
        MsgBox("TournamentCreated")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connection.Close()
            nametxt.Clear()
            datebox.Clear()
            datagridshow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
