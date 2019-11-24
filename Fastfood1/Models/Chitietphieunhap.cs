using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class Chitietphieunhap
    {
        public int ID { get; set; }
        public int Soluong { get; set; }
        public Monan Monan { get; set; }
        public Phieunhap Phieunhap { get; set; }
    }
}
