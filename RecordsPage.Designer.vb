<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordsPage))
        BtnBack = New Button()
        BtnPrint = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        DataGridView1 = New DataGridView()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        BtnInsert = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1713, 917)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(150, 64)
        BtnBack.TabIndex = 1
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.Green
        BtnPrint.FlatStyle = FlatStyle.Popup
        BtnPrint.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPrint.ForeColor = Color.White
        BtnPrint.Location = New Point(1544, 917)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(154, 64)
        BtnPrint.TabIndex = 2
        BtnPrint.Text = "PRINT"
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.BackColor = Color.Teal
        BtnUpdate.FlatStyle = FlatStyle.Popup
        BtnUpdate.Font = New Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnUpdate.ForeColor = Color.White
        BtnUpdate.Location = New Point(1353, 919)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(175, 64)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.YellowGreen
        BtnDelete.FlatStyle = FlatStyle.Popup
        BtnDelete.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDelete.ForeColor = Color.White
        BtnDelete.Location = New Point(1162, 921)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(175, 62)
        BtnDelete.TabIndex = 4
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        PrintDocument1.DocumentName = "Record Print"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(77, 349)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1801, 255)
        DataGridView1.TabIndex = 5
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' BtnInsert
        ' 
        BtnInsert.BackColor = Color.OliveDrab
        BtnInsert.FlatStyle = FlatStyle.Popup
        BtnInsert.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnInsert.ForeColor = Color.White
        BtnInsert.Location = New Point(981, 921)
        BtnInsert.Name = "BtnInsert"
        BtnInsert.Size = New Size(163, 62)
        BtnInsert.TabIndex = 6
        BtnInsert.Text = "ADD"
        BtnInsert.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 120F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(770, -19)
        Label1.Name = "Label1"
        Label1.Size = New Size(888, 249)
        Label1.TabIndex = 7
        Label1.Text = "Record"
        ' 
        ' RecordsPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label1)
        Controls.Add(BtnInsert)
        Controls.Add(DataGridView1)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnPrint)
        Controls.Add(BtnBack)
        Name = "RecordsPage"
        Text = "RecordsPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Label1 As Label
End Class
