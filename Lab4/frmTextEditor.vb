'Lab 4: Text Editor
'Kelley Scales 
'March-22-2016
'Purpose is to create a text editor that can open, save, save as, 
'print, close, exit, copy text, paste text and cut text. We also 
'have two other forms that are included into this form in order to
'show the user about the text editor and give information.

Imports System.IO
Public Class frmTextEditor
    Dim fileName As String
    ''' <summary>
    ''' calls the defaults when the form is first loaded
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmlab4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tsmOpen.Selected = False Then ' if 
            Call MenuDefaults() 'call menu defaults
        ElseIf txtMain.Text = "" = False Then
            Call MenuDefaults()
        Else
            'following options are enabled
            tsmCopy.Enabled = True
            tsmCut.Enabled = True
            tsmPaste.Enabled = True
            tsmSaveAs.Enabled = True
            tsmSave.Enabled = True
            tsmPrint.Enabled = True
            tsmClose.Enabled = True
            tsmPrintPreview.Enabled = True
        End If

    End Sub
    ''' <summary>
    ''' Handles the size changed in order to keep the textbox in size with the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmlab4_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        txtMain.Size = New Size(Me.Size.Width - 40, Me.Size.Height - 100) 'sets width and height of textbox
        If Me.Size.Width < 200 Then
            'if the width goes less than 200 then 
            Me.Size = New Size(200, Me.Size.Height)
            'set back to 200
        End If
        If Me.Size.Height < 200 Then
            'if height goes less than 200 then
            Me.Size = New Size(Me.Size.Width, 200)
            'set back to 200
        End If
    End Sub
    ''' <summary>
    ''' Call defaults for menu and creates criteria when text is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtMain_TextChanged(sender As Object, e As EventArgs) Handles txtMain.TextChanged
        If txtMain.Text = "" = False Then
            ' if text is not blank then enable the following..
            tsmCopy.Enabled = True
            tsmCut.Enabled = True
            tsmPaste.Enabled = True
            tsmSaveAs.Enabled = True
            tsmSave.Enabled = True
            tsmPrint.Enabled = True
            tsmClose.Enabled = True
            tsmPrintPreview.Enabled = True
        End If
        'change status label when changes have been made
        ssrLabel.Text = "Changes have been made to your original file"
    End Sub
    ''' <summary>
    ''' Sets the menu defaults
    ''' </summary>
    Private Sub MenuDefaults()
        'The following options are disabled
        tsmCopy.Enabled = False
        tsmCut.Enabled = False
        tsmPaste.Enabled = False
        tsmSaveAs.Enabled = False
        tsmSave.Enabled = False
        tsmPrint.Enabled = False
        tsmClose.Enabled = False
        tsmPrintPreview.Enabled = False
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                        FILE OPTIONS
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' Opens text file from computer when user clicks on the Open option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        txtMain.Text = "" 'Empty the text in textbox
        Dim openD As New OpenFileDialog 'set opend as openfiledialog
        Dim fileS As FileStream 'set FS as filestream

        openD.Filter = "(Text Files)|*.txt;*.config;"
        'gets file that is a txt file
        openD.Multiselect = False
        'multiselect set to false/ cannot pick multiple files
        openD.ShowDialog()
        ' show dialog to select file

        fileName = openD.FileName
        ' FileN is set to filename
        Try
            fileS = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            'opens/reads file
            Dim txtIn As New StreamReader(fileS)
            'declares txtin as streamreader

            Do While txtIn.Peek <> -1
                Me.txtMain.Text &= txtIn.ReadLine & vbCrLf
                'read info and add it to text editor
            Loop
            fileS.Close()
            'close loop
        Catch ex As Exception
            MsgBox("error: " & Err.Description)
            'output error when it doesn't go through
        End Try
        ssrLabel.Text = "File has been opened into text editor"
        'change status label when file has been saved
    End Sub
    ''' <summary>
    ''' Saves the document as a txt file in file that is opened when user clicks the save option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmSave_Click(sender As Object, e As EventArgs) Handles tsmSave.Click

        My.Computer.FileSystem.WriteAllText(fileName, txtMain.Text, False)
        ' Save text to opened file

        ssrLabel.Text = "File has been saved"
        'change status label when file has been saved
    End Sub
    ''' <summary>
    ''' Saves the document as a txt file when users clicks the save as option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmSaveAs.Click
        Dim saveD As New SaveFileDialog()
        ' create saveD and set it to SaveFileDialog
        Dim File As String
        ' create File as string 

        saveD.Filter = "(Text Files)|*.txt;*.config;"
        'set filter to .txt
        saveD.ShowDialog()
        'show the dialogbox

        File = saveD.FileName
        'set File as the fileName
        If saveD.ShowDialog() = DialogResult.OK Then
            'if dialogbox ok
            IO.File.WriteAllText(saveD.FileName, txtMain.Text)
            'write text to the filename
        End If
        ssrLabel.Text = "File has been saved"
        'change status label when file has been saved 
    End Sub
    ''' <summary>
    ''' Closes the windows application when user clicks the Exit option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Me.Close()
        ' close form
    End Sub
    ''' <summary>
    ''' Opens Print dialog box and gives option to print when user clicks the Print option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmPrint.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        ' set to document printer settings
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'if dialog results ok
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            'show print dialogbox settings
            PrintDocument1.Print()
            'print document
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim filepath As New String(fileName) 'create file name
        Dim font As New Font("arial", 20, FontStyle.Regular) 'set font type/style 
        Dim divider As New String("===============================") 'create divider
        e.Graphics.DrawString(filepath, font, Brushes.Black, 20, 20) ' output file name
        e.Graphics.DrawString(divider, font, Brushes.Black, 50, 50) ' output divider
        e.Graphics.DrawString(txtMain.Text, font, Brushes.Black, 90, 90) ' output text from textbox
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1 'set preview document to printdocument
        PrintPreviewDialog1.ShowDialog() 'show document in dialogbox
    End Sub
    ''' <summary>
    ''' Closes the file when user clicks the Close option in menu and re-sets text editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        txtMain.Text = "" 'clear text
        ssrLabel.Text = "Select a file to open" ' change status bar when close is clicked 
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                    HELP OPTIONS   
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' Gets form named frmIndex and displays it when user clicks Index option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmIndex_Click(sender As Object, e As EventArgs) Handles tsmIndex.Click
        frmIndex.ShowDialog() ' show form called frmIndex
    End Sub
    ''' <summary>
    ''' Gets form named frmAbout and displays it when the user clicks About option in menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmAbout_Click(sender As Object, e As EventArgs) Handles tsmAbout.Click
        frmAbout.ShowDialog() ' show form called frmAbout
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                    EDIT OPTIONS    
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCopy.Click
        Clipboard.SetDataObject(Me.txtMain.SelectedText) 'Retrieve data from selected text
        Me.txtMain.Copy() 'Copy selected text
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmPaste.Click
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then 'Retrieve data from selected text if data is present
            Me.txtMain.Paste() 'Paste selected text
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCut.Click
        Clipboard.SetDataObject(Me.txtMain.SelectedText) 'Retrieve data from selected text
        Me.txtMain.Cut() 'Cut selected text
    End Sub
End Class


