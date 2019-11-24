using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class Monan
    {   

        public int ID { get; set; }
        public string Ten { get; set; }
        public string  Loai { get; set; }
        public int GiaMua { get; set; }
        public int GiaBan { get; set; }
        public int Soluong { get; set; }
        public Nhacungcap Nhacungcap { get; set; }

    }
}
