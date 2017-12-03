using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
  public class SysUserRole
  {
    [Key]
    public int Codigo {get; set;}

    [ForeignKey("SysUser")]
    public int SysUserID { get; set; }
    [ForeignKey("LookUpRole")]
    public int LookUpRoleID { get; set; }
    public bool IsActive { get; set; }
    public int RowCreatedSysUserID { get; set; }
    public DateTime RowCreatedDateTime { get; set; }
    public int RowModifiedSYSUserID { get; set; }
    public DateTime RowModifiedDateTime { get; set; }
    public SysUser SysUser { get; set; }
    public LookUpRole LookUpRole { get; set; }

  }
}
