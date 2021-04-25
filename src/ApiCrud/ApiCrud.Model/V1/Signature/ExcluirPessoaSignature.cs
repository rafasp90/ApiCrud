using ApiCrud.Common.Interfaces.Signature;

namespace ApiCrud.Model.V1.Signature
{
    public class ExcluirPessoaSignature : IExcluirPessoaSignature
    {
        public int CodigoPessoa { get; set; }
    }
}
