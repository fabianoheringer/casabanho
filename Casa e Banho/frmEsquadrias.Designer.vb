<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEsquadrias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEsquadrias))
        Me.txtnropro = New System.Windows.Forms.TextBox()
        Me.lblnroPro = New System.Windows.Forms.Label()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.pnlEclaris = New System.Windows.Forms.Panel()
        Me.txtCtEClaris = New System.Windows.Forms.TextBox()
        Me.txtCtEsq = New System.Windows.Forms.TextBox()
        Me.txtCtMkp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCtDesc = New System.Windows.Forms.MaskedTextBox()
        Me.txtnroprosemvidro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDescVidro = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblVlTotalVidro = New System.Windows.Forms.Label()
        Me.lblMetrVidroTotal = New System.Windows.Forms.Label()
        Me.txtMetrVidro = New System.Windows.Forms.MaskedTextBox()
        Me.txtTipoVidro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lvwVidros = New System.Windows.Forms.ListView()
        Me.btnAddNegocio = New System.Windows.Forms.Button()
        Me.btnDelNegocio = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescInst = New System.Windows.Forms.TextBox()
        Me.lblVlTotalInst = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMetrInst = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoInst = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtVlrLiqCliente = New System.Windows.Forms.TextBox()
        Me.txtVlrCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtVlEntrada = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbQtParcelas = New System.Windows.Forms.ComboBox()
        Me.cmbFPagto = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbEspecificador = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescPercCliente = New System.Windows.Forms.TextBox()
        Me.txtDescVlrCliente = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvwNegocio = New System.Windows.Forms.ListView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Gravar = New System.Windows.Forms.Button()
        Me.btnNovaPro = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnAddVidro = New System.Windows.Forms.Button()
        Me.btnDelVidro = New System.Windows.Forms.Button()
        Me.pnlEclaris.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnropro
        '
        Me.txtnropro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnropro.Location = New System.Drawing.Point(61, 10)
        Me.txtnropro.Name = "txtnropro"
        Me.txtnropro.Size = New System.Drawing.Size(156, 20)
        Me.txtnropro.TabIndex = 0
        '
        'lblnroPro
        '
        Me.lblnroPro.AutoSize = True
        Me.lblnroPro.Location = New System.Drawing.Point(7, 13)
        Me.lblnroPro.Name = "lblnroPro"
        Me.lblnroPro.Size = New System.Drawing.Size(48, 13)
        Me.lblnroPro.TabIndex = 1
        Me.lblnroPro.Text = "PRO823"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(12, 12)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisa.TabIndex = 2
        Me.btnPesquisa.Text = "&Pesquisa"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'pnlEclaris
        '
        Me.pnlEclaris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEclaris.Controls.Add(Me.txtCtEClaris)
        Me.pnlEclaris.Controls.Add(Me.txtCtEsq)
        Me.pnlEclaris.Controls.Add(Me.txtCtMkp)
        Me.pnlEclaris.Controls.Add(Me.txtCtDesc)
        Me.pnlEclaris.Controls.Add(Me.txtnroprosemvidro)
        Me.pnlEclaris.Controls.Add(Me.Label3)
        Me.pnlEclaris.Controls.Add(Me.Label2)
        Me.pnlEclaris.Controls.Add(Me.Label1)
        Me.pnlEclaris.Location = New System.Drawing.Point(12, 123)
        Me.pnlEclaris.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlEclaris.Name = "pnlEclaris"
        Me.pnlEclaris.Size = New System.Drawing.Size(368, 96)
        Me.pnlEclaris.TabIndex = 3
        Me.pnlEclaris.Tag = "Esquadrias"
        '
        'txtCtEClaris
        '
        Me.txtCtEClaris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtEClaris.Location = New System.Drawing.Point(249, 25)
        Me.txtCtEClaris.Name = "txtCtEClaris"
        Me.txtCtEClaris.Size = New System.Drawing.Size(102, 20)
        Me.txtCtEClaris.TabIndex = 9
        '
        'txtCtEsq
        '
        Me.txtCtEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtEsq.Location = New System.Drawing.Point(10, 24)
        Me.txtCtEsq.Name = "txtCtEsq"
        Me.txtCtEsq.Size = New System.Drawing.Size(102, 20)
        Me.txtCtEsq.TabIndex = 8
        '
        'txtCtMkp
        '
        Me.txtCtMkp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtMkp.Location = New System.Drawing.Point(184, 24)
        Me.txtCtMkp.Name = "txtCtMkp"
        Me.txtCtMkp.Size = New System.Drawing.Size(56, 20)
        Me.txtCtMkp.TabIndex = 7
        '
        'txtCtDesc
        '
        Me.txtCtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtDesc.Location = New System.Drawing.Point(118, 24)
        Me.txtCtDesc.Name = "txtCtDesc"
        Me.txtCtDesc.Size = New System.Drawing.Size(60, 20)
        Me.txtCtDesc.TabIndex = 4
        '
        'txtnroprosemvidro
        '
        Me.txtnroprosemvidro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnroprosemvidro.Location = New System.Drawing.Point(12, 63)
        Me.txtnroprosemvidro.Name = "txtnroprosemvidro"
        Me.txtnroprosemvidro.Size = New System.Drawing.Size(143, 20)
        Me.txtnroprosemvidro.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pro Sem Vidros PRO823"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Custo e-Claris"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor Esquadrias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cliente"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomeCliente.Location = New System.Drawing.Point(61, 40)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtNomeCliente.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblnroPro)
        Me.Panel1.Controls.Add(Me.txtNomeCliente)
        Me.Panel1.Controls.Add(Me.txtnropro)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 74)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddVidro)
        Me.Panel2.Controls.Add(Me.btnDelVidro)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtDescVidro)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblVlTotalVidro)
        Me.Panel2.Controls.Add(Me.lblMetrVidroTotal)
        Me.Panel2.Controls.Add(Me.txtMetrVidro)
        Me.Panel2.Controls.Add(Me.txtTipoVidro)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lvwVidros)
        Me.Panel2.Location = New System.Drawing.Point(12, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 212)
        Me.Panel2.TabIndex = 7
        '
        'txtDescVidro
        '
        Me.txtDescVidro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescVidro.Location = New System.Drawing.Point(296, 26)
        Me.txtDescVidro.Name = "txtDescVidro"
        Me.txtDescVidro.Size = New System.Drawing.Size(61, 20)
        Me.txtDescVidro.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(296, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Desconto"
        '
        'lblVlTotalVidro
        '
        Me.lblVlTotalVidro.Location = New System.Drawing.Point(300, 192)
        Me.lblVlTotalVidro.Name = "lblVlTotalVidro"
        Me.lblVlTotalVidro.Size = New System.Drawing.Size(61, 13)
        Me.lblVlTotalVidro.TabIndex = 15
        '
        'lblMetrVidroTotal
        '
        Me.lblMetrVidroTotal.Location = New System.Drawing.Point(94, 192)
        Me.lblMetrVidroTotal.Name = "lblMetrVidroTotal"
        Me.lblMetrVidroTotal.Size = New System.Drawing.Size(84, 13)
        Me.lblMetrVidroTotal.TabIndex = 14
        '
        'txtMetrVidro
        '
        Me.txtMetrVidro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMetrVidro.Location = New System.Drawing.Point(233, 26)
        Me.txtMetrVidro.Name = "txtMetrVidro"
        Me.txtMetrVidro.Size = New System.Drawing.Size(58, 20)
        Me.txtMetrVidro.TabIndex = 11
        '
        'txtTipoVidro
        '
        Me.txtTipoVidro.FormattingEnabled = True
        Me.txtTipoVidro.Location = New System.Drawing.Point(3, 27)
        Me.txtTipoVidro.Name = "txtTipoVidro"
        Me.txtTipoVidro.Size = New System.Drawing.Size(224, 21)
        Me.txtTipoVidro.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Vidro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Metragem"
        '
        'lvwVidros
        '
        Me.lvwVidros.Location = New System.Drawing.Point(3, 81)
        Me.lvwVidros.Name = "lvwVidros"
        Me.lvwVidros.Size = New System.Drawing.Size(358, 108)
        Me.lvwVidros.TabIndex = 0
        Me.lvwVidros.UseCompatibleStateImageBehavior = False
        '
        'btnAddNegocio
        '
        Me.btnAddNegocio.BackColor = System.Drawing.Color.White
        Me.btnAddNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNegocio.Image = CType(resources.GetObject("btnAddNegocio.Image"), System.Drawing.Image)
        Me.btnAddNegocio.Location = New System.Drawing.Point(385, 95)
        Me.btnAddNegocio.Name = "btnAddNegocio"
        Me.btnAddNegocio.Size = New System.Drawing.Size(29, 23)
        Me.btnAddNegocio.TabIndex = 8
        Me.btnAddNegocio.UseVisualStyleBackColor = False
        '
        'btnDelNegocio
        '
        Me.btnDelNegocio.BackColor = System.Drawing.Color.White
        Me.btnDelNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelNegocio.Image = CType(resources.GetObject("btnDelNegocio.Image"), System.Drawing.Image)
        Me.btnDelNegocio.Location = New System.Drawing.Point(418, 95)
        Me.btnDelNegocio.Name = "btnDelNegocio"
        Me.btnDelNegocio.Size = New System.Drawing.Size(29, 23)
        Me.btnDelNegocio.TabIndex = 12
        Me.btnDelNegocio.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtDescInst)
        Me.Panel3.Controls.Add(Me.lblVlTotalInst)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtMetrInst)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cmbTipoInst)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(12, 440)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 80)
        Me.Panel3.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Valor Total:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescInst
        '
        Me.txtDescInst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescInst.Location = New System.Drawing.Point(298, 30)
        Me.txtDescInst.Name = "txtDescInst"
        Me.txtDescInst.Size = New System.Drawing.Size(63, 20)
        Me.txtDescInst.TabIndex = 10
        '
        'lblVlTotalInst
        '
        Me.lblVlTotalInst.Location = New System.Drawing.Point(298, 60)
        Me.lblVlTotalInst.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVlTotalInst.Name = "lblVlTotalInst"
        Me.lblVlTotalInst.Size = New System.Drawing.Size(63, 13)
        Me.lblVlTotalInst.TabIndex = 18
        Me.lblVlTotalInst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(295, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Desconto"
        '
        'txtMetrInst
        '
        Me.txtMetrInst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMetrInst.Location = New System.Drawing.Point(234, 30)
        Me.txtMetrInst.Name = "txtMetrInst"
        Me.txtMetrInst.Size = New System.Drawing.Size(58, 20)
        Me.txtMetrInst.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tipo de Instalação"
        '
        'cmbTipoInst
        '
        Me.cmbTipoInst.FormattingEnabled = True
        Me.cmbTipoInst.Location = New System.Drawing.Point(7, 29)
        Me.cmbTipoInst.Name = "cmbTipoInst"
        Me.cmbTipoInst.Size = New System.Drawing.Size(217, 21)
        Me.cmbTipoInst.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Metragem"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtVlrLiqCliente)
        Me.Panel4.Controls.Add(Me.txtVlrCliente)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.cmbEspecificador)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.cmbVendedor)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(386, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(463, 206)
        Me.Panel4.TabIndex = 7
        '
        'txtVlrLiqCliente
        '
        Me.txtVlrLiqCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVlrLiqCliente.Location = New System.Drawing.Point(79, 113)
        Me.txtVlrLiqCliente.Name = "txtVlrLiqCliente"
        Me.txtVlrLiqCliente.Size = New System.Drawing.Size(126, 20)
        Me.txtVlrLiqCliente.TabIndex = 25
        '
        'txtVlrCliente
        '
        Me.txtVlrCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVlrCliente.Location = New System.Drawing.Point(79, 10)
        Me.txtVlrCliente.Name = "txtVlrCliente"
        Me.txtVlrCliente.Size = New System.Drawing.Size(126, 20)
        Me.txtVlrCliente.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVlEntrada)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cmbQtParcelas)
        Me.GroupBox2.Controls.Add(Me.cmbFPagto)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(211, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 124)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pagamento"
        '
        'txtVlEntrada
        '
        Me.txtVlEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVlEntrada.Location = New System.Drawing.Point(9, 72)
        Me.txtVlEntrada.Name = "txtVlEntrada"
        Me.txtVlEntrada.Size = New System.Drawing.Size(126, 20)
        Me.txtVlEntrada.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(138, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Qt. Parcelas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Valor Entrada"
        '
        'cmbQtParcelas
        '
        Me.cmbQtParcelas.FormattingEnabled = True
        Me.cmbQtParcelas.Location = New System.Drawing.Point(142, 71)
        Me.cmbQtParcelas.Name = "cmbQtParcelas"
        Me.cmbQtParcelas.Size = New System.Drawing.Size(90, 21)
        Me.cmbQtParcelas.TabIndex = 25
        '
        'cmbFPagto
        '
        Me.cmbFPagto.FormattingEnabled = True
        Me.cmbFPagto.Location = New System.Drawing.Point(6, 19)
        Me.cmbFPagto.Name = "cmbFPagto"
        Me.cmbFPagto.Size = New System.Drawing.Size(226, 21)
        Me.cmbFPagto.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Especificador"
        '
        'cmbEspecificador
        '
        Me.cmbEspecificador.FormattingEnabled = True
        Me.cmbEspecificador.Location = New System.Drawing.Point(79, 173)
        Me.cmbEspecificador.Name = "cmbEspecificador"
        Me.cmbEspecificador.Size = New System.Drawing.Size(370, 21)
        Me.cmbEspecificador.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Vendedor"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(79, 149)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(370, 21)
        Me.cmbVendedor.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Valor Líquido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescPercCliente)
        Me.GroupBox1.Controls.Add(Me.txtDescVlrCliente)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(10, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 71)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desconto"
        '
        'txtDescPercCliente
        '
        Me.txtDescPercCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescPercCliente.Location = New System.Drawing.Point(69, 18)
        Me.txtDescPercCliente.Name = "txtDescPercCliente"
        Me.txtDescPercCliente.Size = New System.Drawing.Size(120, 20)
        Me.txtDescPercCliente.TabIndex = 5
        '
        'txtDescVlrCliente
        '
        Me.txtDescVlrCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescVlrCliente.Location = New System.Drawing.Point(69, 44)
        Me.txtDescVlrCliente.Name = "txtDescVlrCliente"
        Me.txtDescVlrCliente.Size = New System.Drawing.Size(120, 20)
        Me.txtDescVlrCliente.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "R$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(52, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Valor Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(386, 253)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 181)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumo"
        '
        'lvwNegocio
        '
        Me.lvwNegocio.Location = New System.Drawing.Point(4, 19)
        Me.lvwNegocio.Name = "lvwNegocio"
        Me.lvwNegocio.Size = New System.Drawing.Size(443, 72)
        Me.lvwNegocio.TabIndex = 11
        Me.lvwNegocio.UseCompatibleStateImageBehavior = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lvwNegocio)
        Me.GroupBox4.Controls.Add(Me.btnAddNegocio)
        Me.GroupBox4.Controls.Add(Me.btnDelNegocio)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(11, 526)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(453, 124)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Negociações"
        '
        'GroupBox5
        '
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(471, 526)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(378, 124)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observações"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(774, 440)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Gravar
        '
        Me.Gravar.Location = New System.Drawing.Point(774, 471)
        Me.Gravar.Name = "Gravar"
        Me.Gravar.Size = New System.Drawing.Size(75, 23)
        Me.Gravar.TabIndex = 14
        Me.Gravar.Text = "&Gravar"
        Me.Gravar.UseVisualStyleBackColor = True
        '
        'btnNovaPro
        '
        Me.btnNovaPro.Location = New System.Drawing.Point(93, 12)
        Me.btnNovaPro.Name = "btnNovaPro"
        Me.btnNovaPro.Size = New System.Drawing.Size(75, 23)
        Me.btnNovaPro.TabIndex = 15
        Me.btnNovaPro.Text = "&Nova PRO"
        Me.btnNovaPro.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Valor Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 13)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Metragem Total:"
        '
        'btnAddVidro
        '
        Me.btnAddVidro.BackColor = System.Drawing.Color.White
        Me.btnAddVidro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVidro.Image = CType(resources.GetObject("btnAddVidro.Image"), System.Drawing.Image)
        Me.btnAddVidro.Location = New System.Drawing.Point(296, 52)
        Me.btnAddVidro.Name = "btnAddVidro"
        Me.btnAddVidro.Size = New System.Drawing.Size(29, 23)
        Me.btnAddVidro.TabIndex = 20
        Me.btnAddVidro.UseVisualStyleBackColor = False
        '
        'btnDelVidro
        '
        Me.btnDelVidro.BackColor = System.Drawing.Color.White
        Me.btnDelVidro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelVidro.Image = CType(resources.GetObject("btnDelVidro.Image"), System.Drawing.Image)
        Me.btnDelVidro.Location = New System.Drawing.Point(327, 52)
        Me.btnDelVidro.Name = "btnDelVidro"
        Me.btnDelVidro.Size = New System.Drawing.Size(29, 23)
        Me.btnDelVidro.TabIndex = 21
        Me.btnDelVidro.UseVisualStyleBackColor = False
        '
        'frmEsquadrias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 656)
        Me.Controls.Add(Me.btnNovaPro)
        Me.Controls.Add(Me.Gravar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlEclaris)
        Me.Controls.Add(Me.btnPesquisa)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1360, 768)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(874, 666)
        Me.Name = "frmEsquadrias"
        Me.Text = "Calculo Esquadrias"
        Me.pnlEclaris.ResumeLayout(False)
        Me.pnlEclaris.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtnropro As TextBox
    Friend WithEvents lblnroPro As Label
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents pnlEclaris As Panel
    Friend WithEvents txtnroprosemvidro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCtDesc As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCtMkp As MaskedTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMetrVidroTotal As Label
    Friend WithEvents btnDelNegocio As Button
    Friend WithEvents btnAddNegocio As Button
    Friend WithEvents txtMetrVidro As MaskedTextBox
    Friend WithEvents txtTipoVidro As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lvwVidros As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMetrInst As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoInst As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescVidro As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblVlTotalVidro As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDescPercCliente As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDescVlrCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbQtParcelas As ComboBox
    Friend WithEvents cmbFPagto As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbEspecificador As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbVendedor As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lvwNegocio As ListView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Gravar As Button
    Friend WithEvents lblVlTotalInst As Label
    Friend WithEvents btnNovaPro As Button
    Friend WithEvents txtVlrLiqCliente As TextBox
    Friend WithEvents txtVlrCliente As TextBox
    Friend WithEvents txtVlEntrada As TextBox
    Friend WithEvents txtCtEClaris As TextBox
    Friend WithEvents txtCtEsq As TextBox
    Friend WithEvents txtDescInst As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAddVidro As Button
    Friend WithEvents btnDelVidro As Button
End Class
