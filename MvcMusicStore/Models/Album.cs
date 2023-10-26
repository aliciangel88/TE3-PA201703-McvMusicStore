using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "AlbunId")]
    public class Album
    {
        [Key]
        [ScaffoldColumn(false)]
        public int AlbunId { get; set; }
        [DisplayName("Genero")]
        public int GeneroId { get; set; }
        [DisplayName("Artist")]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        public string Title { get; set; }
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        public  string AlbumArtUrl { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Artista Artist { get; set; }
    }
}