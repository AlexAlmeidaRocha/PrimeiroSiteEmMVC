using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroSiteEmMVC.Controllers
{
    public class SobreController : Controller
    {
        // GET: SobreController/Pessoal
        public ActionResult Pessoal()
        {
            return View();
        }

        // GET: SobreController/Profissinal
        public ActionResult Profissional()
        {
            return View();
        }      
        
    }
}
