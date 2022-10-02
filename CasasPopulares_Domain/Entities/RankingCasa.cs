namespace CasasPopulares_Domain.Entities
{
    public class RankingCasa
    {
        const int PONTUACAO_INICIAL = 0;

        public RankingCasa(Familia familia)
        {
            this.Familia = familia;
            this.Pontos = PONTUACAO_INICIAL;
        }

        public Familia Familia { get; set; }
        public int Pontos { get; set; }
    }
}
