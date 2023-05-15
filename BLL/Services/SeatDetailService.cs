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
    public class SeatDetailService
    {
        public static List<SeatDetailDTO> Get()
        {
            var data = DataAccessFactory.ManagerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SeatDetail, SeatDetailDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SeatDetailDTO>>(data);
            return mapped;
        }
        public static SeatDetailDTO Get(string id)
        {
            var data = DataAccessFactory.SeatDetailData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SeatDetail, SeatDetailDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SeatDetailDTO>(data);
            return mapped;
        }



        public static SeatDetailDTO Create(SeatDetailDTO seatdetail)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<SeatDetailDTO, SeatDetail>();
                c.CreateMap<SeatDetail, SeatDetailDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<SeatDetail>(seatdetail);
            var data = DataAccessFactory.SeatDetailData().Create(ht);

            if (data != null) return mapper.Map<SeatDetailDTO>(data);
            return null;
        }


        public static SeatDetailDTO Update(SeatDetailDTO SeatDetailDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<SeatDetailDTO, SeatDetail>();
                c.CreateMap<SeatDetail, SeatDetailDTO>();
            });
            var mapper = new Mapper(cfg);
            var seatdetail = mapper.Map<SeatDetail>(SeatDetailDTO);
            var data = DataAccessFactory.SeatDetailData().Update(seatdetail);
            if (data != null)
            {
                return mapper.Map<SeatDetailDTO>(data);
            }
            return null;
        }



        public static bool Delete(string id)
        {

            var result = DataAccessFactory.SeatDetailData().Delete(id);
            return result;

        }
    }
}
