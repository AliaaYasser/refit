using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication17.Models
{
    public class News
    {
        [Key]
        public int id { set; get; }
        [Required]
        public string title { set; get; } 
        public string description { set; get; }
        [FileExtensions(Extensions = "jpg,gif,png,jpeg,mov,avi,wmv,mp4,m4p,m4v,ogg,mpg,mp2,mpeg,mpe,mpv", ErrorMessage = "please upload image or video")]
        public string mediaPath { set; get; }
        [NotMapped]
        public HttpPostedFileBase media { get; set; }
        public bool isActive { set; get; }


    }


    public class NewsApi
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public News newsModel { set; get; }


    }
    public class NewsApiList
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public List<News> newsList{ set; get; }


    }
}