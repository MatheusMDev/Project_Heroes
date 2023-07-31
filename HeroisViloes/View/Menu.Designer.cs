namespace HeroisViloes
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbaNasc = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbRepresent = new System.Windows.Forms.Label();
            this.btHeroi = new System.Windows.Forms.Button();
            this.btVilao = new System.Windows.Forms.Button();
            this.btAmigoHeroi = new System.Windows.Forms.Button();
            this.lbDigit = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.bt_lista = new System.Windows.Forms.Button();
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Snow;
            this.lbWelcome.Location = new System.Drawing.Point(244, 0);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(577, 31);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Olá, Seja Bem Vindo ao Sistema de Heróis!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(441, 129);
            this.txtAnoNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(212, 22);
            this.txtAnoNascimento.TabIndex = 2;
            this.txtAnoNascimento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(777, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Snow;
            this.lbNome.Location = new System.Drawing.Point(128, 105);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(63, 20);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome:";
            // 
            // lbaNasc
            // 
            this.lbaNasc.AutoSize = true;
            this.lbaNasc.BackColor = System.Drawing.Color.Transparent;
            this.lbaNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaNasc.ForeColor = System.Drawing.Color.Snow;
            this.lbaNasc.Location = new System.Drawing.Point(457, 105);
            this.lbaNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbaNasc.Name = "lbaNasc";
            this.lbaNasc.Size = new System.Drawing.Size(178, 20);
            this.lbaNasc.TabIndex = 6;
            this.lbaNasc.Text = "Ano de Nascimento:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.Color.Snow;
            this.lbemail.Location = new System.Drawing.Point(862, 105);
            this.lbemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(69, 20);
            this.lbemail.TabIndex = 7;
            this.lbemail.Text = "E-Mail:";
            // 
            // lbRepresent
            // 
            this.lbRepresent.AutoSize = true;
            this.lbRepresent.BackColor = System.Drawing.Color.Transparent;
            this.lbRepresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepresent.ForeColor = System.Drawing.Color.Snow;
            this.lbRepresent.Location = new System.Drawing.Point(357, 187);
            this.lbRepresent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRepresent.Name = "lbRepresent";
            this.lbRepresent.Size = new System.Drawing.Size(367, 31);
            this.lbRepresent.TabIndex = 9;
            this.lbRepresent.Text = "Qual Botão te Representa?";
            // 
            // btHeroi
            // 
            this.btHeroi.BackColor = System.Drawing.Color.White;
            this.btHeroi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btHeroi.BackgroundImage")));
            this.btHeroi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHeroi.Location = new System.Drawing.Point(68, 242);
            this.btHeroi.Margin = new System.Windows.Forms.Padding(4);
            this.btHeroi.Name = "btHeroi";
            this.btHeroi.Size = new System.Drawing.Size(147, 123);
            this.btHeroi.TabIndex = 11;
            this.btHeroi.UseVisualStyleBackColor = false;
            this.btHeroi.Click += new System.EventHandler(this.btHeroi_Click);
            // 
            // btVilao
            // 
            this.btVilao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVilao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVilao.BackgroundImage")));
            this.btVilao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVilao.Location = new System.Drawing.Point(825, 242);
            this.btVilao.Margin = new System.Windows.Forms.Padding(4);
            this.btVilao.Name = "btVilao";
            this.btVilao.Size = new System.Drawing.Size(147, 123);
            this.btVilao.TabIndex = 12;
            this.btVilao.UseVisualStyleBackColor = false;
            this.btVilao.Click += new System.EventHandler(this.btVilao_Click);
            // 
            // btAmigoHeroi
            // 
            this.btAmigoHeroi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAmigoHeroi.Image = ((System.Drawing.Image)(resources.GetObject("btAmigoHeroi.Image")));
            this.btAmigoHeroi.Location = new System.Drawing.Point(461, 242);
            this.btAmigoHeroi.Margin = new System.Windows.Forms.Padding(4);
            this.btAmigoHeroi.Name = "btAmigoHeroi";
            this.btAmigoHeroi.Size = new System.Drawing.Size(147, 123);
            this.btAmigoHeroi.TabIndex = 13;
            this.btAmigoHeroi.UseVisualStyleBackColor = true;
            this.btAmigoHeroi.Click += new System.EventHandler(this.btAmigoHeroi_Click);
            // 
            // lbDigit
            // 
            this.lbDigit.AutoSize = true;
            this.lbDigit.BackColor = System.Drawing.Color.Transparent;
            this.lbDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDigit.ForeColor = System.Drawing.Color.Snow;
            this.lbDigit.Location = new System.Drawing.Point(471, 42);
            this.lbDigit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDigit.Name = "lbDigit";
            this.lbDigit.Size = new System.Drawing.Size(147, 25);
            this.lbDigit.TabIndex = 14;
            this.lbDigit.Text = "Digite Abaixo:";
            this.lbDigit.Click += new System.EventHandler(this.lbDigit_Click);
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.Location = new System.Drawing.Point(319, 444);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(431, 69);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // bt_lista
            // 
            this.bt_lista.BackColor = System.Drawing.Color.Transparent;
            this.bt_lista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_lista.BackgroundImage")));
            this.bt_lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_lista.Location = new System.Drawing.Point(825, 447);
            this.bt_lista.Margin = new System.Windows.Forms.Padding(4);
            this.bt_lista.Name = "bt_lista";
            this.bt_lista.Size = new System.Drawing.Size(159, 64);
            this.bt_lista.TabIndex = 16;
            this.bt_lista.UseVisualStyleBackColor = false;
            this.bt_lista.Click += new System.EventHandler(this.bt_lista_Click);
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisa.Image")));
            this.bt_pesquisa.Location = new System.Drawing.Point(68, 447);
            this.bt_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(159, 64);
            this.bt_pesquisa.TabIndex = 17;
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_pesquisa);
            this.Controls.Add(this.bt_lista);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbDigit);
            this.Controls.Add(this.btAmigoHeroi);
            this.Controls.Add(this.btVilao);
            this.Controls.Add(this.btHeroi);
            this.Controls.Add(this.lbRepresent);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbaNasc);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbWelcome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbaNasc;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbRepresent;
        private System.Windows.Forms.Button btHeroi;
        private System.Windows.Forms.Button btVilao;
        private System.Windows.Forms.Button btAmigoHeroi;
        private System.Windows.Forms.Label lbDigit;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button bt_lista;
        private System.Windows.Forms.Button bt_pesquisa;
    }
}

