using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lets.Importation.Domain.Interfaces
{
    public interface IExportGenericControllers
    {
        Task<IActionResult> Import(ICollection<IFormFile> files);
        Task<IActionResult> Export();
    }
}
