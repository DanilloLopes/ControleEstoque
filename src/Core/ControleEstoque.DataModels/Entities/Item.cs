using ControleEstoque.DataModels.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.DataModels.Entities
{
    /// <summary>
    /// Representa um item no sistema.
    /// </summary>
    public class Item :  StrongEntity
    {
        /// <summary>
        /// Obtém ou define o nome do item.
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o código do item.
        /// </summary>
        [Required]
        public int CodigoItem { get; set; }

        /// <summary>
        /// Utilizado para gerar um relacionamento entre Ordem e Itens, gerando a entidade OrdemItens.
        /// </summary>
        public ICollection<OrdemItens> OrdemItens { get; set; }
    }
}
