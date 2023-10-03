using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PolitechFalkovskiyD.BLL.Model;
using PolitechFalkovskiyD.DAL.Model;

namespace PolitechFalkoskiy.BLL
{
    public static class SettingAutomapper
    {
        public static MapperConfiguration Init()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientDTO>().ReverseMap();
                cfg.CreateMap<Account, AccountDTO>().ReverseMap();
                cfg.CreateMap<Address, AddressDTO>().ReverseMap();

            });
        }
    }
}
