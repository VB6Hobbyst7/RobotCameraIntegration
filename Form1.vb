Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Public cognexServerIP As IPAddress = IPAddress.Parse("169.254.245.128")
    Public cognexPort As Integer = 23
    Public cognexSocket As Socket
    Public cognexConnected As Boolean = False

    Public robotServerIP As IPAddress = IPAddress.Parse("169.254.245.125")
    Public robotPort As Integer = 29999
    Public robotSocket As Socket
    Public robotConnected As Boolean = False

    Public xArr As New List(Of Double)()
    Public yArr As New List(Of Double)()

    Public Function ConnectToServer(IP As IPAddress, Port As Integer) As Socket
        Try
            Dim EP As New IPEndPoint(IP, Port)
            Dim Sock As New Socket(IP.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
            Dim connected = False
            Dim count As Integer = 0
            While connected = False And count < 15
                Try
                    Sock.Connect(EP)
                    connected = True
                    Return Sock
                Catch ex As Exception
                    MsgBox("Error connecting to cognex server")
                End Try
                count += 1
            End While
            Return Nothing
        Catch ex As Exception
            MsgBox("Error creating the socket")
            Return Nothing
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connects to Cognex Camera on the telnet port and logs in
        'Refreshes the desktop form to show the user that it connected properly to the camera
        cognexSocket = ConnectToServer(cognexServerIP, cognexPort)
        Threading.Thread.Sleep(250)
        Dim bytes(1024) As Byte
        Dim recBytes = cognexSocket.Receive(bytes)
        If Encoding.ASCII.GetString(bytes, 0, recBytes).Contains("User") Then
            Dim user = Encoding.ASCII.GetBytes("admin" & Environment.NewLine)
            cognexSocket.Send(user)
            Threading.Thread.Sleep(250)
            Dim recBytes3 = cognexSocket.Receive(bytes)
            If Encoding.ASCII.GetString(bytes, 0, recBytes3).Contains("Password") Then
                Dim password = Encoding.ASCII.GetBytes(Environment.NewLine)
                cognexSocket.Send(password)
                Threading.Thread.Sleep(250)
                Dim recBytes4 = cognexSocket.Receive(bytes)
                If Encoding.ASCII.GetString(bytes, 0, recBytes4).Contains("User Logged In") Then
                    lblConnected.Text = "Cognex: Connected/Logged In"
                    lblConnected.ForeColor = Color.Green
                    cognexConnected = True
                Else
                    lblConnected.Text = "Cognex: Disconnected"
                    lblConnected.ForeColor = Color.Red
                    cognexConnected = False
                End If
            End If
        Else
            MsgBox("Couldn't connect to the camera")
        End If
        lblIP.Text &= " " & cognexServerIP.ToString()
        lblPort.Text &= " " & cognexPort.ToString()
        If GetStatus() Then
            lblStatus.Text = "Cognex Status: Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Cognex Status: Offline"
            lblStatus.ForeColor = Color.Red
        End If

        'Connects to Universal Robot on the dashboard server port
        'Refreshes the dekstop form to show the user that it connected properly to the robot
        lblRobotIP.Text &= " " & robotServerIP.ToString()
        lblRobotPort.Text &= " " & robotPort.ToString()
        robotSocket = ConnectToServer(robotServerIP, robotPort)
        Dim byes2(1024) As Byte
        Dim bytesRec = robotSocket.Receive(bytes)
        If Encoding.ASCII.GetString(bytes, 0, bytesRec).Contains("Connected") Then
            lblRobotStatus.Text = "Robot Status: Connected"
            lblRobotStatus.ForeColor = Color.Green
            robotConnected = True
        Else
            lblRobotStatus.Text = "Robot Status: Disconnected"
            lblRobotStatus.ForeColor = Color.Red
            robotConnected = True
        End If
    End Sub


    Private Sub btnGF_Click(sender As Object, e As EventArgs) Handles btnGF.Click
        If cognexConnected = True Then
            Dim gfCmd = Encoding.ASCII.GetBytes("GF" & Environment.NewLine)
            cognexSocket.Send(gfCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = cognexSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                MsgBox("Loaded File: " & response.Split("/")(1))
            Else
                MsgBox("Error while sending command")
            End If
        Else
            MsgBox("Camera isn't connected")
        End If
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        If cognexConnected = True Then
            Dim soCmd = Encoding.ASCII.GetBytes("SO1" & Environment.NewLine)
            cognexSocket.Send(soCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = cognexSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("1") = False Then
                    MsgBox("Error turning camera online")
                End If
            Else
                MsgBox("Error turning camera online")
            End If
        Else
            MsgBox("Camera isn't connected")
        End If

        If GetStatus() Then
            lblStatus.Text = "Status: Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Status: Offline"
            lblStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        If cognexConnected = True Then
            Dim soCmd = Encoding.ASCII.GetBytes("SO0" & Environment.NewLine)
            cognexSocket.Send(soCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = cognexSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("1") = False Then
                    MsgBox("Error turning camera offline")
                End If
            Else
                MsgBox("Error turning camera offline")
            End If
        Else
            MsgBox("Camera isn't connected")
        End If

        If GetStatus() Then
            lblStatus.Text = "Status: Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Status: Offline"
            lblStatus.ForeColor = Color.Red
        End If
    End Sub

    Public Function GetStatus()
        If cognexConnected = True Then
            Dim goCmd = Encoding.ASCII.GetBytes("GO" & Environment.NewLine)
            cognexSocket.Send(goCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim recBytes = cognexSocket.Receive(bytes)
            If recBytes <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                If response.Contains("1") Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub btnTrigger_Click(sender As Object, e As EventArgs) Handles btnTrigger.Click
        If cognexConnected = True Then
            Dim trigCmd = Encoding.ASCII.GetBytes("SE8" & Environment.NewLine)
            cognexSocket.Send(trigCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim recBytes = cognexSocket.Receive(bytes)
            If recBytes <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                If response.Contains("1") Then
                    Dim getXCmd = Encoding.ASCII.GetBytes("GVC24" & Environment.NewLine)
                    Dim getYCmd = Encoding.ASCII.GetBytes("GVD24" & Environment.NewLine)
                    cognexSocket.Send(getXCmd)
                    Threading.Thread.Sleep(250)
                    recBytes = cognexSocket.Receive(bytes)
                    If recBytes <> 0 Then
                        response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                        lblPastX.Text = "Previous X: " & lblX.Text.Split(":")(1)
                        lblX.Text = "X: " & response.Split(vbLf)(1).ToString().Trim() & " mm"
                        Dim xValue As Double = response.Split(vbLf)(1).Trim()
                        xArr.Add(response.Split(vbLf)(1).Trim())
                    End If
                    cognexSocket.Send(getYCmd)
                    Threading.Thread.Sleep(250)
                    recBytes = cognexSocket.Receive(bytes)
                    If recBytes <> 0 Then
                        response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                        lblPastY.Text = "Previous Y: " & lblY.Text.Split(":")(1)
                        lblY.Text = "Y: " & response.Split(vbLf)(1).ToString().Trim() & " mm"
                        yArr.Add(response.Split(vbLf)(1).Trim())
                    End If
                Else
                    MsgBox("Error triggering the camera")
                End If
            End If

            'Calculates the average X and Y values of the hole location and refreshes the desktop form
            Dim sumX As Double = 0.0
            Dim sumY As Double = 0.0

            For Each number As Double In xArr
                sumX += number
            Next

            For Each number As Double In yArr
                sumY += number
            Next

            If sumX <> 0.0 And sumY <> 0.0 Then
                lblAvgX.Text = "Avg X: " & (sumX / xArr.Count).ToString("F3") & " mm"
                lblAvgY.Text = "Avg Y: " & (sumY / yArr.Count).ToString("F3") & " mm"
            End If

            'Calculates the standard deviation of the X and Y coordinates of the hole location that have been triggered since the form opened
            Dim sumVarX As Double = 0.0
            Dim sumVarY As Double = 0.0

            For Each number As Double In xArr
                sumVarX += ((number - (sumX / xArr.Count)) ^ 2)
            Next

            For Each number As Double In yArr
                sumVarY += ((number - (sumY / yArr.Count)) ^ 2)
            Next

            If sumVarX <> 0.0 And sumVarY <> 0.0 Then
                lblXDev.Text = "Avg X Dev: " & Math.Sqrt((sumVarX / xArr.Count)).ToString("F4") & " mm"
                lblYDev.Text = "Avg Y Dev: " & Math.Sqrt((sumVarY / yArr.Count)).ToString("F4") & " mm"
            End If
        Else
            MsgBox("Camera is not connected")
        End If
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/gohome.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    Threading.Thread.Sleep(250)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                Else
                    MsgBox("Error loading the program")
                End If
            Else
                MsgBox("Error receiving from the robot")
            End If
        Else
            MsgBox("Robot is not connected")
        End If
    End Sub

    Private Sub btnGoToHole_Click(sender As Object, e As EventArgs) Handles btnGoToHole.Click
        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/CalibrateHole.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    Threading.Thread.Sleep(250)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If
    End Sub
End Class
