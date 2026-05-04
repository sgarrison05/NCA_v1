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
        btnEnd = New Button()
        btnClose = New Button()
        brnStart = New Button()
        dgvCheckIns = New DataGridView()
        txbCurrentNet = New TextBox()
        lblNetID = New Label()
        lblClubID = New Label()
        txbClubName = New TextBox()
        lblModeID = New Label()
        cmbMode = New ComboBox()
        cmbBand = New ComboBox()
        lblBandID = New Label()
        txbFrequency = New TextBox()
        lblFrequencyID = New Label()
        lblNetControlID = New Label()
        txbNetControl = New TextBox()
        lblLogStationID = New Label()
        txbLogStation = New TextBox()
        CS = New DataGridViewTextBoxColumn()
        QST = New DataGridViewTextBoxColumn()
        Name = New DataGridViewTextBoxColumn()
        CITY = New DataGridViewTextBoxColumn()
        grpboxType = New GroupBox()
        rbtnRepeater = New RadioButton()
        rbtnSimplex = New RadioButton()
        lblSessionDateID = New Label()
        lblCheckinID = New Label()
        lblQSTID = New Label()
        lblTStartID = New Label()
        lblTEndID = New Label()
        txbNetDate = New TextBox()
        txbCheckIns = New TextBox()
        txbQST = New TextBox()
        txbTimeStart = New TextBox()
        txbTimeEnd = New TextBox()
        lblArrowID = New Label()
        grpboxCNET.SuspendLayout()
        CType(dgvCheckIns, ComponentModel.ISupportInitialize).BeginInit()
        grpboxType.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpboxCNET
        ' 
        grpboxCNET.Controls.Add(lblLogStationID)
        grpboxCNET.Controls.Add(txbLogStation)
        grpboxCNET.Controls.Add(lblNetControlID)
        grpboxCNET.Controls.Add(txbNetControl)
        grpboxCNET.Controls.Add(cmbBand)
        grpboxCNET.Controls.Add(lblBandID)
        grpboxCNET.Controls.Add(cmbMode)
        grpboxCNET.Controls.Add(lblModeID)
        grpboxCNET.Controls.Add(lblFrequencyID)
        grpboxCNET.Controls.Add(txbFrequency)
        grpboxCNET.Controls.Add(lblClubID)
        grpboxCNET.Controls.Add(txbClubName)
        grpboxCNET.Controls.Add(lblNetID)
        grpboxCNET.Controls.Add(txbCurrentNet)
        grpboxCNET.Controls.Add(btnEnd)
        grpboxCNET.Controls.Add(btnClose)
        grpboxCNET.Controls.Add(brnStart)
        grpboxCNET.Location = New Point(12, 3)
        grpboxCNET.Name = "grpboxCNET"
        grpboxCNET.Size = New Size(776, 152)
        grpboxCNET.TabIndex = 0
        grpboxCNET.TabStop = False
        grpboxCNET.Text = "Current Net"
        ' 
        ' btnEnd
        ' 
        btnEnd.BackColor = Color.Red
        btnEnd.ForeColor = SystemColors.ControlLightLight
        btnEnd.Location = New Point(695, 58)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(75, 32)
        btnEnd.TabIndex = 2
        btnEnd.Text = "End Net"
        btnEnd.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.BlueViolet
        btnClose.ForeColor = SystemColors.ControlLightLight
        btnClose.Location = New Point(695, 105)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 32)
        btnClose.TabIndex = 1
        btnClose.Text = "Close Form"
        btnClose.UseVisualStyleBackColor = False
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
        ' dgvCheckIns
        ' 
        dgvCheckIns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCheckIns.Columns.AddRange(New DataGridViewColumn() {CS, QST, Name, CITY})
        dgvCheckIns.Location = New Point(12, 257)
        dgvCheckIns.Name = "dgvCheckIns"
        dgvCheckIns.Size = New Size(776, 348)
        dgvCheckIns.TabIndex = 1
        ' 
        ' txbCurrentNet
        ' 
        txbCurrentNet.Location = New Point(38, 27)
        txbCurrentNet.Name = "txbCurrentNet"
        txbCurrentNet.Size = New Size(277, 23)
        txbCurrentNet.TabIndex = 3
        ' 
        ' lblNetID
        ' 
        lblNetID.AutoSize = True
        lblNetID.Location = New Point(6, 30)
        lblNetID.Name = "lblNetID"
        lblNetID.Size = New Size(26, 15)
        lblNetID.TabIndex = 4
        lblNetID.Text = "Net"
        ' 
        ' lblClubID
        ' 
        lblClubID.AutoSize = True
        lblClubID.Location = New Point(336, 30)
        lblClubID.Name = "lblClubID"
        lblClubID.Size = New Size(67, 15)
        lblClubID.TabIndex = 6
        lblClubID.Text = "Club Name"
        ' 
        ' txbClubName
        ' 
        txbClubName.Location = New Point(409, 27)
        txbClubName.Name = "txbClubName"
        txbClubName.Size = New Size(198, 23)
        txbClubName.TabIndex = 5
        ' 
        ' lblModeID
        ' 
        lblModeID.AutoSize = True
        lblModeID.Location = New Point(159, 72)
        lblModeID.Name = "lblModeID"
        lblModeID.Size = New Size(38, 15)
        lblModeID.TabIndex = 12
        lblModeID.Text = "Mode"
        ' 
        ' cmbMode
        ' 
        cmbMode.FormattingEnabled = True
        cmbMode.Location = New Point(203, 69)
        cmbMode.Name = "cmbMode"
        cmbMode.Size = New Size(77, 23)
        cmbMode.TabIndex = 13
        ' 
        ' cmbBand
        ' 
        cmbBand.FormattingEnabled = True
        cmbBand.Location = New Point(334, 69)
        cmbBand.Name = "cmbBand"
        cmbBand.Size = New Size(77, 23)
        cmbBand.TabIndex = 15
        ' 
        ' lblBandID
        ' 
        lblBandID.AutoSize = True
        lblBandID.Location = New Point(290, 72)
        lblBandID.Name = "lblBandID"
        lblBandID.Size = New Size(34, 15)
        lblBandID.TabIndex = 14
        lblBandID.Text = "Band"
        ' 
        ' txbFrequency
        ' 
        txbFrequency.Location = New Point(77, 69)
        txbFrequency.Name = "txbFrequency"
        txbFrequency.Size = New Size(73, 23)
        txbFrequency.TabIndex = 9
        ' 
        ' lblFrequencyID
        ' 
        lblFrequencyID.AutoSize = True
        lblFrequencyID.Location = New Point(8, 72)
        lblFrequencyID.Name = "lblFrequencyID"
        lblFrequencyID.Size = New Size(62, 15)
        lblFrequencyID.TabIndex = 10
        lblFrequencyID.Text = "Frequency"
        ' 
        ' lblNetControlID
        ' 
        lblNetControlID.AutoSize = True
        lblNetControlID.Location = New Point(8, 114)
        lblNetControlID.Name = "lblNetControlID"
        lblNetControlID.Size = New Size(24, 15)
        lblNetControlID.TabIndex = 17
        lblNetControlID.Text = "NC"
        ' 
        ' txbNetControl
        ' 
        txbNetControl.Location = New Point(40, 111)
        txbNetControl.Name = "txbNetControl"
        txbNetControl.Size = New Size(99, 23)
        txbNetControl.TabIndex = 16
        ' 
        ' lblLogStationID
        ' 
        lblLogStationID.AutoSize = True
        lblLogStationID.Location = New Point(166, 114)
        lblLogStationID.Name = "lblLogStationID"
        lblLogStationID.Size = New Size(19, 15)
        lblLogStationID.TabIndex = 19
        lblLogStationID.Text = "LS"
        ' 
        ' txbLogStation
        ' 
        txbLogStation.Location = New Point(191, 111)
        txbLogStation.Name = "txbLogStation"
        txbLogStation.Size = New Size(104, 23)
        txbLogStation.TabIndex = 18
        ' 
        ' CS
        ' 
        CS.HeaderText = "Call Sign"
        CS.Name = "CS"
        CS.Resizable = DataGridViewTriState.True
        CS.Width = 125
        ' 
        ' QST
        ' 
        QST.HeaderText = "QST"
        QST.Name = "QST"
        QST.Width = 50
        ' 
        ' Name
        ' 
        Name.HeaderText = "Name"
        Name.Name = "Name"
        Name.Width = 200
        ' 
        ' CITY
        ' 
        CITY.HeaderText = "Location"
        CITY.Name = "CITY"
        CITY.Width = 150
        ' 
        ' grpboxType
        ' 
        grpboxType.BackColor = Color.SlateBlue
        grpboxType.Controls.Add(rbtnSimplex)
        grpboxType.Controls.Add(rbtnRepeater)
        grpboxType.ForeColor = SystemColors.ControlLightLight
        grpboxType.Location = New Point(655, 161)
        grpboxType.Name = "grpboxType"
        grpboxType.Size = New Size(133, 90)
        grpboxType.TabIndex = 2
        grpboxType.TabStop = False
        grpboxType.Text = "Type"
        ' 
        ' rbtnRepeater
        ' 
        rbtnRepeater.AutoSize = True
        rbtnRepeater.Location = New Point(12, 24)
        rbtnRepeater.Name = "rbtnRepeater"
        rbtnRepeater.Size = New Size(71, 19)
        rbtnRepeater.TabIndex = 0
        rbtnRepeater.TabStop = True
        rbtnRepeater.Text = "Repeater"
        rbtnRepeater.UseVisualStyleBackColor = True
        ' 
        ' rbtnSimplex
        ' 
        rbtnSimplex.AutoSize = True
        rbtnSimplex.Location = New Point(12, 58)
        rbtnSimplex.Name = "rbtnSimplex"
        rbtnSimplex.Size = New Size(67, 19)
        rbtnSimplex.TabIndex = 3
        rbtnSimplex.TabStop = True
        rbtnSimplex.Text = "Simplex"
        rbtnSimplex.UseVisualStyleBackColor = True
        ' 
        ' lblSessionDateID
        ' 
        lblSessionDateID.AutoSize = True
        lblSessionDateID.Location = New Point(20, 175)
        lblSessionDateID.Name = "lblSessionDateID"
        lblSessionDateID.Size = New Size(72, 15)
        lblSessionDateID.TabIndex = 3
        lblSessionDateID.Text = "Month | Day"
        ' 
        ' lblCheckinID
        ' 
        lblCheckinID.AutoSize = True
        lblCheckinID.Location = New Point(163, 175)
        lblCheckinID.Name = "lblCheckinID"
        lblCheckinID.Size = New Size(60, 15)
        lblCheckinID.TabIndex = 4
        lblCheckinID.Text = "Check-ins"
        ' 
        ' lblQSTID
        ' 
        lblQSTID.AutoSize = True
        lblQSTID.Location = New Point(262, 175)
        lblQSTID.Name = "lblQSTID"
        lblQSTID.Size = New Size(56, 15)
        lblQSTID.TabIndex = 5
        lblQSTID.Text = "QST/Msg"
        ' 
        ' lblTStartID
        ' 
        lblTStartID.AutoSize = True
        lblTStartID.Location = New Point(386, 175)
        lblTStartID.Name = "lblTStartID"
        lblTStartID.Size = New Size(82, 15)
        lblTStartID.TabIndex = 6
        lblTStartID.Text = "Net Time Start"
        ' 
        ' lblTEndID
        ' 
        lblTEndID.AutoSize = True
        lblTEndID.Location = New Point(522, 175)
        lblTEndID.Name = "lblTEndID"
        lblTEndID.Size = New Size(78, 15)
        lblTEndID.TabIndex = 7
        lblTEndID.Text = "Net Time End"
        ' 
        ' txbNetDate
        ' 
        txbNetDate.Location = New Point(20, 205)
        txbNetDate.Name = "txbNetDate"
        txbNetDate.Size = New Size(100, 23)
        txbNetDate.TabIndex = 8
        ' 
        ' txbCheckIns
        ' 
        txbCheckIns.Location = New Point(163, 205)
        txbCheckIns.Name = "txbCheckIns"
        txbCheckIns.Size = New Size(60, 23)
        txbCheckIns.TabIndex = 9
        ' 
        ' txbQST
        ' 
        txbQST.Location = New Point(262, 205)
        txbQST.Name = "txbQST"
        txbQST.Size = New Size(52, 23)
        txbQST.TabIndex = 10
        ' 
        ' txbTimeStart
        ' 
        txbTimeStart.Location = New Point(386, 205)
        txbTimeStart.Name = "txbTimeStart"
        txbTimeStart.Size = New Size(82, 23)
        txbTimeStart.TabIndex = 11
        ' 
        ' txbTimeEnd
        ' 
        txbTimeEnd.Location = New Point(522, 205)
        txbTimeEnd.Name = "txbTimeEnd"
        txbTimeEnd.Size = New Size(78, 23)
        txbTimeEnd.TabIndex = 12
        ' 
        ' lblArrowID
        ' 
        lblArrowID.AutoSize = True
        lblArrowID.Location = New Point(481, 208)
        lblArrowID.Name = "lblArrowID"
        lblArrowID.Size = New Size(25, 15)
        lblArrowID.TabIndex = 13
        lblArrowID.Text = "-->"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 617)
        Controls.Add(lblArrowID)
        Controls.Add(txbTimeEnd)
        Controls.Add(txbTimeStart)
        Controls.Add(txbQST)
        Controls.Add(txbCheckIns)
        Controls.Add(txbNetDate)
        Controls.Add(lblTEndID)
        Controls.Add(lblTStartID)
        Controls.Add(lblQSTID)
        Controls.Add(lblCheckinID)
        Controls.Add(lblSessionDateID)
        Controls.Add(grpboxType)
        Controls.Add(dgvCheckIns)
        Controls.Add(grpboxCNET)
        Name = "frmMain"
        Text = "Main Form"
        grpboxCNET.ResumeLayout(False)
        grpboxCNET.PerformLayout()
        CType(dgvCheckIns, ComponentModel.ISupportInitialize).EndInit()
        grpboxType.ResumeLayout(False)
        grpboxType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpboxCNET As GroupBox
    Friend WithEvents dgvCheckIns As DataGridView
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents brnStart As Button
    Friend WithEvents lblClubID As Label
    Friend WithEvents txbClubName As TextBox
    Friend WithEvents lblNetID As Label
    Friend WithEvents txbCurrentNet As TextBox
    Friend WithEvents lblModeID As Label
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents cmbBand As ComboBox
    Friend WithEvents lblBandID As Label
    Friend WithEvents lblFrequencyID As Label
    Friend WithEvents txbFrequency As TextBox
    Friend WithEvents lblLogStationID As Label
    Friend WithEvents txbLogStation As TextBox
    Friend WithEvents lblNetControlID As Label
    Friend WithEvents txbNetControl As TextBox
    Friend WithEvents CS As DataGridViewTextBoxColumn
    Friend WithEvents QST As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents CITY As DataGridViewTextBoxColumn
    Friend WithEvents grpboxType As GroupBox
    Friend WithEvents rbtnSimplex As RadioButton
    Friend WithEvents rbtnRepeater As RadioButton
    Friend WithEvents lblSessionDateID As Label
    Friend WithEvents lblCheckinID As Label
    Friend WithEvents lblQSTID As Label
    Friend WithEvents lblTStartID As Label
    Friend WithEvents lblTEndID As Label
    Friend WithEvents txbNetDate As TextBox
    Friend WithEvents txbCheckIns As TextBox
    Friend WithEvents txbQST As TextBox
    Friend WithEvents txbTimeStart As TextBox
    Friend WithEvents txbTimeEnd As TextBox
    Friend WithEvents lblArrowID As Label

End Class
