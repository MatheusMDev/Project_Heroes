using HeroisViloes.View;
using System;
using System.Windows.Forms;
using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using HeroisViloes.Model;

namespace HeroisViloes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // nome
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // ano nascimento = txtAnoNascimento
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btHeroi_Click(object sender, EventArgs e)
        {
            SuperHeroi formHeroi = new SuperHeroi();


            formHeroi.ValorTxtAno = txtAnoNascimento.Text.ToString();           
            formHeroi.ValorTextBoxH = textBox1.Text;
            formHeroi.ValorTxtEmail = txtEmail.Text;
            

            formHeroi.Show();
        }




        private void btAmigoHeroi_Click(object sender, EventArgs e)
        {
            AmigoHeroi formAmigoHeroi = new AmigoHeroi();

     
            formAmigoHeroi.ValorTxtAnoN = txtAnoNascimento.Text.ToString();
            formAmigoHeroi.ValorTextBoxAH = textBox1.Text;
            formAmigoHeroi.ValorTxtEmail = txtEmail.Text;


            formAmigoHeroi.Show();
        }

        private void btVilao_Click(object sender, EventArgs e)
        {
            Vilao formVilao = new Vilao();

            formVilao.ValorTxtAno = txtAnoNascimento.Text.ToString();
            formVilao.ValorTextBoxV = textBox1.Text;
            formVilao.ValorTxtEmail = txtEmail.Text;


            formVilao.ShowDialog();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e) // foto de fundo
        {

        }

        private void lbDigit_Click(object sender, EventArgs e) // frase digite abaixo
        {

        }

        private void bt_lista_Click(object sender, EventArgs e)
        {
            Excluir formexcluir = new Excluir();
            formexcluir.ShowDialog();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            Pesquisar formpesquisar = new Pesquisar();
            formpesquisar.ShowDialog();
        }
    }
}
