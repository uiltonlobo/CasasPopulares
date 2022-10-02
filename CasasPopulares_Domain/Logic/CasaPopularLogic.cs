using CasasPopulares_Domain.Entities;
using CasasPopulares_Domain.Factories;
using CasasPopulares_Domain.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPopulares_Domain.Logic
{
    public class CasaPopularLogic : ICasaPopularLogic
    {
        public List<RankingCasa> ClassificarFamilias(List<Familia> familias)
        {
            List<RankingCasa> ranking = RankingFactory.Criar(familias);

            ranking.ForEach(r => CasaPopularContext.ClassificarCriterios(r));

            return ranking.OrderByDescending(r => r.Pontos).ToList();
        }
    }
}
