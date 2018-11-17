Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        right_move.Interval = 500
        left_move.Interval = 500
        top_move.Interval = 500
        down_move.Interval = 500
        crash.Interval = 100
        crash.Enabled = True
        BelingBeling1.Interval = 300
        PictureBox1.Visible = False
        Button1.Text = "右移"
        Button2.Text = "左移"
        Button4.Text = "上移"
        Button3.Text = "下移"
        PictureBox1.Size = New Size(80, 80)
        PictureBox2.Size = New Size(80, 80)
        PictureBox1.Image = System.Drawing.Image.FromFile("../fly2.png")
        PictureBox2.Image = System.Drawing.Image.FromFile("../fly1.png")
        Me.BackColor = Color.White
        Button5.Text = "快速"
        Button6.Text = "慢速"
    End Sub
    Dim P_right_move%
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right_move.Tick '向右移
        P_right_move = 6
        PictureBox1.Location = New Point(PictureBox1.Location.X + P_right_move, PictureBox1.Location.Y)
        PictureBox2.Location = New Point(PictureBox2.Location.X + P_right_move, PictureBox2.Location.Y)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click '向右移__定时器
        right_move.Enabled = Not right_move.Enabled
        left_move.Enabled = False
        top_move.Enabled = False
        down_move.Enabled = False
        BelingBeling1.Enabled = True
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BelingBeling1.Tick '闪烁
        PictureBox2.Visible = Not PictureBox2.Visible
        PictureBox1.Visible = Not PictureBox1.Visible
    End Sub
    Dim P_left_move%
    Private Sub left_move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles left_move.Tick '向左移
        P_left_move = 6
        PictureBox1.Location = New Point(PictureBox1.Location.X - P_left_move, PictureBox1.Location.Y)
        PictureBox2.Location = New Point(PictureBox2.Location.X - P_left_move, PictureBox2.Location.Y)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click '向左移__定时器
        left_move.Enabled = Not left_move.Enabled
        right_move.Enabled = False
        top_move.Enabled = False
        down_move.Enabled = False
        BelingBeling1.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click '向上移
        top_move.Enabled = Not top_move.Enabled
        right_move.Enabled = False
        left_move.Enabled = False
        down_move.Enabled = False
        BelingBeling1.Enabled = True
    End Sub
    Dim P_top_move%
    Private Sub top_move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles top_move.Tick '向上移__定时器
        P_top_move = 6
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - P_top_move)
        PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y - P_top_move)
    End Sub
    Dim P_down_move%
    Private Sub down_move_Tick(sender As System.Object, e As System.EventArgs) Handles down_move.Tick '向下移_定时器
        P_down_move = 6
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + P_down_move)
        PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y + P_down_move)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click '向下移
        down_move.Enabled = Not down_move.Enabled
        right_move.Enabled = False
        left_move.Enabled = False
        top_move.Enabled = False
        BelingBeling1.Enabled = True
    End Sub

    Private Sub crash_Tick(sender As System.Object, e As System.EventArgs) Handles crash.Tick
        If PictureBox1.Location.X < 0 Or PictureBox1.Location.X > Me.Size.Width - PictureBox1.Size.Width Or
          PictureBox1.Location.Y < 0 Or PictureBox1.Location.Y > Me.Size.Height - PictureBox1.Size.Height Then
            PictureBox1.Location = New Point(Rnd() * Me.Size.Width - PictureBox1.Size.Width, Rnd() * Me.Size.Height - PictureBox1.Size.Height)
            PictureBox2.Location = PictureBox1.Location
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        right_move.Interval = 100
        left_move.Interval = 100
        top_move.Interval = 100
        down_move.Interval = 100
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        right_move.Interval = 1000
        left_move.Interval = 1000
        top_move.Interval = 1000
        down_move.Interval = 1000
    End Sub
End Class
