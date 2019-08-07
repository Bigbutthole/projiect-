Module Module1
    Public Declare Function Beep Lib "kernel32" (dwFreq As Integer, dwDuration As Integer) As Integer
    Public Declare Function Sound Lib "kernel32" Alias "Beep" (dwFreq As Integer, dwDuration As Integer) As Integer
    Const Do0 = 264
    Const Re = 297
    Const Mi = 330
    Const Fa = 352
    Const Sol = 396
    Const La = 440
    Const Ti = 495
    Const Do1 = 528
    Const T4 = 1000
    Sub Main()
        Beep(Fa, 500)
        Beep(Fa, 300)
        Beep(Fa, 300)
        Beep(Sol, 300)
        Beep(La, 500)
        Beep(La, 800)
        Beep(Mi, 800)
        Threading.Thread.Sleep(1000)
        Beep(Re, 500)
        Beep(Re, 300)
        Beep(Re, 300)
        Beep(Mi, 300)
        Beep(Fa, 500)
        Beep(Fa, 800)
        Beep(Do0, 800)
        Threading.Thread.Sleep(1000)
        Beep(Do0, 500)
        Beep(Mi, 500)
        Beep(Re, 500)
        Threading.Thread.Sleep(1000)
        Beep(Do0, 500)
        Beep(Mi, 500)
        Beep(Re, 500)
        Threading.Thread.Sleep(1000)
        Beep(Do0, 500)
        Beep(Mi, 500)
        Beep(Re, 500)
        Beep(Re, 800)
        Beep(Re, 1000)
        Dim a As Integer
        a = 1000
        Beep(800, 1000 * 3)
        Threading.Thread.Sleep(1000)
        Beep(800, 1000 * 3)
        Threading.Thread.Sleep(1000)
        Beep(800, 1000 * 3)
        Do
            Do Until a = 0
                Beep(a, 100)
                a = a - 100
            Loop
            Do Until a = 1000
                Beep(a, 100)
                a = a + 100
            Loop
        Loop
    End Sub
End Module
