using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroisViloes.Model;
using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HeroisViloes.View
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void bt_voltar1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btpesquisa1_Click(object sender, EventArgs e)
        {
            HeroiDAO hidao = new HeroiDAO();
            Herois herois = new Herois();

            AmigoHeroiDao amigoHiDao = new AmigoHeroiDao();
            AmigosHeroi amigoHeroi = new AmigosHeroi();

            VilaoiDao vilDao = new VilaoiDao();
            Viloes viloes = new Viloes();

            int IdPessoa;
            if (int.TryParse(txtpesquisar.Text, out IdPessoa))
            {
                herois.IdPessoa = IdPessoa;
                amigoHeroi.IdPessoa = IdPessoa;
                viloes.IdPessoa = IdPessoa;
            }

            DataTable heroisDataTable = hidao.consultar1(herois);
            DataTable amigoHeroiDataTable = amigoHiDao.consultar1(amigoHeroi);
            DataTable viloesDataTable = vilDao.consultar1(viloes);

            // Mesclar os resultados das três tabelas em um único DataTable
            DataTable mergedDataTable = new DataTable();

            mergedDataTable.Merge(heroisDataTable);
            mergedDataTable.Merge(amigoHeroiDataTable);
            mergedDataTable.Merge(viloesDataTable);

            dgpesquisa.DataSource = mergedDataTable;
        }


        private void dgpesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
