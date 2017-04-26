using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GiangVien
    {
        [Key]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int maGV { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string tenGV { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string diaChi { get; set; }
    }
}
