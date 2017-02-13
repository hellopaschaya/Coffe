<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApplication))
        Me.lvCal = New System.Windows.Forms.ListView()
        Me.dgvShowOther = New System.Windows.Forms.DataGridView()
        Me.dgvShowDrink = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.aa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbShowSum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbShowM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbFree1 = New System.Windows.Forms.Label()
        Me.tbFree = New System.Windows.Forms.TextBox()
        Me.lbFree2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbToManage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbClaim = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbManageCus = New System.Windows.Forms.ToolStripButton()
        Me.btCal = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbShowDC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbSumTotal = New System.Windows.Forms.TextBox()
        Me.pbFree = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvShowOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvShowDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCal
        '
        Me.lvCal.Location = New System.Drawing.Point(12, 437)
        Me.lvCal.Name = "lvCal"
        Me.lvCal.Size = New System.Drawing.Size(922, 250)
        Me.lvCal.TabIndex = 10
        Me.lvCal.UseCompatibleStateImageBehavior = False
        '
        'dgvShowOther
        '
        Me.dgvShowOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvShowOther.EnableHeadersVisualStyles = False
        Me.dgvShowOther.Location = New System.Drawing.Point(676, 113)
        Me.dgvShowOther.Name = "dgvShowOther"
        Me.dgvShowOther.Size = New System.Drawing.Size(660, 266)
        Me.dgvShowOther.TabIndex = 25
        Me.dgvShowOther.TabStop = False
        '
        'dgvShowDrink
        '
        Me.dgvShowDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowDrink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvShowDrink.EnableHeadersVisualStyles = False
        Me.dgvShowDrink.Location = New System.Drawing.Point(12, 113)
        Me.dgvShowDrink.Name = "dgvShowDrink"
        Me.dgvShowDrink.ReadOnly = True
        Me.dgvShowDrink.Size = New System.Drawing.Size(658, 266)
        Me.dgvShowDrink.TabIndex = 24
        Me.dgvShowDrink.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 30)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "เครื่องดื่ม"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'aa
        '
        Me.aa.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.aa.Location = New System.Drawing.Point(972, 80)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(116, 30)
        Me.aa.TabIndex = 26
        Me.aa.Text = "รายการอื่นๆ"
        Me.aa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(950, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 30)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "รวมทั้งหมด"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbShowSum
        '
        Me.tbShowSum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShowSum.Enabled = False
        Me.tbShowSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbShowSum.Location = New System.Drawing.Point(1064, 437)
        Me.tbShowSum.Multiline = True
        Me.tbShowSum.Name = "tbShowSum"
        Me.tbShowSum.Size = New System.Drawing.Size(131, 30)
        Me.tbShowSum.TabIndex = 29
        Me.tbShowSum.Tag = ""
        Me.tbShowSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(1201, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 30)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "แก้ว"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(950, 484)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 30)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ราคารวม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbShowM
        '
        Me.tbShowM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShowM.Enabled = False
        Me.tbShowM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbShowM.Location = New System.Drawing.Point(1064, 484)
        Me.tbShowM.Multiline = True
        Me.tbShowM.Name = "tbShowM"
        Me.tbShowM.Size = New System.Drawing.Size(131, 30)
        Me.tbShowM.TabIndex = 29
        Me.tbShowM.Tag = ""
        Me.tbShowM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(1201, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 30)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "บาท"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(498, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 30)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "(ครบ10แก้ว ฟรี1แก้ว)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFree1
        '
        Me.lbFree1.BackColor = System.Drawing.SystemColors.Control
        Me.lbFree1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFree1.Location = New System.Drawing.Point(950, 530)
        Me.lbFree1.Name = "lbFree1"
        Me.lbFree1.Size = New System.Drawing.Size(116, 30)
        Me.lbFree1.TabIndex = 28
        Me.lbFree1.Text = "ได้รับฟรี"
        Me.lbFree1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbFree1.Visible = False
        '
        'tbFree
        '
        Me.tbFree.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFree.Enabled = False
        Me.tbFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbFree.Location = New System.Drawing.Point(1064, 530)
        Me.tbFree.Multiline = True
        Me.tbFree.Name = "tbFree"
        Me.tbFree.Size = New System.Drawing.Size(131, 30)
        Me.tbFree.TabIndex = 29
        Me.tbFree.Tag = ""
        Me.tbFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbFree.Visible = False
        '
        'lbFree2
        '
        Me.lbFree2.BackColor = System.Drawing.SystemColors.Control
        Me.lbFree2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFree2.Location = New System.Drawing.Point(1201, 530)
        Me.lbFree2.Name = "lbFree2"
        Me.lbFree2.Size = New System.Drawing.Size(82, 30)
        Me.lbFree2.TabIndex = 28
        Me.lbFree2.Text = "แก้ว"
        Me.lbFree2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbFree2.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbToManage, Me.ToolStripSeparator1, Me.tsbExit, Me.tsbClaim, Me.ToolStripSeparator2, Me.tsbManageCus})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1348, 67)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbToManage
        '
        Me.tsbToManage.BackColor = System.Drawing.SystemColors.Highlight
        Me.tsbToManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbToManage.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbToManage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbToManage.Margin = New System.Windows.Forms.Padding(5)
        Me.tsbToManage.Name = "tsbToManage"
        Me.tsbToManage.Size = New System.Drawing.Size(132, 57)
        Me.tsbToManage.Text = "จัดการสินค้า"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 67)
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbExit.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(175, 64)
        Me.tsbExit.Text = "ออกจากโปรแกรม"
        '
        'tsbClaim
        '
        Me.tsbClaim.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsbClaim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClaim.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbClaim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClaim.Margin = New System.Windows.Forms.Padding(5)
        Me.tsbClaim.Name = "tsbClaim"
        Me.tsbClaim.Size = New System.Drawing.Size(145, 57)
        Me.tsbClaim.Text = "ตรวจสอบสิทธิ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 67)
        '
        'tsbManageCus
        '
        Me.tsbManageCus.BackColor = System.Drawing.Color.Olive
        Me.tsbManageCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbManageCus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbManageCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbManageCus.Margin = New System.Windows.Forms.Padding(5)
        Me.tsbManageCus.Name = "tsbManageCus"
        Me.tsbManageCus.Size = New System.Drawing.Size(185, 57)
        Me.tsbManageCus.Text = "จัดการข้อมูลลูกค้า"
        '
        'btCal
        '
        Me.btCal.BackColor = System.Drawing.Color.Lime
        Me.btCal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCal.Location = New System.Drawing.Point(1001, 584)
        Me.btCal.Name = "btCal"
        Me.btCal.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btCal.Size = New System.Drawing.Size(133, 53)
        Me.btCal.TabIndex = 31
        Me.btCal.Text = "คิดเงิน"
        Me.btCal.UseVisualStyleBackColor = False
        '
        'btClear
        '
        Me.btClear.BackColor = System.Drawing.Color.Silver
        Me.btClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btClear.Location = New System.Drawing.Point(1150, 584)
        Me.btClear.Name = "btClear"
        Me.btClear.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btClear.Size = New System.Drawing.Size(133, 53)
        Me.btClear.TabIndex = 31
        Me.btClear.Text = "ยกเลิก"
        Me.btClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 30)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "เลือกชื่อลูกค้า"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbCus
        '
        Me.cbCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbCus.FormattingEnabled = True
        Me.cbCus.Location = New System.Drawing.Point(149, 398)
        Me.cbCus.Name = "cbCus"
        Me.cbCus.Size = New System.Drawing.Size(240, 33)
        Me.cbCus.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(709, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 30)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "มูลค่า 25 บาท"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(950, 657)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 30)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "ส่วนลด"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(1201, 657)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 30)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "บาท"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbShowDC
        '
        Me.tbShowDC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbShowDC.Enabled = False
        Me.tbShowDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbShowDC.Location = New System.Drawing.Point(1064, 657)
        Me.tbShowDC.Multiline = True
        Me.tbShowDC.Name = "tbShowDC"
        Me.tbShowDC.Size = New System.Drawing.Size(131, 30)
        Me.tbShowDC.TabIndex = 29
        Me.tbShowDC.Tag = ""
        Me.tbShowDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(950, 694)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 30)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "ราคาทั้งหมด"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(1201, 694)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 30)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "บาท"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbSumTotal
        '
        Me.tbSumTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSumTotal.Enabled = False
        Me.tbSumTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbSumTotal.Location = New System.Drawing.Point(1064, 694)
        Me.tbSumTotal.Multiline = True
        Me.tbSumTotal.Name = "tbSumTotal"
        Me.tbSumTotal.Size = New System.Drawing.Size(131, 30)
        Me.tbSumTotal.TabIndex = 29
        Me.tbSumTotal.Tag = ""
        Me.tbSumTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbFree
        '
        Me.pbFree.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbFree.BackgroundImage = Global.CoffeShop.My.Resources.Resources.dot
        Me.pbFree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFree.Enabled = False
        Me.pbFree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pbFree.ForeColor = System.Drawing.Color.Transparent
        Me.pbFree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pbFree.Location = New System.Drawing.Point(282, 5)
        Me.pbFree.Name = "pbFree"
        Me.pbFree.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.pbFree.Size = New System.Drawing.Size(24, 23)
        Me.pbFree.TabIndex = 31
        Me.pbFree.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.CoffeShop.My.Resources.Resources.dot
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-166, -524)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'MainApplication
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbCus)
        Me.Controls.Add(Me.pbFree)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btCal)
        Me.Controls.Add(Me.tbFree)
        Me.Controls.Add(Me.tbShowDC)
        Me.Controls.Add(Me.tbSumTotal)
        Me.Controls.Add(Me.tbShowM)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbShowSum)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbFree2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbFree1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvShowOther)
        Me.Controls.Add(Me.dgvShowDrink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.lvCal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "MainApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainApplication"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvShowOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvShowDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvCal As System.Windows.Forms.ListView
    Friend WithEvents dgvShowOther As System.Windows.Forms.DataGridView
    Friend WithEvents dgvShowDrink As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents aa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbShowSum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbShowM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbFree1 As System.Windows.Forms.Label
    Friend WithEvents tbFree As System.Windows.Forms.TextBox
    Friend WithEvents lbFree2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbToManage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClaim As System.Windows.Forms.ToolStripButton
    Friend WithEvents btCal As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCus As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbManageCus As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbShowDC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbSumTotal As System.Windows.Forms.TextBox
    Friend WithEvents pbFree As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
