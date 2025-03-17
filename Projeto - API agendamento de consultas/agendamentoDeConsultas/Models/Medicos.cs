using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace agendamentoDeConsultas.Models
{
    public class Medicos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(11)]
        public string CPF { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]


        public ICollection<Consultas> Consultas{get;set;}
    }
}