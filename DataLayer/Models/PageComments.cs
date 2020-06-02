﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public partial class PageComments
    {
       [Key]
        public int CommentID { get; set; }

        [Display(Name = "خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int PageID { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [MaxLength(200)]
        public string Email { get; set; }
        [Display(Name = "سایت")]
        [MaxLength(200)]
        public string WebSite { get; set; }

        [Display(Name = "نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500)]
        public string Comment { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public DateTime CreateDate { get; set; }

        public virtual Pages Page { get; set; }

        public PageComments()
        {

        }
    }
    
}
