using Microsoft.EntityFrameworkCore;
using webapi_SenaiClassRoom.Domains;

namespace webapi_SenaiClassRoom.Contexts
{
    public class ClassroomContext : DbContext
    {
        public DbSet<CalendarioEscolar> CalendarioEscolar { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<PeriodoCurso> PeriodoCurso { get; set; }
        public DbSet<PeriodoUsuario> PeriodoUsuario { get; set; }
        public DbSet<SalasDeAula> SalasDeAula { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Server=GUILHERME\\SQLEXPRESS; Database=SenaiClassroom_DB; User id=sa; pwd=Senai@134; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
