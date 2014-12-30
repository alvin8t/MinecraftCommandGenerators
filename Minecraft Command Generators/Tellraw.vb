Public Class Tellraw

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True
            ComboBox1.Enabled = True
            ComboBox6.Enabled = True
            ComboBox11.Enabled = True
        Else
            TextBox1.Enabled = False
            ComboBox1.Enabled = False
            ComboBox6.Enabled = False
            ComboBox11.Enabled = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = True
            ComboBox2.Enabled = True
            ComboBox7.Enabled = True
            ComboBox12.Enabled = True
        Else
            TextBox2.Enabled = False
            ComboBox2.Enabled = False
            ComboBox7.Enabled = False
            ComboBox12.Enabled = False

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.Enabled = True
            ComboBox3.Enabled = True
            ComboBox8.Enabled = True
            ComboBox13.Enabled = True
        Else
            TextBox3.Enabled = False
            ComboBox3.Enabled = False
            ComboBox8.Enabled = False
            ComboBox13.Enabled = False

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox4.Enabled = True
            ComboBox4.Enabled = True
            ComboBox9.Enabled = True
            ComboBox14.Enabled = True
        Else
            TextBox4.Enabled = False
            ComboBox4.Enabled = False
            ComboBox9.Enabled = False
            ComboBox14.Enabled = False

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox5.Enabled = True
            ComboBox10.Enabled = True
            ComboBox5.Enabled = True
            ComboBox15.Enabled = True
        Else
            TextBox5.Enabled = False
            ComboBox5.Enabled = False
            ComboBox10.Enabled = False
            ComboBox15.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = "{text:" & TextBox12.Text & TextBox1.Text & TextBox12.Text & ",color:" & ComboBox1.SelectedItem & ",bold:" & ComboBox6.SelectedItem & ",underlined:" & ComboBox11.SelectedItem & "}"
        TextBox8.Text = ",{text:" & TextBox12.Text & TextBox2.Text & TextBox12.Text & ",color:" & ComboBox2.SelectedItem & ",bold:" & ComboBox7.SelectedItem & ",underlined:" & ComboBox12.SelectedItem & "}"

        TextBox6.Text = TextBox13.Text & TextBox7.Text & TextBox8.Text & TextBox9.Text & TextBox10.Text & TextBox11.Text & TextBox14.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        CheckBox1.Checked = True
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        TextBox6.Text = ""
        ComboBox1.SelectedItem = "white"
        ComboBox2.SelectedItem = "white"
        ComboBox3.SelectedItem = "white"
        ComboBox4.SelectedItem = "white"
        ComboBox5.SelectedItem = "white"
        ComboBox6.SelectedItem = "false"
        ComboBox7.SelectedItem = "false"
        ComboBox8.SelectedItem = "false"
        ComboBox9.SelectedItem = "false"
        ComboBox10.SelectedItem = "false"
        ComboBox11.SelectedItem = "false"
        ComboBox12.SelectedItem = "false"
        ComboBox13.SelectedItem = "false"
        ComboBox14.SelectedItem = "false"
        ComboBox15.SelectedItem = "false"

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
        Else
            TextBox7.Visible = False
            TextBox8.Visible = False
            TextBox9.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
        End If
    End Sub

    Private Sub Tellraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class