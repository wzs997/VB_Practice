Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = True And TextBox1.TextLength < 10 Then
            Label4.Text = "√"
            Label4.ForeColor = Color.Lime
        Else
            Label4.Text = "×"
            Label4.ForeColor = Color.Red
        End If
        If TextBox1.Text = "" Then
            Label4.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Dim i As Integer
    Dim j As Integer
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        For i = 1 To Len(TextBox2.Text)
            If Asc(i) < 0 And TextBox1.TextLength < 5 Then
                Label5.Text = "√"
                Label4.ForeColor = Color.Lime
            Else
                Label5.Text = "×"
                Label4.ForeColor = Color.Red
            End If
        Next


    End Sub
    Dim n = 0
    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        n = n + 1
        If n = 10 Then

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If Not TextBox3.Text = "6020" Then
            MsgBox("密码错误")
        End If
    End Sub
End Class
