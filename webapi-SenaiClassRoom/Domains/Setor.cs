using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(Setor))]
    public class Setor
    {
        [Key]
        public Guid IdSetor { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do setor é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        [Required(ErrorMessage = "O nome do responsável é obrigatório!")]
        public string? Responsavel { get; set; }

        //ref.tabela Instituicao
        [Required(ErrorMessage = "O IdInstituicao é obrigatório")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]
        public Instituicao? Instituicao { get; set; }
    }
}
