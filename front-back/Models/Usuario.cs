using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace front_back.Models
{
    [Table("Usuarios")]
        
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir o nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir o email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir a data de nascimento")]
        public DateTime DataNascimento { get; set; }
        public string Login { get; set; }
        public string DespensaVirtual { get; set; } 
        public string HistoricoDespensaVirtual { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir a senha")]
        public string Senha { get; set; }
      
    }
}
