using System.ComponentModel.DataAnnotations;
using GPS.Models;

namespace GPS.Interfaces
{
    public interface IScout
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data da partida")]
        public DateTime DtPartida { get; set; }
        //public virtual Jogador fk_jogador { get; set; }

        public int JogadorId { get; set; }
        //public virtual Jogador Jogadores { get; set; }

        public int Presenca { get; set; }
        //public virtual Parametro fk_parametro { get; set; }
        public string Resultado { get; set; }
        public int Ponto { get; set; }
        public int? Gol { get; set; }
        public int? Assistencia { get; set; }
        public string? ObsScout { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Inativo")]
        public DateTime? Inativo { get; set; }


        public int ParametrosId { get; set; }
        //public virtual Parametro Parametros { get; set; }
    }
}
