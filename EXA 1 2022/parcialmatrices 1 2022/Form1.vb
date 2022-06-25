Public Class Form1
    Dim m1 As Matriz
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        m1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox5.Text = m1.descargar
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox5.Text = m1.descargar
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        m1.cargarm(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = m1.descargar
    End Sub

    Private Sub Pregunta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta1ToolStripMenuItem.Click
        m1.preguntaa1(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = m1.descargar
    End Sub

    Private Sub Pregunta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta2ToolStripMenuItem.Click
        m1.pregunta2()
        TextBox6.Text = m1.descargar
    End Sub
End Class
