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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ClearToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        nameTextbox = New TextBox()
        nameListBox = New ListBox()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearToolStripMenuItem, QuitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ClearToolStripMenuItem
        ' 
        ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        ClearToolStripMenuItem.Size = New Size(126, 26)
        ClearToolStripMenuItem.Text = "Clear"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(126, 26)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter first and last name"
        ' 
        ' nameTextbox
        ' 
        nameTextbox.Location = New Point(18, 63)
        nameTextbox.Name = "nameTextbox"
        nameTextbox.Size = New Size(125, 27)
        nameTextbox.TabIndex = 2
        ' 
        ' nameListBox
        ' 
        nameListBox.FormattingEnabled = True
        nameListBox.Location = New Point(21, 104)
        nameListBox.Name = "nameListBox"
        nameListBox.Size = New Size(187, 304)
        nameListBox.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(205, 63)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(nameListBox)
        Controls.Add(nameTextbox)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Add"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents nameTextbox As TextBox
    Friend WithEvents nameListBox As ListBox
    Friend WithEvents Button1 As Button

End Class
