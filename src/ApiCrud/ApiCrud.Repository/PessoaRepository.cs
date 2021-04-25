using ApiCrud.Common.Interfaces.Result;
using ApiCrud.Common.Interfaces.Signature;
using ApiCrud.Domain.Interfaces.Repository;
using ApiCrud.Domain.Model.Result;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ApiCrud.Repository
{
    public class PessoaRepository: IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("defaultConnection");
        }

        public async Task InserirPessoa(IInserirPessoaSignature signature)
        {
            using SqlConnection sql = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.P_InserirPessoa", sql);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CpfCnpj", SqlDbType.VarChar) { Value = signature.CpfCnpj });
            command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar) { Value = signature.Nome });
            command.Parameters.Add(new SqlParameter("@Rg", SqlDbType.VarChar) { Value = signature.Rg });
            command.Parameters.Add(new SqlParameter("@DataNascimento", SqlDbType.Date) { Value = signature.DataNascimento.Date });
            command.Parameters.Add(new SqlParameter("@Cep", SqlDbType.VarChar) { Value = signature.Cep });
            command.Parameters.Add(new SqlParameter("@Endereco", SqlDbType.VarChar) { Value = signature.Endereco });
            command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.VarChar) { Value = signature.Numero });
            command.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.VarChar) { Value = signature.Complemento });

            await sql.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }


        public async Task AtualizarPessoa(IAtualizarPessoaSignature signature)
        {
            using SqlConnection sql = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.P_AlterarPessoa", sql);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CodPessoa", SqlDbType.Int) { Value = signature.CodigoPessoa });
            command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar) { Value = signature.Nome });
            command.Parameters.Add(new SqlParameter("@Rg", SqlDbType.VarChar) { Value = signature.Rg });
            command.Parameters.Add(new SqlParameter("@DataNascimento", SqlDbType.Date) { Value = signature.DataNascimento.Date });
            command.Parameters.Add(new SqlParameter("@Cep", SqlDbType.VarChar) { Value = signature.Cep });
            command.Parameters.Add(new SqlParameter("@Endereco", SqlDbType.VarChar) { Value = signature.Endereco });
            command.Parameters.Add(new SqlParameter("@Numero", SqlDbType.VarChar) { Value = signature.Numero });
            command.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.VarChar) { Value = signature.Complemento });

            await sql.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task ExcluirPessoa(IExcluirPessoaSignature signature)
        {
            using SqlConnection sql = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.P_ExcluirPessoa", sql);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CodPessoa", SqlDbType.Int) { Value = signature.CodigoPessoa });

            await sql.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task<IEnumerable<IListarPessoaResult>> ListarPessoa()
        {
            using SqlConnection sql = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.P_ListarPessoa", sql);

            command.CommandType = CommandType.StoredProcedure;
            
            await sql.OpenAsync();
            var reader = await command.ExecuteReaderAsync();
            List<IListarPessoaResult> result = null;

            if (reader.HasRows)
            {
                result = new List<IListarPessoaResult>();

                while (reader.Read())
                {
                    result.Add(new ListarPessoaResult
                    {
                        CodigoPessoa = reader.GetInt32("CodPessoa"),
                        Nome = reader.GetString("Nome"),
                        CpfCnpj = reader.GetString("CpfCnpj"),
                        Rg = reader.GetString("Rg"),
                        DataNascimento = reader.GetDateTime("DataNascimento"),
                        Cep = reader.GetString("Cep"),
                        Endereco = reader.GetString("Endereco"),
                        Numero = reader.GetString("Numero"),
                        Complemento = reader.GetString("Complemento"),
                    });
                }            
            }

            return result;
        }

    }
}
