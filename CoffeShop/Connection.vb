Imports System.Data.SqlClient

Public Class Connection
    Public Shared Function Con()
        Dim ConnectSQL As New SqlConnection
        Dim cmd As New SqlCommand
        Try

            ConnectSQL.ConnectionString = " Server = POPANDMAI;" _
                                        & " Database = db_Coffe ;" _
                                        & " Trusted_Connection = True ;"

            ConnectSQL.Open()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            ConnectSQL.Close()
        End Try
        Return ConnectSQL.ConnectionString
    End Function
End Class
