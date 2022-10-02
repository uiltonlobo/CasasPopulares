using System.Collections.Generic;
using System.Linq;

namespace CasasPopulares_Domain.Entities
{
    public class Familia
    {
        public Familia(Pessoa pretendente, Pessoa conjuge)
        {
            this.Pretendente = pretendente;
            this.Conjuge = conjuge;
            Dependentes = new List<Pessoa>();
        }

        public Pessoa Pretendente { get; set; }
        public Pessoa Conjuge { get; set; }
        public List<Pessoa> Dependentes { get; set; }

        public decimal RendaFamiliar 
        { 
            get
            {
                return Pretendente.Renda + Conjuge.Renda + Dependentes.Sum(d => d.Renda);
            }
        }
    }
}
