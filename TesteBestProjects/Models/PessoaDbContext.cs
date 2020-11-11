using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TesteBestProjects.Models
{
    public class PessoaDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}