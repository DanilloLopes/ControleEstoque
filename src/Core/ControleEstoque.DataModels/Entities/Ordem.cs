using ControleEstoque.DataModels.Entities.Abstract;
using ControleEstoque.DataModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.DataModels.Entities
{
    /// <summary>
    /// Representa uma ordem no sistema.
    /// </summary>
    public class Ordem : StrongEntity
    {
        /// <summary>
        /// Obtém ou define a descrição da ordem.
        /// </summary>
        [Required]
        public string Descricao { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação da ordem.
        /// </summary>
        [Required]
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Obtém ou define o número da ordem.
        /// </summary>
        [Required]
        public int NumeroOrdem { get; set; }

        /// <summary>
        /// Utilizado para gerar um relacionamento entre Ordem e Itens, gerando a entidade OrdemItens.
        /// </summary>
        public ICollection<OrdemItens> OrdemItens { get; set; }

        /// <summary>
        /// Obtém ou define o status da ordem.
        /// </summary>
        public TipoStatus Status { get; set; }
    }
}
