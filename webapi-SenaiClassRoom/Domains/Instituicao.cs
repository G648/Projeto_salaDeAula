using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(Instituicao))]
    public class Instituicao
    {
        [Key]
        public Guid IdInstituicao { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome da instituição é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O endereço da instituição é obrigatório")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(12)")]
        [Required(ErrorMessage = "O telefone da instituição é obrigatório")]
        public string? Telefone { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição é obrigatória!")]
        public string? Descricao { get; set; }

    }
}
