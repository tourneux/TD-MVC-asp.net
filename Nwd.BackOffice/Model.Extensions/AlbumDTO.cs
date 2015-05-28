using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nwd.BackOffice.Model
{
    public class AlbumDTO
    {
        [HiddenInput( DisplayValue = false )]
        public int Id { get; set; }
        [Required]
        [StringLength( 40, MinimumLength = 2 )]
        public string Title { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        [DataType( "DatePicker" )]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength( 40, MinimumLength = 2 )]
        public string Type { get; set; }
        public string CoverImagePath { get; set; }
        [Required]
        public Artist Artist { get; set; }
        public List<Track> Tracks { get; set; }

        //public AlbumDTO( int id, string title, TimeSpan duration, DateTime releaseDate, string type, string coverImagePath, Artist artist, List<Track> tracks ) 
        //{
        //    Id = id;
        //    Title = title;
        //    Duration = duration;
        //    ReleaseDate = releaseDate;
        //    Type = type;
        //    CoverImagePath = coverImagePath;
        //    Artist = artist;
        //    Tracks = new List<Track>( tracks ); ;
        //}
        public AlbumDTO( Album album )
        {
            Id = album.Id;
            Title = album.Title;
            Duration = album.Duration;
            ReleaseDate = album.ReleaseDate;
            Type = album.Type;
            CoverImagePath = album.CoverImagePath;
            Artist = album.Artist;
            Tracks = new List<Track>(album.Tracks);
        }
    }
}
