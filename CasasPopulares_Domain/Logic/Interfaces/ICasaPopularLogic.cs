using CasasPopulares_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPopulares_Domain.Logic.Interfaces
{
    public interface ICasaPopularLogic
    {
        List<RankingCasa> ClassificarFamilias(List<Familia> familias);
    }
}
