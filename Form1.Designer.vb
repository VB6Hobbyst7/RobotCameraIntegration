<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblRobotPort = New System.Windows.Forms.Label()
        Me.lblRobotIP = New System.Windows.Forms.Label()
        Me.lblRobotStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.btnGF = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTrigger = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnGoToHole = New System.Windows.Forms.Button()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPastY = New System.Windows.Forms.Label()
        Me.lblPastX = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAvgY = New System.Windows.Forms.Label()
        Me.lblAvgX = New System.Windows.Forms.Label()
        Me.lblYDev = New System.Windows.Forms.Label()
        Me.lblXDev = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblConnected)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 128)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblRobotPort)
        Me.Panel4.Controls.Add(Me.lblRobotIP)
        Me.Panel4.Controls.Add(Me.lblRobotStatus)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblPort)
        Me.Panel4.Controls.Add(Me.lblIP)
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(179, 128)
        Me.Panel4.TabIndex = 1
        '
        'lblRobotPort
        '
        Me.lblRobotPort.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotPort.Location = New System.Drawing.Point(0, 96)
        Me.lblRobotPort.Name = "lblRobotPort"
        Me.lblRobotPort.Size = New System.Drawing.Size(177, 16)
        Me.lblRobotPort.TabIndex = 14
        Me.lblRobotPort.Text = "Robot Port:"
        Me.lblRobotPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRobotIP
        '
        Me.lblRobotIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotIP.Location = New System.Drawing.Point(0, 80)
        Me.lblRobotIP.Name = "lblRobotIP"
        Me.lblRobotIP.Size = New System.Drawing.Size(177, 16)
        Me.lblRobotIP.TabIndex = 13
        Me.lblRobotIP.Text = "Robot IP:"
        Me.lblRobotIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRobotStatus
        '
        Me.lblRobotStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotStatus.Location = New System.Drawing.Point(0, 64)
        Me.lblRobotStatus.Name = "lblRobotStatus"
        Me.lblRobotStatus.Size = New System.Drawing.Size(177, 16)
        Me.lblRobotStatus.TabIndex = 15
        Me.lblRobotStatus.Text = "Robot Status:"
        Me.lblRobotStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(0, 32)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(177, 16)
        Me.lblPort.TabIndex = 5
        Me.lblPort.Text = "Cognex Port:"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(0, 16)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(177, 16)
        Me.lblIP.TabIndex = 4
        Me.lblIP.Text = "Cognex IP:"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(177, 16)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Cognex Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConnected
        '
        Me.lblConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConnected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.Location = New System.Drawing.Point(0, 0)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(918, 128)
        Me.lblConnected.TabIndex = 0
        Me.lblConnected.Text = "UR/Cognex Interaction"
        Me.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGF
        '
        Me.btnGF.BackColor = System.Drawing.Color.Yellow
        Me.btnGF.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGF.Location = New System.Drawing.Point(150, 0)
        Me.btnGF.Name = "btnGF"
        Me.btnGF.Size = New System.Drawing.Size(150, 70)
        Me.btnGF.TabIndex = 1
        Me.btnGF.Text = "Get Loaded File"
        Me.btnGF.UseVisualStyleBackColor = False
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.Yellow
        Me.btnOn.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOn.Location = New System.Drawing.Point(300, 0)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(150, 70)
        Me.btnOn.TabIndex = 2
        Me.btnOn.Text = "Turn Online"
        Me.btnOn.UseVisualStyleBackColor = False
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.Yellow
        Me.btnOff.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOff.Location = New System.Drawing.Point(0, 0)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(150, 70)
        Me.btnOff.TabIndex = 3
        Me.btnOff.Text = "Turn Offline"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnTrigger)
        Me.Panel2.Controls.Add(Me.btnOn)
        Me.Panel2.Controls.Add(Me.btnGF)
        Me.Panel2.Controls.Add(Me.btnOff)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 72)
        Me.Panel2.TabIndex = 7
        '
        'btnTrigger
        '
        Me.btnTrigger.BackColor = System.Drawing.Color.Yellow
        Me.btnTrigger.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTrigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrigger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTrigger.Location = New System.Drawing.Point(450, 0)
        Me.btnTrigger.Name = "btnTrigger"
        Me.btnTrigger.Size = New System.Drawing.Size(150, 70)
        Me.btnTrigger.TabIndex = 4
        Me.btnTrigger.Text = "Trigger"
        Me.btnTrigger.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnGoToHole)
        Me.Panel5.Controls.Add(Me.btnGoHome)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 200)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(918, 72)
        Me.Panel5.TabIndex = 10
        '
        'btnGoToHole
        '
        Me.btnGoToHole.BackColor = System.Drawing.Color.Gray
        Me.btnGoToHole.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGoToHole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToHole.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGoToHole.Location = New System.Drawing.Point(150, 0)
        Me.btnGoToHole.Name = "btnGoToHole"
        Me.btnGoToHole.Size = New System.Drawing.Size(150, 70)
        Me.btnGoToHole.TabIndex = 5
        Me.btnGoToHole.Text = "Go To Hole"
        Me.btnGoToHole.UseVisualStyleBackColor = False
        '
        'btnGoHome
        '
        Me.btnGoHome.BackColor = System.Drawing.Color.Gray
        Me.btnGoHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGoHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGoHome.Location = New System.Drawing.Point(0, 0)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(150, 70)
        Me.btnGoHome.TabIndex = 4
        Me.btnGoHome.Text = "Go Home"
        Me.btnGoHome.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblPastY)
        Me.Panel3.Controls.Add(Me.lblPastX)
        Me.Panel3.Controls.Add(Me.lblY)
        Me.Panel3.Controls.Add(Me.lblX)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 137)
        Me.Panel3.TabIndex = 11
        '
        'lblY
        '
        Me.lblY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(0, 50)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(318, 25)
        Me.lblY.TabIndex = 10
        Me.lblY.Text = "Y: "
        '
        'lblX
        '
        Me.lblX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(0, 25)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(318, 25)
        Me.lblX.TabIndex = 9
        Me.lblX.Text = "X: "
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hole Coordinates"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPastY
        '
        Me.lblPastY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPastY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastY.Location = New System.Drawing.Point(0, 100)
        Me.lblPastY.Name = "lblPastY"
        Me.lblPastY.Size = New System.Drawing.Size(318, 25)
        Me.lblPastY.TabIndex = 12
        Me.lblPastY.Text = "Previous Y: "
        '
        'lblPastX
        '
        Me.lblPastX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPastX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastX.Location = New System.Drawing.Point(0, 75)
        Me.lblPastX.Name = "lblPastX"
        Me.lblPastX.Size = New System.Drawing.Size(318, 25)
        Me.lblPastX.TabIndex = 11
        Me.lblPastX.Text = "Previous X: "
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblYDev)
        Me.Panel6.Controls.Add(Me.lblXDev)
        Me.Panel6.Controls.Add(Me.lblAvgY)
        Me.Panel6.Controls.Add(Me.lblAvgX)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(320, 272)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(281, 137)
        Me.Panel6.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Averages"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvgY
        '
        Me.lblAvgY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvgY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgY.Location = New System.Drawing.Point(0, 50)
        Me.lblAvgY.Name = "lblAvgY"
        Me.lblAvgY.Size = New System.Drawing.Size(279, 25)
        Me.lblAvgY.TabIndex = 12
        Me.lblAvgY.Text = "Avg Y:"
        '
        'lblAvgX
        '
        Me.lblAvgX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvgX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgX.Location = New System.Drawing.Point(0, 25)
        Me.lblAvgX.Name = "lblAvgX"
        Me.lblAvgX.Size = New System.Drawing.Size(279, 25)
        Me.lblAvgX.TabIndex = 11
        Me.lblAvgX.Text = "Avg X:"
        '
        'lblYDev
        '
        Me.lblYDev.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblYDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYDev.Location = New System.Drawing.Point(0, 100)
        Me.lblYDev.Name = "lblYDev"
        Me.lblYDev.Size = New System.Drawing.Size(279, 25)
        Me.lblYDev.TabIndex = 14
        Me.lblYDev.Text = "Avg Y Dev:"
        '
        'lblXDev
        '
        Me.lblXDev.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblXDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXDev.Location = New System.Drawing.Point(0, 75)
        Me.lblXDev.Name = "lblXDev"
        Me.lblXDev.Size = New System.Drawing.Size(279, 25)
        Me.lblXDev.TabIndex = 13
        Me.lblXDev.Text = "Avg X Dev:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 409)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Cognex Connection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblConnected As Label
    Friend WithEvents btnGF As Button
    Friend WithEvents btnOn As Button
    Friend WithEvents btnOff As Button
    Friend WithEvents lblIP As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTrigger As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblRobotPort As Label
    Friend WithEvents lblRobotIP As Label
    Friend WithEvents lblRobotStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnGoHome As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGoToHole As Button
    Friend WithEvents lblPastY As Label
    Friend WithEvents lblPastX As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblYDev As Label
    Friend WithEvents lblXDev As Label
    Friend WithEvents lblAvgY As Label
    Friend WithEvents lblAvgX As Label
    Friend WithEvents Label3 As Label
End Class
