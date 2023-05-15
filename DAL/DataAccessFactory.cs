using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Manager, string, Manager> ManagerData()
        {
            return new ManagerRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new ManagerRepo();
        }

        public static IRepo<ManagerToken, string, ManagerToken> TokenData()
        {
            return new TokenRepo();
        }

        public static IRepo<SeatDetail, string, SeatDetail> SeatDetailData()
        {
            return new SeatDetailRepo();
        }

        public static IRepo<Discount, string, Discount> DiscountData()
        {
            return new DiscountRepo();
        }


    }
}
