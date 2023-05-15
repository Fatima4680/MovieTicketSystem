using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<ManagerToken, string, ManagerToken>
    {
        public ManagerToken Create(ManagerToken obj)
        {
            db.ManagerTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<ManagerToken> Read()
        {
            throw new NotImplementedException();
        }

        public ManagerToken Read(string id)
        {
            return db.ManagerTokens.FirstOrDefault(t => t.TKey.Equals(id));
        }

        public ManagerToken Update(ManagerToken obj)
        {
            var token = Read(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;
        }
    }
}