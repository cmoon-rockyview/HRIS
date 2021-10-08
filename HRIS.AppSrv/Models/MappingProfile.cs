using AutoMapper;
using HRIS.Domain.RV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.AppSrv.Models
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
