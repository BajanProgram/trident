Imports System.Data.SQLite
Public Class MainForm

    Dim conn As New SQLite.SQLiteConnection("Data Source=IMS.db")
    Dim connectionString As String = "Data source=IMS.db"


    Public Sub loadgrid()

        conn.Open()
        Dim cmd As New SQLite.SQLiteCommand
        cmd.Connection = conn

        cmd.CommandText = "select * from inventory_warehouse"

        Dim rdr As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rdr)
        rdr.Close()
        conn.Close()
        DataGridView1.DataSource = dt

        Return


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtComboParts As New DataTable
        Dim dtCombotechs As New DataTable
        Dim dtDestinations As New DataTable



        'Loading Combobox for parts
        dtComboParts = loadparts()

        ComboBoxPart.ValueMember = "name"
        ComboBoxPart.DataSource = dtComboParts
        ComboBoxPart.SelectedIndex = -1
        'Loading Combobox for techs
        dtCombotechs = loadtechs()

        ComboBoxTech.ValueMember = "name"
        ComboBoxTech.DataSource = dtCombotechs

        'Loading Combobox for destinations
        dtDestinations = loadDestination()

        ComboBoxDestination.ValueMember = "venue"
        ComboBoxDestination.DataSource = dtDestinations



        'sub to load grid
        loadgrid()


        ButtonSave.Enabled = False
        ButtonSave.BackColor = Color.Gray






    End Sub

    Public Function searchGrid() As DataTable
        Dim dtSearch As New DataTable
        Dim serial = TextBoxSerial.Text
        Dim partName = ComboBoxPart.Text
        Dim searchQuery As String = "select * from inventory_warehouse where @serial = serial OR @part_name = part_name"
        Dim connectionString As String = "Data source=IMS.db"

        Try
            Using conn As New SQLiteConnection(connectionString)

                Using cmd As New SQLiteCommand(searchQuery, conn)
                    conn.Open()

                    cmd.Parameters.AddWithValue("@serial", serial)
                    cmd.Parameters.AddWithValue("@part_name", partName)
                    Using rdr = cmd.ExecuteReader
                        dtSearch.Load(rdr)
                    End Using
                End Using

            End Using
        Catch ex As Exception

        End Try

        Return dtSearch

    End Function


    Public Sub Reload()
        RadioButtonInsert.Checked = False
        RadioButtonOutgoing.Checked = False
        RadioButtonGood.Checked = False
        RadioButtonBad.Checked = False

        ButtonSearch.Visible = True
    End Sub

    Private Function loadparts() As DataTable

        Dim dtParts As New DataTable
        Dim partNamesQuery As String = "select * from part_names"


        Try

            Using conn As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(partNamesQuery, conn)
                    conn.Open()
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dtParts)
                    End Using
                End Using

            End Using

        Catch ex As Exception
        End Try


        Return dtParts

    End Function

    Private Function loadtechs() As DataTable

        Dim dtTechs As New DataTable
        Dim techNamesQuery As String = "select * from techs"


        Try

            Using conn As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(techNamesQuery, conn)
                    conn.Open()
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dtTechs)
                    End Using
                End Using

            End Using

        Catch ex As Exception
        End Try


        Return dtTechs

    End Function

    Private Function loadDestination() As DataTable

        Dim dtDestination As New DataTable
        Dim shopNamesQuery As String = "select * from destinations"


        Try

            Using conn As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(shopNamesQuery, conn)
                    conn.Open()
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dtDestination)
                    End Using
                End Using

            End Using

        Catch ex As Exception

        End Try


        Return dtDestination

    End Function

    Private Function checkConditition()
        Dim condition As Boolean

        If RadioButtonGood.Checked Then
            condition = True

        ElseIf RadioButtonBad.Checked Then
            condition = False

        End If


        Return condition

    End Function

    Private Sub Clear()
        TextBoxSerial.Text = Nothing
        ComboBoxPart.Text = Nothing
        RadioButtonGood.Checked = False
        RadioButtonBad.Checked = False
        ComboBoxTech.Text = Nothing
        ComboBoxDestination.Text = Nothing
        TextBoxComments.Text = Nothing
    End Sub

    Private Sub RadioButtonIncoming_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInsert.CheckedChanged
        LabelCondition.Visible = RadioButtonInsert.Checked
        LabelTech.Visible = RadioButtonInsert.Checked
        LabelDate.Visible = RadioButtonInsert.Checked


        Panel2.Visible = RadioButtonInsert.Checked
        ComboBoxTech.Visible = RadioButtonInsert.Checked
        DateTimePicker1.Visible = RadioButtonInsert.Checked
        LabelComments.Visible = RadioButtonInsert.Checked
        TextBoxComments.Visible = RadioButtonInsert.Checked

        ButtonSearch.Visible = False
        ButtonSave.Enabled = True
        ButtonSave.BackColor = Color.Transparent
        Clear()


    End Sub

    Private Sub RadioButtonOutgoing_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOutgoing.CheckedChanged
        LabelTech.Visible = RadioButtonOutgoing.Checked
        LabelDate.Visible = RadioButtonOutgoing.Checked
        LabelDestination.Visible = RadioButtonOutgoing.Checked

        ComboBoxTech.Visible = RadioButtonOutgoing.Checked
        ComboBoxDestination.Visible = RadioButtonOutgoing.Checked
        DateTimePicker1.Visible = RadioButtonOutgoing.Checked

        ButtonSave.Enabled = True
        ButtonSearch.Visible = False
        ButtonSave.BackColor = Color.Transparent
        DataGridView1.Focus()
        Clear()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Reload()
        loadgrid()
        Clear()
        ButtonSave.Enabled = False
        ButtonSave.BackColor = Color.Gray
        LabelDataGrid.Text = "Overall Inventory"

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim condition = checkConditition()
        Dim serial = TextBoxSerial.Text
        Dim partName = ComboBoxPart.Text
        Dim destination = ComboBoxDestination.Text
        Dim tech = ComboBoxTech.Text
        Dim dateInfo = DateTimePicker1.Text
        Dim comments = TextBoxComments.Text
        Dim check As Integer

        If RadioButtonInsert.Checked = True Then

            If TextBoxSerial.Text = "" Then
                MsgBox("Please enter serial number")
                Exit Sub
            End If
            If ComboBoxPart.Text = "" Then
                MsgBox("Please enter part name")
                Exit Sub
            End If
            If RadioButtonBad.Checked = False And RadioButtonGood.Checked = False Then
                MsgBox("Please state condition of part")
                Exit Sub
            End If
            If ComboBoxTech.Text = "" Then
                MsgBox("Please enter your name ")
                Exit Sub
            End If

        ElseIf RadioButtonOutgoing.Checked = True Then
            If TextBoxSerial.Text = "" Then
                MsgBox("Please enter serial number")
                Exit Sub
            End If
            If ComboBoxPart.Text = "" Then
                MsgBox("Please enter part name")
                Exit Sub
            End If
            If ComboBoxDestination.Text = "" Then
                MsgBox("Please enter destination")
                Exit Sub
            End If
            If ComboBoxTech.Text = "" Then
                MsgBox("Please enter your name ")
                Exit Sub
            End If
        End If

        Dim insertQuery As String = "insert into inventory_in ( serial, part_name, condition, tech, date,comments)values (@serial,@part_name,@condition, @tech, @entryDate,@comments) "
        Dim insertQueryWarehouse As String = "insert into inventory_warehouse ( serial, part_name, condition,comments)values (@serial,@part_name,@condition,@comments) "




        'INSERT INTO INVENTORY_IN WIH THIS TRY BLOCK
        If RadioButtonInsert.Checked Then
            Try

                Using conn As New SQLiteConnection(connectionString)
                    Using cmd As New SQLiteCommand(insertQuery, conn)
                        conn.Open()




                        cmd.Parameters.AddWithValue("@serial", serial)
                        cmd.Parameters.AddWithValue("@part_name", partName)
                        cmd.Parameters.AddWithValue("@condition", condition)
                        cmd.Parameters.AddWithValue("@comments", comments)
                        cmd.Parameters.AddWithValue("@tech", tech)
                        cmd.Parameters.AddWithValue("@entryDate", dateInfo)

                        cmd.ExecuteNonQuery()



                    End Using

                End Using

            Catch ex As Exception

                MsgBox("Failed to execute", vbCritical, "DB Connection Failed")
            End Try

            'INSERT INTO INVENTORY_WAREHOUSE THIS TRY BLOCK
            Try

                Using conn As New SQLiteConnection(connectionString)
                    Using cmd1 As New SQLiteCommand(insertQueryWarehouse, conn)
                        conn.Open()




                        cmd1.Parameters.AddWithValue("@serial", serial)
                        cmd1.Parameters.AddWithValue("@part_name", partName)
                        cmd1.Parameters.AddWithValue("@condition", condition)
                        cmd1.Parameters.AddWithValue("@comments", comments)


                        cmd1.ExecuteNonQuery()

                        MsgBox("Your information has been saved to overall inventory", vbInformation)

                    End Using

                End Using

            Catch ex As Exception

                MsgBox("Your information has not been saved to overall inventory. Make sure the serial and part you are entering are not already in the database.", vbCritical, "DB Connection Failed")
            End Try


            'Checking to see if radio button outogoing is checked so we can use the deletion query on the outgoing table
        ElseIf RadioButtonOutgoing.Checked = True Then

            Try

                Using conn As New SQLiteConnection(connectionString)
                    Using cmd2 As New SQLiteCommand(conn)
                        conn.Open()


                        cmd2.CommandText = "DELETE FROM inventory_warehouse WHERE serial = @serial AND part_name = @part_name"


                        cmd2.Parameters.AddWithValue("@serial", serial)
                        cmd2.Parameters.AddWithValue("@part_name", partName)



                        check = cmd2.ExecuteNonQuery()

                        If check > 0 Then

                            MsgBox("Your outgoing form has been saved", vbInformation, "Success")

                        Else

                            MsgBox("There isn't a part that matches your request in the Database", vbExclamation, "Part doesnt exist")
                            Exit Sub
                        End If

                    End Using

                End Using

            Catch ex As Exception

                MsgBox("Failed to execute", vbCritical, "DB Connection Failed")
            End Try





            Try

                Using conn As New SQLiteConnection(connectionString)
                    Using cmd1 As New SQLiteCommand(conn)
                        conn.Open()


                        cmd1.CommandText = "insert into inventory_out ( serial, part_name, tech,destination,date_out) values (@serial,@part_name,@tech, @destination, @date) "

                        cmd1.Parameters.AddWithValue("@serial", serial)
                        cmd1.Parameters.AddWithValue("@part_name", partName)
                        cmd1.Parameters.AddWithValue("@tech", tech)
                        cmd1.Parameters.AddWithValue("@destination", destination)
                        cmd1.Parameters.AddWithValue("@date", dateInfo)


                        cmd1.ExecuteNonQuery()



                    End Using

                End Using

            Catch ex As Exception

                MsgBox("Failed to execute", vbCritical, "DB Connection Failed")
            End Try

        End If

        loadgrid()

        Clear()



    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        DataGridView1.DataSource = searchGrid()
        LabelDataGrid.Text = "Search results"
    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If RadioButtonOutgoing.Checked = True Then

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                TextBoxSerial.Text = row.Cells(0).Value.ToString
                ComboBoxPart.Text = row.Cells(1).Value.ToString

            End If


        Else
            Exit Sub
        End If
    End Sub

End Class