using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Contexto : DbContext
  {

    public Contexto() : base("name=MemoriaV") { }
    public DbSet<SysUser> SysUser { get; set; }
  }
}

