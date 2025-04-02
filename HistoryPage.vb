Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class HistoryPage

    Private connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker1.Value = Date.Today

        LoadScanHistory()
    End Sub

    Private Sub LoadScanHistory(Optional filterDate As String = "")
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim query As String = "SELECT s.ID, s.ScanDate, pi.PetID, pi.Name AS Name, c.FullName AS FullName FROM Scanner s
                                       JOIN pets_info pi ON s.PetID = pi.PetID 
                                       JOIN clients c ON pi.ClientID = c.ClientID 
                                       WHERE 1=1"

                If filterDate <> "" Then
                    query &= " AND DATE(s.ScanDate) = @FilterDate"
                End If

                query &= " ORDER BY s.ScanDate DESC"

                Using cmd As New MySqlCommand(query, con)
                    If filterDate <> "" Then
                        cmd.Parameters.AddWithValue("@FilterDate", filterDate)
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim selectedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        LoadScanHistory(selectedDate)
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim DashboardPage As New DashboardPage()
        DashboardPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim eGraphics As Graphics = e.Graphics
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubTitle As New Font("Arial", 12, FontStyle.Regular)
        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10, FontStyle.Regular)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Integer = 50
        Dim xPos As Integer = 50
        Dim logoPath As String = "C:\Users\joanna\source\repos\PETMALU\PetMalu_Records_System\Image\petmalu logo.png"
        Static rowIndex As Integer = 0

        Try
            ' Draw Logo
            If System.IO.File.Exists(logoPath) Then
                Dim logo As Image = Image.FromFile(logoPath)
                eGraphics.DrawImage(logo, xPos, yPos, 150, 150) ' Adjust size as needed
            End If

            ' Clinic Name & Address
            eGraphics.DrawString("PetMalu Animal Clinic", fontTitle, brush, xPos + 180, yPos + 50)
            eGraphics.DrawString("J.P. Rizal St., cor E. Aguinaldo St., Sta. Lucia, Novaliches,", fontSubTitle, brush, xPos + 180, yPos + 90)
            eGraphics.DrawString("Quezon City, Philippines", fontSubTitle, brush, xPos + 180, yPos + 110)

            ' Draw Section Title
            yPos += 180
            eGraphics.DrawString("Scan Record", fontTitle, brush, xPos, yPos)
            yPos += 40

            ' Draw Table Headers
            Dim headers() As String = {"ID", "Scan Date", "Pet ID", "Name", "Full Name"}
            Dim columnWidths() As Integer = {80, 200, 150, 150, 200} ' Adjust column sizes
            Dim xOffset As Integer = xPos

            For i As Integer = 0 To headers.Length - 1
                eGraphics.DrawString(headers(i), fontHeader, brush, xOffset, yPos)
                xOffset += columnWidths(i)
            Next

            yPos += 30 ' Move to the next row

            ' Fetch Data from DataGridView
            While rowIndex < DataGridView1.Rows.Count - 1
                xOffset = xPos
                For i As Integer = 0 To headers.Length - 1
                    Dim value As String = DataGridView1.Rows(rowIndex).Cells(i).Value.ToString()
                    eGraphics.DrawString(value, fontContent, brush, xOffset, yPos)
                    xOffset += columnWidths(i)
                Next
                yPos += 25 ' Move to the next row

                ' Check if the next row will fit on the page
                If yPos + 25 > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    rowIndex += 1 ' Continue from next row on the next page
                    Exit Sub
                End If

                rowIndex += 1
            End While

            ' If all rows are printed, indicate that there are no more pages
            e.HasMorePages = False
            rowIndex = 0 ' Reset rowIndex for next print job

        Catch ex As Exception
            MessageBox.Show("Error in printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
