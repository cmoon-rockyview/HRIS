using HRIS.Domain.TRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Business.Manager
{
    public interface ITrainingReqestMgr
    {
        Task<IEnumerable<TrainingRequest>> GetAllTrainingRequests();
    }
}
