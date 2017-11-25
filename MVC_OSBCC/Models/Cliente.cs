using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public Cliente()
        {
            this.OS = new HashSet<OS>();//tem que ter isso escrito
        }
        public int id { get; set; }
        public string nome { get; set; }
        public int rg { get; set; }
        public string endereco { get; set; }


        [Display(Name = "Lista de Clientes")]
        public virtual ICollection<OS> OS { get; set; }

    }
}