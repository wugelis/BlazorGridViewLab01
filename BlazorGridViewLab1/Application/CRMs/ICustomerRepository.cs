using MingChi.Domain.CRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.CRMApplication.CRMs
{
    /// <summary>
    /// Customer 基本資料存取介面
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// 新增 Customer
        /// </summary>
        /// <param name="customer"></param>
        void Add(Customer customer);
        /// <summary>
        /// 修改 Customer
        /// </summary>
        /// <param name="customer"></param>
        void Edit(Customer customer);
        /// <summary>
        /// 查詢所有 Customers
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetAllCustomers();
    }
}
