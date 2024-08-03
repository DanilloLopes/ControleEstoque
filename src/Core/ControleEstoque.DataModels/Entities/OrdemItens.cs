using ControleEstoque.DataModels.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.DataModels.Entities
{
    public class OrdemItens : EntityBase
    {
        public int OrdemId { get; set; }
        public Ordem Ordem { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantidade { get; set; } 
    }
}
