using CasasPopulares_Domain.Entities;
using CasasPopulares_Domain.Logic.Interfaces;
using System.Linq;

namespace CasasPopulares_Domain.Logic.Strategies
{
    public class FamiliasCom1Ou2DependentesStrategy : ICriterioCasaStrategy
    {
        const int IDADE_MAXIMA_DEPENDENTE = 18;
        const int QUANTIDADE_MINIMA_DEPENDENTES = 1;
        const int QUANTIDADE_MAXIMA_DEPENDENTES = 2;
        const int PONTOS_CRITERIO_ACEITO = 2;
        const int PONTOS_CRITERIO_NAO_ACEITO = 0;

        public void ClassificarPossibilidade(RankingCasa rankingCasa)
        {
            int numeroDependentesValidos = rankingCasa.Familia.Dependentes.Count(d => d.Idade <= IDADE_MAXIMA_DEPENDENTE);

            bool criterioAceito = numeroDependentesValidos >= QUANTIDADE_MINIMA_DEPENDENTES && numeroDependentesValidos <= QUANTIDADE_MAXIMA_DEPENDENTES;

            rankingCasa.Pontos += criterioAceito ? PONTOS_CRITERIO_ACEITO : PONTOS_CRITERIO_NAO_ACEITO;
        }

    }
}
