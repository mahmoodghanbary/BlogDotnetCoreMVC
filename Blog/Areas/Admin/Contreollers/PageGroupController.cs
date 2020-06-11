using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;
using DataLayer.Contracts;
using DataLayer.Repositories;

namespace Blog.Areas.Admin.Contreollers
{
    [Area("Admin")]
    public class PageGroupController : Controller
    {
       private IPageGroupRepository pageGroupRepository;

        public PageGroupController()
        {
            pageGroupRepository = new PageGroupRepository();
        }
     

        // GET: Admin/PageGroup
        public IActionResult Index()
        {
            return View(pageGroupRepository.GetAllGroups());
        }

        // GET: Admin/PageGroup/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = pageGroupRepository.GetGroupsById(id.Value);
                
            if (pageGroups == null)
            {
                return NotFound();
            }

            return View(pageGroups);
        }

        // GET: Admin/PageGroup/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PageGroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("GroupID,GroupTitle")] PageGroups pageGroups)
        {
            if (ModelState.IsValid)
            {
                pageGroupRepository.InsertGroup(pageGroups);
                pageGroupRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(pageGroups);
        }

        // GET: Admin/PageGroup/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = pageGroupRepository.GetGroupsById(id.Value);
            if (pageGroups == null)
            {
                return NotFound();
            }
            return View(pageGroups);
        }

        // POST: Admin/PageGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("GroupID,GroupTitle")] PageGroups pageGroups)
        {
            if (id != pageGroups.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    pageGroupRepository.UpdateGroup(pageGroups);
                     pageGroupRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageGroupsExists(pageGroups.GroupID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pageGroups);
        }

        // GET: Admin/PageGroup/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = pageGroupRepository.GetGroupsById(id.Value);
                
            if (pageGroups == null)
            {
                return NotFound();
            }

            return View(pageGroups);
        }

        // POST: Admin/PageGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            
            pageGroupRepository.DeleteGroup(id);
            pageGroupRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageGroupsExists(int id)
        {
            return PageGroupsExists(id);
        }
    }
}
