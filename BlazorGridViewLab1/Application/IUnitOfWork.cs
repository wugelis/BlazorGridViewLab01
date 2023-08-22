using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.CRMApplication
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
