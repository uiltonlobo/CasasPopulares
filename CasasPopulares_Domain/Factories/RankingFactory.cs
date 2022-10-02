using CasasPopulares_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPopulares_Domain.Factories
{
    public static class RankingFactory
    {
        public static List<RankingCasa> Criar(List<Familia> familias)
        {
            List<RankingCasa> ranking = new List<RankingCasa>();

            familias.ForEach(f =>
            {
                ranking.Add(new RankingCasa(f));
            });

            return ranking;
        }
    }
}
