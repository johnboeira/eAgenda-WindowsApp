
namespace eAgenda.WindowsApp
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lbleAgenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblCompromisso = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbleAgenda
            // 
            this.lbleAgenda.AutoSize = true;
            this.lbleAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lbleAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbleAgenda.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleAgenda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbleAgenda.Location = new System.Drawing.Point(127, 9);
            this.lbleAgenda.Name = "lbleAgenda";
            this.lbleAgenda.Size = new System.Drawing.Size(150, 40);
            this.lbleAgenda.TabIndex = 0;
            this.lbleAgenda.Text = "eAgenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesse:";
            // 
            // btnTarefa
            // 
            this.btnTarefa.BackColor = System.Drawing.Color.Transparent;
            this.btnTarefa.FlatAppearance.BorderSize = 0;
            this.btnTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefa.Image = ((System.Drawing.Image)(resources.GetObject("btnTarefa.Image")));
            this.btnTarefa.Location = new System.Drawing.Point(27, 150);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(105, 95);
            this.btnTarefa.TabIndex = 2;
            this.btnTarefa.UseVisualStyleBackColor = false;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click_1);
            this.btnTarefa.MouseLeave += new System.EventHandler(this.btnTarefa_MouseLeave);
            this.btnTarefa.MouseHover += new System.EventHandler(this.btnTarefa_MouseHover);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.BackColor = System.Drawing.Color.Transparent;
            this.btnCompromisso.FlatAppearance.BorderSize = 0;
            this.btnCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompromisso.Image = ((System.Drawing.Image)(resources.GetObject("btnCompromisso.Image")));
            this.btnCompromisso.Location = new System.Drawing.Point(149, 150);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(105, 95);
            this.btnCompromisso.TabIndex = 3;
            this.btnCompromisso.UseVisualStyleBackColor = false;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click_1);
            this.btnCompromisso.MouseLeave += new System.EventHandler(this.btnCompromisso_MouseLeave_1);
            this.btnCompromisso.MouseHover += new System.EventHandler(this.btnCompromisso_MouseHover_1);
            // 
            // btnContato
            // 
            this.btnContato.BackColor = System.Drawing.Color.Transparent;
            this.btnContato.FlatAppearance.BorderSize = 0;
            this.btnContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContato.Image = ((System.Drawing.Image)(resources.GetObject("btnContato.Image")));
            this.btnContato.Location = new System.Drawing.Point(275, 150);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(105, 95);
            this.btnContato.TabIndex = 4;
            this.btnContato.UseVisualStyleBackColor = false;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click_1);
            this.btnContato.MouseLeave += new System.EventHandler(this.btnContato_MouseLeave_1);
            this.btnContato.MouseHover += new System.EventHandler(this.btnContato_MouseHover_1);
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.BackColor = System.Drawing.Color.Transparent;
            this.lblTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTarefa.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTarefa.Location = new System.Drawing.Point(42, 248);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(76, 23);
            this.lblTarefa.TabIndex = 5;
            this.lblTarefa.Text = "Tarefa";
            // 
            // lblCompromisso
            // 
            this.lblCompromisso.AutoSize = true;
            this.lblCompromisso.BackColor = System.Drawing.Color.Transparent;
            this.lblCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompromisso.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompromisso.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblCompromisso.Location = new System.Drawing.Point(130, 248);
            this.lblCompromisso.Name = "lblCompromisso";
            this.lblCompromisso.Size = new System.Drawing.Size(131, 23);
            this.lblCompromisso.TabIndex = 6;
            this.lblCompromisso.Text = "Compromisso";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContato.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblContato.Location = new System.Drawing.Point(281, 248);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(87, 23);
            this.lblContato.TabIndex = 7;
            this.lblContato.Text = "Contato";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(395, 301);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblCompromisso);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbleAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblCompromisso;
        private System.Windows.Forms.Label lblContato;
    }
}