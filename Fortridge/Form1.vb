Imports Fortridge.Dbconn

Public Class Footridge

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim un As String = ""
        Dim pwd As String = ""
        Connection()
        Dim strQuery = "SELECT username, password FROM user"
        Using Command = connect.CreateCommand
            Command.CommandText = strQuery
            Using reader = Command.ExecuteReader()
                While reader.Read()
                    un = reader.GetString(0)
                    pwd = reader.GetString(1)
                End While
            End Using
        End Using
        connect.Close()

        If lginUname.Text = un And lginPwdtbx.Text = pwd Then
            Dim mgc As ManageCustomer
            mgc = New ManageCustomer()
            mgc.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Details", "Footridge-Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
