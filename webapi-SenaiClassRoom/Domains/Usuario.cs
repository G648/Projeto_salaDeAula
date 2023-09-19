using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_SenaiClassRoom.Domains
{
    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O UsuarioSN do usuário é obrigatório")]
        public string? UsuarioSN { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória")]
        [StringLength(60, ErrorMessage = "A senha deve conter no máximo 60 Caracteres")]
        public string? Senha { get; set; }

        //ref.tabela TiposUsuario
        [Required(ErrorMessage = "O IdTipoUsuario é obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }

        //ref.tabela Instituicao
        [Required(ErrorMessage = "O IdInstituicao é obrigatório")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]
        public Instituicao? Instituicao { get; set; }

        //ref.tabela PeriodoUsuario
        [Required(ErrorMessage = "O IdPeriodoUsuario é obrigatório")]
        public Guid IdPeriodoUsuario { get; set; }

        [ForeignKey(nameof(IdPeriodoUsuario))]
        public PeriodoUsuario? PeriodoUsuario { get; set; }
    }
}
