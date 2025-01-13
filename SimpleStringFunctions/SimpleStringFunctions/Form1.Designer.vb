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
        InputTextBox = New TextBox()
        OutputTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        IndexTextBox = New TextBox()
        Button5 = New Button()
        startTB = New TextBox()
        LengthTB = New TextBox()
        Button6 = New Button()
        wordsComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' InputTextBox
        ' 
        InputTextBox.Location = New Point(33, 56)
        InputTextBox.Name = "InputTextBox"
        InputTextBox.Size = New Size(125, 27)
        InputTextBox.TabIndex = 0
        ' 
        ' OutputTextBox
        ' 
        OutputTextBox.Location = New Point(305, 56)
        OutputTextBox.Name = "OutputTextBox"
        OutputTextBox.Size = New Size(125, 27)
        OutputTextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 2
        Label1.Text = "Input:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(305, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 3
        Label2.Text = "Output:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(36, 101)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Length"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(36, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "ToUpper"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(36, 171)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 6
        Button3.Text = "ToLower"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(36, 206)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 7
        Button4.Text = "IndexOf"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' IndexTextBox
        ' 
        IndexTextBox.Location = New Point(136, 206)
        IndexTextBox.Name = "IndexTextBox"
        IndexTextBox.Size = New Size(55, 27)
        IndexTextBox.TabIndex = 8
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(33, 241)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 9
        Button5.Text = "SubString"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' startTB
        ' 
        startTB.Location = New Point(136, 242)
        startTB.Name = "startTB"
        startTB.Size = New Size(55, 27)
        startTB.TabIndex = 10
        ' 
        ' LengthTB
        ' 
        LengthTB.Location = New Point(197, 241)
        LengthTB.Name = "LengthTB"
        LengthTB.Size = New Size(55, 27)
        LengthTB.TabIndex = 11
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(36, 276)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 12
        Button6.Text = "Split"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' wordsComboBox
        ' 
        wordsComboBox.FormattingEnabled = True
        wordsComboBox.Location = New Point(136, 274)
        wordsComboBox.Name = "wordsComboBox"
        wordsComboBox.Size = New Size(151, 28)
        wordsComboBox.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(wordsComboBox)
        Controls.Add(Button6)
        Controls.Add(LengthTB)
        Controls.Add(startTB)
        Controls.Add(Button5)
        Controls.Add(IndexTextBox)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(OutputTextBox)
        Controls.Add(InputTextBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents IndexTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents startTB As TextBox
    Friend WithEvents LengthTB As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents wordsComboBox As ComboBox

End Class
