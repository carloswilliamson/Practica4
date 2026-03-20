Public Class Form1
    Dim formato As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Iniciar los timers
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Dim date_o para crear una variable, = le asigna un valor de DateTime.Now que es la fecha de ahorita, 
        'el valor es la fecha en el formato de "dd" el numero de dia, "MMMM" el mes en texto, y "yyyy" el año
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""
        'HH' es para la hora en 24h, "hh" es en 12h, "mm" es minutos, y "ss" es segundos
        ' Este es el formato de 24 h
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        Hora.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Segundos.Text = Time_mod(2)
        Dia.Text = Day_o
        Fecha.Text = date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            Hora.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Dia.ForeColor = Color.White
            Fecha.ForeColor = Color.White
            Segundos.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            Hora.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Dia.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
            Segundos.ForeColor = Color.Red
        ElseIf color_texto = "Amarillo" Then
            Hora.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Dia.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow
            Segundos.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            Hora.ForeColor = Color.Green
            Minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Dia.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
            Segundos.ForeColor = Color.Green
        ElseIf color_texto = "Azul" Then
            Hora.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Dia.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
            Segundos.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub
End Class
