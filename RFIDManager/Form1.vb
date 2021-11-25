Imports System.IO
Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCon.Enabled = False
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        portComb.Items.Clear()
        Dim port As Array
        Dim i As Integer
        port = Ports.SerialPort.GetPortNames()
        portComb.Items.AddRange(port)
        i = portComb.Items.Count
        i = i - i

        Try
            portComb.SelectedIndex = i
        Catch ex As Exception
            MsgBox("포트를 찾을 수 없습니다.", MsgBoxStyle.Critical, "포트")
            portComb.Text = ""
            portComb.Items.Clear()
        End Try
        btnCon.Enabled = True
        btnCon.BringToFront()
        portComb.DroppedDown = True
    End Sub

    Private Sub btnCon_Click(sender As Object, e As EventArgs) Handles btnCon.Click
        If SerialPort1.IsOpen Then
            btnCon.Text = "연결"
            Timer1.Enabled = False
            SerialPort1.Close()
        Else
            Try
                SerialPort1.BaudRate = "9600"
                SerialPort1.PortName = portComb.SelectedItem
                SerialPort1.Open()
                btnCon.Text = "연결해제"
                Timer1.Enabled = True
                Label1.Focus()
            Catch ex As Exception
                MsgBox("연결에 실패하였습니다.", MsgBoxStyle.Critical, "연결 실패")
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If SerialPort1.IsOpen Then
                Dim val As String = SerialPort1.ReadExisting()
                If val.Length <> 0 And val.Contains("/") Then
                    Dim sp As String() = val.Split("/")
                    labelUid.Text = "UID:" & sp(0)
                    labelSak.Text = "SAK: " & sp(1)
                    labelPicc.Text = "PICC Type: " & sp(2)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnCon_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCon.KeyDown, btnVer.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub portComb_KeyDown(sender As Object, e As KeyEventArgs) Handles portComb.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnScan_KeyDown(sender As Object, e As KeyEventArgs) Handles btnScan.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub GroupBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles GroupBox1.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("getver")
            Thread.Sleep(500)
            Dim val As String = SerialPort1.ReadExisting
            If val.Contains("-") Then
                Dim sp As String() = val.Split("-")
                labelVer.Text = "RC522 " & sp(0) & " (0x" & sp(1) & ")"
            End If
        End If
    End Sub
End Class
