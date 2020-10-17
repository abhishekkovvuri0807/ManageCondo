using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManageCondo.Business;
using ManageCondo.DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageCondo.Controllers
{
    public class UnitController : Controller
    {

        private readonly UnitBusiness _unitBusiness;

        public UnitController(UnitBusiness propertyBusiness)
        {
            _unitBusiness = propertyBusiness;
        }

        // GET: UnitController
        public ActionResult Index()
        {
            IEnumerable<Unit> unitList = _unitBusiness.GetAllUnits();

            return View(unitList);
        }

        // GET: UnitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
