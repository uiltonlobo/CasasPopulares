using CasasPopulares_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPopulares_Test.Massa
{
    public class MassaCasasPopulares
    {
        public static List<Familia> ObterListaFamilisParaRankear()
        {
            List<Familia> familias = new List<Familia>();

            // 0 pontos
            Familia familia1 = new Familia(
                new Pessoa { Nome = "João", Idade = 35, Renda = 4000 },
                new Pessoa { Nome = "Maria", Idade = 31, Renda = 1900 });

            // 8 pontos
            Familia familia2 = new Familia(            
                new Pessoa { Nome = "Sergio", Idade = 39, Renda = 900 },
                new Pessoa { Nome = "Maria", Idade = 31, Renda = 0 })
            {
                Dependentes = new List<Pessoa> {
                    new Pessoa { Nome = "Bruno", Idade = 8, Renda = 0 },
                    new Pessoa { Nome = "Amanda", Idade = 10, Renda = 0 },
                    new Pessoa { Nome = "Pedro", Idade = 5, Renda = 0}
                }
            };

            // 3 pontos
            Familia familia3 = new Familia(
                new Pessoa { Nome = "Carlos", Idade = 30, Renda = 900 }, 
                new Pessoa { Nome = "Elisa", Idade = 25, Renda = 400 });

            // 2 pontos
            Familia familia4 = new Familia(            
                new Pessoa { Nome = "Alberto", Idade = 32, Renda = 1200 },
                new Pessoa { Nome = "Clara", Idade = 31, Renda = 1200 })
            {
                Dependentes = new List<Pessoa> {
                    new Pessoa { Nome = "Breno", Idade = 15, Renda = 400 }                    
                }
            };


            familias.Add(familia1);
            familias.Add(familia2);
            familias.Add(familia3);
            familias.Add(familia4);

            return familias;
        }
    }
}
