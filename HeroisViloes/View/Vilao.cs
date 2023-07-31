using HeroisViloes.Model.Entities;
using HeroisViloes.Model;
using HeroisViloes.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeroisViloes.View
{
    public partial class Vilao : Form
    {
        public Vilao()
        {
            InitializeComponent();
        }

        public string ValorTextBoxV
        {
            get { return textBox1V.Text; }
            set { textBox1V.Text = value; }
        }

        public string ValorTxtAno
        {
            get { return txtAnoNascimentoV.Text; }
            set { txtAnoNascimentoV.Text = value; }
        }
        public string ValorTxtEmail
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
       

        private void Vilao_Load(object sender, EventArgs e)
        {

        }

        private void txtnomeHeroi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbnomeHeroi_Click(object sender, EventArgs e)
        {

        }

        private void bt_voltar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cadastrar1_Click(object sender, EventArgs e)
        {
            VilaoiDao vilDao = new VilaoiDao();
            Viloes viloes = new Viloes();

            viloes.NomeVilao = txtnomeHeroi.Text;
            viloes.SuperPoder = txt_poder.Text;  
            viloes.PlanetaOrigem = txt_planeta.Text;
            viloes.Parceiro = txt_parceiro.Text;
            viloes.Email = txtEmail.Text;
            viloes.NomePessoa = textBox1V.Text;

            int anoNascimento;
            if (int.TryParse(txtAnoNascimentoV.Text, out anoNascimento))
            {
                viloes.AnoNasc = anoNascimento;
                int anoAtual = DateTime.Now.Year;
                int idade = anoAtual - anoNascimento;

                // Atribuir a idade à propriedade Idade do objeto herois
                viloes.Idade = idade;
            }


            int idInserido = vilDao.inserir1(viloes);
            MessageBox.Show("Cadastrado com Sucesso.  \nID: " + idInserido + "\nLembre-se deste ID para futuras pesquisas e exclusões.");
        }

        private void txt_parceiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_planeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_poder_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1V_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoNascimentoV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
