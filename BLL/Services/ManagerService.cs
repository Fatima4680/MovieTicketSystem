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
    public class ManagerService
    {
        public static List<ManagerDTO> Get()
        {
            var data = DataAccessFactory.ManagerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Manager, ManagerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ManagerDTO>>(data);
            return mapped;
        }
        public static ManagerDTO Get(string id)
        {
            var data = DataAccessFactory.ManagerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Manager, ManagerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ManagerDTO>(data);
            return mapped;
        }



        public static ManagerDTO Create(ManagerDTO manager)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ManagerDTO, Manager>();
                c.CreateMap<Manager, ManagerDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Manager>(manager);
            var data = DataAccessFactory.ManagerData().Create(ht);

            if (data != null) return mapper.Map<ManagerDTO>(data);
            return null;
        }


        public static ManagerDTO Update(ManagerDTO ManagerDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ManagerDTO, Manager>();
                c.CreateMap<Manager, ManagerDTO>();
            });
            var mapper = new Mapper(cfg);
            var manager = mapper.Map<Manager>(ManagerDTO);
            var data = DataAccessFactory.ManagerData().Update(manager);
            if (data != null)
            {
                return mapper.Map<ManagerDTO>(data);
            }
            return null;
        }



        public static bool Delete(string id)
        {

            var result = DataAccessFactory.ManagerData().Delete(id);
            return result;

        }
    }
}
