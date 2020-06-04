using System.Collections.Generic;
using DataLayer.Contracts;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class PageGroupRepository : IPageGroupRepository
    {
        BlogDBContext db = new BlogDBContext();

        public IEnumerable<PageGroups> GetAllGroups()
        {
            return db.PageGroups;
        }
        public PageGroups GetGroupsById(int groupId)
        {
            return db.PageGroups.Find(groupId);
        }

        public bool InsertGroup(PageGroups pageGroups)
        {
            try
            {
                db.PageGroups.Add(pageGroups);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateGroup(PageGroups pageGroups)
        {
            try
            {
                db.Entry(pageGroups).State=EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteGroup(PageGroups pageGroups)
        {
            try
            {
                db.Entry(pageGroups).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroup(int groupId)
        {
            try
            {
                var group = GetGroupsById(groupId);
                DeleteGroup(group);
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