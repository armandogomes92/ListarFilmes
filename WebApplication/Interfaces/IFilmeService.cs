using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Dtos;

namespace WebApplication.Interfaces
{
    public interface IFilmeService
    {
        public ReadFilmeDto AdicionaFilme(CreateFilmeDto dto);
    }
}
