using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class Scout
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data da partida")]
        public DateTime DtPartida { get; set; }
        //public virtual Jogador fk_jogador { get; set; }

        public int JogadorId { get; set; }
        public virtual Jogador? Jogadores { get; set; }

        [Display(Name = "Presença")]
        public bool Presente { get; set; }
        //public virtual Parametro fk_parametro { get; set; }
        
        [Display(Name = "Resultado")]
        public int ParametroId { get; set; }
        public virtual Parametro? Parametros { get; set; }
        public int Ponto { get; set; }
        public int? Gol { get; set; }
        public int? Assistencia { get; set; }
        public string? ObsScout { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Inativo")]
        public DateTime? Inativo { get; set; }

        //Criar construtor para somar resultados

        //public Scout(DateTime dataPartida, int id_jogador, /*bool presenca, int resultado,*/ int ponto, int gol, int assistencia, string? obs)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        this.DtPartida = dataPartida;
        //        this.JogadorId = id_jogador;
        //        this.Presente = /*presenca*/ true;
        //        this.ParametroId = /*resultado*/ 3;
        //        this.Ponto = ponto;
        //        this.Gol = gol;
        //        this.Assistencia = assistencia;
        //        this.ObsScout = obs;
        //    }

        //}

    }
}
