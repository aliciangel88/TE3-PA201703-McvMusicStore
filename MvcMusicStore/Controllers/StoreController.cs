﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        /*public ActionResult Index()
        {
            return View();
        }*/
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
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
        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
            + genre);
            return message;
        }

        //
        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}