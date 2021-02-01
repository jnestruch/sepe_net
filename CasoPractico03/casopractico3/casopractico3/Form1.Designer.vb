<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbMistral = New System.Windows.Forms.RadioButton()
        Me.rbTahoma = New System.Windows.Forms.RadioButton()
        Me.rbVerdana = New System.Windows.Forms.RadioButton()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkStrike = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escribe tu nombre"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(213, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de letra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Formato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(345, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(479, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tamaño"
        '
        'rbMistral
        '
        Me.rbMistral.AutoSize = True
        Me.rbMistral.Location = New System.Drawing.Point(65, 210)
        Me.rbMistral.Name = "rbMistral"
        Me.rbMistral.Size = New System.Drawing.Size(62, 19)
        Me.rbMistral.TabIndex = 6
        Me.rbMistral.TabStop = True
        Me.rbMistral.Text = "Mistral"
        Me.rbMistral.UseVisualStyleBackColor = True
        '
        'rbTahoma
        '
        Me.rbTahoma.AutoSize = True
        Me.rbTahoma.Location = New System.Drawing.Point(65, 260)
        Me.rbTahoma.Name = "rbTahoma"
        Me.rbTahoma.Size = New System.Drawing.Size(71, 19)
        Me.rbTahoma.TabIndex = 7
        Me.rbTahoma.TabStop = True
        Me.rbTahoma.Text = "Tahoma"
        Me.rbTahoma.UseVisualStyleBackColor = True
        '
        'rbVerdana
        '
        Me.rbVerdana.AutoSize = True
        Me.rbVerdana.Location = New System.Drawing.Point(65, 313)
        Me.rbVerdana.Name = "rbVerdana"
        Me.rbVerdana.Size = New System.Drawing.Size(71, 19)
        Me.rbVerdana.TabIndex = 8
        Me.rbVerdana.TabStop = True
        Me.rbVerdana.Text = "Verdana"
        Me.rbVerdana.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Location = New System.Drawing.Point(213, 210)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(66, 19)
        Me.chkItalic.TabIndex = 9
        Me.chkItalic.Text = "Cursiva"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Location = New System.Drawing.Point(213, 260)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(66, 19)
        Me.chkBold.TabIndex = 10
        Me.chkBold.Text = "Negrita"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkStrike
        '
        Me.chkStrike.AutoSize = True
        Me.chkStrike.Location = New System.Drawing.Point(213, 314)
        Me.chkStrike.Name = "chkStrike"
        Me.chkStrike.Size = New System.Drawing.Size(85, 19)
        Me.chkStrike.TabIndex = 11
        Me.chkStrike.Text = "Subrayado"
        Me.chkStrike.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(549, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Image = CType(resources.GetObject("lblRed.Image"), System.Drawing.Image)
        Me.lblRed.Location = New System.Drawing.Point(345, 210)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(67, 15)
        Me.lblRed.TabIndex = 13
        Me.lblRed.Text = "                    "
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Image = CType(resources.GetObject("lblGreen.Image"), System.Drawing.Image)
        Me.lblGreen.Location = New System.Drawing.Point(345, 260)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(67, 15)
        Me.lblGreen.TabIndex = 14
        Me.lblGreen.Text = "                    "
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Image = CType(resources.GetObject("lblBlue.Image"), System.Drawing.Image)
        Me.lblBlue.Location = New System.Drawing.Point(345, 313)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(67, 15)
        Me.lblBlue.TabIndex = 15
        Me.lblBlue.Text = "                    "
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "15", "17"})
        Me.cmbSize.Location = New System.Drawing.Point(483, 249)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(140, 23)
        Me.cmbSize.TabIndex = 16
        Me.cmbSize.Text = "9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 422)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkStrike)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.rbVerdana)
        Me.Controls.Add(Me.rbTahoma)
        Me.Controls.Add(Me.rbMistral)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Curso VB.Net - Tarea 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbMistral As RadioButton
    Friend WithEvents rbTahoma As RadioButton
    Friend WithEvents rbVerdana As RadioButton
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkStrike As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents cmbSize As ComboBox
End Class
