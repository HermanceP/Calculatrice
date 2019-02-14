Public Class Form1
    Dim numero As String 'déclaration des variables
    Dim currentNumber As Double 'chiffre qu'on est en train de taper
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
        Ajouter_numero()
        'MessageBox.Show(currentNumber)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numero = 2
        Ajouter_numero()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numero = 3
        Ajouter_numero()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        numero = 4
        Ajouter_numero()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numero = 5
        Ajouter_numero()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        numero = 6
        Ajouter_numero()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        numero = 7
        Ajouter_numero()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        numero = 8
        Ajouter_numero()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        numero = 9
        Ajouter_numero()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        numero = 0
        Ajouter_numero()
    End Sub


    Sub Ajouter_numero() 'c est une fonction pour tout regrouper
        If TextNumero.Text.Equals("0") = False Or TextNumero.Text.EndsWith("0,") Then
            'j ai mis un comparateur -equals "0"- car on peut avoir 0,0000 et rajouter un chiffre derriere
            TextNumero.Text = TextNumero.Text + numero
        Else
            TextNumero.Text = numero

        End If
        currentNumber = TextNumero.Text
    End Sub

    Private Sub Virgule_Click(sender As Object, e As EventArgs) Handles Virgule.Click
        If TextNumero.Text.EndsWith(",") = False And TextNumero.Text.Contains(",") = False Then
            'si le currentNumber net contient pas de virgule (ex : 0,0,3) ou ne finit par une virgule (ex: O,,,)
            TextNumero.Text = TextNumero.Text + ","

        End If
        currentNumber = TextNumero.Text
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
        currentNumber = TextNumero.Text
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
        currentNumber = TextNumero.Text
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
        currentNumber = TextNumero.Text
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
        currentNumber = TextNumero.Text
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
        currentNumber = TextNumero.Text
        [Operator] = "/"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextNumero.Text = 0
        currentNumber = TextNumero.Text
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        TextNumero.Text = 0
        currentNumber = TextNumero.Text
        TextResultat.Text = ""
        TextFormule.Text = ""
        resultat = 0
        operand1 = 0
        operand2 = 0
        [Operator] = ""
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If TextNumero.Text.Equals("0") = False Then
            TextNumero.Text = TextNumero.Text.Substring(0, TextNumero.Text.Length - 1)
        End If
        If TextNumero.Text = String.Empty Then 'si vide
            TextNumero.Text = 0
        End If
        currentNumber = TextNumero.Text
        'TextNumero.Text.Length > 0 And 
    End Sub

End Class
