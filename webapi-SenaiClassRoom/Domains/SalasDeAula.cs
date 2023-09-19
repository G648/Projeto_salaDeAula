using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(SalasDeAula))]
    public class SalasDeAula
    {
        [Key]
        public Guid IdSalaDeAula { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O número da sala de aula é obrigatório")]
        public string? Numero { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição da sala é obrigatória")]
        public string? Descricao { get; set; }

        //ref.tabela Setor
        [Required(ErrorMessage = "o IdSetor é obrigatório")]
        public Guid IdSetor { get; set; }

        [ForeignKey(nameof(IdSetor))]
        public Setor? Setor { get; set; }


        //ref.tabela Usuario
        [Required(ErrorMessage = "O IdUsuario é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
