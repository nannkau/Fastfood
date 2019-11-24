using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class Hoadon
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Ngaylap { get; set; }
        public int Tongtien { get; set; }
        public Nhanvien Nhanvien { get; set; }
    }
}
