Public Class Form1
    Dim ButtonClickCount = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ButtonClickCount += 1

		If ButtonClickCount = 1 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Red
			display_e.BackColor = Color.Red
			display_f.BackColor = Color.Red
			display_g.BackColor = Color.Gray
			rb0.Checked = True

		ElseIf ButtonClickCount = 2 Then
			display_a.BackColor = Color.Gray
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Gray
			display_e.BackColor = Color.Gray
			display_f.BackColor = Color.Gray
			display_g.BackColor = Color.Gray
			rb1.Checked = True

		ElseIf ButtonClickCount = 3 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Gray
			display_d.BackColor = Color.Red
			display_e.BackColor = Color.Red
			display_f.BackColor = Color.Gray
			display_g.BackColor = Color.Red
			rb2.Checked = True

		ElseIf ButtonClickCount = 4 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Red
			display_e.BackColor = Color.Gray
			display_f.BackColor = Color.Gray
			display_g.BackColor = Color.Red
			rb3.Checked = True

		ElseIf ButtonClickCount = 5 Then
			display_a.BackColor = Color.Gray
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Gray
			display_e.BackColor = Color.Gray
			display_f.BackColor = Color.Red
			display_g.BackColor = Color.Red
			rb4.Checked = True

		ElseIf ButtonClickCount = 6 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Gray
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Red
			display_e.BackColor = Color.Gray
			display_f.BackColor = Color.Red
			display_g.BackColor = Color.Red
			rb5.Checked = True

		ElseIf ButtonClickCount = 7 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Gray
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Red
			display_e.BackColor = Color.Red
			display_f.BackColor = Color.Red
			display_g.BackColor = Color.Red
			rb6.Checked = True

		ElseIf ButtonClickCount = 8 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Gray
			display_e.BackColor = Color.Gray
			display_f.BackColor = Color.Gray
			display_g.BackColor = Color.Gray
			rb7.Checked = True

		ElseIf ButtonClickCount = 9 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Red
			display_e.BackColor = Color.Red
			display_f.BackColor = Color.Red
			display_g.BackColor = Color.Red
			rb8.Checked = True

		ElseIf ButtonClickCount = 10 Then
			display_a.BackColor = Color.Red
			display_b.BackColor = Color.Red
			display_c.BackColor = Color.Red
			display_d.BackColor = Color.Gray
			display_e.BackColor = Color.Gray
			display_f.BackColor = Color.Red
			display_g.BackColor = Color.Red
			rb9.Checked = True

		End If
	End Sub
End Class
