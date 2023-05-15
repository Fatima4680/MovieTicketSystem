using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SeatDetailRepo : Repo, IRepo<SeatDetail, string, SeatDetail>
    {
        public SeatDetail Create(SeatDetail obj)
        {
            db.SeatDetails.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.SeatDetails.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<SeatDetail> Read()
        {
            return db.SeatDetails.ToList();
        }

        public SeatDetail Read(string id)
        {
            return db.SeatDetails.Find(id);
        }

        public SeatDetail Update(SeatDetail obj)
        {
            var ex = Read(obj.SeatId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
