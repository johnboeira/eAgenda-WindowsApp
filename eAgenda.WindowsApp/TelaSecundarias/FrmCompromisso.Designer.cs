
namespace eAgenda.WindowsApp
{
    partial class FrmCompromisso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompromisso));
            this.label2 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tmInicio = new System.Windows.Forms.DateTimePicker();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmTermino = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgCompromisso = new System.Windows.Forms.DataGridView();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTerminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBCOMPROMISSOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBeAgendaDataSet = new eAgenda.WindowsApp.DBeAgendaDataSet();
            this.tBCOMPROMISSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBCOMPROMISSOTableAdapter = new eAgenda.WindowsApp.DBeAgendaDataSetTableAdapters.TBCOMPROMISSOTableAdapter();
            this.cbContato = new System.Windows.Forms.ComboBox();
            this.tBCONTATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBCONTATOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBCONTATOTableAdapter = new eAgenda.WindowsApp.DBeAgendaDataSetTableAdapters.TBCONTATOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCOMPROMISSOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBeAgendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCOMPROMISSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONTATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONTATOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(348, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Link:";
            // 
            // txtLink
            // 
            this.txtLink.Enabled = false;
            this.txtLink.Location = new System.Drawing.Point(424, 55);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(217, 20);
            this.txtLink.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Contato:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Azure;
            this.lblTitulo.Location = new System.Drawing.Point(26, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(90, 22);
            this.lblTitulo.TabIndex = 50;
            this.lblTitulo.Text = "Assunto:";
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPercentual.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.ForeColor = System.Drawing.Color.Azure;
            this.lblPercentual.Location = new System.Drawing.Point(348, 16);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(70, 22);
            this.lblPercentual.TabIndex = 49;
            this.lblPercentual.Text = "Local:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Enabled = false;
            this.txtAssunto.Location = new System.Drawing.Point(122, 16);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(209, 20);
            this.txtAssunto.TabIndex = 48;
            // 
            // txtLocal
            // 
            this.txtLocal.Enabled = false;
            this.txtLocal.Location = new System.Drawing.Point(424, 19);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(217, 20);
            this.txtLocal.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(26, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "Data:";
            // 
            // tmInicio
            // 
            this.tmInicio.Enabled = false;
            this.tmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmInicio.Location = new System.Drawing.Point(320, 88);
            this.tmInicio.Name = "tmInicio";
            this.tmInicio.Size = new System.Drawing.Size(81, 20);
            this.tmInicio.TabIndex = 66;
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(92, 86);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(87, 20);
            this.dtData.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(184, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 68;
            this.label8.Text = "Hora Início:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(414, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 69;
            this.label9.Text = "Hora Termino:";
            // 
            // tmTermino
            // 
            this.tmTermino.Enabled = false;
            this.tmTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmTermino.Location = new System.Drawing.Point(560, 88);
            this.tmTermino.Name = "tmTermino";
            this.tmTermino.Size = new System.Drawing.Size(81, 20);
            this.tmTermino.TabIndex = 70;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(602, 288);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 20);
            this.txtId.TabIndex = 78;
            this.txtId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(393, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 77;
            this.label5.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(206, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "Salvar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(18, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Adicionar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(546, 314);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 95);
            this.btnExcluir.TabIndex = 74;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::eAgenda.WindowsApp.Properties.Resources.salvarInativo;
            this.btnSalvar.Location = new System.Drawing.Point(188, 314);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 95);
            this.btnSalvar.TabIndex = 73;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(375, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 95);
            this.btnEditar.TabIndex = 72;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(13, 314);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 95);
            this.btnAdicionar.TabIndex = 71;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(561, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "Excluir";
            // 
            // dgCompromisso
            // 
            this.dgCompromisso.AllowUserToDeleteRows = false;
            this.dgCompromisso.AutoGenerateColumns = false;
            this.dgCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompromisso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCompromisso.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompromisso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assuntoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaTerminoDataGridViewTextBoxColumn,
            this.Id,
            this.idContatoDataGridViewTextBoxColumn});
            this.dgCompromisso.DataSource = this.tBCOMPROMISSOBindingSource1;
            this.dgCompromisso.Location = new System.Drawing.Point(30, 128);
            this.dgCompromisso.Name = "dgCompromisso";
            this.dgCompromisso.ReadOnly = true;
            this.dgCompromisso.Size = new System.Drawing.Size(611, 191);
            this.dgCompromisso.TabIndex = 80;
            this.dgCompromisso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompromisso_CellClick);
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaTerminoDataGridViewTextBoxColumn
            // 
            this.horaTerminoDataGridViewTextBoxColumn.DataPropertyName = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn.HeaderText = "HoraTermino";
            this.horaTerminoDataGridViewTextBoxColumn.Name = "horaTerminoDataGridViewTextBoxColumn";
            this.horaTerminoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // idContatoDataGridViewTextBoxColumn
            // 
            this.idContatoDataGridViewTextBoxColumn.DataPropertyName = "Id_Contato";
            this.idContatoDataGridViewTextBoxColumn.HeaderText = "Id_Contato";
            this.idContatoDataGridViewTextBoxColumn.Name = "idContatoDataGridViewTextBoxColumn";
            this.idContatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idContatoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tBCOMPROMISSOBindingSource1
            // 
            this.tBCOMPROMISSOBindingSource1.DataMember = "TBCOMPROMISSO";
            this.tBCOMPROMISSOBindingSource1.DataSource = this.dBeAgendaDataSet;
            // 
            // dBeAgendaDataSet
            // 
            this.dBeAgendaDataSet.DataSetName = "DBeAgendaDataSet";
            this.dBeAgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCOMPROMISSOBindingSource
            // 
            this.tBCOMPROMISSOBindingSource.DataMember = "TBCOMPROMISSO";
            this.tBCOMPROMISSOBindingSource.DataSource = this.dBeAgendaDataSet;
            // 
            // tBCOMPROMISSOTableAdapter
            // 
            this.tBCOMPROMISSOTableAdapter.ClearBeforeFill = true;
            // 
            // cbContato
            // 
            this.cbContato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBCONTATOBindingSource, "Id", true));
            this.cbContato.DataSource = this.tBCONTATOBindingSource1;
            this.cbContato.DisplayMember = "Nome";
            this.cbContato.Enabled = false;
            this.cbContato.FormattingEnabled = true;
            this.cbContato.Location = new System.Drawing.Point(122, 52);
            this.cbContato.Name = "cbContato";
            this.cbContato.Size = new System.Drawing.Size(208, 21);
            this.cbContato.TabIndex = 81;
            this.cbContato.ValueMember = "Id";
            // 
            // tBCONTATOBindingSource
            // 
            this.tBCONTATOBindingSource.DataMember = "TBCONTATO";
            this.tBCONTATOBindingSource.DataSource = this.dBeAgendaDataSet;
            // 
            // tBCONTATOBindingSource1
            // 
            this.tBCONTATOBindingSource1.DataMember = "TBCONTATO";
            this.tBCONTATOBindingSource1.DataSource = this.dBeAgendaDataSet;
            // 
            // tBCONTATOTableAdapter
            // 
            this.tBCONTATOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.cbContato);
            this.Controls.Add(this.dgCompromisso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tmTermino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tmInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPercentual);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Compromisso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompromisso_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompromisso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCOMPROMISSOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBeAgendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCOMPROMISSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONTATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCONTATOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tmInicio;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tmTermino;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgCompromisso;
        private DBeAgendaDataSet dBeAgendaDataSet;
        private System.Windows.Forms.BindingSource tBCOMPROMISSOBindingSource;
        private DBeAgendaDataSetTableAdapters.TBCOMPROMISSOTableAdapter tBCOMPROMISSOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBCOMPROMISSOBindingSource1;
        private System.Windows.Forms.ComboBox cbContato;
        private System.Windows.Forms.BindingSource tBCONTATOBindingSource;
        private DBeAgendaDataSetTableAdapters.TBCONTATOTableAdapter tBCONTATOTableAdapter;
        private System.Windows.Forms.BindingSource tBCONTATOBindingSource1;
    }
}