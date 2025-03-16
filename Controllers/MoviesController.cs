using Microsoft.AspNetCore.Mvc;
using repo.Models;

namespace repo.Controllers
{
    public class MoviesController : Controller
    {
        public string Index()
        {
            return "hello from index";
        }
        //public void GetMovie(int? id, string name)
        //{

        //}
        // public string GetMovie(int? id , string name)
        //{
        //   return $"movie name = {name} And id = {id}";
        //}
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    ContentResult result = new ContentResult();
            //result.Content = $"movie name = {name} And id = {id}";
            //result.ContentType = "text/html";
            //result.StatusCode = 300;
            //return Content($"movie name = {name} And id = {id}" , "text/html" );
        //}
        public IActionResult GetMovie(int id , string name)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id < 10)
            {
                return NotFound();
            }
            else
                return Content($"movie name = {name} And id = {id}", "text/html");
        }
        //public IActionResult TestRedirectAction()
        //{
        //return RedirectToRoute("default", new { Controller = "movies", action = "GetMovie" , id = 10});
        //return RedirectToAction(nameof(GetMovie), "Movies", new {id = 11 , name = "mohamed"});
        //return Redirect("https://localhost:44348/movies/getmovie/10?name=ahmed");
        //return Redirect("https://www.google.com/");
        //}
        [HttpPost]
        public IActionResult TestModelBinding([FromQuery]int id, string name)
        {
            return Content($"hello {name} your id is {id}");
        }
        [HttpPost]
        public IActionResult AddMovie([FromBody]Movie movie)
        {
            if (movie is null)
            {
                return BadRequest();
            }
            else
                return Content($"movie{movie.Title} with id {movie.Id}");
        }
    }
}
