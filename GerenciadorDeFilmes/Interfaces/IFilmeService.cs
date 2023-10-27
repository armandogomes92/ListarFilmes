using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDeFilmes.Data.Dtos;

namespace GerenciadorDeFilmes.Interfaces
{
    public interface IFilmeService
    {
        public ReadFilmeDto AdicionaFilme(CreateFilmeDto dto);
    }
}
