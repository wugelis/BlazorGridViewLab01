using MingChi.CRMApplication.Calendars.ViewModels;
using MingChi.CRMApplication.CRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.CRMApplication.Calendars
{
    public class Calendar
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICalendarRepository _calendarRepository;
        private readonly IUnitOfWork _unitOfWork;

        public Calendar(ICustomerRepository customerRepository, ICalendarRepository calendarRepository, IUnitOfWork unitOfWork)
        {
            this._customerRepository = customerRepository;
            this._calendarRepository = calendarRepository;
            this._unitOfWork = unitOfWork;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CalendarViewModel GetCalendars()
        {
            List<MyClass> myClass = new List<MyClass>();
            myClass.Add(new MyClass() { EmpName = "Gelis", EmpId = 1 });
            myClass.Add(new MyClass() { EmpName = "William", EmpId = 2 });

            var result = from a in Accounts
                         join m in myClass
                         on a.UserId equals m.EmpId
                         select new CalendarViewModel()
                         {
                             EmployeeId = $"1{m.EmpId.ToString().PadLeft(9, '0')}",
                             EmployeeName = a.UserName,
                             Calendar = Weeks.Monday
                         };

            return result.FirstOrDefault();
        }

        public void AddCalendar()
        {
            try
            {
                _customerRepository.Add(new Domain.CRMs.Customer() { });
                _calendarRepository.Add(new Domain.Calendar.CalendarEnt() { });

                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                // 請進行相關錯誤處理 (Message ID Trannsform, Write Log, Etc..)
            }
            finally
            {
                //相關的釋放作業
            }
        }

        static IEnumerable<Account> Accounts
        {
            get
            {
                return new Account[] {
            new Account()
            {
                UserId = 1,
                UserName = "Gelis"
            },
            new Account()
            {
                UserId = 2,
                UserName = "Allan"
            }
        };
            }
        }
    }
    public class MyClass
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
    public class Account
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
    

}
