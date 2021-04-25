using ApiCrud.App.Interfaces;
using ApiCrud.Common.Interfaces.Result;
using ApiCrud.Common.Interfaces.Signature;
using ApiCrud.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCrud.App
{
    public class PessoaApp : IPessoaApp
    {
        private readonly IPessoaService _pessoaService;

        public PessoaApp(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public async Task AtualizarPessoa(IAtualizarPessoaSignature signature)
        {
            await _pessoaService.AtualizarPessoa(signature);
        }

        public async Task ExcluirPessoa(IExcluirPessoaSignature signature)
        {
            await _pessoaService.ExcluirPessoa(signature);
        }

        public async Task InserirPessoa(IInserirPessoaSignature signature)
        {
            await _pessoaService.InserirPessoa(signature);
        }

        public async Task<IEnumerable<IListarPessoaResult>> ListarPessoa()
        {
            return await _pessoaService.ListarPessoa();
        }
    }
}
