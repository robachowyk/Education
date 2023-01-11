<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Console
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btncreerboids = New System.Windows.Forms.Button()
        Me.btncreerarbres = New System.Windows.Forms.Button()
        Me.btncreerobstacles = New System.Windows.Forms.Button()
        Me.Timer_pas = New System.Windows.Forms.Timer(Me.components)
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnrapaces = New System.Windows.Forms.Button()
        Me.hsnbboids = New System.Windows.Forms.HScrollBar()
        Me.hsnbarbres = New System.Windows.Forms.HScrollBar()
        Me.hsnbobstacles = New System.Windows.Forms.HScrollBar()
        Me.hsnbrapaces = New System.Windows.Forms.HScrollBar()
        Me.hsco = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hsali = New System.Windows.Forms.HScrollBar()
        Me.hsrep = New System.Windows.Forms.HScrollBar()
        Me.hssep = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblboidsmorts = New System.Windows.Forms.Label()
        Me.hsvrapaces = New System.Windows.Forms.HScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblnbboids = New System.Windows.Forms.Label()
        Me.lblboids = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncreerboids
        '
        Me.btncreerboids.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btncreerboids.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btncreerboids.Location = New System.Drawing.Point(24, 38)
        Me.btncreerboids.Name = "btncreerboids"
        Me.btncreerboids.Size = New System.Drawing.Size(196, 38)
        Me.btncreerboids.TabIndex = 0
        Me.btncreerboids.Text = "Creation des boids"
        Me.btncreerboids.UseVisualStyleBackColor = False
        '
        'btncreerarbres
        '
        Me.btncreerarbres.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btncreerarbres.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btncreerarbres.Location = New System.Drawing.Point(549, 246)
        Me.btncreerarbres.Name = "btncreerarbres"
        Me.btncreerarbres.Size = New System.Drawing.Size(232, 38)
        Me.btncreerarbres.TabIndex = 1
        Me.btncreerarbres.Text = "Creation des arbres"
        Me.btncreerarbres.UseVisualStyleBackColor = False
        '
        'btncreerobstacles
        '
        Me.btncreerobstacles.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btncreerobstacles.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btncreerobstacles.Location = New System.Drawing.Point(549, 123)
        Me.btncreerobstacles.Name = "btncreerobstacles"
        Me.btncreerobstacles.Size = New System.Drawing.Size(232, 38)
        Me.btncreerobstacles.TabIndex = 2
        Me.btncreerobstacles.Text = "Creation des obstacles"
        Me.btncreerobstacles.UseVisualStyleBackColor = False
        '
        'Timer_pas
        '
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnstart.Location = New System.Drawing.Point(180, 518)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(404, 104)
        Me.btnstart.TabIndex = 8
        Me.btnstart.Text = "START"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'btnrapaces
        '
        Me.btnrapaces.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnrapaces.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnrapaces.Location = New System.Drawing.Point(252, 38)
        Me.btnrapaces.Name = "btnrapaces"
        Me.btnrapaces.Size = New System.Drawing.Size(215, 38)
        Me.btnrapaces.TabIndex = 9
        Me.btnrapaces.Text = "Creation des rapaces"
        Me.btnrapaces.UseVisualStyleBackColor = False
        '
        'hsnbboids
        '
        Me.hsnbboids.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsnbboids.Location = New System.Drawing.Point(13, 85)
        Me.hsnbboids.Name = "hsnbboids"
        Me.hsnbboids.Size = New System.Drawing.Size(196, 23)
        Me.hsnbboids.TabIndex = 11
        '
        'hsnbarbres
        '
        Me.hsnbarbres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsnbarbres.LargeChange = 1
        Me.hsnbarbres.Location = New System.Drawing.Point(11, 219)
        Me.hsnbarbres.Maximum = 10
        Me.hsnbarbres.Name = "hsnbarbres"
        Me.hsnbarbres.Size = New System.Drawing.Size(232, 23)
        Me.hsnbarbres.TabIndex = 12
        '
        'hsnbobstacles
        '
        Me.hsnbobstacles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsnbobstacles.LargeChange = 1
        Me.hsnbobstacles.Location = New System.Drawing.Point(11, 98)
        Me.hsnbobstacles.Maximum = 10
        Me.hsnbobstacles.Name = "hsnbobstacles"
        Me.hsnbobstacles.Size = New System.Drawing.Size(232, 23)
        Me.hsnbobstacles.TabIndex = 13
        '
        'hsnbrapaces
        '
        Me.hsnbrapaces.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsnbrapaces.LargeChange = 1
        Me.hsnbrapaces.Location = New System.Drawing.Point(241, 85)
        Me.hsnbrapaces.Maximum = 10
        Me.hsnbrapaces.Name = "hsnbrapaces"
        Me.hsnbrapaces.Size = New System.Drawing.Size(215, 23)
        Me.hsnbrapaces.TabIndex = 14
        '
        'hsco
        '
        Me.hsco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsco.LargeChange = 1
        Me.hsco.Location = New System.Drawing.Point(252, 63)
        Me.hsco.Maximum = 10
        Me.hsco.Name = "hsco"
        Me.hsco.Size = New System.Drawing.Size(182, 25)
        Me.hsco.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(41, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Force de cohésion"
        '
        'hsali
        '
        Me.hsali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsali.LargeChange = 1
        Me.hsali.Location = New System.Drawing.Point(252, 219)
        Me.hsali.Maximum = 10
        Me.hsali.Name = "hsali"
        Me.hsali.Size = New System.Drawing.Size(182, 25)
        Me.hsali.TabIndex = 21
        '
        'hsrep
        '
        Me.hsrep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsrep.LargeChange = 1
        Me.hsrep.Location = New System.Drawing.Point(252, 167)
        Me.hsrep.Maximum = 10
        Me.hsrep.Name = "hsrep"
        Me.hsrep.Size = New System.Drawing.Size(182, 25)
        Me.hsrep.TabIndex = 22
        '
        'hssep
        '
        Me.hssep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hssep.LargeChange = 1
        Me.hssep.Location = New System.Drawing.Point(252, 115)
        Me.hssep.Maximum = 20
        Me.hssep.Minimum = 10
        Me.hssep.Name = "hssep"
        Me.hssep.Size = New System.Drawing.Size(182, 25)
        Me.hssep.TabIndex = 23
        Me.hssep.Value = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(25, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Force de alignement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(41, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Force de répulsion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(29, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Force de séparation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(414, 664)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "boids morts :"
        '
        'lblboidsmorts
        '
        Me.lblboidsmorts.AutoSize = True
        Me.lblboidsmorts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblboidsmorts.Location = New System.Drawing.Point(543, 664)
        Me.lblboidsmorts.Name = "lblboidsmorts"
        Me.lblboidsmorts.Size = New System.Drawing.Size(0, 25)
        Me.lblboidsmorts.TabIndex = 28
        '
        'hsvrapaces
        '
        Me.hsvrapaces.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hsvrapaces.LargeChange = 1
        Me.hsvrapaces.Location = New System.Drawing.Point(252, 138)
        Me.hsvrapaces.Maximum = 4
        Me.hsvrapaces.Minimum = 1
        Me.hsvrapaces.Name = "hsvrapaces"
        Me.hsvrapaces.Size = New System.Drawing.Size(215, 23)
        Me.hsvrapaces.TabIndex = 29
        Me.hsvrapaces.Value = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(98, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(637, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "NOMBRE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Location = New System.Drawing.Point(637, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "NOMBRE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(326, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "NOMBRE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(326, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "VITESSE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hsnbrapaces)
        Me.GroupBox1.Controls.Add(Me.hsnbboids)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 181)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DESSINER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hsnbobstacles)
        Me.GroupBox2.Controls.Add(Me.hsnbarbres)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(538, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 272)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DESSINER"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.hsco)
        Me.GroupBox3.Controls.Add(Me.hssep)
        Me.GroupBox3.Controls.Add(Me.hsrep)
        Me.GroupBox3.Controls.Add(Me.hsali)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(11, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(469, 277)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONTROLE DES FORCES"
        '
        'lblnbboids
        '
        Me.lblnbboids.AutoSize = True
        Me.lblnbboids.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblnbboids.Location = New System.Drawing.Point(234, 664)
        Me.lblnbboids.Name = "lblnbboids"
        Me.lblnbboids.Size = New System.Drawing.Size(0, 25)
        Me.lblnbboids.TabIndex = 38
        '
        'lblboids
        '
        Me.lblboids.AutoSize = True
        Me.lblboids.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblboids.Location = New System.Drawing.Point(234, 712)
        Me.lblboids.Name = "lblboids"
        Me.lblboids.Size = New System.Drawing.Size(0, 25)
        Me.lblboids.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Location = New System.Drawing.Point(16, 664)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 25)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "nombre de boids inital :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Location = New System.Drawing.Point(60, 712)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 25)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "nombre de boids :"
        '
        'Console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 776)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblboids)
        Me.Controls.Add(Me.lblnbboids)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hsvrapaces)
        Me.Controls.Add(Me.lblboidsmorts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnrapaces)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.btncreerobstacles)
        Me.Controls.Add(Me.btncreerarbres)
        Me.Controls.Add(Me.btncreerboids)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Console"
        Me.Text = "Console"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncreerboids As Button
    Friend WithEvents btncreerarbres As Button
    Friend WithEvents btncreerobstacles As Button
    Friend WithEvents Timer_pas As Timer
    Friend WithEvents btnstart As Button
    Friend WithEvents btnrapaces As Button
    Friend WithEvents hsnbarbres As HScrollBar
    Friend WithEvents hsnbobstacles As HScrollBar
    Friend WithEvents hsnbrapaces As HScrollBar
    Friend WithEvents hsco As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents hsali As HScrollBar
    Friend WithEvents hsrep As HScrollBar
    Friend WithEvents hssep As HScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblboidsmorts As Label
    Friend WithEvents hsnbboids As HScrollBar
    Friend WithEvents hsvrapaces As HScrollBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblnbboids As Label
    Friend WithEvents lblboids As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
