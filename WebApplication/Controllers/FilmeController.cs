using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication.Data.Dtos;
using WebApplication.Model;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpPatch("{id}")]
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
