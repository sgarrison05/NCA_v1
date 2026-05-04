<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpboxCNET = New GroupBox()
        DataGridView1 = New DataGridView()
        CS = New DataGridViewTextBoxColumn()
        Name = New DataGridViewTextBoxColumn()
        QST = New DataGridViewTextBoxColumn()
        CITY = New DataGridViewTextBoxColumn()
        brnStart = New Button()
        btnClose = New Button()
        btnEnd = New Button()
        grpboxCNET.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpboxCNET
        ' 
        grpboxCNET.Controls.Add(btnEnd)
        grpboxCNET.Controls.Add(btnClose)
        grpboxCNET.Controls.Add(brnStart)
        grpboxCNET.Location = New Point(12, 3)
        grpboxCNET.Name = "grpboxCNET"
        grpboxCNET.Size = New Size(776, 123)
        grpboxCNET.TabIndex = 0
        grpboxCNET.TabStop = False
        grpboxCNET.Text = "Current Net"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CS, Name, QST, CITY})
        DataGridView1.Location = New Point(12, 132)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 306)
        DataGridView1.TabIndex = 1
        ' 
        ' CS
        ' 
        CS.HeaderText = "Call Sign"
        CS.Name = "CS"
        CS.Resizable = DataGridViewTriState.True
        CS.Width = 125
        ' 
        ' Name
        ' 
        Name.HeaderText = "Name"
        Name.Name = "Name"
        Name.Width = 200
        ' 
        ' QST
        ' 
        QST.HeaderText = "QST"
        QST.Name = "QST"
        QST.Width = 50
        ' 
        ' CITY
        ' 
        CITY.HeaderText = "City"
        CITY.Name = "CITY"
        CITY.Width = 150
        ' 
        ' brnStart
        ' 
        brnStart.BackColor = Color.DarkGreen
        brnStart.ForeColor = SystemColors.ControlLightLight
        brnStart.Location = New Point(695, 13)
        brnStart.Name = "brnStart"
        brnStart.Size = New Size(75, 32)
        brnStart.TabIndex = 0
        brnStart.Text = "Start Net"
        brnStart.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.BlueViolet
        btnClose.ForeColor = SystemColors.ControlLightLight
        btnClose.Location = New Point(695, 82)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 32)
        btnClose.TabIndex = 1
        btnClose.Text = "Close Form"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnEnd
        ' 
        btnEnd.BackColor = Color.Red
        btnEnd.ForeColor = SystemColors.ControlLightLight
        btnEnd.Location = New Point(695, 48)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(75, 32)
        btnEnd.TabIndex = 2
        btnEnd.Text = "End Net"
        btnEnd.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(grpboxCNET)
        Name = "frmMain"
        Text = "Main Form"
        grpboxCNET.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpboxCNET As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CS As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents QST As DataGridViewTextBoxColumn
    Friend WithEvents CITY As DataGridViewTextBoxColumn
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents brnStart As Button

End Class
