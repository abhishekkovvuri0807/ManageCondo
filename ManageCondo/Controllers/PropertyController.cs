using ManageCondo.Business;
using ManageCondo.DomainLayer;
using ManageCondo.Mapper;
using ManageCondo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageCondo.Controllers
{
    public class PropertyController : Controller
    {
        private readonly PropertyBusiness _propertyBusiness;

        public PropertyController(PropertyBusiness propertyBusiness)
        {
            _propertyBusiness = propertyBusiness;
        }

        // GET: PropertyController
        public async Task<ActionResult> Index()
        {
            IEnumerable<Property> propertyList = await _propertyBusiness.GetAllProperties();
            List<PropertyViewModel> propertyViewModelList = PropertyMapper.ToPropertyViewModelList(propertyList);
            return View(propertyViewModelList);
        }

        // GET: PropertyController/Details/5
        public ActionResult Details(int id)
        {
            Property property = _propertyBusiness.GetPropertyDetails(id);
            PropertyViewModel propertyViewModel = PropertyMapper.ToPropertyViewModel(property);
            return View(propertyViewModel);
        }

        // GET: PropertyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyController/Create
        [HttpPost]
        public ActionResult Create(PropertyViewModel propertyViewModel)
        {
            try
            {
                Property property = PropertyMapper.ToProperty(propertyViewModel);
                _propertyBusiness.AddProperty(property);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                throw ex;
                //return View();
            }
        }

        // GET: PropertyController/Edit/5
        public ActionResult Edit(int id)
        {
            Property property = _propertyBusiness.GetPropertyDetails(id);
            PropertyViewModel propertyViewModel = PropertyMapper.ToPropertyViewModel(property);
            return View(propertyViewModel);
        }

        // POST: PropertyController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PropertyViewModel propertyViewModel)
        {
            try
            {
                Property property = PropertyMapper.ToProperty(propertyViewModel);
                _propertyBusiness.UpdateProperty(property);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertyController/Delete/5
        public ActionResult Delete(int id)
        {
            Property property = _propertyBusiness.GetPropertyDetails(id);
            PropertyViewModel propertyViewModel = PropertyMapper.ToPropertyViewModel(property);
            return View(propertyViewModel);
        }

        // POST: PropertyController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PropertyViewModel propertyViewModel)
        {
            try
            {
                Property property = PropertyMapper.ToProperty(propertyViewModel);
                _propertyBusiness.DeleteProperty(property);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
