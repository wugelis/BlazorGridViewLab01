using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using MingChi.CRMApplication.CRMs.ViewModels;
using MingChi.Infrastructure.Configuration.CRMs;
using MingChi.Domain.CRMs;

namespace MingChi.CRMApplication.CRMs
{
    public class CRM
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CRM(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            var result = from cus in _customerRepository.GetAllCustomers()
                         select new CustomerViewModel()
                         {
                             CustomerId = cus.CustomerId,
                             ContactName = cus.ContactName,
                             CompanyName = cus.CompanyName,
                             Region = cus.Region,
                             Address = cus.Address,
                             City = cus.City,
                             ContactTitle = cus.ContactTitle,
                             Country = cus.Country,
                             Phone = cus.Phone
                         };

            return result;
        }

        public int AddCustomer(CustomerViewModel customer)
        {
            int result = 0;
            try
            {
                _customerRepository.Add(new Customer()
                {
                    CustomerId = customer.CustomerId,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    CompanyName = customer.CompanyName,
                    Country = customer.Country,
                    PostalCode = customer.PostalCode,
                    Address = customer.Address,
                    City = customer.City,
                    Phone = customer.Phone,
                    Region = customer.Region,
                    Fax = customer.Fax
                });
                result = _unitOfWork.Commit();
            }
            catch(Exception ex)
            {
                // Write Log

                // Or throw the exception
                throw ex;

            }
            return result;
        }
    }
}
