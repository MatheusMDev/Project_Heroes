using HeroisViloes.Model.Entities;
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
using HeroisViloes.Model;
using HeroisViloes.View;


namespace HeroisViloes.View
{
    public partial class SuperHeroi : Form
    {
        public SuperHeroi()
        {
            InitializeComponent();
        }
          public string ValorTextBoxH
        {
            get { return textBoxH.Text; }
            set { textBoxH.Text = value; }
        }

        public string ValorTxtAno
        {
            get { return txtAnoNascimento.Text; }
            set { txtAnoNascimento.Text = value; }
        }
        public string ValorTxtEmail
        {
            get { return txt_Email.Text; }
            set { txt_Email.Text = value; }
        }



        private void lb_digite_Click(object sender, EventArgs e) // ABAIXO
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbgrupo_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            HeroiDAO hidao = new HeroiDAO();
            Herois herois = new Herois();

            herois.NomeHeroi = txtnomeSuperHeroi.Text;
            herois.Grupo = txtgrupo.Text;
            herois.PlanetaOrigem = txtplaneta1.Text;
            herois.SuperPoder = txtPoder.Text;
            herois.Parceiro = txtparceiro.Text;
            herois.AtividadeProfissional = textBox1.Text;
            herois.NomePessoa = textBoxH.Text;
            herois.Email = txt_Email.Text;

            int anoNascimento;
            if (int.TryParse(txtAnoNascimento.Text, out anoNascimento))
            {
                herois.AnoNasc = anoNascimento;
                int anoAtual = DateTime.Now.Year;
                int idade = anoAtual - anoNascimento;

                // Atribuir a idade à propriedade Idade do objeto herois
                herois.Idade = idade;
            }

            int idInserido = hidao.inserir1(herois);
            MessageBox.Show("Cadastrado com Sucesso. \nID: " + idInserido + "\nLembre-se deste ID para futuras pesquisas e exclusões.");

        }


        private void txtnomeSuperHeroi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtplaneta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbnomeSuperHeroi_Click(object sender, EventArgs e)
        {

        }

        private void SuperHeroi_Load(object sender, EventArgs e)
        {

        }

        public void textBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtAnoNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
