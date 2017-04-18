Imports MySql.Data.MySqlClient
Imports System.Data.DataSet

Public Class frm_esq_PesquisaPRO
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        If txtNomeCliente.Text = "" Then
            MsgBox("Digite o nome do cliente, ou parte dele!", vbCritical)
        Else

            Dim cn As New ConexaoMysql()
            Dim Sql As String = "SELECT num_pro, dt_criacao, nome_cliente, nome_vendedor, vl_ini_cliente from tbl_esquadrias where nome_cliente Like('%" & UCase(txtNomeCliente.Text) & "%') order by dt_criacao;"

            Dim rs As MySqlDataReader
            rs = cn.ExecutaDataRead(Sql)

            With lvwPro
                .Columns.Clear()
                .View = View.Details
                .GridLines = True
                .Columns.Add("Num. Pro", 180)
                .Columns.Add("Data", 90)
                .Columns.Add("Cliente", 190)
                .Columns.Add("Valor:", 70)
                .Columns.Add("Vendedor:", 190)
                .Items.Clear()
                .MultiSelect = False
                If rs.HasRows = False Then
                    MsgBox("Nenhuma PRO Encontrada", vbCritical)
                    txtNomeCliente.Text = ""
                    txtNomeCliente.Select()
                    Exit Sub
                Else
                    While rs.Read
                        Dim num_pro As String = rs("num_pro")
                        Dim li As New ListViewItem(num_pro, 0)
                        li.SubItems.Add(rs("dt_criacao"))
                        li.SubItems.Add(rs("nome_cliente"))
                        li.SubItems.Add(Format(rs("vl_ini_cliente"), "N"))
                        li.SubItems.Add(rs("nome_vendedor"))
                        Me.lvwPro.Items.Add(li)
                    End While
                End If
            End With
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub frm_esq_PesquisaPRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPesquisar.Select()
        txtNomeCliente.Select()
    End Sub

    Private Sub lvwPro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwPro.SelectedIndexChanged

    End Sub

    Private Sub lvwPro_DoubleClick(sender As Object, e As EventArgs) Handles lvwPro.DoubleClick
        Dim Idx As Integer
        With lvwPro

            For intCounter = 1 To .Items.Count - 1
                If .Items(intCounter).Selected Then
                    Idx = .FocusedItem.Index
                End If
            Next
            Utils.BuscaPRO(.FocusedItem.SubItems(0).Text)
            Me.Hide()
        End With

    End Sub
End Class