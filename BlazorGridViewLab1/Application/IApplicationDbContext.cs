using Microsoft.EntityFrameworkCore;
using MingChi.Domain.CRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.CRMApplication
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; set; }

        int SaveChange();
    }
}
