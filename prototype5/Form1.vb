Imports System.Data.OleDb

Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sammy\OneDrive\Documents\Computer coursewokr\designs\golfdbdb.accdb")



    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        loginpanel.Location = New Point(38, 23)
        loginpanel.Size = New Size(305, 407)
        dashpanel.Location = New Point(124, 0)
        dashpanel.Size = New Size(734, 54)
        menupanel.Location = New Point(0, 0)
        menupanel.Size = New Size(124, 486)
        Me.Size = New Size(874, 525)
        Try
            conn.Open()
            MsgBox("Database Connected")
            conn.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim checker As Integer

        Try

            conn.Open()

            cmd.Connection.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from tblplayers where email = '" + txtemail.Text + "'
            and Password = '" + txtPassword.Text + "'"

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

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        btn1.Text = "Create Account"
        txtPassword.UseSystemPasswordChar = False

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        tournamentcrea.Visible = True
        tournamentcrea.Location = New Point(148, 72)
        tournamentcrea.Size = New Size(322, 387)
        dashpanel.Visible = False
        createpanel.Visible = True
        createpanel.Location = New Point(124, 0)
        createpanel.Size = New Size(734, 54)

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dashpanel.Visible = True
        createpanel.Visible = False
        tournamentcrea.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        calendar.Visible = True
        calendarpanel.Visible = True
        dashpanel.Visible = False
        tournamentcrea.Visible = False
        createpanel.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub
End Class
