using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DiscountService
    {
        public static List<DiscountDTO> Get()
        {
            var data = DataAccessFactory.ManagerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Discount, DiscountDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DiscountDTO>>(data);
            return mapped;

        }


        public static DiscountDTO Get(string id)
        {
            var data = DataAccessFactory.DiscountData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Discount, DiscountDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DiscountDTO>(data);
            return mapped;
        }

        public static DiscountDTO Create(DiscountDTO discount)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DiscountDTO, Discount>();
                c.CreateMap<Discount, DiscountDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Discount>(discount);
            var data = DataAccessFactory.DiscountData().Create(ht);

            if (data != null) return mapper.Map<DiscountDTO>(data);
            return null;
        }

        public static DiscountDTO Update(DiscountDTO DiscountDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DiscountDTO, Discount>();
                c.CreateMap<Discount, DiscountDTO>();
            });
            var mapper = new Mapper(cfg);
            var discount= mapper.Map<Discount>(DiscountDTO);
            var data = DataAccessFactory.DiscountData().Update(discount);
            if (data != null)
            {
                return mapper.Map<DiscountDTO>(data);
            }
            return null;
        }
    }
}
