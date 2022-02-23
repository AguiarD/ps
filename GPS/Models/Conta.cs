using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [MaxLength(80, ErrorMessage = "Máximo 50 caracteres")]
        [Display(Name = "Conta")]
        public string DescConta { get; set; }

        [Required(ErrorMessage = "E = Entrada ou S = Saída")]
        [MaxLength(1, ErrorMessage = "E ou S")]
        [Display(Name = "Tipo da Conta")]
        public string TipoConta { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Observação")]
        public string? ObsConta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Inativo { get; set; }
        //public virtual ICollection<Financeiro> Financeiros { get; set; }
    }
}
