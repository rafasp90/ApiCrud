using ApiCrud.Common.Interfaces.Result;
using ApiCrud.Common.Interfaces.Signature;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCrud.Domain.Interfaces.Service
{
    public interface IPessoaService
    {
        Task InserirPessoa(IInserirPessoaSignature signature);
        Task AtualizarPessoa(IAtualizarPessoaSignature signature);
        Task ExcluirPessoa(IExcluirPessoaSignature signature);
        Task<IEnumerable<IListarPessoaResult>> ListarPessoa();
    }
}
