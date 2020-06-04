﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
namespace DataLayer.Contracts
{
    public interface IPageRepository
    {
         IEnumerable<Pages> GetAllPage();
         Pages GetPagesById(int pageId);
         bool InsertPage(Pages page);
         bool UpdatePage(Pages page);
         bool DeletePage(Pages page);
         bool DeletePage(int pageId);
         void Save();
    }
}