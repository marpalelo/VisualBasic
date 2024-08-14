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
        Me.ButtonORIGEN = New System.Windows.Forms.Button()
        Me.TextBoxORIGEN = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonIR = New System.Windows.Forms.Button()
        Me.TextBoxDETALLES = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonBuscarEXE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonORIGEN
        '
        Me.ButtonORIGEN.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonORIGEN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ButtonORIGEN.Location = New System.Drawing.Point(278, 14)
        Me.ButtonORIGEN.Name = "ButtonORIGEN"
        Me.ButtonORIGEN.Size = New System.Drawing.Size(140, 40)
        Me.ButtonORIGEN.TabIndex = 3
        Me.ButtonORIGEN.Text = "Explorar"
        Me.ButtonORIGEN.UseVisualStyleBackColor = False
        '
        'TextBoxORIGEN
        '
        Me.TextBoxORIGEN.Location = New System.Drawing.Point(278, 72)
        Me.TextBoxORIGEN.Name = "TextBoxORIGEN"
        Me.TextBoxORIGEN.ReadOnly = True
        Me.TextBoxORIGEN.Size = New System.Drawing.Size(432, 22)
        Me.TextBoxORIGEN.TabIndex = 2
        Me.TextBoxORIGEN.Text = "Busque el archivo a convertir con Explorar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonIR
        '
        Me.ButtonIR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonIR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ButtonIR.Location = New System.Drawing.Point(570, 14)
        Me.ButtonIR.Name = "ButtonIR"
        Me.ButtonIR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonIR.TabIndex = 9
        Me.ButtonIR.Text = "Convertir"
        Me.ButtonIR.UseVisualStyleBackColor = False
        '
        'TextBoxDETALLES
        '
        Me.TextBoxDETALLES.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBoxDETALLES.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxDETALLES.Location = New System.Drawing.Point(15, 141)
        Me.TextBoxDETALLES.Multiline = True
        Me.TextBoxDETALLES.Name = "TextBoxDETALLES"
        Me.TextBoxDETALLES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDETALLES.Size = New System.Drawing.Size(569, 32)
        Me.TextBoxDETALLES.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Filtro"
        Me.Label4.Visible = False
        '
        'ButtonBuscarEXE
        '
        Me.ButtonBuscarEXE.Location = New System.Drawing.Point(440, 107)
        Me.ButtonBuscarEXE.Name = "ButtonBuscarEXE"
        Me.ButtonBuscarEXE.Size = New System.Drawing.Size(141, 23)
        Me.ButtonBuscarEXE.TabIndex = 15
        Me.ButtonBuscarEXE.Text = "Llamar a Marcelo"
        Me.ButtonBuscarEXE.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CONVERSOR.My.Resources.Resources.conversorMP3Nacional
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 80)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Btn_Cancelar.Location = New System.Drawing.Point(424, 14)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 40)
        Me.Btn_Cancelar.TabIndex = 17
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(812, 170)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonBuscarEXE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDETALLES)
        Me.Controls.Add(Me.ButtonIR)
        Me.Controls.Add(Me.ButtonORIGEN)
        Me.Controls.Add(Me.TextBoxORIGEN)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertidor de formatos LRA-57"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonORIGEN As System.Windows.Forms.Button
    Friend WithEvents TextBoxORIGEN As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonIR As System.Windows.Forms.Button
    Friend WithEvents TextBoxDETALLES As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonBuscarEXE As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button

End Class
