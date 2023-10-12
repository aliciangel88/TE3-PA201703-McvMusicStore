using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        [Key]
        public int AlbunId { get; set; }
        public int GeneroId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public  string AlbumArtUrl { get; set; }
        public Genero Genero { get; set; }
        public Artista Artist { get; set; }
    }
}