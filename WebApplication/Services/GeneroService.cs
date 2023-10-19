using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Data.Dtos;
using WebApplication.Model;

namespace WebApplication.Services
{
    public class GeneroService
    {
        private WebAppContext _dbContext;
        private IMapper _mapper;

        public GeneroService(WebAppContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public List<ReadGeneroDto> RecuperaGenero()
        {
            List<Genero> generos = _dbContext.Generos.ToList();
            if (generos != null)
            {
                return _mapper.Map<List<ReadGeneroDto>>(generos);
            }
            return null;
        }
    }
}
