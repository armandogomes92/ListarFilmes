using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Model;

namespace WebApplication.Data.Dtos
{
    public class ReadFilmeDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
        public WebApplication.Model.Genero Genero { get; set; }
    }
}
