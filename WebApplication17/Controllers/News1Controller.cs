using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class News1Controller : ApiController
    {
        private static string root = System.Web.HttpContext.Current.Server.MapPath("~/Content/images/media/");
        private static string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss tt");
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/News1
        public NewsApiList Getnews()
        {

            NewsApiList newsApiList = new NewsApiList
            {
                Status = true,
                Message = "all data got success",
                newsList = db.news.ToList()
            };
            return newsApiList;

        }
        // GET: api/News1/5
        [ResponseType(typeof(News))]
        public IHttpActionResult GetNews(int id)
        {
            News news = db.news.Find(id);
            if (news == null)
            {
                return NotFound();
            }

            return Ok(news);
        }

        // PUT: api/News1/5
        [ResponseType(typeof(void))]
        public NewsApi editNews(int id, News news)
        {
            
            NewsApi newsStatus = newsStatus = new NewsApi
            {
                Status = ModelState.IsValid,
                Message = "model isn't valid",
                newsModel = news
            };
            if (!ModelState.IsValid)
            {
                return newsStatus;
            }
            else if (ModelState.IsValid)
            {

                if (news.media != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(news.media.FileName);
                    string extention = Path.GetExtension(news.media.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                    news.mediaPath = "../../Content/images/media/" + fileName;
                    fileName = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/images/media"), fileName);
                    news.media.SaveAs(fileName);

                }
                db.Entry(news).State = EntityState.Modified;
                db.SaveChanges();
                newsStatus.Message = "success";
                newsStatus.Status = true;
            }
            else
            {
                return newsStatus;
            }
            return newsStatus;
        }

        // POST: api/News1
        [ResponseType(typeof(News))]
        public NewsApi PostNews(News news)
        {

            NewsApi newsStatus = newsStatus = new NewsApi
            {
                Status = ModelState.IsValid,
                Message = "model isn't valid",
                newsModel = news
            };
            if (!ModelState.IsValid)
            {
                return newsStatus;
            }
            else if (ModelState.IsValid)
            {
                if (news.media != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(news.media.FileName);
                    string extention = Path.GetExtension(news.media.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                    news.mediaPath = "../../Content/images/media/" + fileName;
                    fileName = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/images/media"), fileName);
                    news.media.SaveAs(fileName);

                }

                db.news.Add(news);
                db.SaveChanges();

                newsStatus.Message = "success";
                newsStatus.Status = true;
            }
            else
            {
                return newsStatus;
            }
            return newsStatus;
        }
        // DELETE: api/News1/5
        [ResponseType(typeof(News))]
        public IHttpActionResult DeleteNews(int id)
        {
            News news = db.news.Find(id);
            if (news == null)
            {
                return NotFound();
            }
            File.Delete(news.mediaPath);
            db.news.Remove(news);
            db.SaveChanges();

            return Ok(news);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NewsExists(int id)
        {
            return db.news.Count(e => e.id == id) > 0;
        }


        public NewsApi Delete(int id)
        {

           
            if (id == null)
            {
                NewsApi newsApi = new NewsApi
                {
                    
                    Status = false,
                    Message = "Model isnt vaild id is null",
                    newsModel = null
                };
                return  newsApi;
            }
            News news = db.news.Find(id);
            if (news == null)
            {
                NewsApi newsApi = new NewsApi
                {
                    Status = false,
                    Message = "no model ",
                    newsModel = news
                };
            }
            NewsApi newsApi1 = new NewsApi
            {
                Status = true,
                Message = "success",
                newsModel = news
            };

            db.news.Remove(news);
            db.SaveChanges();
            if (File.Exists(news.mediaPath))
            {
                File.Delete(news.mediaPath);
            }
            return newsApi1;
        }
    }
}