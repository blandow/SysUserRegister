namespace CadastroClientes
{
    partial class FrmRegClient
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radOutro = new System.Windows.Forms.RadioButton();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.maskCel = new System.Windows.Forms.MaskedTextBox();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.maskCep = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.Img = new System.Windows.Forms.PictureBox();
            this.BtnAddImg = new System.Windows.Forms.Button();
            this.BtnRemoveImg = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.maskDoc = new System.Windows.Forms.MaskedTextBox();
            this.radCnpj = new System.Windows.Forms.RadioButton();
            this.radCpf = new System.Windows.Forms.RadioButton();
            this.lblLoad = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(268, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(353, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "RG";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(213, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Estado civil";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(536, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(324, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(437, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Endereço";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(157, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nº";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(204, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bairro";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(15, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(464, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "Celular";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(365, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "E-mail";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(11, 385);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Observações";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(15, 548);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "Situação Cadastral";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(98, 7);
            this.txtCod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(100, 22);
            this.txtCod.TabIndex = 13;
            this.txtCod.TabStop = false;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(270, 51);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(369, 115);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(146, 302);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(53, 22);
            this.txtNum.TabIndex = 10;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(357, 188);
            this.txtRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 22);
            this.txtRG.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(15, 409);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(704, 125);
            this.txtObs.TabIndex = 15;
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMasc.Location = new System.Drawing.Point(13, 22);
            this.radMasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(89, 20);
            this.radMasc.TabIndex = 3;
            this.radMasc.Text = "Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radFem.Location = new System.Drawing.Point(116, 22);
            this.radFem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(83, 20);
            this.radFem.TabIndex = 3;
            this.radFem.Text = "Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            // 
            // radOutro
            // 
            this.radOutro.AutoSize = true;
            this.radOutro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radOutro.Location = new System.Drawing.Point(212, 22);
            this.radOutro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radOutro.Name = "radOutro";
            this.radOutro.Size = new System.Drawing.Size(67, 20);
            this.radOutro.TabIndex = 3;
            this.radOutro.Text = "Outros";
            this.radOutro.UseVisualStyleBackColor = true;
            this.radOutro.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Checked = true;
            this.checkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActive.Location = new System.Drawing.Point(211, 551);
            this.checkActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(59, 20);
            this.checkActive.TabIndex = 15;
            this.checkActive.Text = "Ativo";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // maskCel
            // 
            this.maskCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCel.Location = new System.Drawing.Point(468, 186);
            this.maskCel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskCel.Mask = "(00) 00000-0000";
            this.maskCel.Name = "maskCel";
            this.maskCel.Size = new System.Drawing.Size(135, 26);
            this.maskCel.TabIndex = 6;
            this.maskCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskCel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskData
            // 
            this.maskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskData.Location = new System.Drawing.Point(540, 49);
            this.maskData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskData.Mask = "00/00/0000";
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(107, 26);
            this.maskData.TabIndex = 1;
            this.maskData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskData.Validating += new System.ComponentModel.CancelEventHandler(this.maskData_Validating);
            // 
            // maskCep
            // 
            this.maskCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCep.Location = new System.Drawing.Point(328, 302);
            this.maskCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskCep.Mask = "00,000-000";
            this.maskCep.Name = "maskCep";
            this.maskCep.Size = new System.Drawing.Size(103, 26);
            this.maskCep.TabIndex = 12;
            this.maskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskCep.Validating += new System.ComponentModel.CancelEventHandler(this.maskCep_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOutro);
            this.groupBox1.Controls.Add(this.radMasc);
            this.groupBox1.Controls.Add(this.radFem);
            this.groupBox1.Location = new System.Drawing.Point(215, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.DropDownHeight = 100;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.IntegralHeight = false;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(91, 340);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 14;
            this.cbEstado.Validating += new System.ComponentModel.CancelEventHandler(this.cbEstado_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.AutoCompleteCustomSource.AddRange(new string[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viuvo(a)"});
            this.cbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstadoCivil.DropDownHeight = 100;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.IntegralHeight = false;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viuvo(a)"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(215, 186);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoCivil.TabIndex = 4;
            this.cbEstadoCivil.Validating += new System.ComponentModel.CancelEventHandler(this.cbEstadoCivil_Validating);
            // 
            // cbCidade
            // 
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.DisplayMember = "cidade";
            this.cbCidade.DropDownHeight = 100;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.IntegralHeight = false;
            this.cbCidade.Location = new System.Drawing.Point(19, 302);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 24);
            this.cbCidade.TabIndex = 9;
            // 
            // cbBairro
            // 
            this.cbBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBairro.DisplayMember = "bairro";
            this.cbBairro.DropDownHeight = 100;
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.IntegralHeight = false;
            this.cbBairro.Location = new System.Drawing.Point(205, 300);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(117, 24);
            this.cbBairro.TabIndex = 11;
            // 
            // cbEndereco
            // 
            this.cbEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEndereco.DisplayMember = "endereco";
            this.cbEndereco.DropDownHeight = 100;
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.IntegralHeight = false;
            this.cbEndereco.Location = new System.Drawing.Point(437, 304);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(246, 24);
            this.cbEndereco.TabIndex = 13;
            // 
            // Img
            // 
            this.Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img.Image = global::CadastroClientes.Properties.Resources.esquiador;
            this.Img.Location = new System.Drawing.Point(26, 49);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(173, 174);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img.TabIndex = 10;
            this.Img.TabStop = false;
            this.Img.Click += new System.EventHandler(this.Img_Click);
            // 
            // BtnAddImg
            // 
            this.BtnAddImg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddImg.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAddImg.FlatAppearance.BorderSize = 2;
            this.BtnAddImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnAddImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAddImg.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddImg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddImg.Location = new System.Drawing.Point(20, 229);
            this.BtnAddImg.Name = "BtnAddImg";
            this.BtnAddImg.Size = new System.Drawing.Size(120, 33);
            this.BtnAddImg.TabIndex = 7;
            this.BtnAddImg.TabStop = false;
            this.BtnAddImg.Text = "Imagem";
            this.BtnAddImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAddImg.UseVisualStyleBackColor = false;
            this.BtnAddImg.Click += new System.EventHandler(this.BtnAddImg_Click);
            // 
            // BtnRemoveImg
            // 
            this.BtnRemoveImg.BackColor = System.Drawing.Color.MistyRose;
            this.BtnRemoveImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRemoveImg.BackgroundImage")));
            this.BtnRemoveImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRemoveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveImg.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BtnRemoveImg.FlatAppearance.BorderSize = 2;
            this.BtnRemoveImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnRemoveImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnRemoveImg.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveImg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRemoveImg.Location = new System.Drawing.Point(146, 229);
            this.BtnRemoveImg.Name = "BtnRemoveImg";
            this.BtnRemoveImg.Size = new System.Drawing.Size(51, 31);
            this.BtnRemoveImg.TabIndex = 11;
            this.BtnRemoveImg.TabStop = false;
            this.BtnRemoveImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRemoveImg.UseVisualStyleBackColor = false;
            this.BtnRemoveImg.Click += new System.EventHandler(this.BtnRemoveImg_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.FlatAppearance.BorderSize = 2;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFechar.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFechar.Location = new System.Drawing.Point(15, 584);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 33);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnNovo.FlatAppearance.BorderSize = 2;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNovo.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(141, 584);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 33);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSalvar.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(581, 584);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 33);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // maskDoc
            // 
            this.maskDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDoc.Location = new System.Drawing.Point(211, 111);
            this.maskDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskDoc.Name = "maskDoc";
            this.maskDoc.Size = new System.Drawing.Size(135, 26);
            this.maskDoc.TabIndex = 0;
            this.maskDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskDoc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskDoc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskDoc.Validating += new System.ComponentModel.CancelEventHandler(this.maskDoc_Validating);
            // 
            // radCnpj
            // 
            this.radCnpj.AutoSize = true;
            this.radCnpj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radCnpj.Location = new System.Drawing.Point(280, 92);
            this.radCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCnpj.Name = "radCnpj";
            this.radCnpj.Size = new System.Drawing.Size(63, 20);
            this.radCnpj.TabIndex = 3;
            this.radCnpj.TabStop = true;
            this.radCnpj.Text = "CNPJ";
            this.radCnpj.UseVisualStyleBackColor = true;
            this.radCnpj.CheckedChanged += new System.EventHandler(this.radCnpj_CheckedChanged);
            // 
            // radCpf
            // 
            this.radCpf.AutoSize = true;
            this.radCpf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radCpf.Location = new System.Drawing.Point(215, 92);
            this.radCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCpf.Name = "radCpf";
            this.radCpf.Size = new System.Drawing.Size(54, 20);
            this.radCpf.TabIndex = 3;
            this.radCpf.TabStop = true;
            this.radCpf.Text = "CPF";
            this.radCpf.UseVisualStyleBackColor = true;
            this.radCpf.CheckedChanged += new System.EventHandler(this.radCpf_CheckedChanged);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoad.Location = new System.Drawing.Point(297, 342);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(160, 22);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "buscando CEP...";
            this.lblLoad.Visible = false;
            this.lblLoad.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmRegClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(732, 654);
            this.Controls.Add(this.radCpf);
            this.Controls.Add(this.BtnRemoveImg);
            this.Controls.Add(this.radCnpj);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.maskDoc);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.BtnAddImg);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.cbBairro);
            this.Controls.Add(this.cbEndereco);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskData);
            this.Controls.Add(this.maskCep);
            this.Controls.Add(this.maskCel);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRegClient_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radOutro;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.MaskedTextBox maskCel;
        private System.Windows.Forms.MaskedTextBox maskData;
        private System.Windows.Forms.MaskedTextBox maskCep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.ComboBox cbEndereco;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button BtnAddImg;
        private System.Windows.Forms.Button BtnRemoveImg;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskDoc;
        private System.Windows.Forms.RadioButton radCnpj;
        private System.Windows.Forms.RadioButton radCpf;
        private System.Windows.Forms.Label lblLoad;
        public System.Windows.Forms.TextBox txtCod;
    }
}

