using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LopHocPhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int maHP { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int maGV { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int maMH { get; set; }
        [ForeignKey("Hocky")]
        [Column(TypeName = "int")]
        public int hocKy { get; set; }
        [ForeignKey("Hocky")]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string nienKhoa { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime ngayBatDau { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime ngayKetThuc { get; set; }
        [Column(TypeName = "int")]
        public int slSinhVienLonNhat { get; set; }
        [Column(TypeName = "int")]
        public int slSinhVienNhoNhat { get; set; }
        [ForeignKey("maMH")]
        public virtual MonHoc MonHoc { get; set; }
        [ForeignKey("maGV")]
        public virtual GiangVien GiangVien { get; set; }
        public virtual HocKy Hocky { get; set; }
        public virtual List<KetQuaHocTap> KetQuaHocTaps { get; set; }
    }
}
