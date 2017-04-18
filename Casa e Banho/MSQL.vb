Imports MySql.Data.MySqlClient
Imports System.Data.DataSet

Public Class ConexaoMysql
    Private mConexao As New MySqlConnection
    Private mComando As New MySqlCommand
    Private mDataAdap As New MySqlDataAdapter
    Private mDataRead As MySqlDataReader

    Public Sub ConectarMySql()

        If Not mConexao.State = ConnectionState.Open Then
            Dim strConexao As String = "Data Source=192.168.0.8;userid=root;password=ukloponet;database=casabanho"
            mConexao = New MySqlConnection()
            mConexao.ConnectionString = strConexao

            Try
                mConexao.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Application.Exit()
            End Try
        End If
    End Sub
    Public Sub DesconectarMySql()
        If mConexao.State = ConnectionState.Open Then
            mConexao.Close()
            mConexao.Dispose()
            mConexao = Nothing
        End If
    End Sub
    Public Function ExecutaDataTable(ByVal sql As String) As DataTable
        Dim mDataTable As New DataTable
        Try
            ConectarMySql()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataAdap.SelectCommand = mComando
            mDataAdap.Fill(mDataTable)
            mDataAdap.Dispose()
            Return mDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return mDataTable
    End Function
    Public Function ExecutaDataRead(ByVal sql As String) As MySqlDataReader
        mDataRead = Nothing
        Try
            ConectarMySql()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            mDataRead = mComando.ExecuteReader()
            mComando.Dispose()
            Return mDataRead

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return mDataRead

    End Function
    Public Function ExecutaQuery(ByVal sql As String) As MySqlCommand

        Try
            ConectarMySql()
            mComando.CommandType = CommandType.Text
            mComando.CommandText = sql
            mComando.Connection = mConexao
            Return mComando

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return mComando
    End Function


End Class
