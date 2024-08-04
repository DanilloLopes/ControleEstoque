using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.DataModels.Entities.Abstract
{
    /// <summary>
    /// Classe base para todas as entidades fortes do banco banco de dados.
    /// </summary>
    public abstract class StrongEntity : EntityBase
    {
        /// <summary>
        /// Identificador único da entidade. 
        /// </summary>
        [Required]
        public int Id { get; set; }
    }
}
