namespace CadastroClientes
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAct = new System.Windows.Forms.GroupBox();
            this.btnId = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sit_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearchId = new System.Windows.Forms.GroupBox();
            this.rbSearchInative = new System.Windows.Forms.RadioButton();
            this.rbSearchActive = new System.Windows.Forms.RadioButton();
            this.rbSearchAll = new System.Windows.Forms.RadioButton();
            this.cbSearchGender = new System.Windows.Forms.ComboBox();
            this.cbSearchCivilState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchDate = new System.Windows.Forms.TextBox();
            this.tbSearchAddresss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchDocName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbActive = new System.Windows.Forms.Label();
            this.lbInative = new System.Windows.Forms.Label();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.gbAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.gbSearchId.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAct
            // 
            this.gbAct.BackColor = System.Drawing.Color.Transparent;
            this.gbAct.Controls.Add(this.btnId);
            this.gbAct.Controls.Add(this.btnReport);
            this.gbAct.Controls.Add(this.btnEdit);
            this.gbAct.Controls.Add(this.btnAdd);
            this.gbAct.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbAct.Location = new System.Drawing.Point(12, 12);
            this.gbAct.Name = "gbAct";
            this.gbAct.Size = new System.Drawing.Size(346, 119);
            this.gbAct.TabIndex = 0;
            this.gbAct.TabStop = false;
            this.gbAct.Text = "Ações";
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnId.BackgroundImage")));
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnId.Enabled = false;
            this.btnId.FlatAppearance.BorderSize = 0;
            this.btnId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnId.ForeColor = System.Drawing.Color.Transparent;
            this.btnId.Location = new System.Drawing.Point(246, 21);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(80, 80);
            this.btnId.TabIndex = 1;
            this.btnId.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.Transparent;
            this.btnReport.Location = new System.Drawing.Point(166, 21);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(80, 80);
            this.btnReport.TabIndex = 1;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(86, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 80);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(6, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.foto,
            this.nome,
            this.tipo_doc,
            this.documento,
            this.rg,
            this.email,
            this.estado_civil,
            this.celular,
            this.Genero,
            this.data_nasc,
            this.cidade,
            this.numero,
            this.bairro,
            this.cep,
            this.endereco,
            this.estado,
            this.obs,
            this.sit_cadastro});
            this.dgList.Location = new System.Drawing.Point(12, 137);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowHeadersWidth = 5;
            this.dgList.RowTemplate.Height = 30;
            this.dgList.Size = new System.Drawing.Size(1460, 464);
            this.dgList.TabIndex = 1;
            this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            this.dgList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellMouseEnter);
            this.dgList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellMouseLeave);
            this.dgList.MouseEnter += new System.EventHandler(this.dgList_MouseEnter);
            this.dgList.MouseLeave += new System.EventHandler(this.dgList_MouseLeave);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Nº";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 33;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.MinimumWidth = 6;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 87;
            // 
            // tipo_doc
            // 
            this.tipo_doc.DataPropertyName = "tipo_doc";
            this.tipo_doc.HeaderText = "Tipo de Documento";
            this.tipo_doc.MinimumWidth = 6;
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            this.tipo_doc.Width = 79;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 94;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            this.rg.HeaderText = "RG";
            this.rg.MinimumWidth = 6;
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 80;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.MinimumWidth = 6;
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.ReadOnly = true;
            this.estado_civil.Width = 76;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular/Telefone";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 91;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 35;
            // 
            // data_nasc
            // 
            this.data_nasc.DataPropertyName = "data_nasc";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.data_nasc.DefaultCellStyle = dataGridViewCellStyle6;
            this.data_nasc.HeaderText = "Data Nascimento";
            this.data_nasc.MinimumWidth = 6;
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.ReadOnly = true;
            this.data_nasc.Width = 87;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 6;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 69;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "número";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 42;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 6;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 92;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.MinimumWidth = 6;
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 82;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 103;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 101;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Observação";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 125;
            // 
            // sit_cadastro
            // 
            this.sit_cadastro.DataPropertyName = "sit_cadastro";
            this.sit_cadastro.HeaderText = "Situação do Cadastro";
            this.sit_cadastro.MinimumWidth = 6;
            this.sit_cadastro.Name = "sit_cadastro";
            this.sit_cadastro.ReadOnly = true;
            this.sit_cadastro.Width = 90;
            // 
            // gbSearchId
            // 
            this.gbSearchId.BackColor = System.Drawing.Color.Transparent;
            this.gbSearchId.Controls.Add(this.rbSearchInative);
            this.gbSearchId.Controls.Add(this.rbSearchActive);
            this.gbSearchId.Controls.Add(this.rbSearchAll);
            this.gbSearchId.Controls.Add(this.cbSearchGender);
            this.gbSearchId.Controls.Add(this.cbSearchCivilState);
            this.gbSearchId.Controls.Add(this.label4);
            this.gbSearchId.Controls.Add(this.tbSearchDate);
            this.gbSearchId.Controls.Add(this.tbSearchAddresss);
            this.gbSearchId.Controls.Add(this.label6);
            this.gbSearchId.Controls.Add(this.tbSearchDocName);
            this.gbSearchId.Controls.Add(this.label5);
            this.gbSearchId.Controls.Add(this.label3);
            this.gbSearchId.Controls.Add(this.label2);
            this.gbSearchId.Controls.Add(this.tbSearchId);
            this.gbSearchId.Controls.Add(this.label1);
            this.gbSearchId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbSearchId.Location = new System.Drawing.Point(364, 27);
            this.gbSearchId.Name = "gbSearchId";
            this.gbSearchId.Size = new System.Drawing.Size(1108, 95);
            this.gbSearchId.TabIndex = 0;
            this.gbSearchId.TabStop = false;
            this.gbSearchId.Text = "Filtros";
            // 
            // rbSearchInative
            // 
            this.rbSearchInative.AutoSize = true;
            this.rbSearchInative.ForeColor = System.Drawing.Color.DarkRed;
            this.rbSearchInative.Location = new System.Drawing.Point(1027, 65);
            this.rbSearchInative.Name = "rbSearchInative";
            this.rbSearchInative.Size = new System.Drawing.Size(67, 20);
            this.rbSearchInative.TabIndex = 6;
            this.rbSearchInative.Text = "Inativo";
            this.rbSearchInative.UseVisualStyleBackColor = true;
            this.rbSearchInative.CheckedChanged += new System.EventHandler(this.rbSearchInative_CheckedChanged);
            // 
            // rbSearchActive
            // 
            this.rbSearchActive.AutoSize = true;
            this.rbSearchActive.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbSearchActive.Location = new System.Drawing.Point(1027, 43);
            this.rbSearchActive.Name = "rbSearchActive";
            this.rbSearchActive.Size = new System.Drawing.Size(58, 20);
            this.rbSearchActive.TabIndex = 6;
            this.rbSearchActive.Text = "Ativo";
            this.rbSearchActive.UseVisualStyleBackColor = true;
            this.rbSearchActive.CheckedChanged += new System.EventHandler(this.rbSearchActive_CheckedChanged);
            // 
            // rbSearchAll
            // 
            this.rbSearchAll.AutoSize = true;
            this.rbSearchAll.Checked = true;
            this.rbSearchAll.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbSearchAll.Location = new System.Drawing.Point(1027, 21);
            this.rbSearchAll.Name = "rbSearchAll";
            this.rbSearchAll.Size = new System.Drawing.Size(68, 20);
            this.rbSearchAll.TabIndex = 6;
            this.rbSearchAll.TabStop = true;
            this.rbSearchAll.Text = "Todos";
            this.rbSearchAll.UseVisualStyleBackColor = true;
            this.rbSearchAll.CheckedChanged += new System.EventHandler(this.rbSearchAll_CheckedChanged);
            // 
            // cbSearchGender
            // 
            this.cbSearchGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viuvo(a)"});
            this.cbSearchGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearchGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchGender.DropDownHeight = 100;
            this.cbSearchGender.FormattingEnabled = true;
            this.cbSearchGender.IntegralHeight = false;
            this.cbSearchGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cbSearchGender.Location = new System.Drawing.Point(378, 50);
            this.cbSearchGender.Name = "cbSearchGender";
            this.cbSearchGender.Size = new System.Drawing.Size(121, 24);
            this.cbSearchGender.TabIndex = 5;
            this.cbSearchGender.SelectedIndexChanged += new System.EventHandler(this.tbSearchId_TextChanged);
            // 
            // cbSearchCivilState
            // 
            this.cbSearchCivilState.AutoCompleteCustomSource.AddRange(new string[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viuvo(a)"});
            this.cbSearchCivilState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearchCivilState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchCivilState.DropDownHeight = 100;
            this.cbSearchCivilState.FormattingEnabled = true;
            this.cbSearchCivilState.IntegralHeight = false;
            this.cbSearchCivilState.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viuvo(a)"});
            this.cbSearchCivilState.Location = new System.Drawing.Point(251, 50);
            this.cbSearchCivilState.Name = "cbSearchCivilState";
            this.cbSearchCivilState.Size = new System.Drawing.Size(121, 24);
            this.cbSearchCivilState.TabIndex = 5;
            this.cbSearchCivilState.SelectedIndexChanged += new System.EventHandler(this.tbSearchId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(375, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genero";
            // 
            // tbSearchDate
            // 
            this.tbSearchDate.Location = new System.Drawing.Point(789, 52);
            this.tbSearchDate.Name = "tbSearchDate";
            this.tbSearchDate.Size = new System.Drawing.Size(201, 22);
            this.tbSearchDate.TabIndex = 1;
            this.tbSearchDate.TextChanged += new System.EventHandler(this.tbSearchId_TextChanged);
            // 
            // tbSearchAddresss
            // 
            this.tbSearchAddresss.Location = new System.Drawing.Point(505, 52);
            this.tbSearchAddresss.Name = "tbSearchAddresss";
            this.tbSearchAddresss.Size = new System.Drawing.Size(278, 22);
            this.tbSearchAddresss.TabIndex = 1;
            this.tbSearchAddresss.TextChanged += new System.EventHandler(this.tbSearchId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(786, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data nascimento";
            // 
            // tbSearchDocName
            // 
            this.tbSearchDocName.Location = new System.Drawing.Point(71, 52);
            this.tbSearchDocName.Name = "tbSearchDocName";
            this.tbSearchDocName.Size = new System.Drawing.Size(173, 22);
            this.tbSearchDocName.TabIndex = 1;
            this.tbSearchDocName.TextChanged += new System.EventHandler(this.tbSearchId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(502, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Endereços Gerais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(248, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estado Cívil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(68, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome/CPF/CNPJ";
            // 
            // tbSearchId
            // 
            this.tbSearchId.Location = new System.Drawing.Point(18, 52);
            this.tbSearchId.Name = "tbSearchId";
            this.tbSearchId.Size = new System.Drawing.Size(40, 22);
            this.tbSearchId.TabIndex = 1;
            this.tbSearchId.TextChanged += new System.EventHandler(this.tbSearchId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotal.Location = new System.Drawing.Point(9, 617);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(113, 16);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total Localizado: ";
            // 
            // lbActive
            // 
            this.lbActive.AutoSize = true;
            this.lbActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbActive.Location = new System.Drawing.Point(145, 617);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(77, 16);
            this.lbActive.TabIndex = 0;
            this.lbActive.Text = "Total Ativo: ";
            // 
            // lbInative
            // 
            this.lbInative.AutoSize = true;
            this.lbInative.ForeColor = System.Drawing.Color.Firebrick;
            this.lbInative.Location = new System.Drawing.Point(243, 617);
            this.lbInative.Name = "lbInative";
            this.lbInative.Size = new System.Drawing.Size(86, 16);
            this.lbInative.TabIndex = 0;
            this.lbInative.Text = "Total Inativo: ";
            // 
            // lblNotFound
            // 
            this.lblNotFound.BackColor = System.Drawing.Color.White;
            this.lblNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFound.ForeColor = System.Drawing.Color.Coral;
            this.lblNotFound.Image = ((System.Drawing.Image)(resources.GetObject("lblNotFound.Image")));
            this.lblNotFound.Location = new System.Drawing.Point(15, 197);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Padding = new System.Windows.Forms.Padding(0, 120, 0, 0);
            this.lblNotFound.Size = new System.Drawing.Size(1453, 404);
            this.lblNotFound.TabIndex = 2;
            this.lblNotFound.Text = "Nada encontrado...";
            this.lblNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotFound.Visible = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1480, 673);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.gbSearchId);
            this.Controls.Add(this.gbAct);
            this.Controls.Add(this.lbInative);
            this.Controls.Add(this.lbActive);
            this.Controls.Add(this.lbTotal);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu cadastro clientes";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.gbAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.gbSearchId.ResumeLayout(false);
            this.gbSearchId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.GroupBox gbSearchId;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchDocName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchCivilState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSearchGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearchAddresss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSearchInative;
        private System.Windows.Forms.RadioButton rbSearchActive;
        private System.Windows.Forms.RadioButton rbSearchAll;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Label lbInative;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn sit_cadastro;
        private System.Windows.Forms.Label lblNotFound;
    }
}