using System.Collections.Generic;
using System.Threading.Tasks;
using Example.Models;
using Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class BioController : ControllerBase
    {
        private readonly IBioService bioService;

        public BioController(IBioService bioService)
        {
            this.bioService = bioService;
        }

        [HttpGet]
        public async Task<IEnumerable<Bio>> GetBios()
        {
            return await bioService.GetBiosAsync();
        }
    }
}