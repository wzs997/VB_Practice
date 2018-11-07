
Public Class Form1
   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.AutoScroll = True
        GroupBox4.Text = "下列能接收焦点的控件是(  )。"
        CheckBox1.Text = "文本框"
        CheckBox2.Text = "命令按钮"
        CheckBox3.Text = "单选按钮"
        CheckBox4.Text = "标签框"
        GroupBox5.Text = "一般来说好的算法具备哪些特点(   )。"
        CheckBox5.Text = "有穷性"
        CheckBox6.Text = "确定性"
        CheckBox7.Text = "有输出结果"
        CheckBox8.Text = "有效性"
        GroupBox6.Text = "描述算法的方法是多种多样的，可以用(    )来描述算法。"
        CheckBox9.Text = "文字"
        CheckBox10.Text = "符号"
        CheckBox12.Text = "高级语言"
        CheckBox11.Text = "流程图"
        GroupBox7.Text = "单选按钮控件和复选框控件都具有Value属性，它们的作用完全相反。"
        GroupBox8.Text = "VB规定窗体文件的扩展名是.vbp"
        RadioButton13.Text = "正确"
        RadioButton14.Text = "错误"
        RadioButton15.Text = "正确"
        RadioButton16.Text = "错误"
        Button1.Text = "提交试卷！"
    End Sub
    Dim xuanze1%, xuanze2%, xuanze3%, duoxuan1%, duoxuan2%, duoxuan3%, panduan1%, panduan2%
    pub  Dim sum = xuanze1 + xuanze2 + xuanze3% + duoxuan1% + duoxuan2% + duoxuan3% + panduan2% + panduan1%
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'sum = xuanze1 + xuanze2 + xuanze3% + duoxuan1% + duoxuan2% + duoxuan3% + panduan2% + panduan1%
        'MsgBox(sum)
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged,
        CheckBox1.CheckedChanged,
        CheckBox4.CheckedChanged,
        CheckBox3.CheckedChanged
        If CheckBox2.Checked = True And CheckBox3.Checked = True Then
            duoxuan1 = 20
        Else
            duoxuan1 = 0
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged,
        CheckBox6.CheckedChanged,
        CheckBox5.CheckedChanged,
        CheckBox7.CheckedChanged
        If CheckBox5.Checked = True And CheckBox6.Checked = True And CheckBox7.Checked = True And CheckBox8.Checked = True Then
            duoxuan2 = 20
        Else
            duoxuan2 = 0
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged,
        CheckBox9.CheckedChanged,
        CheckBox10.CheckedChanged,
        CheckBox11.CheckedChanged
        If CheckBox9.Checked = True And CheckBox10.Checked = True And CheckBox11.Checked = True Then
            xuanze3 = 20
        Else
            xuanze3 = 0
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged,
        RadioButton4.CheckedChanged,
        RadioButton3.CheckedChanged,
        RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            xuanze1 = 0
        End If
        If RadioButton2.Checked = True Then
            xuanze1 = 10
        End If
        If RadioButton4.Checked = True Then
            xuanze1 = 0
        End If
        If RadioButton3.Checked = True Then
            xuanze1 = 0
        End If
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged,
        RadioButton5.CheckedChanged,
        RadioButton6.CheckedChanged,
        RadioButton8.CheckedChanged
        If RadioButton5.Checked = True Then
            xuanze2 = 0
        End If
        If RadioButton6.Checked = True Then
            xuanze2 = 10
        End If
        If RadioButton7.Checked = True Then
            xuanze2 = 0
        End If
        If RadioButton8.Checked = True Then
            xuanze2 = 0
        End If
    End Sub
    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged,
        RadioButton10.CheckedChanged,
        RadioButton11.CheckedChanged,
        RadioButton12.CheckedChanged
        If RadioButton9.Checked = True Then
            xuanze3 = 10
        End If
        If RadioButton10.Checked = True Then
            xuanze3 = 0
        End If
        If RadioButton11.Checked = True Then
            xuanze3 = 0
        End If
        If RadioButton12.Checked = True Then
            xuanze3 = 0
        End If

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton13.CheckedChanged,
        RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            panduan1 = 5
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton16.CheckedChanged,
        RadioButton15.CheckedChanged
        If RadioButton16.Checked = True Then
            panduan2 = 5
        End If
    End Sub
End Class