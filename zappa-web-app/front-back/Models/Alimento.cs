using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace front_back.Models
{
    [Table("Alimentos")]
    public class Alimento
    {
        [Key]
        public string AlimentoId { get; set; }

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Insira o nome do alimento.")]
        public string Alimentos {  get; set; }
        
        [ForeignKey(nameof(Alimentos))]
        public string UserID { get; set; }

        public string Categoria { get; set; }

        public DateTime Consumo { get; set; }

        public DateTime Validade { get; set; }

        public string DespensaId { get; set; }
    }

    public enum Categoria
    {
        Padaria,
        Legumes,
        Enlatados,
    }
}
