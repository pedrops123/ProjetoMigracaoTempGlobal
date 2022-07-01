using Lets.Core.Api.Controllers.DefaultApi;
using Lets.Importation.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lets.Importation.Api.Controllers.v1
{
    [Route("api/v1/TesteImport")]
    public sealed class TesteImportacaoController : AbstractController, IExportGenericControllers
    {
        public TesteImportacaoController(IMediator mediator) : base(mediator)
        { }

        [HttpPost]
        public async Task<IActionResult> Import([FromBody] ICollection<IFormFile> files)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Export()
        {
            return Ok();
        }
    }
}