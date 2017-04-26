using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SinhVien
    {
        [Key]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int maSV { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string tenSV { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string diaChi { get; set; }
        public virtual List<KetQuaHocTap> KetQuaHocTaps { get; set; }
    }
}
