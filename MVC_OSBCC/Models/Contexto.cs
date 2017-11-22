using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MVC5.Models;


namespace MVC_OSBCC.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("MVC5") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<OS> OrdemServico { get; set; }

    }
}