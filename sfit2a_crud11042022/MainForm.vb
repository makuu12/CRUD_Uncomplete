Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class MainForm
    Dim theme As New theme



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchpanel(Form1)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Dark" Then
            Dim theme As New Colorfunction
            theme.Form1_darktheme()
        Else
            Form1.Panel1.BackColor = Color.FromArgb(25, 25, 25)
            Form1.TextBox1.BackColor = Color.FromArgb(25, 25, 25)
            Form1.TextBox1.ForeColor = Color.White
            Form1.TextBox2.BackColor = Color.FromArgb(25, 25, 25)
            Form1.TextBox2.ForeColor = Color.White
            Form1.TextBox3.BackColor = Color.FromArgb(25, 25, 25)
            Form1.TextBox3.ForeColor = Color.White
            Form1.TextBox4.BackColor = Color.FromArgb(25, 25, 25)
            Form1.TextBox4.ForeColor = Color.White
            Form1.ComboBox1.BackColor = Color.FromArgb(25, 25, 25)
            Form1.ComboBox1.ForeColor = Color.White
            Form1.ComboBox2.BackColor = Color.FromArgb(25, 25, 25)
            Form1.ComboBox2.ForeColor = Color.White
            Form1.Button1.BackColor = Color.FromArgb(25, 25, 25)
            Form1.Button1.ForeColor = Color.White
            Form1.update.BackColor = Color.FromArgb(25, 25, 25)
            Form1.update.ForeColor = Color.White
            Form1.delete.BackColor = Color.FromArgb(25, 25, 25)
            Form1.delete.ForeColor = Color.White
            Form1.search.BackColor = Color.FromArgb(25, 25, 25)
            Form1.search.ForeColor = Color.White
            Form1.Label1.BackColor = Color.FromArgb(25, 25, 25)
            Form1.Label2.BackColor = Color.FromArgb(25, 25, 25)
            Form1.Label3.BackColor = Color.FromArgb(25, 25, 25)
            Form1.Label4.BackColor = Color.FromArgb(25, 25, 25)
            Form1.Label5.BackColor = Color.FromArgb(25, 25, 25)
            Form1.Label1.ForeColor = Color.White
            Form1.Label2.ForeColor = Color.White
            Form1.Label3.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Panel2.BackColor = Color.FromArgb(58, 56, 69)
            Button1.BackColor = Color.FromArgb(58, 56, 69)
            Button2.BackColor = Color.FromArgb(58, 56, 69)
            Button3.BackColor = Color.FromArgb(58, 56, 69)
            Button4.BackColor = Color.FromArgb(58, 56, 69)
            Button1.ForeColor = Color.White
            Button2.ForeColor = Color.White
            Button3.ForeColor = Color.White
            Button4.ForeColor = Color.White
            Button4.Text = "Dark"

        End If

    End Sub




    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    If Button4.Text = "Dark" Then
    '        Dim buttons As Boolean = True
    '        theme.nightheme(buttons)
    '    End If
    'End Sub
End Class
Public Class Colorfunction
    Sub Form1_darktheme()
        Form1.Panel1.BackColor = Color.FromArgb(25, 25, 25)
        Form1.TextBox1.BackColor = Color.FromArgb(25, 25, 25)
        Form1.TextBox1.ForeColor = Color.White
        Form1.TextBox2.BackColor = Color.FromArgb(25, 25, 25)
        Form1.TextBox2.ForeColor = Color.White
        Form1.TextBox3.BackColor = Color.FromArgb(25, 25, 25)
        Form1.TextBox3.ForeColor = Color.White
        Form1.TextBox4.BackColor = Color.FromArgb(25, 25, 25)
        Form1.TextBox4.ForeColor = Color.White
        Form1.ComboBox1.BackColor = Color.FromArgb(25, 25, 25)
        Form1.ComboBox1.ForeColor = Color.White
        Form1.ComboBox2.BackColor = Color.FromArgb(25, 25, 25)
        Form1.ComboBox2.ForeColor = Color.White
        Form1.Button1.BackColor = Color.FromArgb(25, 25, 25)
        Form1.Button1.ForeColor = Color.White
        Form1.update.BackColor = Color.FromArgb(25, 25, 25)
        Form1.update.ForeColor = Color.White
        Form1.delete.BackColor = Color.FromArgb(25, 25, 25)
        Form1.delete.ForeColor = Color.White
        Form1.search.BackColor = Color.FromArgb(25, 25, 25)
        Form1.search.ForeColor = Color.White
        Form1.Label1.BackColor = Color.FromArgb(25, 25, 25)
        Form1.Label2.BackColor = Color.FromArgb(25, 25, 25)
        Form1.Label3.BackColor = Color.FromArgb(25, 25, 25)
        Form1.Label4.BackColor = Color.FromArgb(25, 25, 25)
        Form1.Label5.BackColor = Color.FromArgb(25, 25, 25)
        Form1.Label1.ForeColor = Color.White
        Form1.Label2.ForeColor = Color.White
        Form1.Label3.ForeColor = Color.White
        Form1.Label4.ForeColor = Color.White
        Form1.Label5.ForeColor = Color.White
        MainForm.Panel2.BackColor = Color.FromArgb(58, 56, 69)
        MainForm.Button1.BackColor = Color.FromArgb(58, 56, 69)
        MainForm.Button2.BackColor = Color.FromArgb(58, 56, 69)
        MainForm.Button3.BackColor = Color.FromArgb(58, 56, 69)
        MainForm.Button4.BackColor = Color.FromArgb(58, 56, 69)
        MainForm.Button1.ForeColor = Color.White
        MainForm.Button2.ForeColor = Color.White
        MainForm.Button3.ForeColor = Color.White
        MainForm.Button4.ForeColor = Color.White
        MainForm.Button4.Text = "Light"
    End Sub
End Class
