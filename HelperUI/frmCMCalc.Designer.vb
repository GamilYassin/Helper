<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMCalc
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtCMP1 = New System.Windows.Forms.TextBox()
        Me.txtCMd1 = New System.Windows.Forms.TextBox()
        Me.txtRev1 = New System.Windows.Forms.TextBox()
        Me.txtCost1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtCMP2 = New System.Windows.Forms.TextBox()
        Me.txtRev2 = New System.Windows.Forms.TextBox()
        Me.txtCost2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtCMP3 = New System.Windows.Forms.TextBox()
        Me.txtRev3 = New System.Windows.Forms.TextBox()
        Me.txtCost3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(313, 213)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.txtCMP1)
        Me.TabPage1.Controls.Add(Me.txtCMd1)
        Me.TabPage1.Controls.Add(Me.txtRev1)
        Me.TabPage1.Controls.Add(Me.txtCost1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(305, 175)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CM Calc"
        '
        'txtCMP1
        '
        Me.txtCMP1.BackColor = System.Drawing.Color.White
        Me.txtCMP1.Location = New System.Drawing.Point(80, 127)
        Me.txtCMP1.Name = "txtCMP1"
        Me.txtCMP1.Size = New System.Drawing.Size(212, 31)
        Me.txtCMP1.TabIndex = 4
        '
        'txtCMd1
        '
        Me.txtCMd1.BackColor = System.Drawing.Color.White
        Me.txtCMd1.Location = New System.Drawing.Point(80, 87)
        Me.txtCMd1.Name = "txtCMd1"
        Me.txtCMd1.Size = New System.Drawing.Size(212, 31)
        Me.txtCMd1.TabIndex = 3
        '
        'txtRev1
        '
        Me.txtRev1.Location = New System.Drawing.Point(80, 6)
        Me.txtRev1.Name = "txtRev1"
        Me.txtRev1.Size = New System.Drawing.Size(212, 31)
        Me.txtRev1.TabIndex = 1
        '
        'txtCost1
        '
        Me.txtCost1.Location = New System.Drawing.Point(80, 43)
        Me.txtCost1.Name = "txtCost1"
        Me.txtCost1.Size = New System.Drawing.Size(212, 31)
        Me.txtCost1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CM %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CM $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rev $"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost $"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.txtCMP2)
        Me.TabPage2.Controls.Add(Me.txtRev2)
        Me.TabPage2.Controls.Add(Me.txtCost2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(305, 175)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rev Calc"
        '
        'txtCMP2
        '
        Me.txtCMP2.Location = New System.Drawing.Point(80, 83)
        Me.txtCMP2.Name = "txtCMP2"
        Me.txtCMP2.Size = New System.Drawing.Size(212, 31)
        Me.txtCMP2.TabIndex = 7
        '
        'txtRev2
        '
        Me.txtRev2.BackColor = System.Drawing.Color.White
        Me.txtRev2.Location = New System.Drawing.Point(80, 9)
        Me.txtRev2.Name = "txtRev2"
        Me.txtRev2.Size = New System.Drawing.Size(212, 31)
        Me.txtRev2.TabIndex = 5
        '
        'txtCost2
        '
        Me.txtCost2.Location = New System.Drawing.Point(80, 46)
        Me.txtCost2.Name = "txtCost2"
        Me.txtCost2.Size = New System.Drawing.Size(212, 31)
        Me.txtCost2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "CM %"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Rev $"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cost $"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.txtCMP3)
        Me.TabPage3.Controls.Add(Me.txtRev3)
        Me.TabPage3.Controls.Add(Me.txtCost3)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(305, 175)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cost Calc"
        '
        'txtCMP3
        '
        Me.txtCMP3.Location = New System.Drawing.Point(80, 83)
        Me.txtCMP3.Name = "txtCMP3"
        Me.txtCMP3.Size = New System.Drawing.Size(212, 31)
        Me.txtCMP3.TabIndex = 10
        '
        'txtRev3
        '
        Me.txtRev3.Location = New System.Drawing.Point(80, 9)
        Me.txtRev3.Name = "txtRev3"
        Me.txtRev3.Size = New System.Drawing.Size(212, 31)
        Me.txtRev3.TabIndex = 8
        '
        'txtCost3
        '
        Me.txtCost3.BackColor = System.Drawing.Color.White
        Me.txtCost3.Location = New System.Drawing.Point(80, 46)
        Me.txtCost3.Name = "txtCost3"
        Me.txtCost3.Size = New System.Drawing.Size(212, 31)
        Me.txtCost3.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "CM %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Rev $"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 25)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Cost $"
        '
        'frmCMCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(313, 213)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCMCalc"
        Me.Text = "frmCMCalc"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtCMP1 As TextBox
    Friend WithEvents txtCMd1 As TextBox
    Friend WithEvents txtRev1 As TextBox
    Friend WithEvents txtCost1 As TextBox
    Friend WithEvents txtCMP2 As TextBox
    Friend WithEvents txtRev2 As TextBox
    Friend WithEvents txtCost2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCMP3 As TextBox
    Friend WithEvents txtRev3 As TextBox
    Friend WithEvents txtCost3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
