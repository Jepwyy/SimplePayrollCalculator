Public Class Form1
    Dim ans As Integer
    Dim deduc As Integer
    Dim tax As Integer
    Dim phil As Integer
    Dim s As Integer
    Dim net As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans = ((TextBox2.Text * TextBox3.Text) * (TextBox1.Text))
        TextBox4.Text = ans
        TextBox9.Text = ans

        tax = ans * 0.15
        TextBox5.Text = tax
        phil = ans * 0.05
        TextBox6.Text = phil
        s = ans * 0.02
        TextBox7.Text = s
        deduc = tax + phil + s
        TextBox8.Text = deduc
        TextBox10.Text = deduc

        net = TextBox9.Text - TextBox10.Text
        TextBox11.Text = net
    End Sub
End Class