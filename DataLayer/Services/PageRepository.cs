using DataLayer.Models;
using DataLayer.Contracts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class PageRepository : IPageRepository
    {
        private BlogDBContext db;
        public PageRepository(BlogDBContext context)
        {
            db = context;
        }
        public IEnumerable<Pages> GetAllPage()
        {
            return db.Pages;
        }
        public Pages GetPagesById(int pageId)
        {
            return db.Pages.Find(pageId);
        }
          public bool InsertPage(Pages page)
        {
            try
            {
                db.Pages.Add(page);
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
                db.Entry(page).State=EntityState.Modified;
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
                db.Entry(page).State=EntityState.Deleted;
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
            db.SaveChanges();
        }

        

        

      


    }
}