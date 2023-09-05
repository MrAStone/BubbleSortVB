Module Module1

    Sub Main()
        Dim r As New Random
        Dim data(1000) As Integer
        For i = 0 To data.Length - 1
            data(i) = r.Next(1000, 10000)
        Next
        Dim swaps As Boolean = True
        Dim n As Integer = data.Length - 1
        While swaps
            swaps = False
            For i = 1 To n
                If data(i - 1) > data(i) Then
                    Dim temp As Integer = data(i)
                    data(i) = data(i - 1)
                    data(i - 1) = temp
                    swaps = True
                End If

            Next
            n -= 1
        End While

        For i = 0 To data.Length - 1
            Console.Write(data(i) & " ")
        Next
    End Sub

End Module
