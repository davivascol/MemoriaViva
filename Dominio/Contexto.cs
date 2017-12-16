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

    public DbSet<LookUpRole> LookupRole { get; set; }
    public DbSet<SystemUser> SystemUser { get; set; }
    public DbSet<SysUserProfile> SysUserProfile { get; set; }
    public DbSet<SysUserRole> SysUserRole { get; set; }
  }
}

