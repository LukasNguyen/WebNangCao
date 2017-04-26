using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [Key]
        [Column(TypeName = "int")]
        public int maUser { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string passWord { get; set; }
        [Key]
        [Column(TypeName = "int", Order = 2)]
        public int maRole { get; set; }
        [ForeignKey("maRole")]
        public Role Role { get; set; }
    }
}
