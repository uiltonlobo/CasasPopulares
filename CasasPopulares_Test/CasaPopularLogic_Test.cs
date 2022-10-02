using CasasPopulares_Domain.Entities;
using CasasPopulares_Domain.Logic;
using CasasPopulares_Domain.Logic.Interfaces;
using CasasPopulares_Test.Massa;
using System;
using System.Collections.Generic;
using Xunit;

namespace CasasPopulares_Test
{
    public class CasaPopularLogic_Test
    {
        [Fact]
        public void ClassificarFamiliasConformeCriterios()
        {
            List<Familia> familias = MassaCasasPopulares.ObterListaFamilisParaRankear();
            List<RankingCasa> rankingClassificado;

            ICasaPopularLogic logic = new CasaPopularLogic();

            rankingClassificado = logic.ClassificarFamilias(familias);

            Assert.Equal(8, rankingClassificado[0].Pontos);
            Assert.Equal(3, rankingClassificado[1].Pontos);
            Assert.Equal(2, rankingClassificado[2].Pontos);
            Assert.Equal(0, rankingClassificado[3].Pontos);
        }
    }
}
