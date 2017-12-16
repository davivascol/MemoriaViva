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
      try
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
      }
      catch (DbEntityValidationException e)
      {
        foreach (var eve in e.EntityValidationErrors)
        {
          Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
              eve.Entry.Entity.GetType().Name, eve.Entry.State);
          foreach (var ve in eve.ValidationErrors)
          {
            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                ve.PropertyName, ve.ErrorMessage);
          }
        }
        throw;
      }
      catch (Exception ex)
      {

      }
      return View();
    }
  }
}