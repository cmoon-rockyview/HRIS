using AutoMapper;
using HRIS.AppSrv.Models;
using HRIS.Data.Perisistance;
using HRIS.Data.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.AppSrv.RV
{
    public class EmployeeListBase: ComponentBase
    {
        [Inject]
        public IUnitOfWork _unit { get; set; }
        public List<EmployeeDTO> _employees;
      
        [Inject]
        public IMapper _mapper { get; set; }

        public EmployeeListBase(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public EmployeeListBase()
        {

        }

        protected override async Task OnInitializedAsync()
        {
            var emps = await _unit.IEmployeeRepoIns.FindAsync(s => !s.EmployeeId.Contains("No EmpId"));
            _employees = _mapper.Map<List<EmployeeDTO>>(emps);
        }


    }
}
