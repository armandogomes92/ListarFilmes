using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDeFilmes.Data.Dtos;
using GerenciadorDeFilmes.Model;

namespace GerenciadorDeFilmes.Profiles
{
    public class GeneroProfile : Profile
    {
        public GeneroProfile()
        {
            CreateMap<Genero, ReadGeneroDto>();
        }
    }
}
