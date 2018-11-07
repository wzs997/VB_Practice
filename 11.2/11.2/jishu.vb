Public Class jishu

    Private Sub jishu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "一、单选题。（每题10分，共3题）"
        Label1.Font = New Font("宋体", 10, FontStyle.Bold)
        Label2.Text = "1、Visual Basic的编程机制是＿？"
        Label3.Text = "2、"
        RadioButton1.Text = "可视化"
        RadioButton2.Text = "面向对象"
        RadioButton3.Text = "面向图形"
        RadioButton4.Text = "事件驱动"

    End Sub
End Class