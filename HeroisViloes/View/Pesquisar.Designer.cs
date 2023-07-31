namespace HeroisViloes.View
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            this.lbsearch = new System.Windows.Forms.Label();
            this.lbnomepesq = new System.Windows.Forms.Label();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.dgpesquisa = new System.Windows.Forms.DataGridView();
            this.btpesquisa1 = new System.Windows.Forms.Button();
            this.bt_voltar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgpesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbsearch
            // 
            this.lbsearch.AutoSize = true;
            this.lbsearch.BackColor = System.Drawing.Color.Transparent;
            this.lbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsearch.ForeColor = System.Drawing.Color.Snow;
            this.lbsearch.Location = new System.Drawing.Point(441, 11);
            this.lbsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(166, 36);
            this.lbsearch.TabIndex = 0;
            this.lbsearch.Text = "Pesquisar:";
            // 
            // lbnomepesq
            // 
            this.lbnomepesq.AutoSize = true;
            this.lbnomepesq.BackColor = System.Drawing.Color.Transparent;
            this.lbnomepesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnomepesq.ForeColor = System.Drawing.Color.Snow;
            this.lbnomepesq.Location = new System.Drawing.Point(156, 71);
            this.lbnomepesq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnomepesq.Name = "lbnomepesq";
            this.lbnomepesq.Size = new System.Drawing.Size(131, 29);
            this.lbnomepesq.TabIndex = 1;
            this.lbnomepesq.Text = "Digite o ID:";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(340, 78);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(345, 22);
            this.txtpesquisar.TabIndex = 2;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
            // 
            // dgpesquisa
            // 
            this.dgpesquisa.AllowUserToAddRows = false;
            this.dgpesquisa.AllowUserToDeleteRows = false;
            this.dgpesquisa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgpesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpesquisa.Location = new System.Drawing.Point(87, 134);
            this.dgpesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgpesquisa.Name = "dgpesquisa";
            this.dgpesquisa.ReadOnly = true;
            this.dgpesquisa.RowHeadersWidth = 51;
            this.dgpesquisa.Size = new System.Drawing.Size(905, 303);
            this.dgpesquisa.TabIndex = 3;
            this.dgpesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpesquisa_CellContentClick);
            // 
            // btpesquisa1
            // 
            this.btpesquisa1.Location = new System.Drawing.Point(745, 64);
            this.btpesquisa1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btpesquisa1.Name = "btpesquisa1";
            this.btpesquisa1.Size = new System.Drawing.Size(155, 50);
            this.btpesquisa1.TabIndex = 4;
            this.btpesquisa1.Text = "Buscar";
            this.btpesquisa1.UseVisualStyleBackColor = true;
            this.btpesquisa1.Click += new System.EventHandler(this.btpesquisa1_Click);
            // 
            // bt_voltar1
            // 
            this.bt_voltar1.Location = new System.Drawing.Point(460, 462);
            this.bt_voltar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_voltar1.Name = "bt_voltar1";
            this.bt_voltar1.Size = new System.Drawing.Size(144, 78);
            this.bt_voltar1.TabIndex = 30;
            this.bt_voltar1.Text = "Voltar";
            this.bt_voltar1.UseVisualStyleBackColor = true;
            this.bt_voltar1.Click += new System.EventHandler(this.bt_voltar1_Click);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_voltar1);
            this.Controls.Add(this.btpesquisa1);
            this.Controls.Add(this.dgpesquisa);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.lbnomepesq);
            this.Controls.Add(this.lbsearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.dgpesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbsearch;
        private System.Windows.Forms.Label lbnomepesq;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.DataGridView dgpesquisa;
        private System.Windows.Forms.Button btpesquisa1;
        private System.Windows.Forms.Button bt_voltar1;
    }
}