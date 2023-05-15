using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManagerRepo : Repo, IRepo<Manager, string, Manager>, IAuth<bool>
    {
        public bool Authenticate(string mname, string password)
        {
            var data = db.Managers.FirstOrDefault(u => u.ManagerId.Equals(mname) &&
            u.MPassword.Equals(password));
            if (data != null) return true;
            return false;
        }

        public Manager Create(Manager obj)
        {
            db.Managers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Managers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Manager> Read()
        {
            return db.Managers.ToList();
        }

        public Manager Read(string id)
        {
            return db.Managers.Find(id);
        }

        public Manager Update(Manager obj)
        {
            var ex = Read(obj.ManagerId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
