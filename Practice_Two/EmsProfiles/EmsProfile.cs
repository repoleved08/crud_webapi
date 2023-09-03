using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Practice_Two.Entities;
using Practice_Two.Requests;
using Practice_Two.ResponseDTO;

namespace Practice_Two.EmsProfiles
{
    public class EmsProfile : Profile
    {
        public EmsProfile()
        {
            CreateMap<EmsUsers, EmsResponse>().ReverseMap();
            CreateMap<EmsUsers, AddEmsUser>().ReverseMap();
        }
    }
}
