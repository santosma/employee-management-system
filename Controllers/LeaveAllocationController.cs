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
    [Authorize(Roles = "Administrator")]
    public class LeaveAllocationsController : Controller
    {
        private readonly ILeaveAllocationRepository _reposLeaveAllocation;
        private readonly ILeaveTypeRepository _reposLeaveTypes;
        private readonly IMapper _mappings;

        public LeaveAllocationsController(
            ILeaveAllocationRepository reposLeaveAllocation,
            ILeaveTypeRepository reposLeaveTypes,
            IMapper mappings
        )
        {
            _reposLeaveAllocation = reposLeaveAllocation;
            _reposLeaveTypes = reposLeaveTypes;
            _mappings = mappings;
        }

        // GET: LeaveAllocationController
        public ActionResult Index()
        {
            var leavetypes = _reposLeaveAllocation.FindAll();
            var model = _mappings.Map<ICollection<LeaveAllocation>, ICollection<LeaveAllocationViewModel>>(leavetypes);
            return View(model);
        }

        // GET: LeaveAllocationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeaveAllocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveAllocationController/Create
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

        // GET: LeaveAllocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeaveAllocationController/Edit/5
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

        // GET: LeaveAllocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveAllocationController/Delete/5
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
