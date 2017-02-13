Imports System.Data.SqlClient

Public Class ManageMenu

    Dim comboSource As New Dictionary(Of String, String)()
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub

    Private Sub ManageMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        tbShowID.Focus()
        comboSource.Add("1", "เครื่องดื่ม")
        comboSource.Add("2", "อื่นๆ")
        cbTypeMenu.DataSource = New BindingSource(comboSource, Nothing)
        cbTypeMenu.DisplayMember = "Value"
        cbTypeMenu.ValueMember = "Key"
        SelectDGV()
        SelectDGVOther()
        dgvShowDrink.Columns.Item("id_dType").Visible = False
        dgvShowDrink.Columns.Item("hcp_id").Visible = False
        dgvShowOther.Columns.Item("id_dType").Visible = False
        dgvShowDrink.AllowUserToAddRows = False
        dgvShowOther.AllowUserToAddRows = False
        dgvShowDrink.Font = Label3.Font
        dgvShowOther.Font = Label3.Font
    End Sub
    Private Sub AddData()
        rdbSD.Enabled = False
        rdbSO.Enabled = False
        tbShowID.Text = ""
        tbShowID.Enabled = False
        btSearch.Enabled = False
        btAdd.Enabled = False
        cbTypeMenu.Enabled = True
        rdbHot.Enabled = True
        rdbCool.Enabled = True
        rdbSpin.Enabled = True
        tbName.Enabled = True
        tbPrice.Enabled = True
        btSave.Enabled = True
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
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Private Sub SelectIdType()
        Dim dt As New DataTable()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectIDMenu]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)

        cmd.Parameters.AddWithValue("@id_dType", Convert.ToInt16(cbTypeMenu.SelectedValue))
        cmd.Parameters.AddWithValue("@id_drink", tbID.Text)
        cmd.Parameters.AddWithValue("@id_other", tbID.Text)

        cn.Open()

        sqlDa.Fill(dt)
        If dt.Rows.Count = 0 Then
            If cmd.Parameters.Item("@id_dType").Value = 1 Then
                tbID.Text = "D001"
            ElseIf cmd.Parameters.Item("@id_dType").Value = 2 Then
                tbID.Text = "E001"
            End If
        ElseIf dt.Rows.Count > 0 Then
            If cmd.Parameters.Item("@id_dType").Value = 1 Then
                Dim oldNum As String = dt.Rows(0).Item("id_drink")
                Dim rNumber As Integer = CInt(oldNum.Substring(1, 3)) + 1
                Dim newId As String = "D" & rNumber.ToString("000")
                tbID.Text = newId
            ElseIf cmd.Parameters.Item("@id_dType").Value = 2 Then
                Dim oldNum As String = dt.Rows(0).Item("id_other")
                Dim rNumber As Integer = CInt(oldNum.Substring(1, 3)) + 1
                Dim newId As String = "E" & rNumber.ToString("000")
                tbID.Text = newId
            End If
        End If

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub cbTypeMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTypeMenu.SelectedIndexChanged

        cbTypeMenu.DisplayMember = "Value"
        cbTypeMenu.ValueMember = "Key"
        If cbTypeMenu.SelectedValue = 1 Then
            rdbHot.Visible = True
            rdbCool.Visible = True
            rdbSpin.Visible = True

        ElseIf cbTypeMenu.SelectedValue = 2 Then
            rdbHot.Visible = False
            rdbCool.Visible = False
            rdbSpin.Visible = False
        End If

    End Sub


    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Select Case MsgBox("บันทึกข้อมูลใช่หรือไม่ ", MsgBoxStyle.YesNo, "บันทึกข้อมูล")
            Case MsgBoxResult.Yes
                If tbName.Text = "" And tbPrice.Text = "" Then
                    MsgBox("กรุณากรอกข้อมูลให้ครบถ้วนก่อนทำการบันทึก ")
                Else
                    Dim cn As New SqlConnection(Connection.Con)
                    Dim cmd As New SqlCommand("[dbo].[insertMenu]", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    If Convert.ToInt16(cbTypeMenu.SelectedValue) = 1 Then
                        cmd.Parameters.Add("@id_dType", SqlDbType.Int).Value = cbTypeMenu.SelectedValue
                        cmd.Parameters.Add("@name_dType", SqlDbType.VarChar).Value = "เครื่องดื่ม"
                        cmd.Parameters.Add("@id_drink", SqlDbType.VarChar).Value = tbID.Text
                        cmd.Parameters.Add("@name_drink", SqlDbType.VarChar).Value = tbName.Text
                        cmd.Parameters.Add("@price_drink", SqlDbType.Money).Value = tbPrice.Text.Trim
                        If rdbHot.Checked = True Then
                            cmd.Parameters.Add("@hcp_id", SqlDbType.Int).Value = 1
                        ElseIf rdbCool.Checked = True Then
                            cmd.Parameters.Add("@hcp_id", SqlDbType.Int).Value = 2
                        ElseIf rdbSpin.Checked = True Then
                            cmd.Parameters.Add("@hcp_id", SqlDbType.Int).Value = 3
                        End If

                    ElseIf Convert.ToInt16(cbTypeMenu.SelectedValue) = 2 Then
                        cmd.Parameters.Add("@id_dType", SqlDbType.Int).Value = cbTypeMenu.SelectedValue
                        cmd.Parameters.Add("@name_dType", SqlDbType.VarChar).Value = "อื่นๆ"
                        cmd.Parameters.Add("@id_other", SqlDbType.VarChar).Value = tbID.Text
                        cmd.Parameters.Add("@name_other", SqlDbType.VarChar).Value = tbName.Text
                        cmd.Parameters.Add("@price_other", SqlDbType.Money).Value = tbPrice.Text
                    End If

                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MessageBox.Show("บันทึกเรียบร้อยแล้ว")
                    ClearData()
                    SelectDGV()
                    SelectDGVOther()
                End If

                
            Case MsgBoxResult.No


        End Select
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        SelectIdType()

        AddData()
        cbTypeMenu.Select()

    End Sub

    Private Sub cbTypeMenu_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTypeMenu.SelectionChangeCommitted
        SelectIdType()
    End Sub
    Private Sub ClearData()
        rdbSD.Checked = True
        rdbSD.Enabled = True
        rdbSO.Enabled = True
        btDelete.Enabled = False
        btUpdate.Enabled = False
        tbShowID.Text = ""
        tbShowID.Enabled = True
        btSearch.Enabled = True
        btAdd.Enabled = True
        cbTypeMenu.Enabled = False
        cbTypeMenu.SelectedIndex = 0
        tbID.Text = ""
        rdbHot.Enabled = False
        rdbCool.Enabled = False
        rdbSpin.Enabled = False
        tbName.Enabled = False
        tbName.Text = ""
        tbPrice.Text = ""
        tbPrice.Enabled = False
        btSave.Enabled = False
        rdbHot.Checked = True
        tbShowID.Focus()
    End Sub
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        ClearData()
    End Sub

    Private Sub tbPrice_Leave(sender As Object, e As EventArgs) Handles tbPrice.Leave
        If tbPrice.Text = "" Then
            tbPrice.Text = ""
        Else
            Dim amount As Integer
            amount = CType(tbPrice.Text, Integer)
            tbPrice.Text = amount.ToString("#,##0.00")
        End If
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
       

        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[searchMenu]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)

        cmd.Parameters.AddWithValue("@ShowID", tbShowID.Text)
        If rdbSD.Checked = True Then
            cmd.Parameters.AddWithValue("@rdbSD", 1)
        ElseIf rdbSO.Checked = True Then
            cmd.Parameters.AddWithValue("@rdbSD", 2)
        End If
        cn.Open()
       
        sqlDa.Fill(ds)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่ค้นหา")
            ClearData()

            Return
        ElseIf ds.Tables(0).Rows.Count > 0 Then
            cbTypeMenu.Enabled = False
            btAdd.Enabled = False
            btDelete.Enabled = True
            btUpdate.Enabled = True
            tbName.Enabled = True
            tbPrice.Enabled = True
            If cmd.Parameters.Item("@rdbSD").Value = 1 Then
                cbTypeMenu.SelectedIndex = ds.Tables(0).Rows(0).Item("id_dType") - 1

                Dim a As Integer = ds.Tables(0).Rows(0).Item("hcpid")
                If ds.Tables(0).Rows(0).Item("hcpid") = 1 Then
                    rdbHot.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("hcpid") = 2 Then
                    rdbCool.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("hcpid") = 3 Then
                    rdbSpin.Checked = True
                End If

                tbID.Text = ds.Tables(0).Rows(0).Item("IDProduct")
                tbName.Text = ds.Tables(0).Rows(0).Item("NameProduct")
                Dim amount As Integer
                amount = CType(ds.Tables(0).Rows(0).Item("PriceProduct"), Integer)
                tbPrice.Text = amount.ToString("#,##0.00")
            ElseIf cmd.Parameters.Item("@rdbSD").Value = 2 Then
                cbTypeMenu.SelectedIndex = Integer.Parse(ds.Tables(0).Rows(0).Item("id_dType")) - 1
                tbID.Text = ds.Tables(0).Rows(0).Item("IDProduct")
                tbName.Text = ds.Tables(0).Rows(0).Item("NameProduct")
                Dim amount As Integer
                amount = CType(ds.Tables(0).Rows(0).Item("PriceProduct"), Integer)
                tbPrice.Text = amount.ToString("#,##0.00")
            End If

        End If


        cn.Close()


    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Select Case MsgBox("คุณต้องการจะลบข้อมูลหรือไม่ ", MsgBoxStyle.YesNo, "การลบข้อมูล")
            Case MsgBoxResult.Yes
                Dim dt As New DataTable()
                Dim ds As New DataSet()
                Dim cn As New SqlConnection(Connection.Con)
                Dim cmd As New SqlCommand("[dbo].[deleteMenu]", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim sqlDa As New SqlDataAdapter(cmd)


                cmd.Parameters.AddWithValue("@id_dType", cbTypeMenu.SelectedValue)
                cmd.Parameters.AddWithValue("@id_product", tbID.Text)


                cn.Open()
                sqlDa.Fill(ds)
                MsgBox("ลบข้อมูลเรียบร้อยแล้ว")
                ClearData()
                cn.Close()
                SelectDGV()
                SelectDGVOther()
                dgvShowOther.ClearSelection()
                dgvShowDrink.ClearSelection()
            Case MsgBoxResult.No


        End Select

    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Select Case MsgBox("คุณต้องการจะแก้ไขข้อมูลหรือไม่ ", MsgBoxStyle.YesNo, "การแก้ไขข้อมูล")
            Case MsgBoxResult.Yes
                Dim dt As New DataTable()
                Dim ds As New DataSet()
                Dim cn As New SqlConnection(Connection.Con)
                Dim cmd As New SqlCommand("[dbo].[updateMenu]", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim sqlDa As New SqlDataAdapter(cmd)


                cmd.Parameters.AddWithValue("@id_dType", cbTypeMenu.SelectedValue)
                If rdbHot.Checked = True Then
                    cmd.Parameters.AddWithValue("@hcp_id", 1)
                ElseIf rdbCool.Checked = True Then
                    cmd.Parameters.AddWithValue("@hcp_id", 2)
                ElseIf rdbSpin.Checked = True Then
                    cmd.Parameters.AddWithValue("@hcp_id", 3)
                End If
                cmd.Parameters.AddWithValue("@id_product", tbID.Text)
                cmd.Parameters.AddWithValue("@name_product", tbName.Text)
                cmd.Parameters.AddWithValue("@price_product", tbPrice.Text)

                cn.Open()
                sqlDa.Fill(ds)
                MsgBox("แก้ไข้ข้อมูลเรียบร้อยแล้ว")
                ClearData()
                cn.Close()
                SelectDGV()
                SelectDGVOther()
                dgvShowOther.ClearSelection()
                dgvShowDrink.ClearSelection()
            Case MsgBoxResult.No


        End Select
    End Sub

    Private Sub tbShowID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbShowID.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btSearch_Click(Me, EventArgs.Empty)
        End If

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If


        End If
    End Sub

    Private Sub tbPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrice.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btSave_Click(Me, EventArgs.Empty)
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvShowDrink_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowDrink.CellClick

        If e.RowIndex >= 0 Then
            cbTypeMenu.Enabled = False
            rdbHot.Enabled = True
            rdbCool.Enabled = True
            rdbSpin.Enabled = True
            btAdd.Enabled = False
            btDelete.Enabled = True
            btUpdate.Enabled = True
            tbName.Enabled = True
            tbPrice.Enabled = True
            Dim row As DataGridViewRow
            row = Me.dgvShowDrink.Rows(e.RowIndex)
            tbShowID.Text = row.Cells("รหัสสินค้า").Value.ToString.Trim

            cbTypeMenu.SelectedIndex = Convert.ToInt16(row.Cells("id_dType").Value.ToString.Trim) - 1
            If cbTypeMenu.SelectedIndex = 0 Then
                rdbSD.Checked = True
            Else
                rdbSO.Checked = True
            End If
            If row.Cells("hcp_id").Value = 1 Then
                rdbHot.Checked = True
            ElseIf row.Cells("hcp_id").Value = 2 Then
                rdbCool.Checked = True
            Else
                rdbSpin.Checked = True
            End If
            tbID.Text = row.Cells("รหัสสินค้า").Value.ToString.Trim
            tbName.Text = row.Cells("ชื่อสินค้า").Value.ToString

            Dim amount As Integer
            amount = CType(row.Cells("ราคาสินค้า").Value.ToString.Trim, Integer)
            tbPrice.Text = amount.ToString("#,##0.00")
        End If
    End Sub

    Private Sub dgvShowOther_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowOther.CellClick
        If e.RowIndex >= 0 Then
            cbTypeMenu.Enabled = False
            btAdd.Enabled = False
            btDelete.Enabled = True
            btUpdate.Enabled = True
            tbName.Enabled = True
            tbPrice.Enabled = True
            Dim row As DataGridViewRow
            row = Me.dgvShowOther.Rows(e.RowIndex)

            tbShowID.Text = row.Cells("รหัสสินค้า").Value.ToString.Trim
            cbTypeMenu.SelectedIndex = Convert.ToInt16(row.Cells("id_dType").Value.ToString.Trim) - 1
            If cbTypeMenu.SelectedIndex = 0 Then
                rdbSD.Checked = True
            Else
                rdbSO.Checked = True
            End If
            tbID.Text = row.Cells("รหัสสินค้า").Value.ToString.Trim
            tbName.Text = row.Cells("ชื่อสินค้า").Value.ToString

            Dim amount As Integer
            amount = CType(row.Cells("ราคาสินค้า").Value.ToString.Trim, Integer)
            tbPrice.Text = amount.ToString("#,##0.00")
        End If
    End Sub

    Private Sub dgvShowOther_Leave(sender As Object, e As EventArgs) Handles dgvShowOther.Leave
        dgvShowOther.ClearSelection()
    End Sub

    Private Sub dgvShowDrink_Leave(sender As Object, e As EventArgs) Handles dgvShowDrink.Leave
        dgvShowDrink.ClearSelection()
    End Sub

    Private Sub btToHome_Click(sender As Object, e As EventArgs) Handles btToHome.Click
        Me.Close()
        MainApplication.Show()

    End Sub

    Private Sub btAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btAdd.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btAdd_Click(Me, EventArgs.Empty)
        End If
    End Sub
End Class