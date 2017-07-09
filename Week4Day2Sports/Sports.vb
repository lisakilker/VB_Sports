Public Class frmSports

    Private Sub TeamBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TeamBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TeamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LittleLeagueDataSet)

    End Sub

    Private Sub frmSports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LittleLeagueDataSet.Team' table. You can move, or remove it, as needed.
        Me.TeamTableAdapter.Fill(Me.LittleLeagueDataSet.Team)

    End Sub

    Private Sub btnAges_Click(sender As Object, e As EventArgs) Handles btnAges.Click
        Dim strSQL As String = "SELECT * FROM Team"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\LisaKilker\Documents\Chapter 10\LittleLeague.accdb"
        Dim odaLittleLeague As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datPlayers As New DataTable
        Dim intCount As Integer = 0
        Dim intNumOf12YearOlds As Integer
        Dim intNumOf13yearOlds As Integer
        Dim intNumOf14YearOlds As Integer
        Dim decAverageAge As Decimal
        Dim intTotalAverageAge As Integer

        odaLittleLeague.Fill(datPlayers)
        odaLittleLeague.Dispose()

        For intCount = 0 To datPlayers.Rows.Count - 1
            intTotalAverageAge += Convert.ToDecimal(datPlayers.Rows(intCount)("Age"))

            If datPlayers.Rows(intCount)("Age") = 12 Then
                intNumOf12YearOlds += 1
            End If
            If datPlayers.Rows(intCount)("Age") = 13 Then
                intNumOf13yearOlds += 1
            End If
            If datPlayers.Rows(intCount)("Age") = 14 Then
                intNumOf14YearOlds += 1
            End If
        Next

        decAverageAge = intTotalAverageAge / intCount

        lbl12YearOlds.Visible = True
        lbl13YearOlds.Visible = True
        lbl14YearOlds.Visible = True
        lblAverageAges.Visible = True

        lbl12YearOlds.Text = "There are " & intNumOf12YearOlds.ToString("F0") & " 12-year-olds"
        lbl13YearOlds.Text = "There are " & intNumOf13yearOlds.ToString("F0") & " 13-year-olds"
        lbl14YearOlds.Text = "There are " & intNumOf14YearOlds.ToString("F0") & " 14-year-olds"
        lblAverageAges.Text = "The average player age is: " & decAverageAge.ToString("F0")


    End Sub
End Class


