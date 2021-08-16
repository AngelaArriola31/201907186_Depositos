Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox3.Visible = True
            TextBox3.Focus()
        Else
            TextBox3.Clear()
            TextBox3.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            TextBox1.Visible = True
            TextBox1.Focus()
        Else
            TextBox1.Clear()
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            TextBox2.Visible = True
            TextBox2.Focus()
        Else
            TextBox2.Clear()
            TextBox2.Visible = False
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Proceso.Click
        descuento = 0
        If (nombre.Text = "") Then
            MsgBox("ERROR, NO INGRESÓ SU NOMBRE")
            nombre.Focus()
            Exit Sub
        End If

        If (anterior.Text = "") Then
            MsgBox("ERROR, NO INGRESÓ SU SALDO ANTERIOR")
            anterior.Focus()
            Exit Sub
        End If

        nombre = nombre
        antes = Val(anterior.Text)


        If ((CheckBox1.Checked) Or (CheckBox2.Checked) Or (CheckBox3.Checked)) Then
            If (CheckBox1.Checked) Then
                If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text) > 0) Then
                    propios = Val(TextBox3.Text)
                Else
                    MsgBox("ERROR FORMATO NO VALIDO PARA CHEQUES PROPIOS")
                    TextBox3.Focus()
                    Exit Sub
                End If
            Else
                propios = 0
            End If

            If (CheckBox2.Checked) Then
                If (IsNumeric(TextBox1.Text) And Val(TextBox1.Text) > 0) Then
                    ajenos = Val(TextBox1.Text)
                Else
                    MsgBox("ERROR FORMATO NO VALIDO PARA CHEQUES DE OTROS BANCOS")
                    TextBox1.Focus()
                    Exit Sub
                End If
            Else
                ajenos = 0
            End If

            If (CheckBox3.Checked) Then
                If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text) > 0) Then
                    efectivo = Val(TextBox2.Text)
                Else
                    MsgBox("ERROR FORMATO NO VALIDO PARA EFECTIVO")
                    TextBox2.Focus()
                    Exit Sub
                End If
            Else
                efectivo = 0
            End If
        Else
            MsgBox("ERROR NO SELECCIONO METODO DE DEPÓSITO")
            Exit Sub
        End If

        depositoss = efectivo + ajenos + propios
        parcial = antes + depositoss


        If (Monetario.Checked) Then
            total = 0

        ElseIf (MonetarioP.Checked) Then
            If antes > 1 And antes < 10001 Then
                total = antes * ip1
            ElseIf antes >= 10001 And antes < 15001 Then
                total = antes * ip2
            ElseIf antes >= 15001 Then
                total = antes * ip3
            End If

        ElseIf (Ahorros.Checked) Then
            If parcial > 1 And parcial < 1001 Then
                total = parcial * int1
            ElseIf parcial >= 1001 And parcial < 5001 Then
                total = parcial * int2
            ElseIf parcial >= 5001 And parcial < 15001 Then
                total = parcial * inte3
            ElseIf parcial >= 15001 Then
                total = parcial * int4
            End If

        Else
            MsgBox("ERROR")
            Exit Sub
        End If

        Me.Hide()
        Final.Show()

        fin = parcial + total


    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        limpiasion()



    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            limpiasion()

        End If
    End Sub
End Class
