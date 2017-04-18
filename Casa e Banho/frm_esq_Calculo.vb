Imports MySql.Data.MySqlClient

Public Class frm_esq_Calculo
    Public tipo As String

    Public Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        frm_esq_PesquisaPRO.ShowDialog()
    End Sub

    Private Sub txtnropro_Leave(sender As Object, e As EventArgs) Handles txtnropro.Leave
        txtnropro.Text = UCase(txtnropro.Text)
        Utils.BuscaPRO(txtnropro.Text)
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

    Private Sub frm_esq_Calculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With lvwVidros
            .View = View.Details
            .GridLines = True
            .Columns.Add("Tipo de Vidro", 180, HorizontalAlignment.Left)
            .Columns.Add("Metragem", 80, HorizontalAlignment.Left)
            .Columns.Add("Valor", 100, HorizontalAlignment.Left)
            .Columns.Add("Custo", 100, HorizontalAlignment.Left)
        End With

        For Each ctl In Me.Controls
            ctl.Enabled = False
        Next
        btnNovaPro.Enabled = True
        btnPesquisa.Enabled = True
        pnlCliente.Enabled = True
        txtNomeCliente.Enabled = False
    End Sub
    Public Sub btnNovaPro_Click(sender As Object, e As EventArgs) Handles btnNovaPro.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
        frm_esq_Calculo_Load(e, e)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Utils.CalcularEsquadria(txtnropro.Text)
    End Sub

    Private Sub txtnropro_TextChanged(sender As Object, e As EventArgs) Handles txtnropro.TextChanged

    End Sub
End Class
