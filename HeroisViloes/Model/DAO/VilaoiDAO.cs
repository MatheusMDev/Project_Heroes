using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using HeroisViloes.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model
{
    class VilaoiDao : IDao
    {
        public bool atualizar(object objeto)
        {
            Viloes vilao = new Viloes();
            vilao = (Viloes)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE VILOES set nome = '" + vilao.NomePessoa +
                 "', anoNasc '" + vilao.AnoNasc +
                 "', idade'" + vilao.Idade +
                 "', email'" + vilao.Email +
                 "', nomeVilao'" + vilao.NomeVilao +
                 "', planetaOrigem'" + vilao.PlanetaOrigem +
                 "', parceiro '" + vilao.Parceiro +
                 "', superPoder '" + vilao.SuperPoder +
                 "' Where idHeroi =" + vilao.IdPessoa;
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Atualização" + ex);
            }
            finally { Conexao.fecharConexao(); }
            return sucesso;

        }

        public bool consultar(object objeto)
        {
            Viloes vilao = new Viloes();
            vilao = (Viloes)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM VILOES WHERE idVilao = " + vilao.IdPessoa;

            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Excuta a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    vilao.IdPessoa = dataReader.GetInt32(0);
                    vilao.NomePessoa = dataReader.GetString(1);
                    vilao.AnoNasc = dataReader.GetInt32(2);
                    vilao.Idade = dataReader.GetInt32(3);
                    vilao.Email = dataReader.GetString(4);
                    vilao.NomeVilao = dataReader.GetString(6);
                    vilao.PlanetaOrigem = dataReader.GetString(7);
                    vilao.Parceiro = dataReader.GetString(9);
                    vilao.SuperPoder = dataReader.GetString(10);

                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }

        public DataTable consultar1(object objeto)
        {
            Viloes vilao = new Viloes();
            vilao = (Viloes)objeto;

            DataTable dataTable = new DataTable();

            string SELECT = "SELECT * FROM VILOES WHERE idVilao = " + vilao.IdPessoa;
            SqlDataReader dataReader = null;

            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataTable.Columns.Add("IdPessoa", typeof(int));
                    dataTable.Columns.Add("NomePessoa", typeof(string));
                    dataTable.Columns.Add("AnoNasc", typeof(int));
                    dataTable.Columns.Add("Idade", typeof(int));
                    dataTable.Columns.Add("Email", typeof(string));
                    dataTable.Columns.Add("NomeVilao", typeof(string));
                    dataTable.Columns.Add("PlanetaOrigem", typeof(string));
                    dataTable.Columns.Add("Parceiro", typeof(string));
                    dataTable.Columns.Add("SuperPoder", typeof(string));

                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();

                        row["IdPessoa"] = Convert.ToInt32(dataReader[0].ToString());
                        row["NomePessoa"] = dataReader[1].ToString();
                        row["AnoNasc"] = Convert.ToInt32(dataReader[2].ToString());
                        row["Idade"] = Convert.ToInt32(dataReader[3].ToString());
                        row["Email"] = dataReader[4].ToString();
                        row["NomeVilao"] = dataReader[5].ToString();
                        row["PlanetaOrigem"] = dataReader[6].ToString();
                        row["Parceiro"] = dataReader[7].ToString();
                        row["SuperPoder"] = dataReader[8].ToString();
                        dataTable.Rows.Add(row);
                    }
                }

                command.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }

            return dataTable;
        }


        public List<object> consultar(string sql)
        {
            List<object> listaViloes = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(sql, conexaoDB);

                // DataReader ira receber o resultada da consulta 
                //Somente para leitura
                SqlDataReader dataReader;

                // Executa a consulta 
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    listaViloes = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                        Viloes vilao = new Viloes();
                    vilao.IdPessoa = dataReader.GetInt32(0);
                    vilao.NomePessoa = dataReader.GetString(1);
                    vilao.AnoNasc = dataReader.GetInt32(2);
                    vilao.Idade = dataReader.GetInt32(3);
                    vilao.Email = dataReader.GetString(4);
                    vilao.NomeVilao = dataReader.GetString(5);
                    vilao.PlanetaOrigem = dataReader.GetString(6);
                    vilao.Parceiro = dataReader.GetString(7);
                    vilao.SuperPoder = dataReader.GetString(8);

                    listaViloes.Add(vilao);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return listaViloes;
        }

        public bool excluir(object objeto)
        {
            Viloes vilao = new Viloes();
            vilao = (Viloes)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM viloes WHERE idVilao = " + vilao.IdPessoa;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, conexaoDB);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }

        public bool inserir(object objeto)
        {
            Viloes vilao = new Viloes();
            vilao = (Viloes)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO VILOES (nome, anoNasc, idade, " +
                "email, nomeVilao, planetaOrigem, " +
                "parceiro, superPoder) " +
                "values (' " + vilao.NomePessoa +
                "', '" + vilao.AnoNasc +
                "', '" + vilao.Idade +
                "', '" + vilao.Email +
                "', '" + vilao.NomeVilao +
                "', '" + vilao.PlanetaOrigem +
                "', '" + vilao.Parceiro +
                "', '" + vilao.SuperPoder +
                "' )";

            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Inscrição");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de Inserção " + ex);
            }

            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
        public int inserir1(object objeto)
        {
            Viloes vilao = (Viloes)objeto;
            int idGerado = 0;

            string INSERT = "INSERT INTO VILOES (nome, anoNasc, idade, " +
                "email, nomeVilao, planetaOrigem, " +
                "parceiro, superPoder) " +
                "VALUES ('" + vilao.NomePessoa +
                "', '" + vilao.AnoNasc +
                "', '" + vilao.Idade +
                "', '" + vilao.Email +
                "', '" + vilao.NomeVilao +
                "', '" + vilao.PlanetaOrigem +
                "', '" + vilao.Parceiro +
                "', '" + vilao.SuperPoder +
                "'); SELECT SCOPE_IDENTITY();";

            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

                idGerado = Convert.ToInt32(command.ExecuteScalar());

                Console.WriteLine("Sucesso na Inscrição");
                command.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de Inserção " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }

            return idGerado;
        }


    }
}


