using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuEduca.Models
{
    [Table("CadastroUsuario")]
    public class CadastroUsuario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NomeCompleto")]
        [Display(Name = "Nome completo")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;

        [Column("TipoUsuario")]
        [Display(Name = "Tipo do usuárioo")]
        public string TipoUsuario { get; set; } = string.Empty;

    }
}
