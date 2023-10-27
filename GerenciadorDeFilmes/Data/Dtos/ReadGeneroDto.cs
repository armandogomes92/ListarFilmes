using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GerenciadorDeFilmes.Model;

namespace GerenciadorDeFilmes.Data.Dtos
{
    public class ReadGeneroDto
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Genero> Genero { get; set; }
    }
}
