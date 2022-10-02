using CasasPopulares_Domain.Entities;
using CasasPopulares_Domain.Logic.Interfaces;
using CasasPopulares_Domain.Logic.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPopulares_Domain.Logic
{
    public class CasaPopularContext
    {
        private static List<ICriterioCasaStrategy> estrategias;

        static CasaPopularContext()
        {
            estrategias = new List<ICriterioCasaStrategy>();

            estrategias.Add(new RendaTotalAte900Strategy());
            estrategias.Add(new RendaTotalEntre901E1500Strategy());
            estrategias.Add(new FamiliasCom3OuMaisDependentesStrategy());
            estrategias.Add(new FamiliasCom1Ou2DependentesStrategy());
        }

        public static void ClassificarCriterios(RankingCasa ranking)
        {
            estrategias.ForEach(e => e.ClassificarPossibilidade(ranking));
        }
    }
}
