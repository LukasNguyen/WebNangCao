using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API.Controllers
{
    public class QuanLyController : ApiController
    {
        QuanLyDAL db;
        public QuanLyController()
        {
            db = new QuanLyDAL();
        }
        [HttpPost]
        public IHttpActionResult PostEbook(EbookViewModel ebook)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dữ liệu chưa hợp lệ!");
            if (ebdal.InsertEbook(new Model.Ebook()
            {
                BookId = ebook.BookId,
                BookTitle = ebook.BookTitle,
                Introduction = ebook.Introduction,
                AuthorName = ebook.AuthorName,
                PublisherName = ebook.PublisherName
            }))
                return Ok();
            return BadRequest("nhập lại bookId");
        }
    }
}
