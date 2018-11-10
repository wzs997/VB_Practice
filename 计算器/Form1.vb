Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "1"
        Else
            TextBox3.Text = "1"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "2"
        Else
            TextBox3.Text = "2"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "3"
        Else
            TextBox3.Text = "3"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "4"
        Else
            TextBox3.Text = "4"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "5"
        Else
            TextBox3.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "6"
        Else
            TextBox3.Text = "6"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "7"
        Else
            TextBox3.Text = "7"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "8"
        Else
            TextBox3.Text = "8"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "9"
        Else
            TextBox3.Text = "9"
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox2.Text = "+"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox2.Text = "-"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox2.Text = "*"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox2.Text = "/"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        Else
            TextBox3.Text = "0"
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Not TextBox3.Text = "" Then
            TextBox3.Text = ""
        ElseIf Not TextBox2.Text = "" Then
            TextBox2.Text = ""
        ElseIf Not TextBox1.Text = "" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
   
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Select Case TextBox2.Text
            Case "+"
                TextBox4.Text = (TextBox1.Text) + Val(TextBox3.Text)
            Case "-"
                TextBox4.Text = (TextBox1.Text) - Val(TextBox3.Text)
            Case "*"
                TextBox4.Text = (TextBox1.Text) * Val(TextBox3.Text)
            Case "/"
                TextBox4.Text = (TextBox1.Text) / Val(TextBox3.Text)
        End Select
    End Sub
End Class
