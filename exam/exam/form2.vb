Public Class form2

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "显示答案"
        Label1.Font = New Font("楷体", 15, FontStyle.Bold)
        Label1.Text = "您的成绩为 " & Form1.sum & " !!!"
        Label2.Text = " "

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Text = "单选题：B C D" & vbCrLf & "多选题：BC  ABCD  BCD" & vbCrLf & "判断题：错误  错误"
    End Sub
End Class