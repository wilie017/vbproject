Imports System.Data.SQLite
Imports Fortridge.Dbconn
Imports Microsoft.Office.Interop

Public Class ManageCustomer
    Dim id As Int32 = 0
    Dim am As Int32 = 0
    Dim nm As String = ""
    Dim sn As String = ""
    Dim em As String = ""
    Dim gn As String = ""
    Dim pn As String = ""
    Dim ad As String = ""
    Dim ot As String = ""
    Dim srcph As String = ""
    Dim srcnm As String = ""
    Private Sub ManageCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gendertCmbobx.SelectedIndex = 0
        LoadDGV2()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If CustID.Text <> "" Then
            MessageBox.Show("You Can not Create new over existing User data- Click New/Clear All to add new", "Failed")
            Return
        End If
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
                LoadDGV2()
            End If
            connect.Close()

        Catch ex As Exception
            MessageBox.Show("Insert of Record Failed")
        End Try


    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

        If CustID.Text = "" Then
            MessageBox.Show("Failed to identify the User TO Update- You may Select again", "Failed")
            Return
        End If

        If firstnameTbx.Text = "" And lastnameTbx.Text = "" And emailTbx.Text = "" And gendertCmbobx.Text = "-Choose gender-" And phonTbx.Text = "" And addressTbx.Text = "" And amountTbx.Text = "" Then
            MessageBox.Show("All data has not been filled, please fill in to Update", "Failed")
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
            Dim strQuery = "Update customer SET firstName = @fn, surName= @ln, email = @em, gender = @gn, phoneNumber = @pn, adress = @ad, amount = @am, other= @ot WHERE id = @id"
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
                Command.Parameters.Add("@id", DbType.String).Value = CustID.Text
                Command.ExecuteNonQuery()
            End Using
            Dim Diagre As DialogResult = MessageBox.Show("Record Updated Successfuly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Diagre = DialogResult.OK Then
                '' Clearfields()  ''No need to clear field sfor the meantime
                LoadDGV2()
            End If
            connect.Close()

        Catch ex As Exception
            MessageBox.Show("Update of Record Failed")
        End Try


    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Clearfields()
    End Sub

    Private Sub SrcBtn_Click(sender As Object, e As EventArgs) Handles SrcBtn.Click
        Dim strQuery = "SELECT * FROM customer WHERE firstName = @srcnm OR phoneNumber = @srcph"
        Dim searching As Boolean = True
        LoadDGV2_Final(strQuery, searching)

    End Sub

    Sub LoadDGV()
        CustomerDgv.Rows.Clear()

        Try
            Connection()
            Dim sql = "SELECT * FROM customer"
            Dim ds As DataSet = New DataSet()
            Dim da = New SQLiteDataAdapter(sql, connect)
            da.Fill(ds)
            CustomerDgv.DataSource = ds.Tables(0).DefaultView
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub
    Sub LoadDGV2()
        Dim strQuery = "SELECT * FROM customer"
        Dim searching As Boolean = False
        LoadDGV2_Final(strQuery, searching)
    End Sub

    Sub LoadDGV2_Final(strQuery, searching)

        CustomerDgv.Rows.Clear()
        CustomerDgv.ColumnCount = 7
        CustomerDgv.Columns(0).Name = "User ID"
        CustomerDgv.Columns(1).Name = "Name"
        CustomerDgv.Columns(2).Name = "Surname"
        CustomerDgv.Columns(3).Name = "Email"
        CustomerDgv.Columns(4).Name = "Gender"
        CustomerDgv.Columns(5).Name = "Phone Number"
        CustomerDgv.Columns(6).Name = "Amount"


        Dim row As String()
        Try
            Connection()

            Using Command = connect.CreateCommand
                Command.CommandText = strQuery
                If searching = True Then
                    Command.Parameters.Add("@srcnm", DbType.String).Value = src_nameTbx.Text
                    Command.Parameters.Add("@srcph", DbType.String).Value = src_phoneTbx.Text
                End If
                Using reader = Command.ExecuteReader
                    While reader.Read()
                        id = CStr(reader.GetInt32(0))
                        nm = reader.GetString(1)
                        sn = reader.GetString(2)
                        em = reader.GetString(3)
                        gn = reader.GetString(4)
                        pn = reader.GetString(5)
                        ad = reader.GetString(6)
                        am = CStr(reader.GetInt32(7))
                        row = New String() {id, nm, sn, em, gn, pn, am}
                        CustomerDgv.Rows.Add(row)
                    End While

                End Using
            End Using
            connect.Close()


        Catch ex As Exception
            MessageBox.Show("Retrieving of Records Failed" + ex.Message)
        End Try
    End Sub


    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        LoadDGV2()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If CustID.Text <> "" Then


            Try
                Connection()
                Dim strQuery = "SELECT * FROM customer WHERE id = @id"
                Using Command = connect.CreateCommand
                    Command.CommandText = strQuery
                    Command.Parameters.Add("@id", DbType.String).Value = CustID.Text
                    Using reader = Command.ExecuteReader
                        While reader.Read()

                            firstnameTbx.Text = reader.GetString(1)
                            lastnameTbx.Text = reader.GetString(2)
                            emailTbx.Text = reader.GetString(3)
                            gendertCmbobx.SelectedItem = reader.GetString(4)
                            phonTbx.Text = reader.GetString(5)
                            addressTbx.Text = reader.GetString(6)
                            amountTbx.Text = CStr(reader.GetInt32(7))
                        End While

                    End Using
                End Using
                connect.Close()


            Catch ex As Exception
                MessageBox.Show("Selected Row Not Found !")
            End Try

        Else
            MessageBox.Show("Please ensure you have selected one from list to edit", "Failed", MessageBoxButtons.OK)
        End If

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
        CustID.Clear()
    End Sub

    Private Sub CustomerDgv_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerDgv.KeyDown
        If e.KeyCode = Keys.Delete Then
            DelBtn.PerformClick()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description =
            "Select the directory that you want to use , to save the file."
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Dim pathToSave = FolderBrowserDialog1.SelectedPath

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Dim i As Int16, j As Int16, k As Int16
            Try
                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")


                For i = 0 To CustomerDgv.RowCount - 2
                    For j = 0 To CustomerDgv.ColumnCount - 1
                        For k = 1 To CustomerDgv.Columns.Count
                            xlWorkSheet.Cells(1, k) = CustomerDgv.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = CustomerDgv(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkBook.SaveAs(pathToSave + "\mycustomers.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                 Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                xlWorkBook.Close(True, misValue, misValue)
                xlApp.Quit()

                releaseObject(xlWorkSheet)
                releaseObject(xlWorkBook)
                releaseObject(xlApp)
            Catch rx As Exception
                MessageBox.Show("Failed to Write the " + pathToSave + "mycustomers.xls - File may be in Use or Opened")
            End Try

            MessageBox.Show("Exported Succesfully", "Sucess")
        End If
    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub CustomerDgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustomerDgv.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = CustomerDgv.Rows(e.RowIndex)
            Clearfields()
            CustID.Text = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If CustID.Text = "" Then
            MessageBox.Show("Failed to identify the User TO Delete- You may Select again", "Failed")
            Return
        End If

        Dim confDel As DialogResult = MessageBox.Show("Are You very Sure to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confDel = DialogResult.Yes Then

            Try

                Connection()
                Dim strQuery = "DELETE FROM customer WHERE id = @id"
                Using Command = connect.CreateCommand
                    Command.CommandText = strQuery
                    Command.Parameters.Add("@id", DbType.String).Value = CustID.Text
                    Command.ExecuteNonQuery()
                End Using
                Dim Diagre As DialogResult = MessageBox.Show("Deleted  Successfuly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Diagre = DialogResult.OK Then
                    Clearfields()
                    LoadDGV2()
                End If
                connect.Close()

            Catch ex As Exception
                MessageBox.Show("Deletion of Record Failed")
            End Try
        End If

    End Sub



    Private Sub ManageCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As DialogResult = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If res = DialogResult.Yes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class