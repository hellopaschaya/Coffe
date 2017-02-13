Imports System.Data.SqlClient

Public Class Claim

    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub
    Private Sub btToHome_Click(sender As Object, e As EventArgs) Handles btToHome.Click
        Me.Close()
        MainApplication.Show()
    End Sub
    Private Sub checkFree()
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[checkFreeCoffe]", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim sqlDa As New SqlDataAdapter(cmd)
        cn.Open()
        sqlDa.Fill(dt)
        cbShowFree.DataSource = dt
        cbShowFree.DisplayMember = "cus_name"
        cbShowFree.ValueMember = "cus_id"
        cn.Close()
    End Sub
    Private Sub deleteFree()
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[deleteFree]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)
        'Dim a As String = cusId
        'Dim b As String = unit * 10
        cmd.Parameters.AddWithValue("@cusid", cbShowFree.SelectedValue)
        cmd.Parameters.AddWithValue("@unit", nudUnit.Value * 10)
        cn.Open()
        sqlDa.Fill(ds)
        cn.Close()
    End Sub
    Private Sub checkFreeDD()
        Dim dt As New DataTable()
        Dim ds As New DataSet()
        Dim cn As New SqlConnection(Connection.Con)
        Dim cmd As New SqlCommand("[dbo].[checkFreeCoffeDD]", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDa As New SqlDataAdapter(cmd)
        Dim a As String = cbShowFree.SelectedValue
        cn.Open()
        cmd.Parameters.AddWithValue("@idCus", a)
        sqlDa.Fill(dt)

        If dt.Rows.Count = 0 Then
             btUseFree.Enabled = False
            nudUnit.Enabled = False
        ElseIf dt.Rows.Count > 9 Then
            nudUnit.Text = Math.Floor(Integer.Parse(dt.Rows(0).Item("unit")) / 10)
            btUseFree.Enabled = True
        End If
        nudUnit.Minimum = 1
        nudUnit.Maximum = nudUnit.Text
        cn.Close()
    End Sub



    Private Sub Claim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudUnit.ReadOnly = True
        checkFree()
        checkFreeDD()
    End Sub

    Private Sub cbShowFree_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbShowFree.SelectionChangeCommitted

        checkFreeDD()

    End Sub

    Private Sub btUseFree_Click(sender As Object, e As EventArgs) Handles btUseFree.Click

        OpenForm2()

    End Sub
    Private form2Instance As MainApplication

    Private Sub OpenForm2()
        Dim sum As String = Integer.Parse(nudUnit.Value) * 25
        If form2Instance Is Nothing OrElse form2Instance.IsDisposed Then
            form2Instance = New MainApplication
        End If
        form2Instance.cusId = cbShowFree.SelectedValue
        'form2Instance.unit = Integer.Parse(nudUnit.Value)
        form2Instance.val = sum
        form2Instance.check = 1
        deleteFree()
        Me.Close()
        form2Instance.Show()
        form2Instance.Activate()
    End Sub
End Class
