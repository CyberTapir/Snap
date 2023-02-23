<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.picP1Card = New System.Windows.Forms.PictureBox()
        Me.picP2Card = New System.Windows.Forms.PictureBox()
        Me.lblP1Card = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblP2Card = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        CType(Me.picP1Card, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Card, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picP1Card
        '
        Me.picP1Card.Location = New System.Drawing.Point(56, 58)
        Me.picP1Card.Name = "picP1Card"
        Me.picP1Card.Size = New System.Drawing.Size(106, 144)
        Me.picP1Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picP1Card.TabIndex = 0
        Me.picP1Card.TabStop = False
        '
        'picP2Card
        '
        Me.picP2Card.Location = New System.Drawing.Point(206, 58)
        Me.picP2Card.Name = "picP2Card"
        Me.picP2Card.Size = New System.Drawing.Size(115, 144)
        Me.picP2Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picP2Card.TabIndex = 1
        Me.picP2Card.TabStop = False
        '
        'lblP1Card
        '
        Me.lblP1Card.AutoSize = True
        Me.lblP1Card.Location = New System.Drawing.Point(85, 229)
        Me.lblP1Card.Name = "lblP1Card"
        Me.lblP1Card.Size = New System.Drawing.Size(41, 15)
        Me.lblP1Card.TabIndex = 2
        Me.lblP1Card.Text = "Label1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(250, 229)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 15)
        Me.LinkLabel1.TabIndex = 3
        '
        'lblP2Card
        '
        Me.lblP2Card.AutoSize = True
        Me.lblP2Card.Location = New System.Drawing.Point(240, 229)
        Me.lblP2Card.Name = "lblP2Card"
        Me.lblP2Card.Size = New System.Drawing.Size(41, 15)
        Me.lblP2Card.TabIndex = 4
        Me.lblP2Card.Text = "Label2"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(147, 285)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 353)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblP2Card)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblP1Card)
        Me.Controls.Add(Me.picP2Card)
        Me.Controls.Add(Me.picP1Card)
        Me.Name = "Form1"
        Me.Text = "Snap"
        CType(Me.picP1Card, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Card, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picP1Card As PictureBox
    Friend WithEvents picP2Card As PictureBox
    Friend WithEvents lblP1Card As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblP2Card As Label
    Friend WithEvents btnPlay As Button
End Class
