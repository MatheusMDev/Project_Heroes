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
    class AmigoHeroiDao : IDao
    {
        public bool atualizar(object objeto)
        {
            AmigosHeroi AmigoHeroi = new AmigosHeroi();
            AmigoHeroi = (AmigosHeroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE AMIGOSHEROI set nome = '" + AmigoHeroi.NomePessoa +
                 "', anoNasc '" + AmigoHeroi.AnoNasc +
                 "', idade'" + AmigoHeroi.Idade +
                 "', email'" + AmigoHeroi.Email +
                 "', atividadeProfissional'" + AmigoHeroi.AtividadeProfissional +
                 "', hobby '" + AmigoHeroi.Hobby +
                 "' Where idAmigo =" + AmigoHeroi.IdPessoa;
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
            AmigosHeroi AmigoHeroi = new AmigosHeroi();
            AmigoHeroi = (AmigosHeroi)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM AMIGOSHEROI WHERE idAmigo = " + AmigoHeroi.IdPessoa;

            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Executa a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    AmigoHeroi.IdPessoa = dataReader.GetInt32(0);
                    AmigoHeroi.NomePessoa = dataReader.GetString(1);
                    AmigoHeroi.AnoNasc = dataReader.GetInt32(2);
                    AmigoHeroi.Idade = dataReader.GetInt32(3);
                    AmigoHeroi.Email = dataReader.GetString(4);
                    AmigoHeroi.Hobby = dataReader.GetString(5);
                    AmigoHeroi.AtividadeProfissional = dataReader.GetString(6);

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
            AmigosHeroi amigoHeroi = new AmigosHeroi();
            amigoHeroi = (AmigosHeroi)objeto;

            DataTable dataTable = new DataTable();

            string SELECT = "SELECT * FROM AMIGOSHEROI WHERE idAmigo = " + amigoHeroi.IdPessoa;

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
                    dataTable.Columns.Add("Hobby", typeof(string));
                    dataTable.Columns.Add("AtividadeProfissional", typeof(string));


                    while (dataReader.Read())
                    {
                        DataRow row = dataTable.NewRow();

                        row["IdPessoa"] = Convert.ToInt32(dataReader[0].ToString());
                        row["NomePessoa"] = dataReader[1].ToString();
                        row["AnoNasc"] = Convert.ToInt32(dataReader[2].ToString());
                        row["Idade"] = Convert.ToInt32(dataReader[3].ToString());
                        row["Email"] = dataReader[4].ToString();
                        row["Hobby"] = dataReader[5].ToString();
                        row["AtividadeProfissional"] = dataReader[6].ToString();
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
            List<object> listaAmigoHeroi = null;
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
                    listaAmigoHeroi = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    AmigosHeroi AmigoHeroi = new AmigosHeroi();
                    AmigoHeroi.IdPessoa = dataReader.GetInt32(0);
                    AmigoHeroi.NomePessoa = dataReader.GetString(1);
                    AmigoHeroi.AnoNasc = dataReader.GetInt32(2);
                    AmigoHeroi.Idade = dataReader.GetInt32(3);
                    AmigoHeroi.Email = dataReader.GetString(4);
                    AmigoHeroi.Hobby = dataReader.GetString(5);
                    AmigoHeroi.AtividadeProfissional = dataReader.GetString(6);
                    listaAmigoHeroi.Add(AmigoHeroi);
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
            return listaAmigoHeroi;
        }

        public bool excluir(object objeto)
        {
            AmigosHeroi AmigoHeroi = new AmigosHeroi();
            AmigoHeroi = (AmigosHeroi)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM AMIGOSHEROI WHERE idAmigo = " + AmigoHeroi.IdPessoa;
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
            AmigosHeroi AmigoHeroi = new AmigosHeroi();
            AmigoHeroi = (AmigosHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO AMIGOSHEROI (nome, anoNasc, idade, " +
                "email,hobby, atividadeProfissional) " +
                "values (' " + AmigoHeroi.NomePessoa +
                "', '" + AmigoHeroi.AnoNasc +
                "', '" + AmigoHeroi.Idade +
                "', '" + AmigoHeroi.Email +
                "', '" + AmigoHeroi.Hobby +
                "', '" + AmigoHeroi.AtividadeProfissional +
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
            AmigosHeroi amigoHeroi = (AmigosHeroi)objeto;
            int idGerado = 0;

            string INSERT = "INSERT INTO AMIGOSHEROI (nome, anoNasc, idade, " +
                "email,hobby, atividadeProfissional) " +
                "VALUES ('" + amigoHeroi.NomePessoa +
                "', '" + amigoHeroi.AnoNasc +
                "', '" + amigoHeroi.Idade +
                "', '" + amigoHeroi.Email +
                "', '" + amigoHeroi.Hobby +
                "', '" + amigoHeroi.AtividadeProfissional +
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


