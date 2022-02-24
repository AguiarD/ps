﻿using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class Partida : Scout
    {
        //TIME A
        //A1
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Jogador A1")]
        public int JogadorIdA1 { get; set; }
        public virtual Jogador JogadoresA1 { get; set; }
        [Display(Name = "Gols A1")]
        public int? GolsA1 { get; set; }
        
        //A2
        [Display(Name = "Jogador A2")]
        public int? JogadorIdA2 { get; set; }
        public virtual Jogador JogadoresA2 { get; set; }
        [Display(Name = "Gols A2")]
        public int? GolsA2 { get; set; }

        //A3
        [Display(Name = "Jogador A3")]
        public int? JogadorIdA3 { get; set; }
        public virtual Jogador JogadoresA3 { get; set; }
        [Display(Name = "Gols A3")]
        public int? GolsA3 { get; set; }

        //A4
        [Display(Name = "Jogador A4")]
        public int? JogadorIdA4 { get; set; }
        public virtual Jogador JogadoresA4 { get; set; }
        [Display(Name = "Gols A4")]
        public int? GolsA4 { get; set; }

        //A5
        [Display(Name = "Jogador A5")]
        public int? JogadorIdA5 { get; set; }
        public virtual Jogador JogadoresA5 { get; set; }
        [Display(Name = "Gols A5")]
        public int? GolsA5 { get; set; }

        //A6
        [Display(Name = "Jogador A6")]
        public int? JogadorIdA6 { get; set; }
        public virtual Jogador JogadoresA6 { get; set; }
        [Display(Name = "Gols A6")]
        public int? GolsA6 { get; set; }

        //A7
        [Display(Name = "Jogador A7")]
        public int? JogadorIdA7 { get; set; }
        public virtual Jogador JogadoresA7 { get; set; }
        [Display(Name = "Gols A7")]
        public int? GolsA7 { get; set; }

        //A8
        [Display(Name = "Jogador A8")]
        public int? JogadorIdA8 { get; set; }
        public virtual Jogador JogadoresA8 { get; set; }
        [Display(Name = "Gols A8")]
        public int? GolsA8 { get; set; }

        //A9
        [Display(Name = "Jogador A9")]
        public int? JogadorIdA9 { get; set; }
        public virtual Jogador JogadoresA9 { get; set; }
        [Display(Name = "Gols A9")]
        public int? GolsA9 { get; set; }

        //A10
        [Display(Name = "Jogador A10")]
        public int? JogadorIdA10 { get; set; }
        public virtual Jogador JogadoresA10 { get; set; }
        [Display(Name = "Gols A10")]
        public int? GolsA10 { get; set; }

        //TIME B
        //B1
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Jogador B1")]
        public int JogadorIdB1 { get; set; }
        public virtual Jogador JogadoresB1 { get; set; }
        [Display(Name = "Gols B1")]
        public int? GolsB1 { get; set; }

        //B2
        [Display(Name = "Jogador B2")]
        public int? JogadorIdB2 { get; set; }
        public virtual Jogador JogadoresB2 { get; set; }
        [Display(Name = "Gols B2")]
        public int? GolsB2 { get; set; }

        //B3
        [Display(Name = "Jogador B3")]
        public int? JogadorIdB3 { get; set; }
        public virtual Jogador JogadoresB3 { get; set; }
        [Display(Name = "Gols B3")]
        public int? GolsB3 { get; set; }

        //B4
        [Display(Name = "Jogador B4")]
        public int? JogadorIdB4 { get; set; }
        public virtual Jogador JogadoresB4 { get; set; }
        [Display(Name = "Gols B4")]
        public int? GolsB4 { get; set; }

        //B5
        [Display(Name = "Jogador B5")]
        public int? JogadorIdB5 { get; set; }
        public virtual Jogador JogadoresB5 { get; set; }
        [Display(Name = "Gols B5")]
        public int? GolsB5 { get; set; }

        //B6
        [Display(Name = "Jogador B6")]
        public int? JogadorIdB6 { get; set; }
        public virtual Jogador JogadoresB6 { get; set; }
        [Display(Name = "Gols B6")]
        public int? GolsB6 { get; set; }

        //B7
        [Display(Name = "Jogador B7")]
        public int? JogadorIdB7 { get; set; }
        public virtual Jogador JogadoresB7 { get; set; }
        [Display(Name = "Gols B7")]
        public int? GolsB7 { get; set; }

        //B8
        [Display(Name = "Jogador B8")]
        public int? JogadorIdB8 { get; set; }
        public virtual Jogador JogadoresB8 { get; set; }
        [Display(Name = "Gols B8")]
        public int? GolsB8 { get; set; }

        //B9
        [Display(Name = "Jogador B9")]
        public int? JogadorIdB9 { get; set; }
        public virtual Jogador JogadoresB9 { get; set; }
        [Display(Name = "Gols B9")]
        public int? GolsB9 { get; set; }

        //B10
        [Display(Name = "Jogador B10")]
        public int? JogadorIdB10 { get; set; }
        public virtual Jogador JogadoresB10 { get; set; }
        [Display(Name = "Gols B10")]
        public int? GolsB10 { get; set; }

        public Partida(DateTime dataPartida, int id_jogador, bool presenca, int resultado, int ponto, int gol, int assistencia, string? obs)
        {
            this.DtPartida = dataPartida;
            this.JogadorId = id_jogador;
            this.Presente = presenca;
            this.ParametroId = resultado;
            this.Ponto = ponto;
            this.Gol = gol;
            this.Assistencia = assistencia;
            this.ObsScout = obs;
        }


        //private int presenca()
        //{
        //    return presenca();
        //}

        //private int ponto()
        //{
        //    return ponto();
        //}

        //private int? golsA()
        //{
        //    return GolsA1;
        //}

        //private int? golsB()
        //{
        //    return GolsB1;
        //}

        //private int assistencia()
        //{
        //    return assistencia();
        //}
    }
}
