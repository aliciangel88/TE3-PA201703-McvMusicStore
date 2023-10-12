using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Artista
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}