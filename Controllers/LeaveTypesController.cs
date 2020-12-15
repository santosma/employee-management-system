using AutoMapper;
using employee_management_system.Contracts;
using employee_management_system.Data;
using employee_management_system.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Controllers
{
    // Viewable via login permissions
    [Authorize(Roles ="Administrator")]
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository _repos;
        private readonly IMapper _mappings;

        public LeaveTypesController(ILeaveTypeRepository repos, IMapper mappings)
        {
            _mappings = mappings;
            _repos = repos;
        }
        // GET: LeaveTypesController

        public ActionResult Index()
        {
            var leavetypes = _repos.FindAll();
            var model = _mappings.Map<ICollection<LeaveType>, ICollection<LeaveTypeViewModel>>(leavetypes);
            return View(model);
        }

        // GET: LeaveTypesController/Details/5
        public ActionResult Details(int id)
        {
            //does the id even exist?
            if(!_repos.Exists(id))
            {
                //if not return 404 error
                return NotFound();
            }
            //map the model by id with LeaveType
            var modelMapping = _mappings.Map<LeaveTypeViewModel>(_repos.FindById(id));
            return View(modelMapping);
        }
        
        public ActionResult Create()
        {
            return View();
        }


        // POST: LeaveTypesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeaveTypeViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                var modelMapping = _mappings.Map<LeaveType>(model);
                //give datetime after model mapping
                modelMapping.DateCreated = DateTime.Now;
                if(!_repos.Create(modelMapping))
                {
                    ModelState.AddModelError("", "Error adding data from form");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Error");
                return View(model);
            }
        }

        // GET: LeaveTypesController/Edit/5
        //send desired id to edit
        public ActionResult Edit(int id)
        {
            //if no records found 
            if(!_repos.Exists(id))
            {
                //404 error
                return NotFound();
            }
            //map model to the record
            var modelMapping = _mappings.Map<LeaveTypeViewModel>(_repos.FindById(id));
            return View(modelMapping);
        }

        // TODO: Change implementation to [HttpPut(..)]
        // POST: LeaveTypesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LeaveTypeViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                var modelMapping = _mappings.Map<LeaveType>(model);
                if(!_repos.Update(modelMapping))
                {
                    ModelState.AddModelError("", "Error updating record");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Unknown Error while updating record");
                return View(model);
            }
        }

        // GET: LeaveTypesController/Delete/5
        public ActionResult Delete(int id)
        {   
            //does the id even exist?
            if (!_repos.Exists(id))
            {
                //if not return 404 error
                return NotFound();
            }
            //map the model by id with LeaveType
            var modelMapping = _mappings.Map<LeaveTypeViewModel>(_repos.FindById(id));
            return View(modelMapping);
        }

        // TODO:change [HttpDelete(..)]
        // TODO: Implement soft Delete() 
        // POST: LeaveTypesController/Delete/5 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, LeaveTypeViewModel viewModel)
        {
            try
            {
                var model = _repos.FindById(id);
                if(model == null)
                {
                    return NotFound();
                }
                if(!_repos.Delete(model))
                {
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
