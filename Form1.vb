Public Class Form1
    Dim numero As String 'déclaration des variables
    Dim currentNumber As Integer
    Dim resultat As Integer
    Dim operand1 As Integer
    Dim operand2 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextResultat_TextChanged(sender As Object, e As EventArgs) Handles TextResultat.TextChanged

    End Sub

    Private Sub TextFormule_TextChanged(sender As Object, e As EventArgs) Handles TextFormule.TextChanged

    End Sub

    Private Sub TextNumero_TextChanged(sender As Object, e As EventArgs) Handles TextNumero.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numero = 1
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
        'MessageBox.Show(currentNumber)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numero = 2
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero
        End If
        currentNumber = TextNumero.Text
        'MessageBox.Show(currentNumber)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

    End Sub

    Private Sub Virgule_Click(sender As Object, e As EventArgs) Handles Virgule.Click

    End Sub

    Private Sub Egal_Click(sender As Object, e As EventArgs) Handles Egal.Click
        TextFormule.Text = TextFormule.Text + TextNumero.Text + " = "
        operand2 = currentNumber
        resultat = operand1 + operand2
        'MessageBox.Show(operand2)
        TextResultat.Text = resultat
        TextNumero.Text = 0
    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        'TextResultat.Text = Val(TextFormule.Text)
        operand1 = currentNumber
        TextFormule.Text = TextFormule.Text + TextNumero.Text + " + "
        TextNumero.Text = 0
        'MessageBox.Show(operand1)
    End Sub

    Private Sub Soustraction_Click(sender As Object, e As EventArgs) Handles Soustraction.Click

    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click

    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click

    End Sub

End Class
