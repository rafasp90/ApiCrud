﻿using System;

namespace ApiCrud.Common.Interfaces.Signature
{
    public interface IInserirPessoaSignature
    {
        string Nome { get; set; }
        string CpfCnpj { get; set; }
        string Rg { get; set; }
        DateTime DataNascimento { get; set; }
        string Endereco { get; set; }
        string Numero { get; set; }
        string Complemento { get; set; }
        string Cep { get; set; }
    }
}