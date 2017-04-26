using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLHocPhanContext:DbContext
    {
        public DbSet<HocKy> HocKys { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<KetQuaHocTap> KetQuaHocTaps { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public QLHocPhanContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
