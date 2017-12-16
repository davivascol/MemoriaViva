using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
  public class SystemUser
  {
    [Key]
    public int Codigo { get; set; }
    public string LoginName { get; set; }
    public string PasswordEncryptedText { get; set; }
    public int RowCreatedSYSUserID { get; set; }
    public DateTime RowCreatedDateTime { get; set; }
    public int RowModifiedSYSUserID { get; set; }
    public DateTime RowModifiedDateTime { get; set; }
  }
}
