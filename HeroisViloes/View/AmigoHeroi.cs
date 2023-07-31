using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroisViloes.Model.Entities;
using HeroisViloes.Model.DAO;
using HeroisViloes.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeroisViloes.View
{
    public partial class AmigoHeroi : Form
    {
        public AmigoHeroi()
        {
            InitializeComponent();
        }


        public string ValorTextBoxAH
        {
            get { return textBox1AH.Text; }
            set { textBox1AH.Text = value; }
        }

        public string ValorTxtAnoN
        {
            get { return txtAnoNascimentoAH.Text; }
            set { txtAnoNascimentoAH.Text = value; }
        }
        public string ValorTxtEmail
        {
            get { return txtEmailAH.Text; }
            set { txtEmailAH.Text = value; }
        }
        private void bt_voltar2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void bt_cadastrar2_Click(object sender, EventArgs e)
        {
           AmigoHeroiDao amigoHiDao = new AmigoHeroiDao();
            AmigosHeroi amigoHeroi = new AmigosHeroi();

            amigoHeroi.Hobby = txthobby.Text;
            amigoHeroi.AtividadeProfissional = txtprofissional.Text;
            amigoHeroi.Email = txtEmailAH.Text;
            amigoHeroi.NomePessoa = textBox1AH.Text;

            int anoNascimento;
            if (int.TryParse(txtAnoNascimentoAH.Text, out anoNascimento))
            {
                amigoHeroi.AnoNasc = anoNascimento;
                int anoAtual = DateTime.Now.Year;
                int idade = anoAtual - anoNascimento;

                // Atribuir a idade à propriedade Idade do objeto herois
                 amigoHeroi.Idade = idade;
            }



             int idInserido = amigoHiDao.inserir1(amigoHeroi);
             MessageBox.Show("Cadastrado com Sucesso. \nID: " + idInserido + "\nLembre-se deste ID para futuras pesquisas e exclusões.");
        }

        private void lbemailAH_Click(object sender, EventArgs e)
        {

        }

        private void textBox1AH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoNascimentoAH_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmigoHeroi_Load(object sender, EventArgs e)
        {

        }

        private void txtEmailAH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDAH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
