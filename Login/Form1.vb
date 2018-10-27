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
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Dim i As Integer
    Dim j As Char
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        For i = 1 To Len(TextBox2.Text)
            j = Mid(TextBox2.Text, i, 1)
            If (AscW(j) > -40870 And AscW(j) < -19967 And TextBox2.TextLength < 5) Or (AscW(j) < 40870 And AscW(j) > 19967 And TextBox2.TextLength < 5) Then
                Label5.Text = "√"
                Label5.ForeColor = Color.Lime
            Else
                Label5.Text = "×"
                Label5.ForeColor = Color.Red
            End If
        Next i
        If TextBox2.Text = "" Then
            Label5.Text = ""
        End If
    End Sub
    Dim n = 0
    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
       
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not TextBox3.Text = "6020" Then
            MsgBox("密码错误", 1 + 64, "警告")
        End If    
    End Sub
    Dim m = 0
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        m = m + 1
        If m = 10 Then
            Label7.Text = "2018071154"
            Label8.Text = "6020"
            Label9.Text = "王中石"
            Label7.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        n = n + 1
        If n = 10 Then
            Label7.Text = "i"
            Label7.ForeColor = Color.Gray
            Label7.Font = New Font("宋体", 8)
        End If

    End Sub

    Private Sub Label7_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseDown
        m = m + 1
        If m = 10 Then
            Label7.Text = "2018071154"
            Label8.Text = "6020"
            Label9.Text = "王中石"
            Label7.ForeColor = Color.Black
        End If
    End Sub
End Class
