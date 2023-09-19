using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(PeriodoUsuario))]
    public class PeriodoUsuario
    {
        [Key]
        public Guid IdPeriodoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo do periodo do usuário é obrigatório")]
        public string? Titulo { get; set; }
    }
}
