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
        Me.components = New System.ComponentModel.Container()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Segundos = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Tiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hora
        '
        Me.Hora.BackColor = System.Drawing.SystemColors.ControlText
        Me.Hora.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Hora.Location = New System.Drawing.Point(249, 190)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(74, 45)
        Me.Hora.TabIndex = 0
        Me.Hora.Text = "00"
        Me.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(332, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Minutos
        '
        Me.Minutos.BackColor = System.Drawing.SystemColors.ControlText
        Me.Minutos.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Minutos.Location = New System.Drawing.Point(413, 190)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(61, 45)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        Me.Minutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.BackColor = System.Drawing.SystemColors.ControlText
        Me.Fecha.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Fecha.Location = New System.Drawing.Point(208, 322)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(291, 28)
        Me.Fecha.TabIndex = 3
        Me.Fecha.Text = "9 de Marzo del 2026"
        Me.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dia
        '
        Me.Dia.BackColor = System.Drawing.SystemColors.ControlText
        Me.Dia.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dia.Location = New System.Drawing.Point(297, 249)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(126, 32)
        Me.Dia.TabIndex = 4
        Me.Dia.Text = "Lunes"
        Me.Dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Practica_4.My.Resources.Resources.descarga
        Me.PictureBox2.Location = New System.Drawing.Point(464, 271)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica_4.My.Resources.Resources.descarga__8_
        Me.PictureBox1.Location = New System.Drawing.Point(12, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 566)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(38, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 304)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(17, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuración"
        '
        'Segundos
        '
        Me.Segundos.AutoSize = True
        Me.Segundos.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Segundos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Segundos.Location = New System.Drawing.Point(353, 150)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(39, 13)
        Me.Segundos.TabIndex = 8
        Me.Segundos.Text = "Label3"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Reset)
        Me.Panel2.Controls.Add(Me.Start)
        Me.Panel2.Controls.Add(Me.Tiempo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(38, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 304)
        Me.Panel2.TabIndex = 9
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(191, 158)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 3
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(65, 158)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 2
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Tiempo
        '
        Me.Tiempo.AutoSize = True
        Me.Tiempo.Location = New System.Drawing.Point(144, 87)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(39, 13)
        Me.Tiempo.TabIndex = 1
        Me.Tiempo.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cronometro"
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(723, 566)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hora As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Segundos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Reset As Button
    Friend WithEvents Start As Button
    Friend WithEvents Tiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer3 As Timer
End Class
