using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int rg { get; set; }
        public string endereco { get; set; }
        public virtual OS OSBCC { get; set; }
        public virtual string relatorioServicos { get { return OSBCC.aparelho + "-" + OSBCC.descricao + "-" + OSBCC.valor; } }

    }
}