Imports MySql.Data.MySqlClient

Public Class frmEsquadrias
    Public Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        'Dim cn As New ConexaoMysql()
        'Dim Sql As String = "SELECT * from tbl_esquadrias where num_pro = '" & txtnropro.Text & "'"
        'Dim rs As MySqlDataReader
        'rs = cn.ExecutaDataRead(Sql)

        'If rs.HasRows = True Then
        '    MessageBox.Show("Tem Registros")
        '    While rs.Read
        '        lblnroPro.Text = rs("nome_cliente").ToString()
        '    End While
        'Else
        '    MessageBox.Show("Nao tem Registros")
        'End If
    End Sub

    Private Sub txtnropro_Leave(sender As Object, e As EventArgs) Handles txtnropro.Leave
        txtnropro.Text = UCase(txtnropro.Text)
        Utils.BuscaPRO()
    End Sub
    Private Sub txtCtEClaris_TextChanged(sender As Object, e As EventArgs) Handles txtCtEClaris.TextChanged
        Utils.TextBoxMoeda(txtCtEClaris)
    End Sub

    Private Sub txtCtEsq_TextChanged(sender As Object, e As EventArgs) Handles txtCtEsq.TextChanged
        Utils.TextBoxMoeda(txtCtEsq)
    End Sub

    Private Sub txtVlrCliente_TextChanged(sender As Object, e As EventArgs) Handles txtVlrCliente.TextChanged
        Utils.TextBoxMoeda(txtVlrCliente)
    End Sub

    Private Sub txtDescVlrCliente_TextChanged(sender As Object, e As EventArgs) Handles txtDescVlrCliente.TextChanged
        Utils.TextBoxMoeda(txtVlrCliente)
    End Sub

    Private Sub txtVlEntrada_TextChanged(sender As Object, e As EventArgs) Handles txtVlEntrada.TextChanged
        Utils.TextBoxMoeda(txtVlEntrada)
    End Sub

    Private Sub txtVlrLiqCliente_TextChanged(sender As Object, e As EventArgs) Handles txtVlrLiqCliente.TextChanged
        Utils.TextBoxMoeda(txtVlrLiqCliente)
    End Sub

    Private Sub frmEsquadrias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With lvwVidros
            .View = View.Details
            .GridLines = True
            .Columns.Add("Tipo de Vidro", 180, HorizontalAlignment.Left)
            .Columns.Add("Metragem", 80, HorizontalAlignment.Left)
            .Columns.Add("Valor", 100, HorizontalAlignment.Left)
            .Columns.Add("Custo", 100, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub txtnropro_TextChanged(sender As Object, e As EventArgs) Handles txtnropro.TextChanged
    End Sub
End Class
