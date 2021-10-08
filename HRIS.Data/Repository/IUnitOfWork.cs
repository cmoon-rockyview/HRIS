using HRIS.Data.Repository.RV;
using HRIS.Data.Repository.TRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Repository
{
    public interface IUnitOfWork
    {

        Task CompleteAsync();
        void Complete();

        public ITrainingRequestRepo ITrainingRequestRepoIns { get; }

        public IEmployeeRepo IEmployeeRepoIns { get; }

    }
}
