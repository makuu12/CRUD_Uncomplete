<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FIRST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LAST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "COURSE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(364, 26)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(135, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(364, 26)
        Me.TextBox2.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(364, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(534, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(129, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search.Location = New System.Drawing.Point(534, 239)
        Me.search.Name = "search"
        Me.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.search.Size = New System.Drawing.Size(129, 41)
        Me.search.TabIndex = 8
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(302, 246)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(197, 26)
        Me.TextBox3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(135, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox4.Size = New System.Drawing.Size(364, 26)
        Me.TextBox4.TabIndex = 11
        '
        'update
        '
        Me.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update.Location = New System.Drawing.Point(534, 97)
        Me.update.Name = "update"
        Me.update.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.update.Size = New System.Drawing.Size(129, 39)
        Me.update.TabIndex = 12
        Me.update.Text = "UPDATE"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Location = New System.Drawing.Point(534, 165)
        Me.delete.Name = "delete"
        Me.delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.delete.Size = New System.Drawing.Size(129, 39)
        Me.delete.TabIndex = 13
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SECTION"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {""})
        Me.ComboBox2.Location = New System.Drawing.Point(135, 170)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(364, 28)
        Me.ComboBox2.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(680, 670)
        Me.Panel1.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(661, 371)
        Me.DataGridView1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 670)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents search As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
