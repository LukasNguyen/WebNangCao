using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int maMH { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string tenMH { get; set; }
        [Column(TypeName = "int")]
        public int soTinChi { get; set; }
    }
}
