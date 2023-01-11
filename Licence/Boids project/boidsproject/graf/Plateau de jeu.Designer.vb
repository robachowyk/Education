<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPlateau
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
        Me.PlateauPictureBox = New System.Windows.Forms.PictureBox()
        Me.TimerN = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PlateauPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlateauPictureBox
        '
        Me.PlateauPictureBox.BackColor = System.Drawing.SystemColors.Control
        Me.PlateauPictureBox.BackgroundImage = Global.graf.My.Resources.Resources.boidsnuages
        Me.PlateauPictureBox.Location = New System.Drawing.Point(20, 20)
        Me.PlateauPictureBox.Name = "PlateauPictureBox"
        Me.PlateauPictureBox.Size = New System.Drawing.Size(800, 800)
        Me.PlateauPictureBox.TabIndex = 0
        Me.PlateauPictureBox.TabStop = False
        '
        'TimerN
        '
        Me.TimerN.Enabled = True
        Me.TimerN.Interval = 1000
        '
        'FormPlateau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 836)
        Me.Controls.Add(Me.PlateauPictureBox)
        Me.Name = "FormPlateau"
        Me.Text = "Plateau"
        CType(Me.PlateauPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlateauPictureBox As PictureBox
    Friend WithEvents TimerN As Timer
End Class
