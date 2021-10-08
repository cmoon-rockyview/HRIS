using HRIS.Data.Repository.TRN;
using HRIS.Domain.TRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Perisistance.TRN
{
    public class TrainingRequestRepo: Repository<TrainingRequest>, ITrainingRequestRepo
    {
        public TrainingRequestRepo(HRContext context): base(context)
        {

        }
        public HRContext HRContext
        {
            get { return _Context as HRContext; }
        }

    }
}
