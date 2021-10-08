using HRIS.Data;
using HRIS.Data.Perisistance;
using HRIS.Data.Repository;
using HRIS.Domain.TRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Business.Manager
{
    public class TrainingRequestMgr : ITrainingReqestMgr
    {
        IUnitOfWork unit;

        public TrainingRequestMgr()
        {
            unit = new UnitOfWork(new HRContext());
        }

        public async Task<IEnumerable<TrainingRequest>> GetAllTrainingRequests()
        {
            return await unit.ITrainingRequestRepoIns.GetAllAsync();
        }
    }
}
