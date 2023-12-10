<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Location = New System.Drawing.Point(539, 155)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(129, 39)
        Me.delete.TabIndex = 29
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update.Location = New System.Drawing.Point(539, 87)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(129, 39)
        Me.update.TabIndex = 28
        Me.update.Text = "UPDATE"
        Me.update.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(140, 29)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(364, 26)
        Me.TextBox4.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(307, 236)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(197, 26)
        Me.TextBox3.TabIndex = 25
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search.Location = New System.Drawing.Point(539, 229)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(129, 41)
        Me.search.TabIndex = 24
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(539, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 39)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(661, 371)
        Me.DataGridView1.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(140, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(364, 28)
        Me.ComboBox1.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(364, 26)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(364, 26)
        Me.TextBox1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "GENDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "LAST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FIRST NAME"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 670)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents search As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
