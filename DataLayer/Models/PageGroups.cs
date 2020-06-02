﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public partial class PageGroups
    {
           [Key]
        public int GroupID { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }


        //Navigation Property
        public virtual List<Pages> Pages { get; set; }

        public PageGroups()
        {
            
        }
    }
}
