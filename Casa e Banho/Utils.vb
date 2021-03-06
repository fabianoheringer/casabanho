﻿Imports MySql.Data.MySqlClient
Imports System.Data.DataSet

Public Class Utils
    Public Shared Sub TextBoxMoeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MessageBox.Show(ex.Message, "TextBoxMoeda")
        End Try
    End Sub

    Public Shared Sub RestringeKey(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And
           Not Convert.ToInt32(e.KeyChar) = Keys.Back And
           Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Public Shared Sub BuscaPRO(ByVal num_pro As String)
        If num_pro.Contains("PRO823") Then
        Else
            num_pro = "PRO823" & num_pro
        End If

        Dim cn As New ConexaoMysql()
        Dim Sql As String = "SELECT * from tbl_esquadrias where num_pro = '" & num_pro & "';"

        Dim rs As MySqlDataReader
        rs = cn.ExecutaDataRead(Sql)

        If rs.HasRows = True Then
            Dim msgbox_result As MsgBoxResult
            msgbox_result = MsgBox("Deseja alterar a proposta?", vbYesNo)
            If msgbox_result = vbYes Then
                'HABILITA OS CAMPOS
                'frm_esq_Calculo.pnlCliente.Enabled = True
                frm_esq_Calculo.pnlEclaris.Enabled = True
                frm_esq_Calculo.pnlVidros.Enabled = True
                frm_esq_Calculo.pnlInstalacao.Enabled = True
                frm_esq_Calculo.pnlPagto.Enabled = True
                frm_esq_Calculo.cmbVendedor.Enabled = False
                frm_esq_Calculo.txtnropro.Enabled = True


                While rs.Read
                    With frm_esq_Calculo
                        .txtnropro.Text = Replace(num_pro, "PRO823", "")
                        .txtNomeCliente.Text = rs("nome_cliente")
                        .txtCtEsq.Text = rs("vl_venda_eclaris")
                        .txtCtDesc.Text = rs("desc_fabrica")
                        .txtCtMkp.Text = rs("vl_markup_fabrica")
                        .txtCtEsq.Text = rs("ct_venda_eclaris")
                        .txtnroprosemvidro.Text = rs("num_pro_semvidro")
                        .txtVlrCliente.Text = rs("vl_ini_cliente")
                        .txtVlrLiqCliente.Text = rs("vl_ini_cliente")
                        .txtDescPercCliente.Text = (1 - (.txtVlrLiqCliente.Text / .txtVlrCliente.Text)) * 100
                        .txtDescVlrCliente.Text = (.txtVlrCliente.Text - .txtVlrLiqCliente.Text)
                        .cmbVendedor.Text = rs("nome_vendedor")
                        .cmbEspecificador.Text = rs("nome_especificador")
                        .cmbFPagto.Text = rs("tipo_pagamento")
                        .txtVlEntrada.Text = rs("vl_entrada")
                        .cmbQtParcelas.Text = rs("qt_parcelas")
                        'INSTALACAO
                        .cmbTipoInst.Text = rs("tipo_instalacao")
                        .txtMetrInst.Text = rs("metr_instalacao")
                        .txtDescInst.Text = rs("desc_instalacao")
                        .lblVlTotalInst.Text = CDbl(rs("vl_instalacao")).ToString("N")
                        'VIDROS
                    End With
                End While
                rs.Close()

                Sql = "SELECT * from tbl_esq_vidros where num_pro = '" & num_pro & "';"

                rs = cn.ExecutaDataRead(Sql)
                If rs.HasRows = True Then
                    With frm_esq_Calculo.lvwVidros
                        .Items.Clear()
                        .View = View.Details
                        .GridLines = True
                        .LabelEdit = False
                    End With
                    While rs.Read
                        Dim tipo_vidro As String = rs("tipo_vidro")
                        Dim li As New ListViewItem(tipo_vidro, 0)
                        li.SubItems.Add(Format(rs("metr_vidro"), "N"))
                        li.SubItems.Add(Format(rs("vl_vidro_total"), "N"))
                        li.SubItems.Add(Format(rs("vl_ct_vidro"), "N"))
                        frm_esq_Calculo.lvwVidros.Items.Add(li)
                    End While
                    Utils.CalculaVidro()
                End If
            Else
                MessageBox.Show("Nao tem Registros")
                End If
            End If
    End Sub
    Public Shared Sub CalculaVidro()
        With frm_esq_Calculo
            .lblMetrVidroTotal.Text = "0,00"
            .lblVlTotalVidro.Text = "0,00"
            For intCounter = 0 To .lvwVidros.Items.Count - 1
                .lblVlTotalVidro.Text = CDec(.lblVlTotalVidro.Text) + CDec(.lvwVidros.Items(intCounter).SubItems(2).Text)
                .lblMetrVidroTotal.Text = Format(CDec(.lblMetrVidroTotal.Text) + CDec(.lvwVidros.Items(intCounter).SubItems(1).Text), "N")
                '.lblCustoVidro.Text = (.lblCustoVidro + CDec(.ListItems(intCounter).SubItems(3)) * (1 - (frmCalculo.txtDescVidro / 100)))
            Next
        End With

    End Sub

    Public Shared Sub CalcularEsquadria(num_pro As String)
        Dim campo As String
        With frm_esq_Calculo
            For Each ctl In .Controls
                If Left(ctl.name, 3) = "txt" Or Left(ctl.Name, 3) = "cmb" Then
                    campo = ctl.name
                End If
                If campo = "" Then
                    MsgBox("Preencha todos os campos", vbCritical)
                    Exit Sub
                Else
                    MsgBox("OK")
                End If
            Next
        End With
    End Sub
End Class

