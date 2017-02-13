Imports System.Data.SqlClient

Public Class MainApplication
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Public Property val As Integer
    Public Property check As Integer
    Public Property cusId As String


    Dim number As Integer
    Dim sum As Integer
    Dim sumM As Integer
    Dim row As Integer
    Dim num As Integer = 0
    Dim free As Integer
    Dim count As Double


    Private Sub selectCBCus()
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectCus]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)
        cn.Open()
        sqlDa.Fill(dt)
        cbCus.DataSource = dt
        cbCus.DisplayMember = "cus_name"
        cbCus.ValueMember = "cus_id"

        cn.Close()

    End Sub
    Private Sub SelectDGV()
        Dim dt As New DataTable()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectDGVDrink]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)

        cmd.Parameters.AddWithValue("@id_dType", 98)

        cn.Open()
        sqlDa.Fill(dt)
        dgvShowDrink.DataSource = dt
        dgvShowDrink.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvShowDrink.AllowUserToDeleteRows = False
        dgvShowDrink.Columns.Item("ชื่อสินค้า").Width = 200
        dgvShowDrink.ReadOnly = True
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Private Sub SelectDGVOther()
        Dim dt As New DataTable()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectDGVOther]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)

        cmd.Parameters.AddWithValue("@id_dType2", 99)

        cn.Open()
        sqlDa.Fill(dt)
        dgvShowOther.DataSource = dt
        dgvShowOther.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvShowOther.AllowUserToDeleteRows = False
        dgvShowOther.ReadOnly = True
        dgvShowOther.Columns.Item("ชื่อสินค้า").Width = 200
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub
   
    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkFree()
        selectCBCus()
        SelectDGV()
        SelectDGVOther()
        dgvShowDrink.Columns.Item("id_dType").Visible = False
        dgvShowDrink.Columns.Item("hcp_id").Visible = False
        dgvShowOther.Columns.Item("id_dType").Visible = False
        dgvShowDrink.AllowUserToAddRows = False
        dgvShowOther.AllowUserToAddRows = False
        dgvShowDrink.Font = Label2.Font
        dgvShowOther.Font = Label2.Font
        With lvCal
            .View = View.Details
            .GridLines = True
            .Font = Label2.Font
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False

            .Columns.Add("รายการที่").Width = 100
            .Columns.Add("รหัสสินค้า").Width = 100
            .Columns.Add("ชื่อ").Width = 250
            .Columns.Add("hcs").Width = 100
            .Columns.Add("ราคา").Width = 100
            .Columns.Add("จำนวน").Width = 100
            .Columns.Add("ชื่อเล่นลูกค้า").Width = 170

        End With

        tbShowSum.Text = 0
        tbShowM.Text = 0

    End Sub

    Private Sub dgvShowDrink_Leave(sender As Object, e As EventArgs) Handles dgvShowDrink.Leave
        dgvShowDrink.ClearSelection()
    End Sub

    Private Sub dgvShowOther_Leave(sender As Object, e As EventArgs) Handles dgvShowOther.Leave
        dgvShowOther.ClearSelection()
    End Sub

    Private Sub dgvShowDrink_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowDrink.CellClick
        If e.RowIndex = -1 Then
            For i = 0 To dgvShowDrink.Columns.Count - 1

                dgvShowDrink.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic

            Next i
            Return
        End If
        Dim ListItem1 As ListViewItem
        Dim row As DataGridViewRow
        row = Me.dgvShowDrink.Rows(e.RowIndex)
        Dim amount As Integer
        amount = CType(row.Cells("ราคาสินค้า").Value.ToString.Trim, Integer)

        num = num + 1
        ListItem1 = lvCal.Items.Add(num)

        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)

        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectCusName]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@id", cbCus.SelectedValue)
        cn.Open()
        sqlDa.Fill(ds)


        ListItem1.SubItems(1).Text = row.Cells("รหัสสินค้า").Value
        ListItem1.SubItems(2).Text = row.Cells("ชื่อสินค้า").Value
        ListItem1.SubItems(3).Text = row.Cells("type").Value
        ListItem1.SubItems(4).Text = amount.ToString("#,##0.00")
        ListItem1.SubItems(5).Text = 1
        ListItem1.SubItems(6).Text = ds.Tables(0).Rows(0).Item("cus_name")
        sum += Decimal.Parse(ListItem1.SubItems(4).Text)
        sumM += Decimal.Parse(ListItem1.SubItems(5).Text)

        tbShowSum.Text = sumM
        tbShowM.Text = sum
    End Sub


    Private Sub dgvShowOther_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowOther.CellClick
        If e.RowIndex = -1 Then
            For i = 0 To dgvShowOther.Columns.Count - 1

                dgvShowOther.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic

            Next i
            Return
        End If
        Dim ListItem1 As ListViewItem
        Dim row As DataGridViewRow
        row = Me.dgvShowOther.Rows(e.RowIndex)
        Dim amount As Integer
        amount = CType(row.Cells("ราคาสินค้า").Value.ToString.Trim, Integer)

        num = num + 1
        ListItem1 = lvCal.Items.Add(num)

        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        ListItem1.SubItems.Add(String.Empty)
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectCusName]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@id", cbCus.SelectedValue)
        cn.Open()
        sqlDa.Fill(ds)
        ListItem1.SubItems(1).Text = row.Cells("รหัสสินค้า").Value
        ListItem1.SubItems(2).Text = row.Cells("ชื่อสินค้า").Value

        ListItem1.SubItems(4).Text = amount.ToString("#,##0.00")
        ListItem1.SubItems(5).Text = 1
        ListItem1.SubItems(6).Text = ds.Tables(0).Rows(0).Item("cus_name")
        sum += Decimal.Parse(ListItem1.SubItems(4).Text)
        sumM += Decimal.Parse(ListItem1.SubItems(5).Text)

        tbShowSum.Text = sumM
        tbShowM.Text = sum
    End Sub

    Private Sub tbShowSum_TextChanged(sender As Object, e As EventArgs) Handles tbShowSum.TextChanged
        If CDbl(tbShowSum.Text) < 10 Then
            lbFree1.Visible = False
            tbFree.Visible = False
            lbFree2.Visible = False
        ElseIf CDbl(tbShowSum.Text) > 9 Then
            lbFree1.Visible = True
            tbFree.Visible = True
            lbFree2.Visible = True
        End If

        count = Math.Floor(tbShowSum.Text / 10)
        tbFree.Text = count
    End Sub

    Private Sub lvCal_DoubleClick(sender As Object, e As EventArgs) Handles lvCal.DoubleClick
        If lvCal.SelectedIndices.Count > 0 Then
            Dim price As String = lvCal.Items(lvCal.SelectedIndices(0)).SubItems(4).Text()
            sum -= price
        End If

        sumM -= 1
        Dim i As Integer = 0
        For i = 0 To lvCal.SelectedItems.Count - 1
            Dim lvi As ListViewItem
            lvi = lvCal.SelectedItems(i)
            lvCal.Items.Remove(lvi)
        Next

        Dim j As Integer
        num = 0

        For j = 0 To lvCal.Items.Count - 1
            num = num + 1
            lvCal.Items(j).SubItems(0).Text = num.ToString

        Next
     
        tbShowSum.Text = sumM
        tbShowM.Text = sum
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        Select Case MsgBox("ต้องการออกจากโปรแกรมหรือไม่ ?", MsgBoxStyle.YesNo, "ออกจากโปรแกรม")
            Case MsgBoxResult.Yes
                End
            Case MsgBoxResult.No
        End Select
    End Sub

    Private Sub tsbToManage_Click(sender As Object, e As EventArgs) Handles tsbToManage.Click
        Me.Hide()
        ManageMenu.Show()
    End Sub

    Private Sub tsbClaim_Click(sender As Object, e As EventArgs) Handles tsbClaim.Click
        Me.Hide()
        Claim.Show()
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        clearData()


    End Sub
    Private Sub clearData()
        tbShowSum.Text = 0
        tbShowM.Text = 0
        tbFree.Text = ""
        lbFree1.Visible = False
        tbFree.Visible = False
        lbFree2.Visible = False
        cbCus.Enabled = True
        tbShowDC.Text = ""
        tbSumTotal.Text = ""
        lvCal.Clear()
        num = 0
        free = 0
        count = 0
        number = 0
        sumM = 0
        sum = 0
        With lvCal
            .View = View.Details
            .GridLines = True
            .Font = Label2.Font
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False

            .Columns.Add("รายการที่").Width = 100
            .Columns.Add("รหัสสินค้า").Width = 100
            .Columns.Add("ชื่อ").Width = 250
            .Columns.Add("hcs").Width = 100
            .Columns.Add("ราคา").Width = 100
            .Columns.Add("จำนวน").Width = 100
            .Columns.Add("ชื่อเล่นลูกค้า").Width = 170

        End With
    End Sub
    Private Sub checkFree()
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectSellCoffe]", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim sqlDa As New SqlDataAdapter(cmd)


        cn.Open()
        sqlDa.Fill(dt)

        If dt.Rows.Count > 9 Then
            pbFree.Visible = True
        ElseIf dt.Rows.Count < 10 Then
            pbFree.Visible = False
        End If
        cn.Close()

    End Sub
   

    Private Sub btCal_Click(sender As Object, e As EventArgs) Handles btCal.Click, pbFree.Click

        tbSumTotal.Text = Integer.Parse(tbShowM.Text) - val
        If Convert.ToDecimal(tbSumTotal.Text) < 0 Then
            tbSumTotal.Text = "ฟรี"
        End If
        Select Case MsgBox("คิดเงินรายการทั้งหมดหรือไม่ ?", MsgBoxStyle.YesNo, "ชำระเงิน")
            Case MsgBoxResult.Yes
                Dim dt As New DataTable()
                Dim ds As New DataSet()
                Dim cn As New SqlConnection(Connection.Con)
                cn.Open()

                For i = 0 To lvCal.Items.Count - 1
                    Dim cmd As New SqlCommand("[dbo].[sellCoffe]", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim sqlDa As New SqlDataAdapter(cmd)
                    cmd.Parameters.Add("@sell_id", SqlDbType.VarChar).Value = lvCal.Items(i).SubItems(1).Text
                    cmd.Parameters.Add("@sell_name", SqlDbType.VarChar).Value = lvCal.Items(i).SubItems(2).Text
                    cmd.Parameters.Add("@hcs_name", SqlDbType.VarChar).Value = lvCal.Items(i).SubItems(3).Text
                    cmd.Parameters.Add("@sell_price", SqlDbType.Money).Value = lvCal.Items(i).SubItems(4).Text
                    cmd.Parameters.Add("@sell_unit", SqlDbType.Int).Value = lvCal.Items(i).SubItems(5).Text
                    cmd.Parameters.Add("@cus_name", SqlDbType.VarChar).Value = lvCal.Items(i).SubItems(6).Text
                    cmd.Parameters.Add("@cus_id", SqlDbType.VarChar).Value = cbCus.SelectedValue
                    cmd.ExecuteNonQuery()

                Next
                clearData()
                cn.Close()
                checkFree()

                MsgBox("บันทึกข้อมูลการขายเรียบร้อยแล้ว")
            Case MsgBoxResult.No
        End Select
    End Sub
   
    Private Sub tsbManageCus_Click(sender As Object, e As EventArgs) Handles tsbManageCus.Click
        Me.Hide()
        ManageCus.Show()
    End Sub

    Private Sub cbCus_MouseClick(sender As Object, e As MouseEventArgs) Handles cbCus.MouseClick

    End Sub

    Private Sub MainApplication_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim a As Integer = check
        tbShowDC.Text = val
        If a = 1 Then
            cbCus.SelectedValue = cusId
            cbCus.Enabled = False
        Else

        End If

    End Sub

   
   
  
   
End Class