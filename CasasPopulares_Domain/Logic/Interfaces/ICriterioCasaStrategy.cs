using CasasPopulares_Domain.Entities;

namespace CasasPopulares_Domain.Logic.Interfaces

{
    public interface ICriterioCasaStrategy
    {
        void ClassificarPossibilidade(RankingCasa rankingCasa);
    }
}
