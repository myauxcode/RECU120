Public Class Matriz
    Const fmax = 50
    Const cmax = 50
    Private fi, co, m(fmax, cmax) As Integer
    Public Sub matriz()
        fi = 0
        co = 0
    End Sub
    Public Sub cargarm(nf As Integer, nc As Integer)
        Dim f, c As Integer
        fi = nf
        co = nc
        For f = 1 To fi
            For c = 1 To co
                m(f, c) = InputBox("inserte elemento")
            Next
        Next
    End Sub
    Public Sub cargar(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim f, c As Integer
        fi = nf
        co = nc
        For f = 1 To fi
            For c = 1 To co
                m(f, c) = a + Rnd() * (b - a)
            Next
        Next
    End Sub
    Public Function descargar()
        Dim f, c As Integer
        Dim s As String = ""
        For f = 1 To fi
            s = s + (Chr(13) + Chr(10)) + "|"
            For c = 1 To co
                s = s + Str(m(f, c)) + "|"
            Next
        Next
        Return s
    End Function
    Public Sub inter(f1 As Integer, c1 As Integer, f2 As Integer, c2 As Integer)
        Dim aux As Integer = m(f1, c1)
        m(f1, c1) = m(f2, c2)
        m(f2, c2) = aux
    End Sub

    Public Sub preguntaa1(f1 As Integer, f2 As Integer, c1 As Integer, c2 As Integer)
        Dim f, c, fd, cd, i As Integer
        For c = c2 To c1 Step -1
            For f = f2 To f1 Step -1
                For cd = c To c1 Step -1
                    If cd = c Then
                        i = f
                    Else
                        i = f2
                    End If
                    For fd = i To f1 Step -1
                        If m(f, c) > m(fd, cd) Then
                            inter(f, c, fd, cd)
                        End If
                    Next
                Next
            Next
        Next


    End Sub
    Public Sub ordenar()
        Dim fp, cp, fd, cd, i As Integer
        For fp = 1 To fi
            For cp = 1 To co
                For fd = fp To fi
                    If fd = fp Then
                        i = cp
                    Else
                        i = 1
                    End If
                    For cd = i To co
                        If m(fp, cp) > m(fd, cd) Then
                            inter(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub
    Public Sub cargarv(ele As Integer)
        co = co + 1
        m(1, co) = ele
    End Sub
    Public Sub pregunta2()
        Dim f, c, tope, ele As Integer

        Dim pares As Matriz = New Matriz
        Dim impares As Matriz = New Matriz
        pares.fi = 1
        impares.fi = 1

        tope = 1
        For c = co - 1 To 1 Step -1
            For f = tope To 1 Step -1
                ele = m(f, c)
                If (ele Mod 2 = 0) Then
                    pares.cargarv(ele)
                Else
                    impares.cargarv(ele)
                End If
            Next
            tope = tope + 1
        Next

        pares.ordenar()
        impares.ordenar()

        tope = 1
        Dim i = 1
        Dim j = 1
        For c = co - 1 To 1 Step -1
            For f = tope To 1 Step -1
                If (i <= pares.co) Then
                    m(f, c) = pares.m(1, i)
                    i = i + 1
                Else
                    m(f, c) = impares.m(1, j)
                    j = j + 1
                End If
            Next
            tope = tope + 1
        Next
    End Sub

End Class
