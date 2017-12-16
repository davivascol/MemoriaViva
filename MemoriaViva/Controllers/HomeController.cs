using Dominio;
using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemoriaViva.Controllers
{
  public class HomeController : Controller
  {
    // GET: Default
    public ActionResult Index()
    {

      Contexto c = new Contexto();
      var systemuser = new SystemUser()
      {
        LoginName = "Davi",
        PasswordEncryptedText = "aojoasisjd",
        RowCreatedDateTime = DateTime.Now,
        RowModifiedDateTime = DateTime.Now,
        RowCreatedSYSUserID = 0,
        RowModifiedSYSUserID = 0
      }; 

      c.SystemUser.Add(systemuser);
      c.SaveChanges();

      return View();
    }
  }
}