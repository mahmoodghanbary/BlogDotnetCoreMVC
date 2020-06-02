﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Contracts
{
    public interface IPageGroupRepository
    {
        IEnumerable<PageGroups> GetAllGroups();
        PageGroups GetGroupsById(int groupId);
        bool InsertGroup(PageGroups pageGroups);
        bool UpdateGroup(PageGroups pageGroups);
        bool DeleteGroup(PageGroups pageGroups);
        bool DeleteGroup(int groupId);
        void Save();

    }
}