using CasasPopulares_Domain.Entities;
using CasasPopulares_Domain.Logic.Interfaces;

namespace CasasPopulares_Domain.Logic.Strategies
{
    public class RendaTotalEntre901E1500Strategy : ICriterioCasaStrategy
    {
        const int PONTOS_CRITERIO_ACEITO = 3;
        const int PONTOS_CRITERIO_NAO_ACEITO = 0;
        const decimal LIMITE_MINIMO = 900;
        const decimal LIMITE_MAXIMO = 1500;

        public void ClassificarPossibilidade(RankingCasa rankingCasa)
        {
            decimal rendaFamiliar = rankingCasa.Familia.RendaFamiliar;
            
            bool criterioAceito =  rendaFamiliar > LIMITE_MINIMO && rendaFamiliar < LIMITE_MAXIMO;

            rankingCasa.Pontos += criterioAceito ? PONTOS_CRITERIO_ACEITO : PONTOS_CRITERIO_NAO_ACEITO;
        }
    }
}
