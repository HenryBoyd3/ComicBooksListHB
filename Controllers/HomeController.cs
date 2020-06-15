using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ComicBooksCharacters.Models;


namespace MVC_ComicBooksCharacters.Controllers
{
    public class HomeController : Controller
    {
         ComicBookContext cbtext= null;
        public HomeController()
        {
            ComicBookContext cbtxt = new ComicBookContext();
            cbtxt.Database.EnsureCreated();
            cbtext = cbtxt;


        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View(cbtext);
        }
    }
}
