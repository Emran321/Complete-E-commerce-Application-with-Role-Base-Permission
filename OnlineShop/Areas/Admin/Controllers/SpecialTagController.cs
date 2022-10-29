using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialTagController : Controller
    {
        private ApplicationDbContext _db;
        public SpecialTagController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.SpecialTags.ToList());
        }

        //Create get action Method

        public ActionResult Create()
        {
            return View();
        }

        //Create post action Method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(SpecialTag specialTag)
        {
            if(specialTag != null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState.IsValid)
            {
                _db.SpecialTags.Add(specialTag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }



        // get Edit action Method

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tags = _db.SpecialTags.Find(id);
            if (tags == null)
            {
                return NotFound();
            }
            return View(tags);
        }



        //Edit post action Method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                _db.Update(specialTag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }


        // get Details action Method

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tags = _db.SpecialTags.Find(id);
            if (tags == null)
            {
                return NotFound();
            }
            return View(tags);
        }


        //Create Details action Method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Details(SpecialTag specialTag)
        {
            return RedirectToAction(nameof(Index));
        }



        // get Delete action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tags = _db.SpecialTags.Find(id);
            if (tags == null)
            {
                return NotFound();
            }
            return View(tags);
        }

        //Create Delete action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, SpecialTag specialTag)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != specialTag.Id)
            {
                return NotFound();
            }
            var tags = _db.SpecialTags.Find(id);
            if (tags == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(tags);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tags);
        }

    }
}
