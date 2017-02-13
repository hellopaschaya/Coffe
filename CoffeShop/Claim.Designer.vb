<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Claim
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btToHome = New System.Windows.Forms.Button()
        Me.cbShowFree = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btUseFree = New System.Windows.Forms.Button()
        Me.nudUnit = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("AngsanaUPC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1348, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coffe Shop"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btToHome
        '
        Me.btToHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btToHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btToHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btToHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btToHome.Image = Global.CoffeShop.My.Resources.Resources.ic_arrow_back_black_24dp_1x
        Me.btToHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btToHome.Location = New System.Drawing.Point(893, 285)
        Me.btToHome.Name = "btToHome"
        Me.btToHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btToHome.Size = New System.Drawing.Size(166, 60)
        Me.btToHome.TabIndex = 18
        Me.btToHome.Text = "ไปยังหน้าหลัก"
        Me.btToHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btToHome.UseVisualStyleBackColor = False
        '
        'cbShowFree
        '
        Me.cbShowFree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShowFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbShowFree.FormattingEnabled = True
        Me.cbShowFree.Location = New System.Drawing.Point(576, 158)
        Me.cbShowFree.Name = "cbShowFree"
        Me.cbShowFree.Size = New System.Drawing.Size(203, 33)
        Me.cbShowFree.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(378, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 30)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ลูกค้าที่ได้สิทธิ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "จำนวน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(785, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "สิทธิ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btUseFree
        '
        Me.btUseFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btUseFree.Location = New System.Drawing.Point(576, 264)
        Me.btUseFree.Name = "btUseFree"
        Me.btUseFree.Size = New System.Drawing.Size(203, 35)
        Me.btUseFree.TabIndex = 22
        Me.btUseFree.Text = "ใช้สิทธิ"
        Me.btUseFree.UseVisualStyleBackColor = True
        '
        'nudUnit
        '
        Me.nudUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.nudUnit.Location = New System.Drawing.Point(576, 212)
        Me.nudUnit.Name = "nudUnit"
        Me.nudUnit.Size = New System.Drawing.Size(203, 31)
        Me.nudUnit.TabIndex = 23
        '
        'Claim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 669)
        Me.ControlBox = False
        Me.Controls.Add(Me.nudUnit)
        Me.Controls.Add(Me.btUseFree)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbShowFree)
        Me.Controls.Add(Me.btToHome)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("AngsanaUPC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MinimizeBox = False
        Me.Name = "Claim"
        Me.Text = "Claim"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nudUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btToHome As System.Windows.Forms.Button
    Friend WithEvents cbShowFree As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btUseFree As System.Windows.Forms.Button
    Friend WithEvents nudUnit As System.Windows.Forms.NumericUpDown

End Class
