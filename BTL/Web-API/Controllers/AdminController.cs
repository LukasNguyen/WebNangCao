using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API.Controllers
{
    public class AdminController : ApiController
    {
        AdminDAL db;
        public AdminController()
        {
            db = new AdminDAL();
        }
        public IHttpActionResult GetAllRole()
        {
            var lstRole = db.GetAllRole();
            if (lstRole.Count == 0)
                return NotFound();
            return Ok(lstRole);
        }
        public IHttpActionResult GetUser(int id, string password)
        {
            var user = db.GetUserByIDAndPassWord(id, password);
            if (user != null)
                return Ok(user);
            return BadRequest("Không tìm thấy user");
        }
    }
}
