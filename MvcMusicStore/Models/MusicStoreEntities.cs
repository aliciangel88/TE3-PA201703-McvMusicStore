using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities : DBContext
    {
        public DBset<Album> Albums { get; set; }
        public DBset<Genero> Genero { get; set; }
        }
}