<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblAboutInfo = New System.Windows.Forms.Label()
        Me.btnOk1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAboutInfo
        '
        Me.lblAboutInfo.AutoSize = True
        Me.lblAboutInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutInfo.Location = New System.Drawing.Point(42, 24)
        Me.lblAboutInfo.Name = "lblAboutInfo"
        Me.lblAboutInfo.Size = New System.Drawing.Size(162, 80)
        Me.lblAboutInfo.TabIndex = 0
        Me.lblAboutInfo.Text = "Author: Kelley Scales " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab #4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Custom Text Editor"
        '
        'btnOk1
        '
        Me.btnOk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk1.Location = New System.Drawing.Point(84, 152)
        Me.btnOk1.Name = "btnOk1"
        Me.btnOk1.Size = New System.Drawing.Size(106, 34)
        Me.btnOk1.TabIndex = 1
        Me.btnOk1.Text = "Ok"
        Me.btnOk1.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 209)
        Me.Controls.Add(Me.btnOk1)
        Me.Controls.Add(Me.lblAboutInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutInfo As System.Windows.Forms.Label
    Friend WithEvents btnOk1 As System.Windows.Forms.Button
End Class
