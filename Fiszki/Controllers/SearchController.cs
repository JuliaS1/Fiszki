using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiszki.Models;

namespace Fiszki.Controllers
{
    public class SearchController : Controller
    {
        
        private static IList<Fiszkii> wykaz = new List<Fiszkii>()
        {
            new Fiszkii(){id_fiszki=1, Nazwa_fiszki="Genshin Impact",Opis="Jak budowac postac",Kategoria="Gry",Przedmiot=" ",Zrobione=true},
            new Fiszkii(){id_fiszki=2,Nazwa_fiszki="Wystawy w muzeach",Opis="Opisy popiersi",Kategoria="Rzeźby",Przedmiot="Sztuka",Zrobione=false},
        };
        // GET: SearchController
        public ActionResult Przegladaj(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            var fiszka = from Fiszkii in wykaz
                          select Fiszkii ;
            switch (sortOrder)
            {
                case "name_desc":
                    fiszka = fiszka.OrderByDescending( Fiszkii=> Fiszkii.Nazwa_fiszki);
                    break;
                default:
                    fiszka = fiszka.OrderBy(Fiszkii => Fiszkii.Nazwa_fiszki);
                    break;
            }
            
                    return View(wykaz);
        }

        // GET: SearchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SearchController/Create
        public ActionResult Create()
        {
            return View(new Fiszkii());
        }

        // POST: SearchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fiszkii fiszkii)
        {
                fiszkii.id_fiszki = wykaz.Count + 1;
                wykaz.Add(fiszkii);
                return RedirectToAction(nameof(Przegladaj));
        }

        // GET: SearchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(wykaz.FirstOrDefault(x=>x.id_fiszki ==id));
        }

        // POST: SearchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Fiszkii fiszkii)
        {
                Fiszkii fiszkii1 = wykaz.FirstOrDefault(x => x.id_fiszki == id);
                fiszkii1.Nazwa_fiszki = fiszkii.Nazwa_fiszki;
                fiszkii1.Opis = fiszkii.Opis;
                fiszkii1.Przedmiot = fiszkii.Przedmiot;
                fiszkii1.Kategoria = fiszkii.Kategoria;
                fiszkii1.Zrobione = fiszkii.Zrobione;
            return RedirectToAction(nameof(Przegladaj));
            
        }

        // GET: SearchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(wykaz.FirstOrDefault(x => x.id_fiszki == id));
        }

        // POST: SearchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Fiszkii fiszkii)
        {
            Fiszkii fiszkii1 = wykaz.FirstOrDefault(x => x.id_fiszki == id);
            wykaz.Remove(fiszkii1);
            return RedirectToAction(nameof(Przegladaj));
           
        }
        
    }
}
