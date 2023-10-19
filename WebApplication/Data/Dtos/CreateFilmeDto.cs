using System;
using System.ComponentModel.DataAnnotations;
using WebApplication.Model;

namespace WebApplication.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
        public int GeneroId { get; set; }
    }
}
