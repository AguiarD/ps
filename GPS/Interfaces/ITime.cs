namespace GPS.Interfaces
{
    public interface ITime
    {
        public string Jogador1 { get; set; }
        public int Gols1 { get; set; }

        public string Jogador2 { get; set; }
        public int Gols2 { get; set; }

        public string Jogador3 { get; set; }
        public int Gols3 { get; set; }

        public string Jogador4 { get; set; }
        public int Gols4 { get; set; }

        public string Jogador5 { get; set; }
        public int Gols5 { get; set; }

        public string Jogador6 { get; set; }
        public int Gols6 { get; set; }

        public string Jogador7 { get; set; }
        public int Gols7 { get; set; }

        public string Jogador8 { get; set; }
        public int Gols8 { get; set; }

        public string Jogador9 { get; set; }
        public int Gols9 { get; set; }

        public string Jogador10 { get; set; }
        public int Gols10 { get; set; }

        public int SomaGols()
        {
            return Gols1 + Gols2 + Gols3 + Gols4 + Gols5 + Gols6 + Gols7 + Gols8 + Gols9 + Gols10;
        }
    }
}
