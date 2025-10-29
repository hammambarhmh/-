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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.التاريخالحاليToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.التاريخوالوقتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الشهرمنالتاريخToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.رقميمثليوممنالاسبوعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الوقتالحاليToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الساعاتمنالوقتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الدقائقمنالوقتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الثوانيمنالوقتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.السنةمنالوقتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClockToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(351, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClockToolStripMenuItem
        '
        Me.ClockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.TimeToolStripMenuItem})
        Me.ClockToolStripMenuItem.Name = "ClockToolStripMenuItem"
        Me.ClockToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ClockToolStripMenuItem.Text = "Clock"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.التاريخالحاليToolStripMenuItem, Me.التاريخوالوقتToolStripMenuItem, Me.الشهرمنالتاريخToolStripMenuItem, Me.رقميمثليوممنالاسبوعToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'التاريخالحاليToolStripMenuItem
        '
        Me.التاريخالحاليToolStripMenuItem.Name = "التاريخالحاليToolStripMenuItem"
        Me.التاريخالحاليToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.التاريخالحاليToolStripMenuItem.Text = "التاريخ الحالي"
        '
        'التاريخوالوقتToolStripMenuItem
        '
        Me.التاريخوالوقتToolStripMenuItem.Name = "التاريخوالوقتToolStripMenuItem"
        Me.التاريخوالوقتToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.التاريخوالوقتToolStripMenuItem.Text = " التاريخ والوقت معا"
        '
        'الشهرمنالتاريخToolStripMenuItem
        '
        Me.الشهرمنالتاريخToolStripMenuItem.Name = "الشهرمنالتاريخToolStripMenuItem"
        Me.الشهرمنالتاريخToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.الشهرمنالتاريخToolStripMenuItem.Text = "الشهر من التاريخ"
        '
        'رقميمثليوممنالاسبوعToolStripMenuItem
        '
        Me.رقميمثليوممنالاسبوعToolStripMenuItem.Name = "رقميمثليوممنالاسبوعToolStripMenuItem"
        Me.رقميمثليوممنالاسبوعToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.رقميمثليوممنالاسبوعToolStripMenuItem.Text = "رقم يمثل يوم من الاسبوع"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.الوقتالحاليToolStripMenuItem, Me.الساعاتمنالوقتToolStripMenuItem, Me.الدقائقمنالوقتToolStripMenuItem, Me.الثوانيمنالوقتToolStripMenuItem, Me.السنةمنالوقتToolStripMenuItem})
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.TimeToolStripMenuItem.Text = "Time"
        '
        'الوقتالحاليToolStripMenuItem
        '
        Me.الوقتالحاليToolStripMenuItem.Name = "الوقتالحاليToolStripMenuItem"
        Me.الوقتالحاليToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.الوقتالحاليToolStripMenuItem.Text = "الوقت الحالي "
        '
        'الساعاتمنالوقتToolStripMenuItem
        '
        Me.الساعاتمنالوقتToolStripMenuItem.Name = "الساعاتمنالوقتToolStripMenuItem"
        Me.الساعاتمنالوقتToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.الساعاتمنالوقتToolStripMenuItem.Text = "الساعات من الوقت"
        '
        'الدقائقمنالوقتToolStripMenuItem
        '
        Me.الدقائقمنالوقتToolStripMenuItem.Name = "الدقائقمنالوقتToolStripMenuItem"
        Me.الدقائقمنالوقتToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.الدقائقمنالوقتToolStripMenuItem.Text = "الدقائق من الوقت"
        '
        'الثوانيمنالوقتToolStripMenuItem
        '
        Me.الثوانيمنالوقتToolStripMenuItem.Name = "الثوانيمنالوقتToolStripMenuItem"
        Me.الثوانيمنالوقتToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.الثوانيمنالوقتToolStripMenuItem.Text = "الثواني من الوقت "
        '
        'السنةمنالوقتToolStripMenuItem
        '
        Me.السنةمنالوقتToolStripMenuItem.Name = "السنةمنالوقتToolStripMenuItem"
        Me.السنةمنالوقتToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.السنةمنالوقتToolStripMenuItem.Text = "السنة من الوقت"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(351, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents التاريخالحاليToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents التاريخوالوقتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الشهرمنالتاريخToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents رقميمثليوممنالاسبوعToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الوقتالحاليToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الساعاتمنالوقتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الدقائقمنالوقتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents الثوانيمنالوقتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents السنةمنالوقتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
