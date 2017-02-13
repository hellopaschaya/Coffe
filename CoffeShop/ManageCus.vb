Imports System.Data.SqlClient

Public Class ManageCus
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub
    Private Sub btToHome_Click(sender As Object, e As EventArgs) Handles btToHome.Click
        Me.Close()
        MainApplication.Show()
    End Sub
    Private Sub clear()
        tbShowID.Enabled = True
        tbShowID.Text = ""
        tbShowID.Focus()
        btSearch.Enabled = True
        btAdd.Enabled = True
        btDelete.Enabled = False
        btUpdate.Enabled = False
        tbID.Enabled = False
        tbID.Text = ""
        tbName.Enabled = False
        tbName.Text = ""
        tbTel.Enabled = False
        tbTel.Text = ""
        btSave.Enabled = False
    End Sub
    Private Sub selectCus()
        Dim dt As New DataTable()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[selectCus]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)



        cn.Open()
        sqlDa.Fill(dt)
        dgvShowCus.DataSource = dt
        dgvShowCus.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvShowCus.AllowUserToDeleteRows = False
        dgvShowCus.ReadOnly = True
        dgvShowCus.Columns.Item("cus_name").Width = 200
        dgvShowCus.Columns.Item("cus_tel").Width = 200
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Private Sub newIDCus()
        Dim dt As New DataTable()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[newIDCus]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)



        cn.Open()

        sqlDa.Fill(dt)
        tbShowID.Text = ""
        tbShowID.Enabled = False
        btSearch.Enabled = False
        tbName.Enabled = True
        tbTel.Enabled = True
        btSave.Enabled = True

        If dt.Rows.Count = 0 Then

            tbID.Text = "C001"

        ElseIf dt.Rows.Count > 0 Then

            Dim oldNum As String = dt.Rows(0).Item("cus_id")
            Dim rNumber As Integer = CInt(oldNum.Substring(1, 3)) + 1
            Dim newId As String = "C" & rNumber.ToString("000")
            tbID.Text = newId
     
        End If

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub ManageCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvShowCus.Font = Label4.Font
        selectCus()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[searchCus]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)


        cmd.Parameters.AddWithValue("@cusID", tbShowID.Text)
      
        cn.Open()

        sqlDa.Fill(ds)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่ค้นหา")
            tbShowID.Focus()
            Return
        ElseIf ds.Tables(0).Rows.Count > 0 Then
            btAdd.Enabled = False
            btDelete.Enabled = True
            btUpdate.Enabled = True
            tbName.Enabled = True
            tbTel.Enabled = True
            tbID.Text = ds.Tables(0).Rows(0).Item("cus_id")
            tbName.Text = ds.Tables(0).Rows(0).Item("cus_name")
            tbTel.Text = ds.Tables(0).Rows(0).Item("cus_tel")
        End If
        cn.Close()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        clear()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        newIDCus()
    End Sub

    Private Sub tbTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Select Case MsgBox("บันทึกข้อมูลใช่หรือไม่ ", MsgBoxStyle.YesNo, "บันทึกข้อมูล")
            Case MsgBoxResult.Yes
                If tbName.Text = "" And tbTel.Text = "" Then
                    MsgBox("กรุณากรอกข้อมูลให้ครบถ้วนก่อนทำการบันทึก ")
                Else
                    Dim cn As New SqlConnection(Connection.Con)
                    Dim cmd As New SqlCommand("[dbo].[insertCus]", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add("@cus_id", SqlDbType.VarChar).Value = tbID.Text
                    cmd.Parameters.Add("@cus_name", SqlDbType.VarChar).Value = tbName.Text
                    If tbTel.Text.Count < 10 Then
                        MsgBox("เบอร์โทรอย่างน้อยต้องมี 10 หลัก")
                        tbTel.Focus()
                        Return
                    Else
                        cmd.Parameters.Add("@cus_tel", SqlDbType.VarChar).Value = tbTel.Text
                    End If
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MessageBox.Show("บันทึกเรียบร้อยแล้ว")
                    clear()
                    selectCus()
                End If
            Case MsgBoxResult.No
        End Select
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Select Case MsgBox("คุณต้องการจะลบข้อมูลหรือไม่ ", MsgBoxStyle.YesNo, "การลบข้อมูล")
            Case MsgBoxResult.Yes
                Dim dt As New DataTable()
                Dim ds As New DataSet()
                Dim cn As New SqlConnection(Connection.Con)
                Dim cmd As New SqlCommand("[dbo].[deleteCus]", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim sqlDa As New SqlDataAdapter(cmd)

                cmd.Parameters.AddWithValue("@cus_id", tbID.Text)
                cn.Open()
                sqlDa.Fill(ds)
                MsgBox("ลบข้อมูลเรียบร้อยแล้ว")
                clear()
                cn.Close()
                selectCus()
            Case MsgBoxResult.No
        End Select
    End Sub

    Private Sub dgvShowCus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowCus.CellClick
        If e.RowIndex = -1 Then
            For i = 0 To dgvShowCus.Columns.Count - 1

                dgvShowCus.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic

            Next i
            Return
        End If

        Dim row As DataGridViewRow
        row = Me.dgvShowCus.Rows(e.RowIndex)

        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[searchCus]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@cusID", tbID.Text)
        cn.Open()
        sqlDa.Fill(ds)
        btAdd.Enabled = False
        btDelete.Enabled = True
        btUpdate.Enabled = True
        tbName.Enabled = True
        tbTel.Enabled = True
        tbShowID.Text = ""
        tbShowID.Enabled = False
        btSearch.Enabled = False

        tbID.Text = row.Cells("cus_id").Value
        tbName.Text = row.Cells("cus_name").Value
        tbTel.Text = row.Cells("cus_tel").Value

        cn.Close()
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Select Case MsgBox("คุณต้องการจะแก้ไขข้อมูลหรือไม่ ", MsgBoxStyle.YesNo, "การแก้ไขข้อมูล")
            Case MsgBoxResult.Yes
                Dim dt As New DataTable()
                Dim ds As New DataSet()
                Dim cn As New SqlConnection(Connection.Con)
                Dim cmd As New SqlCommand("[dbo].[updateCus]", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim sqlDa As New SqlDataAdapter(cmd)
              
                cmd.Parameters.AddWithValue("@cus_id", tbID.Text)
                cmd.Parameters.AddWithValue("@cus_name", tbName.Text)
                cmd.Parameters.AddWithValue("@cus_tel", tbTel.Text)
                cn.Open()
                sqlDa.Fill(ds)
                MsgBox("แก้ไข้ข้อมูลเรียบร้อยแล้ว")
                clear()
                cn.Close()
                selectCus()
               
            Case MsgBoxResult.No
        End Select
    End Sub
End Class