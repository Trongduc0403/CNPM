using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class BBSCController
    {
        public static bool AddBBSC(BBSC bbsc)
        {
            using (var _context = new CNPMEntities())
            {
                _context.BBSCs.Add(bbsc);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool RemoveBBSC(string MaBBSC)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dbbbsc = (from sc in _context.BBSCs
                            where sc.MaBBSC == MaBBSC
                            select sc).FirstOrDefault();
                _context.BBSCs.Remove(dbbbsc);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
