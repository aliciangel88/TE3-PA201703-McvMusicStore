using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
       // GET: /Store/
       /* public string Index()
        {
            return "Hello from Store.Index()";
        }*/
        //
        // GET: /Store/Browse
        public string BrowseM()
        {
            return "Hello from Store.Browse()";
        }
        //
        // GET: /Store/Details
        /*public string Details()
        {
            return "Hello from Store.Details()";
        }*/

        //
        // GET: /Store/Browse?genero=Disco
        /*public string Browse(string genero)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genero = "
            + genero);
            return message;
        }*/

        //
        // GET: /Store/Details/5
        /*public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }*/

        public ActionResult Details(int Id)
        {
            var album = new Album { Title = "Album " + Id };
            return View(album);
        }
        public ActionResult Index()
        {
            var genero = new List<Genero>
            {
                new Genero { Name = "Disco"},
                new Genero { Name = "Jazz"},
                new Genero { Name = "Rock"}
            };
            return View(genero);
        }
        public ActionResult Browse(string genero)
        {
            var generoModel = new Genero { Name = genero };
            return View(generoModel);
        }

    }
}