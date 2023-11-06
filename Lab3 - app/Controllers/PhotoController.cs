using Microsoft.AspNetCore.Mvc;
using Lab3___app.Models;

namespace Lab3___app.Controllers
{
    public class PhotoController : Controller
    {
        static Dictionary<int, Photo> _photos = new Dictionary<int, Photo>();
        static int Id = 1;
        public IActionResult Index()
        {
            return View(_photos);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Photo model)
        {
            if (ModelState.IsValid)
            {
                // dodaj model do bazy lub kolekcji
                model.Id = Id++;
                _photos.Add(model.Id, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            return View(_photos[Id]);
        }

        [HttpPost]
        public IActionResult Update(Photo model)
        {
            if (ModelState.IsValid)
            {
                _photos[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            return View(_photos[Id]);
        }

        [HttpPost]
        public IActionResult Details(Photo model)
        {
            if (ModelState.IsValid)
            {
                _photos[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            return View(_photos[Id]);
        }

        [HttpPost]
        public IActionResult Delete(Photo model)
        {
            _photos.Remove(model.Id);
            return RedirectToAction("Index");
        }
    }
}
