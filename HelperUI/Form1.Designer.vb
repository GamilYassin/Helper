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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TemplatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTemplateFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuNotePad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuote = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplatesToolStripMenuItem, Me.CalculatorsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.mnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(413, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TemplatesToolStripMenuItem
        '
        Me.TemplatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTemplateFileToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuNotePad})
        Me.TemplatesToolStripMenuItem.Name = "TemplatesToolStripMenuItem"
        Me.TemplatesToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.TemplatesToolStripMenuItem.Text = "Templates"
        '
        'AddTemplateFileToolStripMenuItem
        '
        Me.AddTemplateFileToolStripMenuItem.Name = "AddTemplateFileToolStripMenuItem"
        Me.AddTemplateFileToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AddTemplateFileToolStripMenuItem.Text = "Add Template File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(62, 24)
        Me.mnuAbout.Text = "About"
        '
        'CalculatorsToolStripMenuItem
        '
        Me.CalculatorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalc, Me.mnuCMCalc, Me.mnuQuote})
        Me.CalculatorsToolStripMenuItem.Name = "CalculatorsToolStripMenuItem"
        Me.CalculatorsToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.CalculatorsToolStripMenuItem.Text = "Calculators"
        '
        'mnuCalc
        '
        Me.mnuCalc.Name = "mnuCalc"
        Me.mnuCalc.Size = New System.Drawing.Size(216, 26)
        Me.mnuCalc.Text = "Windows Calc"
        '
        'mnuCMCalc
        '
        Me.mnuCMCalc.Name = "mnuCMCalc"
        Me.mnuCMCalc.Size = New System.Drawing.Size(216, 26)
        Me.mnuCMCalc.Text = "CM/Rev/Cost Calc"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        'mnuNotePad
        '
        Me.mnuNotePad.Name = "mnuNotePad"
        Me.mnuNotePad.Size = New System.Drawing.Size(216, 26)
        Me.mnuNotePad.Text = "Notepad ++"
        '
        'mnuQuote
        '
        Me.mnuQuote.Name = "mnuQuote"
        Me.mnuQuote.Size = New System.Drawing.Size(216, 26)
        Me.mnuQuote.Text = "Quote Calc"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 89)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Helper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TemplatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTemplateFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents CalculatorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCalc As ToolStripMenuItem
    Friend WithEvents mnuCMCalc As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuNotePad As ToolStripMenuItem
    Friend WithEvents mnuQuote As ToolStripMenuItem
End Class
