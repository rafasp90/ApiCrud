using ApiCrud.App.Interfaces;
using ApiCrud.Model.V1.Signature;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Threading.Tasks;

namespace ApiCrud.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaApp _pessoaApp;

        public PessoaController(IPessoaApp pessoaApp)
        {
            _pessoaApp = pessoaApp;
        }

        [HttpPost]
        [Route(nameof(Inserir))]
        public async Task Inserir(InserirPessoaSignature signature)
        {
            await _pessoaApp.InserirPessoa(signature);
        }

        [HttpPost]
        [Route(nameof(Atualizar))]
        public async Task Atualizar(AtualizarPessoaSignature signature)
        {
            await _pessoaApp.AtualizarPessoa(signature);
        }

        [HttpPost]
        [Route(nameof(Excluir))]
        public async Task Excluir(ExcluirPessoaSignature signature)
        {
            await _pessoaApp.ExcluirPessoa(signature);
        }

        [HttpGet]
        [Route(nameof(Listar))]
        public async Task<IStatusCodeActionResult> Listar()
        {
            var result = await _pessoaApp.ListarPessoa();
            return Ok(result);
        }
    }
}
