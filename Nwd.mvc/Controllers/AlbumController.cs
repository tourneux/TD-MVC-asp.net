using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nwd.BackOffice.Impl;
using Nwd.BackOffice.Model;

namespace Nwd.mvc.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult AdminAlbums()
        {
            AlbumRepository alre = new AlbumRepository();
            return View( alre.GetAllAlbums() );
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
            if( id == 0 ) { throw new ArgumentNullException( "album" ); }
            AlbumRepository alre = new AlbumRepository();
            return View( alre.GetAlbumForEdit( id ) );
        }

        // GET: Album/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
        [HttpPost]
        public ActionResult Create( AlbumDTO albumDTO )
        {
            if( albumDTO == null ) { throw new ArgumentNullException( "album" ); }
            try
            {
                AlbumRepository alre = new AlbumRepository();
                Album album = new Album();
                album.Title = albumDTO.Title;
                album.Duration = albumDTO.Duration;
                album.ReleaseDate = albumDTO.ReleaseDate;
                album.Type = albumDTO.Type;
                album.CoverImagePath = albumDTO.CoverImagePath;
                album.Artist = albumDTO.Artist;
                if( albumDTO.Tracks.Count > 0 )
                {
                    album.Tracks = new List<Track>( albumDTO.Tracks );
                } else
                {
                    album.Tracks = new List<Track>();
                }
                album = alre.CreateAlbum( album, Server );

                return RedirectToAction( "../Admin/Album/List" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            if( id == 0 ) { throw new ArgumentNullException( "album" ); }
            AlbumRepository alre = new AlbumRepository();
            AlbumDTO aldto = new AlbumDTO( alre.GetAlbumForEdit( id ) );
            return View( aldto );
        }

        // POST: Album/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AlbumDTO albumDTO)
        {
            if( albumDTO == null ) { throw new ArgumentNullException( "album" ); }
            if( id == 0 ) { throw new ArgumentNullException( "album" ); }
            try
            {
                AlbumRepository alre = new AlbumRepository();
                Album album = alre.GetAlbumForEdit( id );
                album.Title = albumDTO.Title;
                album.Duration = albumDTO.Duration;
                album.ReleaseDate = albumDTO.ReleaseDate;
                album.Type = albumDTO.Type;
                album.CoverImagePath = albumDTO.CoverImagePath;
                album.Artist = albumDTO.Artist;
                if( albumDTO.Tracks.Count > 0 ) 
                {
                    album.Tracks = new List<Track>( albumDTO.Tracks );
                }
                alre.EditAlbum( Server, album );

                return RedirectToAction( "../Admin/Album/List" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Album album)
        {
            if( id == 0 ) { throw new ArgumentNullException( "album" ); }
            try
            {
                AlbumRepository alre = new AlbumRepository();
                //alre.Delete( id );
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
