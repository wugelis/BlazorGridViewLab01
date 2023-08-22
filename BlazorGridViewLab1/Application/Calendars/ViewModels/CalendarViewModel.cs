namespace MingChi.CRMApplication.Calendars.ViewModels
{
    public class CalendarViewModel
    {
        public Weeks Week { get; set; }
        public string EmployeeId { get; internal set; }
        public string EmployeeName { get; internal set; }
        public Weeks Calendar { get; internal set; }
    }

    public enum Weeks
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}