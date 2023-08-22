using MingChi.CRMApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.Infrastructure.Models
{
    /// <summary>
    /// 控制交易、並維持交易的完整性
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UnitOfWork(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public int Commit()
        {
            return _applicationDbContext.SaveChange();
        }
    }
}
