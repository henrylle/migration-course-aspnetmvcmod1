using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCProjetoEmpresa.Models
{
    public class EmpresaDBContext : DbContext
    {
        public EmpresaDBContext() : base("name=EmpresaDBContext") { }

        public DbSet<Empresa> Empresas { get; set; }

    }
}