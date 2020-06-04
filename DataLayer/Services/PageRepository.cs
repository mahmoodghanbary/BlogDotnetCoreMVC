using DataLayer.Models;
using DataLayer.Contracts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class PageRepository : IPageRepository
    {
        private BlogDBContext _db;
        public PageRepository(BlogDBContext db)
        {
            _db = db;
        }
        public IEnumerable<Pages> GetAllPage()
        {
            return _db.Pages;
        }
        public Pages GetPagesById(int pageId)
        {
            return _db.Pages.Find(pageId);
        }
          public bool InsertPage(Pages page)
        {
            try
            {
                _db.Pages.Add(page);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePage(Pages page)
        {
            try
            {
                _db.Entry(page).State=EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePage(Pages page)
        {
            try
            {
                _db.Entry(page).State=EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePage(int pageId)
        {
            try
            {
               var page = GetPagesById(pageId);
                DeletePage(page);
                return true;
                
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        

        

      


    }
}