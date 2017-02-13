<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageMenu
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
        Me.dgvShowDrink = New System.Windows.Forms.DataGridView()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTypeMenu = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.rdbSpin = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdbCool = New System.Windows.Forms.RadioButton()
        Me.rdbHot = New System.Windows.Forms.RadioButton()
        Me.btToHome = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvShowOther = New System.Windows.Forms.DataGridView()
        Me.aa = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.rdbSD = New System.Windows.Forms.RadioButton()
        Me.rdbSO = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvShowDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvShowOther, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShowDrink
        '
        Me.dgvShowDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowDrink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvShowDrink.Location = New System.Drawing.Point(12, 84)
        Me.dgvShowDrink.Name = "dgvShowDrink"
        Me.dgvShowDrink.Size = New System.Drawing.Size(603, 266)
        Me.dgvShowDrink.TabIndex = 18
        Me.dgvShowDrink.TabStop = False
        '
        'btSave
        '
        Me.btSave.Enabled = False
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSave.Location = New System.Drawing.Point(138, 317)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(95, 30)
        Me.btSave.TabIndex = 15
        Me.btSave.Text = "บันทึกรายการ"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ประเภทสินค้า"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbName
        '
        Me.tbName.Enabled = False
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbName.Location = New System.Drawing.Point(176, 208)
        Me.tbName.Multiline = True
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(261, 30)
        Me.tbName.TabIndex = 13
        Me.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ชื่อสินค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbTypeMenu
        '
        Me.cbTypeMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeMenu.Enabled = False
        Me.cbTypeMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTypeMenu.FormattingEnabled = True
        Me.cbTypeMenu.Location = New System.Drawing.Point(174, 119)
        Me.cbTypeMenu.Name = "cbTypeMenu"
        Me.cbTypeMenu.Size = New System.Drawing.Size(131, 33)
        Me.cbTypeMenu.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btUpdate)
        Me.GroupBox1.Controls.Add(Me.btDelete)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.rdbSpin)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rdbCool)
        Me.GroupBox1.Controls.Add(Me.rdbHot)
        Me.GroupBox1.Controls.Add(Me.btToHome)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.cbTypeMenu)
        Me.GroupBox1.Controls.Add(Me.btSave)
        Me.GroupBox1.Controls.Add(Me.tbPrice)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(621, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 387)
        Me.GroupBox1.TabIndex = 20
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
        Me.tbID.Location = New System.Drawing.Point(176, 172)
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
        'rdbSpin
        '
        Me.rdbSpin.AutoSize = True
        Me.rdbSpin.Enabled = False
        Me.rdbSpin.Location = New System.Drawing.Point(616, 123)
        Me.rdbSpin.Name = "rdbSpin"
        Me.rdbSpin.Size = New System.Drawing.Size(57, 29)
        Me.rdbSpin.TabIndex = 11
        Me.rdbSpin.Text = "ปั่น"
        Me.rdbSpin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 30)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "รหัสสินค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbCool
        '
        Me.rdbCool.AutoSize = True
        Me.rdbCool.Enabled = False
        Me.rdbCool.Location = New System.Drawing.Point(492, 123)
        Me.rdbCool.Name = "rdbCool"
        Me.rdbCool.Size = New System.Drawing.Size(63, 29)
        Me.rdbCool.TabIndex = 10
        Me.rdbCool.Text = "เย็น"
        Me.rdbCool.UseVisualStyleBackColor = True
        '
        'rdbHot
        '
        Me.rdbHot.AutoSize = True
        Me.rdbHot.Checked = True
        Me.rdbHot.Enabled = False
        Me.rdbHot.Location = New System.Drawing.Point(370, 123)
        Me.rdbHot.Name = "rdbHot"
        Me.rdbHot.Size = New System.Drawing.Size(67, 29)
        Me.rdbHot.TabIndex = 9
        Me.rdbHot.TabStop = True
        Me.rdbHot.Text = "ร้อน"
        Me.rdbHot.UseVisualStyleBackColor = True
        '
        'btToHome
        '
        Me.btToHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btToHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btToHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btToHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btToHome.Image = Global.CoffeShop.My.Resources.Resources.ic_arrow_back_black_24dp_1x
        Me.btToHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btToHome.Location = New System.Drawing.Point(530, 317)
        Me.btToHome.Name = "btToHome"
        Me.btToHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btToHome.Size = New System.Drawing.Size(166, 60)
        Me.btToHome.TabIndex = 17
        Me.btToHome.Text = "ไปยังหน้าหลัก"
        Me.btToHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btToHome.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCancel.Location = New System.Drawing.Point(248, 317)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(95, 30)
        Me.btCancel.TabIndex = 16
        Me.btCancel.Text = "ยกเลิก"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'tbPrice
        '
        Me.tbPrice.Enabled = False
        Me.tbPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbPrice.Location = New System.Drawing.Point(176, 254)
        Me.tbPrice.MaxLength = 10
        Me.tbPrice.Multiline = True
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(167, 30)
        Me.tbPrice.TabIndex = 14
        Me.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(371, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "บาท"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ราคา"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รหัสสินค้า"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvShowOther
        '
        Me.dgvShowOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvShowOther.Location = New System.Drawing.Point(6, 408)
        Me.dgvShowOther.Name = "dgvShowOther"
        Me.dgvShowOther.Size = New System.Drawing.Size(609, 266)
        Me.dgvShowOther.TabIndex = 19
        Me.dgvShowOther.TabStop = False
        '
        'aa
        '
        Me.aa.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.aa.Location = New System.Drawing.Point(251, 375)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(116, 30)
        Me.aa.TabIndex = 22
        Me.aa.Text = "รายการอื่นๆ"
        Me.aa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 30)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "เครื่องดื่ม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btSearch
        '
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSearch.Location = New System.Drawing.Point(563, 33)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(95, 30)
        Me.btSearch.TabIndex = 4
        Me.btSearch.Tag = "4"
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btSearch)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbShowID)
        Me.GroupBox2.Controls.Add(Me.rdbSD)
        Me.GroupBox2.Controls.Add(Me.rdbSO)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(621, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(702, 88)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหารหัสสินค้า"
        '
        'tbShowID
        '
        Me.tbShowID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShowID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbShowID.Location = New System.Drawing.Point(137, 33)
        Me.tbShowID.Multiline = True
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(131, 30)
        Me.tbShowID.TabIndex = 1
        Me.tbShowID.Tag = ""
        Me.tbShowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdbSD
        '
        Me.rdbSD.AutoSize = True
        Me.rdbSD.Checked = True
        Me.rdbSD.Location = New System.Drawing.Point(299, 34)
        Me.rdbSD.Name = "rdbSD"
        Me.rdbSD.Size = New System.Drawing.Size(109, 29)
        Me.rdbSD.TabIndex = 2
        Me.rdbSD.TabStop = True
        Me.rdbSD.Tag = ""
        Me.rdbSD.Text = "เครื่องดื่ม"
        Me.rdbSD.UseVisualStyleBackColor = True
        '
        'rdbSO
        '
        Me.rdbSO.AutoSize = True
        Me.rdbSO.Location = New System.Drawing.Point(440, 33)
        Me.rdbSO.Name = "rdbSO"
        Me.rdbSO.Size = New System.Drawing.Size(69, 29)
        Me.rdbSO.TabIndex = 3
        Me.rdbSO.TabStop = True
        Me.rdbSO.Tag = ""
        Me.rdbSO.Text = "อื่นๆ"
        Me.rdbSO.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(859, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 48)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Coffe Shop"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1348, 48)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Welcome To My Shop"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.CoffeShop.My.Resources.Resources.Cafe_96
        Me.PictureBox2.Location = New System.Drawing.Point(1090, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(232, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.CoffeShop.My.Resources.Resources.Cafe_96
        Me.PictureBox1.Location = New System.Drawing.Point(621, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ManageMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvShowOther)
        Me.Controls.Add(Me.dgvShowDrink)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.aa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "ManageMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageCoffe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvShowDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvShowOther, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvShowDrink As System.Windows.Forms.DataGridView
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTypeMenu As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents tbPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbSpin As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCool As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHot As System.Windows.Forms.RadioButton
    Friend WithEvents dgvShowOther As System.Windows.Forms.DataGridView
    Friend WithEvents aa As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbShowID As System.Windows.Forms.TextBox
    Friend WithEvents rdbSD As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSO As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btToHome As System.Windows.Forms.Button
End Class
