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
        Me.lname = New System.Windows.Forms.Label()
        Me.lcount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lname
        '
        Me.lname.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.Location = New System.Drawing.Point(-1, 25)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(801, 64)
        Me.lname.TabIndex = 0
        Me.lname.Text = "Channel ID"
        Me.lname.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lcount
        '
        Me.lcount.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcount.Location = New System.Drawing.Point(-1, 121)
        Me.lcount.Name = "lcount"
        Me.lcount.Size = New System.Drawing.Size(801, 91)
        Me.lcount.TabIndex = 1
        Me.lcount.Text = "0"
        Me.lcount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 274)
        Me.Controls.Add(Me.lcount)
        Me.Controls.Add(Me.lname)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube Subscribers Livecounts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lname As System.Windows.Forms.Label
    Friend WithEvents lcount As System.Windows.Forms.Label

End Class
