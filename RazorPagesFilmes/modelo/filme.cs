using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.modelo
{
    public class filme
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        [Required (ErrorMessage = "Digite o nome do gênero")]
        [StringLength(30,MinimumLength = 3)]    
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;
        

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal](18,2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int Pontos { get; set; } = 0;



    }
}
