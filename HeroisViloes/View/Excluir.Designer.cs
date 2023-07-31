namespace HeroisViloes.View
{
    partial class Excluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir));
            this.bt_excluir = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDigit = new System.Windows.Forms.Label();
            this.bt_voltar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(745, 256);
            this.bt_excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(159, 64);
            this.bt_excluir.TabIndex = 17;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Transparent;
            this.lbNome.Location = new System.Drawing.Point(251, 261);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(64, 39);
            this.lbNome.TabIndex = 18;
            this.lbNome.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 277);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbDigit
            // 
            this.lbDigit.AutoSize = true;
            this.lbDigit.BackColor = System.Drawing.Color.Transparent;
            this.lbDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDigit.ForeColor = System.Drawing.Color.Transparent;
            this.lbDigit.Location = new System.Drawing.Point(266, 35);
            this.lbDigit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDigit.Name = "lbDigit";
            this.lbDigit.Size = new System.Drawing.Size(518, 36);
            this.lbDigit.TabIndex = 20;
            this.lbDigit.Text = "Digite Quem Deseja Excluir Abaixo:";
            // 
            // bt_voltar1
            // 
            this.bt_voltar1.Location = new System.Drawing.Point(45, 462);
            this.bt_voltar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_voltar1.Name = "bt_voltar1";
            this.bt_voltar1.Size = new System.Drawing.Size(144, 78);
            this.bt_voltar1.TabIndex = 29;
            this.bt_voltar1.Text = "Voltar";
            this.bt_voltar1.UseVisualStyleBackColor = true;
            this.bt_voltar1.Click += new System.EventHandler(this.bt_voltar1_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_voltar1);
            this.Controls.Add(this.lbDigit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.bt_excluir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDigit;
        private System.Windows.Forms.Button bt_voltar1;
    }
}