Imports System.Math
Module Module1
    Public nombre As Integer
    Public antes As Double
    Public total As Double
    Public descuento As Double
    Public parcial As Double
    Public fin As Double
    Public Const int1 = 0.015, int2 = 0.025, inte3 = 0.075, int4 = 0.1
    Public Const ip1 = 0.025, ip2 = 0.03, ip3 = 0.045
    Public propios As Byte
    Public ajenos As Byte
    Public efectivo As Byte
    Public depositoss As Double


    Sub Resultaditos()


        MsgBox(nombre & "a continuación se le muestra el resultado de su operación")
        Final.interes.Text = Str(Round(parcial, 2))
        Final.total.Text = Str(Round(fin, 2))
    End Sub

    Sub limpiasion()


        Final.interes.Clear()
        Final.total.Clear()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.nombre.Clear()
        Form1.anterior.Clear()
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.Monetario.Checked = False
        Form1.MonetarioP.Checked = False
        Form1.Ahorros.Checked = False



    End Sub




End Module
