using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MingChi.CRMApplication;
using MingChi.CRMApplication.CRMs;
using MingChi.CRMApplication.CRMs.ViewModels;

namespace BlazorGridViewLab1.Server.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        [Route("GetCustomers")]
        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            CRM crm = new CRM(_customerRepository, _unitOfWork);

            var result = crm.GetCustomers();

            return result;
        }

        [Route("AddCustomer")]
        [HttpPost]
        public int AddCustomer(CustomerViewModel customerViewModel)
        {
            CRM crm = new CRM(_customerRepository, _unitOfWork);

            return crm.AddCustomer(customerViewModel);
        }
    }
}
