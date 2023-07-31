using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model
{
    class HeroiDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            Herois heroi = new Herois();
            heroi = (Herois)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE HEROIS set nome = '" + heroi.NomePessoa +
                 "', anoNasc '" + heroi.AnoNasc +
                 "', idade'" + heroi.Idade +
                 "', email'" + heroi.Email +
                 "', nomeHeroi'" + heroi.NomeHeroi +
                 "', planetaOrigem'" + heroi.PlanetaOrigem +
                 "', atividadeProfissional'" + heroi.AtividadeProfissional +
                 "', parceiro '" + heroi.Parceiro +
                 "', superPoder '" + heroi.SuperPoder +
                 "', grupo '" + heroi.Grupo +
                 "' Where idHeroi =" + heroi.IdPessoa;
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
            Herois heroi = new Herois();
            heroi = (Herois)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM HEROIS WHERE idHeroi = " + heroi.IdPessoa;

            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Exuta a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    heroi.IdPessoa = dataReader.GetInt32(0);
                    heroi.NomePessoa = dataReader.GetString(1);
                    heroi.AnoNasc = dataReader.GetInt32(2);
                    heroi.Idade = dataReader.GetInt32(3);
                    heroi.Email = dataReader.GetString(4);
                    heroi.NomeHeroi = dataReader.GetString(5);
                    heroi.PlanetaOrigem = dataReader.GetString(6);
                    heroi.AtividadeProfissional = dataReader.GetString(7);
                    heroi.Parceiro = dataReader.GetString(8);
                    heroi.SuperPoder = dataReader.GetString(9);
                    heroi.Grupo = dataReader.GetString(10);

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
            Herois heroi = new Herois();
            heroi = (Herois)objeto;

            DataTable dataTable = new DataTable();

            string SELECT = "SELECT * FROM HEROIS WHERE idHeroi = " + heroi.IdPessoa;

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
                    dataTable.Columns.Add("NomeHeroi", typeof(string));
                    dataTable.Columns.Add("PlanetaOrigem", typeof(string));
                    dataTable.Columns.Add("AtividadeProfissional", typeof(string));
                    dataTable.Columns.Add("Parceiro", typeof(string));
                    dataTable.Columns.Add("SuperPoder", typeof(string));
                    dataTable.Columns.Add("Grupo", typeof(string));

                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();

                        row["IdPessoa"] = Convert.ToInt32(dataReader[0].ToString());
                        row["NomePessoa"] = dataReader[1].ToString();
                        row["AnoNasc"] = Convert.ToInt32(dataReader[2].ToString());
                        row["Idade"] = Convert.ToInt32(dataReader[3].ToString());
                        row["Email"] = dataReader[4].ToString();
                        row["NomeHeroi"] = dataReader[5].ToString();
                        row["PlanetaOrigem"] = dataReader[6].ToString();
                        row["AtividadeProfissional"] = dataReader[7].ToString();
                        row["Parceiro"] = dataReader[8].ToString();
                        row["SuperPoder"] = dataReader[9].ToString();
                        row["Grupo"] = dataReader[10].ToString();
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
            List<object> listaHeroi = null;
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
                    listaHeroi = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    Herois heroi = new Herois();
                    heroi.IdPessoa = dataReader.GetInt32(0);
                    heroi.NomePessoa = dataReader.GetString(1);
                    heroi.AnoNasc = dataReader.GetInt32(2);
                    heroi.Idade = dataReader.GetInt32(3);
                    heroi.Email = dataReader.GetString(4);
                    heroi.NomeHeroi = dataReader.GetString(6);
                    heroi.PlanetaOrigem = dataReader.GetString(7);
                    heroi.AtividadeProfissional = dataReader.GetString(8);
                    heroi.Parceiro = dataReader.GetString(9);
                    heroi.SuperPoder = dataReader.GetString(10);
                    heroi.Grupo = dataReader.GetString(11);

                    listaHeroi.Add(heroi);
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
            return listaHeroi;
        }

        public bool excluir(object objeto)
        {
            Herois heroi = new Herois();
            heroi = (Herois)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM herois WHERE idHeroi = " + heroi.IdPessoa;
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
            Herois heroi = new Herois();
            heroi = (Herois)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO HEROIS (nome, anoNasc, idade, " +
                "email, nomeHeroi, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo) " +
                "values (' " + heroi.NomePessoa +
                "', '" + heroi.AnoNasc +
                "', '" + heroi.Idade +
                "', '" + heroi.Email +
                "', '" + heroi.NomeHeroi +
                "', '" + heroi.PlanetaOrigem +
                "', '" + heroi.AtividadeProfissional +
                "', '" + heroi.Parceiro +
                "', '" + heroi.SuperPoder +
                "', '" + heroi.Grupo +
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
            Herois heroi = (Herois)objeto;
            int idGerado = 0;

            string INSERT = "INSERT INTO HEROIS (nome, anoNasc, idade, " +
                "email, nomeHeroi, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo) " +
                "VALUES ('" + heroi.NomePessoa +
                "', '" + heroi.AnoNasc +
                "', '" + heroi.Idade +
                "', '" + heroi.Email +
                "', '" + heroi.NomeHeroi +
                "', '" + heroi.PlanetaOrigem +
                "', '" + heroi.AtividadeProfissional +
                "', '" + heroi.Parceiro +
                "', '" + heroi.SuperPoder +
                "', '" + heroi.Grupo +
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


