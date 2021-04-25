using ApiCrud.Common.Interfaces.Result;
using ApiCrud.Common.Interfaces.Signature;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCrud.App.Interfaces
{
    public interface IPessoaApp
    {
        Task InserirPessoa(IInserirPessoaSignature signature);
        Task AtualizarPessoa(IAtualizarPessoaSignature signature);
        Task ExcluirPessoa(IExcluirPessoaSignature signature);
        Task<IEnumerable<IListarPessoaResult>> ListarPessoa();
    }
}
