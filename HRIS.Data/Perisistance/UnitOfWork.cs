using HRIS.Data.Perisistance.RV;
using HRIS.Data.Perisistance.TRN;
using HRIS.Data.Repository;
using HRIS.Data.Repository.RV;
using HRIS.Data.Repository.TRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Perisistance
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly HRContext _Context;

        public UnitOfWork(HRContext context)
        {
            _Context = context;
            IEmployeeRepoIns = new EmpolyeeRepo(_Context);
            ITrainingRequestRepoIns = new TrainingRequestRepo(_Context);
        }

        public ITrainingRequestRepo ITrainingRequestRepoIns { get; private set; }

        public IEmployeeRepo IEmployeeRepoIns { get; private set; }

        public void Complete()
        {
            try
            {
                _Context.SaveChanges();
            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public async Task CompleteAsync()
        {
            try
            {
                await _Context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
