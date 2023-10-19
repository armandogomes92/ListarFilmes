using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Data.Dtos;
using WebApplication.Interfaces;
using WebApplication.Model;

namespace WebApplication.Services
{
    public class FilmeService : IFilmeService
    {
        private WebAppContext _dbContext;
        private IMapper _mapper;

        public FilmeService(WebAppContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public ReadFilmeDto AdicionaFilme(CreateFilmeDto dto)
        {

            try
            {
                Filme filme = _mapper.Map<Filme>(dto);
                _dbContext.Filmes.Add(filme);
                //_dbContext.SaveChanges();
                _dbContext.Database.BeginTransaction().Commit();
                return _mapper.Map<ReadFilmeDto>(filme);
            }
            catch(Exception)
            {
                _dbContext.Database.BeginTransaction().Rollback();
                throw;
            }
        }

        public List<ReadFilmeDto> RecuperaFilmes()
        {
            List<Filme> filmes = _dbContext.Filmes.ToList();
            if (filmes != null) 
            {
                return _mapper.Map<List<ReadFilmeDto>>(filmes);
            }
            return null;
        }

        public Result AtualizaFilme(int id, UpdateFilmeDto dto)
        {
            Filme filme = _dbContext.Filmes.FirstOrDefault(filme => filme.Id == id);
            
            if (filme == null) return Result.Fail("Filme não encontrado");
            
            _mapper.Map(dto, filme);
            _dbContext.SaveChanges();
            
            return Result.Ok();
        }

        public Result RemoveFilmes(List<int> ids)
        {
            List<Filme> filmes = new List<Filme>();
            
            foreach (int id in ids)
            {
                var filme = _dbContext.Filmes.Where(filme => filme.Id == id).ToList();
                filmes.AddRange(filme);
            }
            
            _dbContext.Filmes.RemoveRange(filmes);
            _dbContext.SaveChanges();

            return Result.Ok();
        }
    }
}
