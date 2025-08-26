using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranStore.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Categoria> GetCategorias()
        {
            List<Categoria> categorias = new List<Categoria>{
                new Categoria{
                    Id = 1,
                    Nome = "Monitores"
                },
                new Categoria {
                    Id = 2,
                    Nome = "Consoles"
                },
                new Categoria {
                    Id = 3,
                    Nome = "Notebooks"
                }
            };
            return categorias; 
        }
    }
}