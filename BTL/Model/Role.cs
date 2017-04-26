using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Role
    {
        [Key]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int maRole { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string tenRole { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
