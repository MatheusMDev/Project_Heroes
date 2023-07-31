using HeroisViloes.Model;
using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HeroisViloes.View
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            HeroiDAO hidao = new HeroiDAO();
            Herois herois = new Herois();

            AmigoHeroiDao amigoHiDao = new AmigoHeroiDao();
            AmigosHeroi amigoHeroi = new AmigosHeroi();

            VilaoiDao vilDao = new VilaoiDao();
            Viloes viloes = new Viloes();

            int IdPessoa;
            if (int.TryParse(textBox1.Text, out IdPessoa))
            {
                herois.IdPessoa = IdPessoa;
                amigoHeroi.IdPessoa = IdPessoa;
                viloes.IdPessoa= IdPessoa;  
            }

            hidao.excluir(herois);
            amigoHiDao.excluir(amigoHeroi);
            vilDao.excluir(viloes);

            MessageBox.Show("Cadastro Excluído com Sucesso");
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // ID _ NOME
        {

        }

        private void bt_voltar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
