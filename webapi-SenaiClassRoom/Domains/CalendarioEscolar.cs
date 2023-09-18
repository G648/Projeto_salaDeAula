using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(CalendarioEscolar))]
    public class CalendarioEscolar
    {
        [Key]
        public Guid IdCalendarioEscolar { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data de inicio é obrigatório")]
        public DateTime InicioCalendario { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data de término é obrigatória")]
        public DateTime FinalCalendario { get; set; }


        //ref.tabela Instituicao
        [Required(ErrorMessage = "O IdInstituicao é obrigatório")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]
        public Instituicao? Instituicao { get; set; }
    }
}
