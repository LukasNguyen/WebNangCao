using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KetQuaHocTap
    {
        [Key]
        [Column(TypeName = "int", Order = 1)]
        public int maSV { get; set; }
        [Key]
        [Column(TypeName = "int", Order = 2)]
        public int maHP { get; set; }
        [Column(TypeName ="float")]
        public float diemTK1 { get; set; }
        [Column(TypeName = "float")]
        public float diemTK2 { get; set; }
        [Column(TypeName = "float")]
        public float diemTK3 { get; set; }
        [Column(TypeName = "float")]
        public float diemGK { get; set; }
        [Column(TypeName = "float")]
        public float diemCK { get; set; }
        [Column(TypeName = "float")]
        public float diemTong { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(2)]
        public string xepLoai { get; set; }
        [ForeignKey("maSV")]
        public virtual SinhVien SinhVien { get; set; }
        [ForeignKey("maHP")]
        public virtual LopHocPhan LopHocPhan { get; set; }
    }
}
