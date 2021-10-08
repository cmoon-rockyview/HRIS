using HRIS.Data.Repository.RV;
using HRIS.Domain.RV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Perisistance.RV
{
    public class EmpolyeeRepo : Repository<Employee>, IEmployeeRepo
    {

        public EmpolyeeRepo(HRContext context) : base(context)
        {

        }

        public HRContext HRContext
        {
            get { return _Context as HRContext; }
        }
    }
}
