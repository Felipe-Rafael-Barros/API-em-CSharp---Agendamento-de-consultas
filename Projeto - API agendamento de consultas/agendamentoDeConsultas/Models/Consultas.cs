using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace agendamentoDeConsultas.Models
{
    public class Consultas
    {
        [Key]
        public int Id { get; set; } //Definir como PK

        [Required]
        public int MedicoId { get; set; } // FK de Médicos

        [Required]
        public int PacienteId { get; set; } //FK de Pacientes
        
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public string Status { get; set; }

        public Medicos Medico { get; set; }
        public Pacientes Paciente { get; set; }
    }
}