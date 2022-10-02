using CasasPopulares_Domain.Entities;
using CasasPopulares_Domain.Logic.Interfaces;

namespace CasasPopulares_Domain.Logic.Strategies
{
    public class RendaTotalAte900Strategy : ICriterioCasaStrategy
    {
        const int PONTOS_CRITERIO_ACEITO = 5;
        const int PONTOS_CRITERIO_NAO_ACEITO = 0;
        const decimal LIMITE_MAXIMO = 900;

        public void ClassificarPossibilidade(RankingCasa rankingCasa)
        {
            decimal rendaFamiliar = rankingCasa.Familia.RendaFamiliar;

            bool criterioAceito =  rendaFamiliar <= LIMITE_MAXIMO;

            rankingCasa.Pontos += criterioAceito ? PONTOS_CRITERIO_ACEITO : PONTOS_CRITERIO_NAO_ACEITO;
        }
    }
}
