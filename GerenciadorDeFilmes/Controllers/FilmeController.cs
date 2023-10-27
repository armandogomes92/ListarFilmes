using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GerenciadorDeFilmes.Data.Dtos;
using GerenciadorDeFilmes.Services;

namespace GerenciadorDeFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    
    public class FilmeController : ControllerBase
    {

        private FilmeService _filmeService;

        public FilmeController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpGet]
        public IActionResult RecuperaFilmes()
        {
            List<ReadFilmeDto> readDto = _filmeService.RecuperaFilmes();
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto dto)
        {
            _filmeService.AdicionaFilme(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto dto)
        {
            Result resultado = _filmeService.AtualizaFilme(id, dto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult RemoveFilmes([FromBody] List<int> ids)
        {
            _filmeService.RemoveFilmes(ids);
            return NoContent();
        }
    }
}
