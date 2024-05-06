Public Class Form1

    ' visual basic exercises from https://www.youtube.com/watch?v=HFWQdGn5DaU&t=5581s part 18

    ' Declare a global array variable
    Public aiData() As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the array with  values
        aiData = New Integer() {5, 7, 33, 22, 8}
    End Sub

    Private Function ArrayTotal(arrayIn() As Integer) As Integer
        ' arrayIn() : The parentheses() after the parameter name arrayIn indicate that it's an array.
        ' As Integer: This part specifies the data type Of the elements In the array, in this case, integers.
        ' As Integer: the second "As Integer" refers to the return type of the function.

        ' function will return the sum of a given array 
        Dim total As Integer
        For i = 0 To arrayIn.Length - 1
            total += arrayIn(i)
        Next
        Return total
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' output each item in a msg box
        For i = 0 To (aiData.Length - 1)
            MsgBox(aiData(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' output each array item in the same msgbox
        Dim runningTotal As String
        runningTotal = ""

        For i = 0 To (aiData.Length - 1)
            runningTotal = runningTotal & aiData(i) & vbNewLine
        Next

        MsgBox(runningTotal)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' output the sum of all array items

        Dim iTotal As Integer

        iTotal = ArrayTotal(aiData)
        MsgBox(iTotal)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' output average value from array items
        Dim iAverage As Integer

        iAverage = ArrayTotal(aiData) / aiData.Length
        MsgBox(iAverage)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' output array items that are >20
        Dim bigNums As String

        bigNums = ""

        For i = 0 To aiData.Length - 1
            If aiData(i) > 20 Then
                bigNums += aiData(i) & vbNewLine
            End If
        Next

        MsgBox(bigNums)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' output the largest item in an array
        Dim max As Integer

        max = 0
        For i = 0 To aiData.Length - 1
            If aiData(i) > max Then
                max = aiData(i)
            End If
        Next
        MsgBox(max)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' output the smallest item from the array
        Dim low As Integer

        low = aiData(0)

        For i = 0 To aiData.Length - 1
            If aiData(i) < low Then
                low = aiData(i)
            End If
        Next
        MsgBox(low)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' replace each array item with a value twice as large

        Dim sArrayItems As String
        sArrayItems = ""

        For i = 0 To aiData.Length - 1
            'aiData(i) *= 2
            sArrayItems += (aiData(i) * 2) & vbNewLine
        Next

        MsgBox(sArrayItems)

    End Sub
End Class
