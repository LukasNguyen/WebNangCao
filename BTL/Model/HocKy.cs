using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HocKy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int", Order = 1)]
        public int hocKy { get; set; }
        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [StringLength(10)]
        public string nienKhoa { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime ngayBatDau { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime ngayKetThuc { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime ngayBatDauDangKyHP { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime ngayKetThucDangKyHP { get; set; }
        public virtual List<LopHocPhan> LopHocPhans { get; set; }
    }
}
