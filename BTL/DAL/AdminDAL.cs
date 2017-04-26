using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDAL
    {
        QLHocPhanContext db;
        public AdminDAL()
        {
            db = new QLHocPhanContext();
            db.Database.Connection.ConnectionString = @"Data Source=DESKTOP-0DO63JB\BLUE;Initial Catalog=QLHocPhan;Integrated Security=True";
            db.Database.CreateIfNotExists();
            db.SaveChanges();
        }
        public List<Role> GetAllRole()
        {
            return db.Roles.ToList();
        }
        public User GetUserByIDAndPassWord(int id, string password)
        {
            var temp = db.Users.Where(x => x.maUser == id).FirstOrDefault();
            if (temp != null)
            {
                if (temp.passWord == null)
                {
                    return temp;
                }
                if (temp.passWord == password)
                {
                    return temp;
                }
            }
            return null;
        }
    }
}
