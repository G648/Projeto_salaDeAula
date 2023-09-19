using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(Curso))]
    public class Curso
    {
        [Key]
        public Guid IdCurso { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do curso é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "TINYINT")]
        [Required(ErrorMessage = "A quantidade de alunos é obrigatória")]
        public int QuantidadeAlunos { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição do curso é obrigatória")]
        public string? Descricao { get; set; }

        //ref.tabela PeriodoCurso
        [Required(ErrorMessage = "O IdPeriodoCurso é obrigatório")]
        public Guid IdPeriodoCurso { get; set; }

        [ForeignKey(nameof(IdPeriodoCurso))]
        public PeriodoCurso? PeriodoCurso { get; set; }

        //ref.tabela SalasDeAula
        [Required(ErrorMessage = "O IdSalaDeAula é obrigatório")]
        public Guid IdSalaDeAula { get; set; }

        [ForeignKey(nameof(IdSalaDeAula))]
        public SalasDeAula? SalasDeAula { get; set; }
    }
}
