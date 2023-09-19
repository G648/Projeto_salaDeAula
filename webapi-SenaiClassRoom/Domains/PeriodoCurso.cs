using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(PeriodoCurso))]
    public class PeriodoCurso
    {
        [Key]
        public Guid IdPeriodoCurso { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = ("O titulo do periodo do curso é obrigatório"))]
        public string? Titulo { get; set; }
    }
}
