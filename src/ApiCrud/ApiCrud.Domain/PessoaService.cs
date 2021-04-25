using ApiCrud.Common.Interfaces.Result;
using ApiCrud.Common.Interfaces.Signature;
using ApiCrud.Domain.Interfaces.Repository;
using ApiCrud.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCrud.Domain
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task AtualizarPessoa(IAtualizarPessoaSignature signature)
        {
            await _pessoaRepository.AtualizarPessoa(signature);
        }

        public async Task ExcluirPessoa(IExcluirPessoaSignature signature)
        {
            await _pessoaRepository.ExcluirPessoa(signature);
        }

        public async Task InserirPessoa(IInserirPessoaSignature signature)
        {
            await _pessoaRepository.InserirPessoa(signature);
        }

        public async Task<IEnumerable<IListarPessoaResult>> ListarPessoa()
        {
            return await _pessoaRepository.ListarPessoa();
        }
    }
}
