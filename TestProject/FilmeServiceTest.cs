using Moq;
using System;
using WebApplication.Data;
using WebApplication.Data.Dtos;
using WebApplication.Model;
using WebApplication.Services;
using WebApplication.Interfaces;
using Xunit;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplication.Profiles;

namespace TestProject
{
    public class FilmeServiceTest
    {
        [Fact]
        public void AdicionaFilme()
        {
            //Arrange
            var repositorioMock = new Mock<IFilmeService>();
            var servico = repositorioMock.Object;

            CreateFilmeDto dto = new CreateFilmeDto 
            {
                Nome = "Teste 1",
                DataCriacao = new DateTime(2023, 10, 19),
                Ativo = true ,
                GeneroId = 1
            };

            //Act
            var resultado = servico.AdicionaFilme(dto);

            //Assert
            //Verifica se o comportamento foi invocado
            repositorioMock.Verify(b => b.AdicionaFilme(dto));

        }
    }
}
