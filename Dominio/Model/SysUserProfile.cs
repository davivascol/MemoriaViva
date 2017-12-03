using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
  public class SysUserProfile
  {
    [Key]
    public int Codigo { get; set; }

    [ForeignKey("SysUser")]
    public int SysUserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }
    public int RowCreatedSYSUserID { get; set; }
    public DateTime RowCreatedDateTime { get; set; }
    public int RowModifiedSysUserID { get; set; }
    public DateTime RowModifiedDateTime { get; set; }
    public SysUser SysUser { get;set;}
  }
}
