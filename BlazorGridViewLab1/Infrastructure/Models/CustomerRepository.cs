using MingChi.CRMApplication;
using MingChi.CRMApplication.CRMs;
using MingChi.Domain.CRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.Infrastructure.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CustomerRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Add(Customer customer)
        {
            _applicationDbContext.Customers.Add(customer); 
        }

        public void Edit(Customer customer)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 查詢所有 Customers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _applicationDbContext.Customers.ToList();
        }
    }
}
