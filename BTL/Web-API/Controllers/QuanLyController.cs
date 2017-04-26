using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API.Models;

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
        public IHttpActionResult MoLopHocPhan(LopHocPhanViewModel lhp)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dữ liệu chưa hợp lệ!");
            if (lhp.slSinhVienNhoNhat < 0 || lhp.slSinhVienLonNhat < 0)
                return BadRequest("Số lượng sinh viên không được nhỏ hơn 0");
            if (lhp.slSinhVienNhoNhat >= lhp.slSinhVienLonNhat)
                return BadRequest("Số lượng sinh viên lớn nhất phải lớn hơn số lượng sinh viên nhỏ nhất");
            if(lhp.ngayBatDau>=lhp.ngayKetThuc)
                return BadRequest("Ngày bắt đầu học môn không thể lớn hơn hoặc bằng ngày hết môn");
            if (db.MoLopHocPhan(new Model.LopHocPhan())
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
