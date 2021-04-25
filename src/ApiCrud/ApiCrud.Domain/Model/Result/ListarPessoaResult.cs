using ApiCrud.Common.Interfaces.Result;
using System;

namespace ApiCrud.Domain.Model.Result
{
    public class ListarPessoaResult : IListarPessoaResult
    {
        public int CodigoPessoa { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
    }
}
