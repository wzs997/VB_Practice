Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Text = "开始游戏"
        Button1.Text = "地鼠1号"
        Button2.Text = "地鼠2号"
        Button3.Text = "地鼠3号"
        Button4.Text = "地鼠4号"
        Button5.Text = "地鼠5号"
        Button6.Text = "地鼠6号"
        Button7.Text = "地鼠7号"
        Button8.Text = "地鼠8号"
        Button9.Text = "地鼠9号"
        Me.WindowState = FormWindowState.Maximized
        Label1.Font = New Font("黑体", 13, FontStyle.Bold)
        Button1.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button2.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button3.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button4.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button5.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button9.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button6.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button7.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
        Button8.Image = System.Drawing.Image.FromFile("..\\土拨鼠.gif")
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Timer2.Interval = 100
        Timer1.Interval = 15000
        Timer3.Interval = 1400
        Timer4.Interval = 10
        Button10.Visible = False
    End Sub
    Dim sum = 0
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        sum = sum + 1
        Button1.Visible = False
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Timer5.Enabled = False
        MsgBox("游戏结束！！ 您的得分为" & sum, 1)
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim value = Int((9 * Rnd()) + 1)
        Select Case value
            Case 1
                Button1.Visible = True
            Case 2
                Button2.Visible = True
            Case 3
                Button3.Visible = True
            Case 4
                Button4.Visible = True
            Case 5
                Button5.Visible = True
            Case 6
                Button6.Visible = True
            Case 7
                Button7.Visible = True
            Case 8
                Button8.Visible = True
            Case 9
                Button9.Visible = True
        End Select
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        sum = sum + 1
        Button2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Visible = False
        sum = sum + 1
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Visible = False
        sum = sum + 1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Button5.Visible = False
        sum = sum + 1
    End Sub
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Button9.Visible = False
        sum = sum + 1
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button7.Visible = False
        sum = sum + 1
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Button8.Visible = False
        sum = sum + 1
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Button6.Visible = False
        sum = sum + 1
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label1.Text = "分数:" & sum
    End Sub
End Class