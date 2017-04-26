using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_API.Models
{
    public class LopHocPhanViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        public int maGV { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int maMH { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int hocKy { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(10)]
        public int nienKhoa { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.DateTime)]
        public DateTime ngayBatDau { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.DateTime)]
        public DateTime ngayKetThuc { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int slSinhVienLonNhat { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int slSinhVienNhoNhat { get; set; }
    }
}