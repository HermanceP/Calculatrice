Public Class Form1
    Dim numero As String 'déclaration des variables
    Dim currentNumber As Double
    Dim resultat As Double
    Dim operand1 As Double
    Dim operand2 As Double
    Dim [Operator] As String

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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numero = 3
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        numero = 4
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numero = 5
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        numero = 6
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        numero = 7
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        numero = 8
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        numero = 9
        If TextNumero.Text = 0 Then
            TextNumero.Text = numero
        Else
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        numero = 0
        If TextNumero.Text <> 0 Then
            TextNumero.Text = TextNumero.Text + numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Virgule_Click(sender As Object, e As EventArgs) Handles Virgule.Click
        TextNumero.Text = TextNumero.Text + ","
    End Sub

    Private Sub Egal_Click(sender As Object, e As EventArgs) Handles Egal.Click
        If TextNumero.Text.EndsWith(",") Then 'si le currentNumber finit par une virgule il faut l'enlever
            TextNumero.Text = TextNumero.Text.Substring(0, TextNumero.Text.Length - 1)
        End If

        TextFormule.Text = ""
        operand2 = currentNumber
        If [Operator] = "+" Then
            resultat = operand1 + operand2
        ElseIf [Operator] = "-" Then
            resultat = operand1 - operand2
        ElseIf [Operator] = "/" Then
            resultat = operand1 / operand2
        ElseIf [Operator] = "*" Then
            resultat = operand1 * operand2
        ElseIf [Operator] = "" Then
            resultat = currentNumber
        End If
        TextResultat.Text = resultat
        TextNumero.Text = 0
        resultat = 0
        operand1 = 0
        operand2 = 0
        [Operator] = ""
    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        If [Operator] = "+" Then
            operand1 = operand1 + currentNumber
        ElseIf [Operator] = "-" Then
            operand1 = operand1 - currentNumber
        ElseIf [Operator] = "/" Then
            operand1 = operand1 / currentNumber
        ElseIf [Operator] = "*" Then
            operand1 = operand1 * currentNumber
        ElseIf [Operator] = "" Then
            operand1 = currentNumber
        End If

        TextResultat.Text = operand1
        TextFormule.Text = TextFormule.Text + TextNumero.Text + " + "
        TextNumero.Text = 0
        [Operator] = "+"
    End Sub

    Private Sub Soustraction_Click(sender As Object, e As EventArgs) Handles Soustraction.Click
        If [Operator] = "+" Then
            operand1 = operand1 + currentNumber
        ElseIf [Operator] = "-" Then
            operand1 = operand1 - currentNumber
        ElseIf [Operator] = "/" Then
            operand1 = operand1 / currentNumber
        ElseIf [Operator] = "*" Then
            operand1 = operand1 * currentNumber
        ElseIf [Operator] = "" Then
            operand1 = currentNumber
        End If

        TextResultat.Text = operand1
        TextFormule.Text = TextFormule.Text + TextNumero.Text + " - "
        TextNumero.Text = 0
        [Operator] = "-"
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        If [Operator] = "+" Then
            operand1 = operand1 + currentNumber
        ElseIf [Operator] = "-" Then
            operand1 = operand1 - currentNumber
        ElseIf [Operator] = "/" Then
            operand1 = operand1 / currentNumber
        ElseIf [Operator] = "*" Then
            operand1 = operand1 * currentNumber
        ElseIf [Operator] = "" Then
            operand1 = currentNumber
        End If

        TextResultat.Text = operand1
        TextFormule.Text = TextFormule.Text + TextNumero.Text + " * "
        TextNumero.Text = 0
        [Operator] = "*"
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        If [Operator] = "+" Then
            operand1 = operand1 + currentNumber
        ElseIf [Operator] = "-" Then
            operand1 = operand1 - currentNumber
        ElseIf [Operator] = "/" Then
            operand1 = operand1 / currentNumber
        ElseIf [Operator] = "*" Then
            operand1 = operand1 * currentNumber
        ElseIf [Operator] = "" Then
            operand1 = currentNumber
        End If

        TextResultat.Text = operand1
        TextFormule.Text = TextFormule.Text + TextNumero.Text + " / "
        TextNumero.Text = 0
        [Operator] = "/"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        currentNumber = 0
        TextNumero.Text = 0
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        TextNumero.Text = 0
        TextResultat.Text = ""
        TextFormule.Text = ""
        resultat = 0
        operand1 = 0
        operand2 = 0
        [Operator] = ""
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If TextNumero.Text.Length > 0 And TextNumero.Text <> 0 Then
            TextNumero.Text = TextNumero.Text.Substring(0, TextNumero.Text.Length - 1)
        End If
    End Sub

    Private Sub ParentheseOuvrante_Click(sender As Object, e As EventArgs) Handles ParentheseOuvrante.Click

    End Sub

    Private Sub ParentheseFermante_Click(sender As Object, e As EventArgs) Handles ParentheseFermante.Click

    End Sub
End Class
