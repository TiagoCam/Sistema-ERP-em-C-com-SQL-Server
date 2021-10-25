
namespace Projeto_Final
{
    partial class frmCliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnGravarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtRuaCliente = new System.Windows.Forms.TextBox();
            this.txtCompleCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.ufCliente = new System.Windows.Forms.ComboBox();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtNmCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PessoaCliente = new System.Windows.Forms.ComboBox();
            this.telCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCliente.Location = new System.Drawing.Point(8, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(144, 44);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInativo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbInativo.Location = new System.Drawing.Point(344, 22);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(74, 24);
            this.rdbInativo.TabIndex = 37;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtivo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbAtivo.Location = new System.Drawing.Point(269, 22);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(62, 24);
            this.rdbAtivo.TabIndex = 36;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(198, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Status:";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovoCliente.Image = global::Projeto_Final.Properties.Resources.novo_documento;
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCliente.Location = new System.Drawing.Point(632, 72);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(146, 72);
            this.btnNovoCliente.TabIndex = 34;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelarCliente.Image = global::Projeto_Final.Properties.Resources.cancelar;
            this.btnCancelarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCliente.Location = new System.Drawing.Point(632, 406);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(146, 72);
            this.btnCancelarCliente.TabIndex = 33;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluirCliente.Image = global::Projeto_Final.Properties.Resources.remover;
            this.btnExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCliente.Location = new System.Drawing.Point(633, 322);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(146, 72);
            this.btnExcluirCliente.TabIndex = 32;
            this.btnExcluirCliente.Text = "Remover";
            this.btnExcluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlterarCliente.Image = global::Projeto_Final.Properties.Resources.alterar;
            this.btnAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarCliente.Location = new System.Drawing.Point(632, 238);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(146, 72);
            this.btnAlterarCliente.TabIndex = 31;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btnGravarCliente
            // 
            this.btnGravarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGravarCliente.Image = global::Projeto_Final.Properties.Resources.salve_;
            this.btnGravarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarCliente.Location = new System.Drawing.Point(632, 155);
            this.btnGravarCliente.Name = "btnGravarCliente";
            this.btnGravarCliente.Size = new System.Drawing.Size(146, 72);
            this.btnGravarCliente.TabIndex = 30;
            this.btnGravarCliente.Text = "Gravar";
            this.btnGravarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(26, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 64);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Cliente";
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCliente.Location = new System.Drawing.Point(43, 28);
            this.txtBuscaCliente.MaxLength = 60;
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(493, 29);
            this.txtBuscaCliente.TabIndex = 11;
            // 
            // dgvFunc
            // 
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(26, 400);
            this.dgvFunc.MultiSelect = false;
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunc.Size = new System.Drawing.Size(578, 86);
            this.dgvFunc.TabIndex = 28;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(119, 71);
            this.txtNomeCliente.MaxLength = 60;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(485, 29);
            this.txtNomeCliente.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(119, 107);
            this.txtEmailCliente.MaxLength = 20;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(192, 29);
            this.txtEmailCliente.TabIndex = 23;
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod.ForeColor = System.Drawing.Color.Red;
            this.lbl_Cod.Location = new System.Drawing.Point(707, 21);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(0, 24);
            this.lbl_Cod.TabIndex = 21;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(628, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 24);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código:";
            // 
            // txtRuaCliente
            // 
            this.txtRuaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaCliente.Location = new System.Drawing.Point(119, 179);
            this.txtRuaCliente.MaxLength = 20;
            this.txtRuaCliente.Name = "txtRuaCliente";
            this.txtRuaCliente.Size = new System.Drawing.Size(192, 29);
            this.txtRuaCliente.TabIndex = 39;
            // 
            // txtCompleCliente
            // 
            this.txtCompleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleCliente.Location = new System.Drawing.Point(119, 214);
            this.txtCompleCliente.MaxLength = 20;
            this.txtCompleCliente.Name = "txtCompleCliente";
            this.txtCompleCliente.Size = new System.Drawing.Size(192, 29);
            this.txtCompleCliente.TabIndex = 40;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.Location = new System.Drawing.Point(119, 249);
            this.txtCidadeCliente.MaxLength = 20;
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(192, 29);
            this.txtCidadeCliente.TabIndex = 41;
            // 
            // ufCliente
            // 
            this.ufCliente.FormattingEnabled = true;
            this.ufCliente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.ufCliente.Location = new System.Drawing.Point(119, 284);
            this.ufCliente.Name = "ufCliente";
            this.ufCliente.Size = new System.Drawing.Size(192, 21);
            this.ufCliente.TabIndex = 43;
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCliente.Location = new System.Drawing.Point(413, 215);
            this.txtBairroCliente.MaxLength = 20;
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(191, 29);
            this.txtBairroCliente.TabIndex = 47;
            // 
            // txtNmCliente
            // 
            this.txtNmCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmCliente.Location = new System.Drawing.Point(413, 180);
            this.txtNmCliente.MaxLength = 20;
            this.txtNmCliente.Name = "txtNmCliente";
            this.txtNmCliente.Size = new System.Drawing.Size(191, 29);
            this.txtNmCliente.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(51, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(42, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Pessoa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(68, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Rua:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(22, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Complem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(42, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(77, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "UF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(323, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 55;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(361, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 24);
            this.label10.TabIndex = 56;
            this.label10.Text = "CPF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(328, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 57;
            this.label11.Text = "Número:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(349, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 24);
            this.label12.TabIndex = 58;
            this.label12.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(360, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 24);
            this.label13.TabIndex = 59;
            this.label13.Text = "CEP:";
            // 
            // PessoaCliente
            // 
            this.PessoaCliente.FormattingEnabled = true;
            this.PessoaCliente.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.PessoaCliente.Location = new System.Drawing.Point(119, 147);
            this.PessoaCliente.Name = "PessoaCliente";
            this.PessoaCliente.Size = new System.Drawing.Size(192, 21);
            this.PessoaCliente.TabIndex = 60;
            // 
            // telCliente
            // 
            this.telCliente.Location = new System.Drawing.Point(413, 113);
            this.telCliente.Mask = "(00) 00000-0000";
            this.telCliente.Name = "telCliente";
            this.telCliente.Size = new System.Drawing.Size(191, 20);
            this.telCliente.TabIndex = 61;
            this.telCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(413, 147);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(191, 20);
            this.txtCpfCliente.TabIndex = 62;
            this.txtCpfCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCepCliente
            // 
            this.txtCepCliente.Location = new System.Drawing.Point(414, 253);
            this.txtCepCliente.Mask = "00.000-000";
            this.txtCepCliente.Name = "txtCepCliente";
            this.txtCepCliente.Size = new System.Drawing.Size(191, 20);
            this.txtCepCliente.TabIndex = 63;
            this.txtCepCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(413, 290);
            this.maskedTextBox1.Mask = "00.000.000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBox1.TabIndex = 65;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(351, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 24);
            this.label14.TabIndex = 64;
            this.label14.Text = "CNPJ:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCepCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.telCliente);
            this.Controls.Add(this.PessoaCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBairroCliente);
            this.Controls.Add(this.txtNmCliente);
            this.Controls.Add(this.ufCliente);
            this.Controls.Add(this.txtCidadeCliente);
            this.Controls.Add(this.txtCompleCliente);
            this.Controls.Add(this.txtRuaCliente);
            this.Controls.Add(this.rdbInativo);
            this.Controls.Add(this.rdbAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.btnGravarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmCliente";
            this.Size = new System.Drawing.Size(811, 508);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnGravarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtRuaCliente;
        private System.Windows.Forms.TextBox txtCompleCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.ComboBox ufCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtNmCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox PessoaCliente;
        private System.Windows.Forms.MaskedTextBox telCliente;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        private System.Windows.Forms.MaskedTextBox txtCepCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label14;
    }
}
