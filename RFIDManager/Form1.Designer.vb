<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.portComb = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnCon = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelPicc = New System.Windows.Forms.Label()
        Me.labelSak = New System.Windows.Forms.Label()
        Me.labelUid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnVer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labelVer = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnScan
        '
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Location = New System.Drawing.Point(54, 12)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(75, 23)
        Me.btnScan.TabIndex = 0
        Me.btnScan.Text = "포트스캔"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'portComb
        '
        Me.portComb.FormattingEnabled = True
        Me.portComb.Location = New System.Drawing.Point(135, 14)
        Me.portComb.Name = "portComb"
        Me.portComb.Size = New System.Drawing.Size(101, 20)
        Me.portComb.TabIndex = 1
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.RtsEnable = True
        '
        'btnCon
        '
        Me.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCon.Location = New System.Drawing.Point(54, 42)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(182, 23)
        Me.btnCon.TabIndex = 2
        Me.btnCon.Text = "연결"
        Me.btnCon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelPicc)
        Me.GroupBox1.Controls.Add(Me.labelSak)
        Me.GroupBox1.Controls.Add(Me.labelUid)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RFID 정보"
        '
        'labelPicc
        '
        Me.labelPicc.Font = New System.Drawing.Font("돋움체", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.labelPicc.Location = New System.Drawing.Point(7, 112)
        Me.labelPicc.Name = "labelPicc"
        Me.labelPicc.Size = New System.Drawing.Size(255, 43)
        Me.labelPicc.TabIndex = 0
        Me.labelPicc.Text = "PICC Type: "
        '
        'labelSak
        '
        Me.labelSak.AutoSize = True
        Me.labelSak.Font = New System.Drawing.Font("돋움체", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.labelSak.Location = New System.Drawing.Point(6, 68)
        Me.labelSak.Name = "labelSak"
        Me.labelSak.Size = New System.Drawing.Size(70, 21)
        Me.labelSak.TabIndex = 0
        Me.labelSak.Text = "SAK: "
        '
        'labelUid
        '
        Me.labelUid.AutoSize = True
        Me.labelUid.Font = New System.Drawing.Font("돋움체", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.labelUid.Location = New System.Drawing.Point(6, 29)
        Me.labelUid.Name = "labelUid"
        Me.labelUid.Size = New System.Drawing.Size(70, 21)
        Me.labelUid.TabIndex = 0
        Me.labelUid.Text = "UID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 4
        '
        'Timer1
        '
        '
        'btnVer
        '
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Location = New System.Drawing.Point(10, 20)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(66, 23)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "가져오기"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.labelVer)
        Me.GroupBox2.Controls.Add(Me.btnVer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 53)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "센서 정보"
        '
        'labelVer
        '
        Me.labelVer.AutoSize = True
        Me.labelVer.Font = New System.Drawing.Font("돋움체", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.labelVer.Location = New System.Drawing.Point(82, 24)
        Me.labelVer.Name = "labelVer"
        Me.labelVer.Size = New System.Drawing.Size(15, 13)
        Me.labelVer.TabIndex = 3
        Me.labelVer.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(301, 308)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCon)
        Me.Controls.Add(Me.portComb)
        Me.Controls.Add(Me.btnScan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RFID Scanner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnScan As Button
    Friend WithEvents portComb As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnCon As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelUid As Label
    Friend WithEvents labelPicc As Label
    Friend WithEvents labelSak As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnVer As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labelVer As Label
End Class
