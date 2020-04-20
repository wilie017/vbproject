Imports Fortridge.Dbconn

Public Class ManageCustomer
    Private Sub ManageCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gendertCmbobx.SelectedIndex = 0
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If firstnameTbx.Text = "" And lastnameTbx.Text = "" And emailTbx.Text = "" And gendertCmbobx.Text = "-Choose gender-" And phonTbx.Text = "" And addressTbx.Text = "" And amountTbx.Text = "" Then
            MessageBox.Show("All data has not been filled, please fill in", "Failed")
            Return
        End If

        If firstnameTbx.Text = "" Then
            MessageBox.Show("Please fill in First Name", "Failed")
            Return
        End If

        If lastnameTbx.Text = "" Then
            MessageBox.Show("Please fill in Last name", "Failed")
            Return
        End If

        If emailTbx.Text = "" Then
            MessageBox.Show("Please fill in email", "Failed")
            Return
        End If

        If gendertCmbobx.Text = "- choose gender -" Then
            MessageBox.Show("Please select your gender", "Failed")
            Return
        End If

        If phonTbx.Text = "" Then
            MessageBox.Show("Please fill in phone number", "Failed")
            Return
        End If

        If addressTbx.Text = "" Then
            MessageBox.Show("Please fill in Home address", "Failed")
            Return
        End If

        If amountTbx.Text = "" Then
            MessageBox.Show("Please fill in Initial Amout", "Failed")
            Return
        End If


        Try

            Connection()
            Dim strQuery = "INSERT INTO customer(firstName, surName, email, gender, phoneNumber, adress, amount, other) VALUES(@fn, @ln, @em, @gn, @pn, @ad, @am, @ot)"
            Using Command = connect.CreateCommand
                Command.CommandText = strQuery
                Command.Parameters.Add("@fn", DbType.String).Value = firstnameTbx.Text
                Command.Parameters.Add("@ln", DbType.String).Value = lastnameTbx.Text
                Command.Parameters.Add("@em", DbType.String).Value = emailTbx.Text
                Command.Parameters.Add("@gn", DbType.String).Value = gendertCmbobx.SelectedItem
                Command.Parameters.Add("@pn", DbType.VarNumeric).Value = phonTbx.Text
                Command.Parameters.Add("@ad", DbType.String).Value = addressTbx.Text
                Command.Parameters.Add("@am", DbType.VarNumeric).Value = amountTbx.Text
                Command.Parameters.Add("@ot", DbType.String).Value = othertbx.Text
                Command.ExecuteNonQuery()
            End Using
            Dim Diagre As DialogResult = MessageBox.Show("Record Inserted Successfuly", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Diagre = DialogResult.OK Then
                Clearfields()
            End If
            connect.Close()

        Catch ex As Exception
            MessageBox.Show("Insert of Record Failed")
        End Try


    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Clearfields()
    End Sub

    Private Sub SrcBtn_Click(sender As Object, e As EventArgs) Handles SrcBtn.Click
        Dim id As Int32 = 0
        Dim am As Int32 = 0
        Dim nm As String = ""
        Dim sn As String = ""
        Dim gn As String = ""
        Dim pn As String = ""
        Dim ad As String = ""
        Dim ot As String = ""
        Try


            Connection()
            Dim strQuery = "SELECT * FROM customer"
            Using Command = connect.CreateCommand
                Command.CommandText = strQuery
                Using reader = Command.ExecuteReader
                    While reader.Read()
                        id = reader.GetInt32(0)
                        nm = reader.GetString(1)
                        sn = reader.GetString(2)
                        gn = reader.GetString(3)
                        pn = reader.GetString(4)
                        ad = reader.GetString(5)
                        am = reader.GetString(6)
                        ot = reader.GetString(7)
                    End While
                End Using
            End Using

            dt = New DataTable
            da.Fill(dt)

            Me.CustomerDgv.DataSource = dt


            connect.Close()


        Catch ex As Exception
            MessageBox.Show("Retrieving of Records Failed")
        End Try





    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

    End Sub

    Sub Clearfields()
        firstnameTbx.Clear()
        lastnameTbx.Clear()
        emailTbx.Clear()
        gendertCmbobx.SelectedIndex = 0
        phonTbx.Clear()
        addressTbx.Clear()
        amountTbx.Clear()
        othertbx.Clear()
    End Sub

    Private Sub CustomerDgv_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerDgv.KeyDown
        If e.KeyCode = Keys.Delete Then
            DelBtn.PerformClick()
        End If
    End Sub

    'Application.Exit()
End Class