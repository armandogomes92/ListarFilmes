using Moq;
using System;
using GerenciadorDeFilmes.Data;
using GerenciadorDeFilmes.Data.Dtos;
using GerenciadorDeFilmes.Model;
using GerenciadorDeFilmes.Services;
using GerenciadorDeFilmes.Interfaces;
using Xunit;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeFilmes.Profiles;

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
