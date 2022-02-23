using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPS.Models
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Conta")]
        public int ContaId { get; set; }

        public virtual Conta Contas { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Jogador")]
        public int JogadorId { get; set; }
        public virtual Jogador Jogadores { get; set; }

        //[Range(1, 100)] 
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Obrigatorio")]
        [Column(TypeName = "money")]
        public decimal Valor { get; set; } //trocar para double

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Observação")]
        public string? ObsLancamento { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Informe uma data de previsão!")]
        [Display(Name = "Data de Previsão")]
        public DateTime DtPrevisao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Baixa")]
        public DateTime? DtBaixa { get; set; }
        //public virtual Jogador fk_jogador { get; set; }
        //public virtual Conta fk_conta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Inativo { get; set; }
    }
}
