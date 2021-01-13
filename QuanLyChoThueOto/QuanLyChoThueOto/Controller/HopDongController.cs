using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class HopDongController
    {
        public static bool AddHopDong(HopDong hopdong)
        {
            using (var _context = new CNPMEntities())
            {
                _context.HopDongs.Add(hopdong);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
