using Microsoft.EntityFrameworkCore;
using agendamentoDeConsultas.Models;

namespace agendamentoDeConsultas.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração do DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets para cada entidade
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        // Configurações adicionais (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração dos relacionamentos
            modelBuilder.Entity<Consulta>()
                .HasOne(c => c.Medico)
                .WithMany(m => m.Consultas)
                .HasForeignKey(c => c.MedicoId);

            modelBuilder.Entity<Consulta>()
                .HasOne(c => c.Paciente)
                .WithMany(p => p.Consultas)
                .HasForeignKey(c => c.PacienteId);

            // Configuração do enum StatusConsulta
            modelBuilder.Entity<Consulta>()
                .Property(c => c.Status)
                .HasConversion<string>(); // Armazena o enum como string no banco

            // Índices únicos para CPF e Email
            modelBuilder.Entity<Medico>()
                .HasIndex(m => m.CPF)
                .IsUnique();

            modelBuilder.Entity<Paciente>()
                .HasIndex(p => p.CPF)
                .IsUnique();
        }
    }
}