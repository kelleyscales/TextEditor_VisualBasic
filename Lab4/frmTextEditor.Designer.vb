<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextEditor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssrMessage = New System.Windows.Forms.StatusStrip()
        Me.ssrLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolTipTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.mnuMenu.SuspendLayout()
        Me.ssrMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmEdit, Me.tsmHelp})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(846, 24)
        Me.mnuMenu.TabIndex = 1
        Me.mnuMenu.Text = "MenuStrip2"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOpen, Me.tsmSave, Me.tsmSaveAs, Me.tsmPrint, Me.tsmPrintPreview, Me.tsmClose, Me.tsmExit})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmFile.Text = "File"
        '
        'tsmOpen
        '
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.ShortcutKeyDisplayString = ""
        Me.tsmOpen.Size = New System.Drawing.Size(152, 22)
        Me.tsmOpen.Text = "Open"
        '
        'tsmSave
        '
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.ShortcutKeyDisplayString = ""
        Me.tsmSave.Size = New System.Drawing.Size(152, 22)
        Me.tsmSave.Text = "Save"
        '
        'tsmSaveAs
        '
        Me.tsmSaveAs.Name = "tsmSaveAs"
        Me.tsmSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.tsmSaveAs.Text = "Save As"
        '
        'tsmPrint
        '
        Me.tsmPrint.Name = "tsmPrint"
        Me.tsmPrint.ShortcutKeyDisplayString = ""
        Me.tsmPrint.Size = New System.Drawing.Size(152, 22)
        Me.tsmPrint.Text = "Print"
        '
        'tsmPrintPreview
        '
        Me.tsmPrintPreview.Name = "tsmPrintPreview"
        Me.tsmPrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.tsmPrintPreview.Text = "Print Preview"
        '
        'tsmClose
        '
        Me.tsmClose.Name = "tsmClose"
        Me.tsmClose.Size = New System.Drawing.Size(152, 22)
        Me.tsmClose.Text = "Close"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(152, 22)
        Me.tsmExit.Text = "Exit"
        '
        'tsmEdit
        '
        Me.tsmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCopy, Me.tsmCut, Me.tsmPaste})
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsmEdit.Text = "Edit"
        '
        'tsmCopy
        '
        Me.tsmCopy.Name = "tsmCopy"
        Me.tsmCopy.ShortcutKeyDisplayString = "Ctrl + c"
        Me.tsmCopy.Size = New System.Drawing.Size(148, 22)
        Me.tsmCopy.Text = "Copy"
        '
        'tsmCut
        '
        Me.tsmCut.Name = "tsmCut"
        Me.tsmCut.ShortcutKeyDisplayString = "Crtl + x"
        Me.tsmCut.Size = New System.Drawing.Size(148, 22)
        Me.tsmCut.Text = "Cut"
        '
        'tsmPaste
        '
        Me.tsmPaste.Name = "tsmPaste"
        Me.tsmPaste.ShortcutKeyDisplayString = "Ctrl + v"
        Me.tsmPaste.Size = New System.Drawing.Size(148, 22)
        Me.tsmPaste.Text = "Paste"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmIndex, Me.tsmAbout})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmHelp.Text = "Help"
        '
        'tsmIndex
        '
        Me.tsmIndex.Name = "tsmIndex"
        Me.tsmIndex.Size = New System.Drawing.Size(107, 22)
        Me.tsmIndex.Text = "Index"
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.Size = New System.Drawing.Size(107, 22)
        Me.tsmAbout.Text = "About"
        '
        'ssrMessage
        '
        Me.ssrMessage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssrLabel})
        Me.ssrMessage.Location = New System.Drawing.Point(0, 542)
        Me.ssrMessage.Name = "ssrMessage"
        Me.ssrMessage.Size = New System.Drawing.Size(846, 22)
        Me.ssrMessage.TabIndex = 2
        Me.ssrMessage.Text = "StatusStrip1"
        '
        'ssrLabel
        '
        Me.ssrLabel.Name = "ssrLabel"
        Me.ssrLabel.Size = New System.Drawing.Size(114, 17)
        Me.ssrLabel.Text = "Select a File to Open"
        '
        'txtMain
        '
        Me.txtMain.BackColor = System.Drawing.SystemColors.Window
        Me.txtMain.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.Location = New System.Drawing.Point(12, 24)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMain.Size = New System.Drawing.Size(821, 515)
        Me.txtMain.TabIndex = 3
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 564)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.ssrMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.mnuMenu)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTextEditor"
        Me.Text = "Custom Text Editor - Lab 4"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ssrMessage.ResumeLayout(False)
        Me.ssrMessage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssrMessage As System.Windows.Forms.StatusStrip
    Friend WithEvents ssrLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolTipTextEditor As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents tsmPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
