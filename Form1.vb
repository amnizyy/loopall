Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num1 As Integer
        Dim num2 As Integer

        num1 = Val(startTxt.Text)
        num2 = Val(endTxt.Text)

        Do While num1 < num2

            MessageBox.Show("The value is " & num1)
            num1 = num1 + 1

        Loop

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        Dim num1 As Integer
        Dim num2 As Integer

        num1 = Val(startTxt.Text)
        num2 = Val(endTxt.Text)

        Do
            num1 += 1
            MessageBox.Show("The value is " & num1)
        Loop While num1 < num2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        Dim num1 As Integer
        Dim num2 As Integer

        num1 = Val(startTxt.Text)
        num2 = Val(endTxt.Text)

        Do
            MessageBox.Show(num1)

            num1 = num1 + 1
        Loop Until num1 >= num2

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        Dim num1 As Integer
        Dim num2 As Integer

        num1 = Val(startTxt.Text)
        num2 = Val(endTxt.Text)

        For index As Integer = num1 To num2

            MessageBox.Show(index)
        Next
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        Dim answer As String

        Do
            answer = InputBox("Are we there yet(1=Yes/0=No)")


        Loop While answer <> "1"
        MsgBox("Alhamdulillah", MsgBoxStyle.Information)


    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Dim i As Integer
        For i = 1 To 10
            MsgBox("Work hard for excellence")
            lstView.Items.Add(i)

        Next
    End Sub

    Private Sub FindingSumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindingSumToolStripMenuItem.Click
        Me.Hide()
        find.Show()

    End Sub
End Class
