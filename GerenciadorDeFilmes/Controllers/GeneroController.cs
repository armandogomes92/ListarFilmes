using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDeFilmes.Data.Dtos;
using GerenciadorDeFilmes.Services;

namespace GerenciadorDeFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneroController : ControllerBase
    {
        private GeneroService _generoService;

        public GeneroController(GeneroService generoService)
        {
            _generoService = generoService;
        }

        [HttpGet]
        public IActionResult RecuperaGeneros()
        {
            List<ReadGeneroDto> readDto = _generoService.RecuperaGenero();
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }
    }
}
