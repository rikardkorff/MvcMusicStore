using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.ViewModels;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

      public ActionResult Index()
      {
        // Create a list of genres
        List<string> genres = new List<string>() { "Rock", "Jazz", "Country", "Pop", "Disco" };

        // Create our View Model
        StoreIndexViewModel viewModel = new StoreIndexViewModel() { NumberOfGenres = genres.Count, Genres = genres };

        ViewBag.Starred = new List<string> { "Rock", "Jazz" };
        
        return this.View(viewModel);
      }

      //public string Index()
      //{
      //  return "Hello from Store.Index()";
      //}

      // GET: /Store/Browse?genre=Disco
      public ActionResult Browse(string genre)
      {
        Genre genreModel = new Genre() { Name = genre};

        List<Album> albums = new List<Album>()
                               {
                                 new Album() { Title = genre + " Album 1"},
                                 new Album() { Title = genre + " Album 2"}
                               };
        StoreBrowseViewModel viewModel = new StoreBrowseViewModel()
                                           {
                                             Genre = genreModel,
                                             Albums = albums
                                           };
        return this.View(viewModel);
      }

      // GET: /Store/Details/5
      public ActionResult Details(int Id)
      {
        Album album = new Album() { Title = "Sample Album" };
        return this.View(album);
      }
    }
}
