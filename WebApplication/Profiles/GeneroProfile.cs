using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Dtos;
using WebApplication.Model;

namespace WebApplication.Profiles
{
    public class GeneroProfile : Profile
    {
        public GeneroProfile()
        {
            CreateMap<Genero, ReadGeneroDto>();
        }
    }
}
