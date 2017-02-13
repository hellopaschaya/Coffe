<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCus
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
        Me.btToHome = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvShowCus = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvShowCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btToHome
        '
        Me.btToHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btToHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btToHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btToHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btToHome.Image = Global.CoffeShop.My.Resources.Resources.ic_arrow_back_black_24dp_1x
        Me.btToHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btToHome.Location = New System.Drawing.Point(442, 237)
        Me.btToHome.Name = "btToHome"
        Me.btToHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btToHome.Size = New System.Drawing.Size(166, 60)
        Me.btToHome.TabIndex = 18
        Me.btToHome.Text = "ไปยังหน้าหลัก"
        Me.btToHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btToHome.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btSearch)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbShowID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(668, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 88)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาลูกค้า"
        '
        'btSearch
        '
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSearch.Location = New System.Drawing.Point(342, 33)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(95, 30)
        Me.btSearch.TabIndex = 4
        Me.btSearch.Tag = "4"
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รหัสลูกค้า"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbShowID
        '
        Me.tbShowID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShowID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbShowID.Location = New System.Drawing.Point(137, 33)
        Me.tbShowID.Multiline = True
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(170, 30)
        Me.tbShowID.TabIndex = 1
        Me.tbShowID.Tag = ""
        Me.tbShowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btUpdate)
        Me.GroupBox1.Controls.Add(Me.btDelete)
        Me.GroupBox1.Controls.Add(Me.btToHome)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btSave)
        Me.GroupBox1.Controls.Add(Me.tbTel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(581, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 311)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพิ่มเมนูสินค้า"
        '
        'btUpdate
        '
        Me.btUpdate.Enabled = False
        Me.btUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btUpdate.Location = New System.Drawing.Point(397, 39)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(95, 30)
        Me.btUpdate.TabIndex = 7
        Me.btUpdate.Text = "อัพเดท"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Enabled = False
        Me.btDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btDelete.Location = New System.Drawing.Point(285, 39)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(95, 30)
        Me.btDelete.TabIndex = 6
        Me.btDelete.Text = "ลบ"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'tbID
        '
        Me.tbID.Enabled = False
        Me.tbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbID.Location = New System.Drawing.Point(173, 92)
        Me.tbID.Multiline = True
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(131, 30)
        Me.tbID.TabIndex = 12
        Me.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btAdd.Location = New System.Drawing.Point(173, 39)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(95, 30)
        Me.btAdd.TabIndex = 5
        Me.btAdd.Text = "เพิ่ม"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 30)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "รหัสลูกค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCancel.Location = New System.Drawing.Point(245, 237)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(95, 30)
        Me.btCancel.TabIndex = 16
        Me.btCancel.Text = "ยกเลิก"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Enabled = False
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSave.Location = New System.Drawing.Point(135, 237)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(95, 30)
        Me.btSave.TabIndex = 15
        Me.btSave.Text = "บันทึกรายการ"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'tbTel
        '
        Me.tbTel.Enabled = False
        Me.tbTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTel.Location = New System.Drawing.Point(173, 174)
        Me.tbTel.MaxLength = 10
        Me.tbTel.Multiline = True
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(167, 30)
        Me.tbTel.TabIndex = 14
        Me.tbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "บาท"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เบอร์โทร"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbName
        '
        Me.tbName.Enabled = False
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbName.Location = New System.Drawing.Point(173, 128)
        Me.tbName.Multiline = True
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(261, 30)
        Me.tbName.TabIndex = 13
        Me.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ชื่อลูกค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvShowCus
        '
        Me.dgvShowCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvShowCus.EnableHeadersVisualStyles = False
        Me.dgvShowCus.Location = New System.Drawing.Point(12, 143)
        Me.dgvShowCus.Name = "dgvShowCus"
        Me.dgvShowCus.ReadOnly = True
        Me.dgvShowCus.Size = New System.Drawing.Size(544, 405)
        Me.dgvShowCus.TabIndex = 25
        Me.dgvShowCus.TabStop = False
        '
        'ManageCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvShowCus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "ManageCus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ManageCus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvShowCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btToHome As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbShowID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents tbTel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvShowCus As System.Windows.Forms.DataGridView
End Class
