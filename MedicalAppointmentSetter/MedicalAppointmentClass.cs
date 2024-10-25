using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentSetter
{
    public class MedicalAppointmentPrinter
    {
        public void Print(MedicalAppointment medicalAppointment)
        {
            Console.WriteLine(
                "Appointment will take place on " + medicalAppointment.GetDate());
        }
    }
    public class MedicalAppointment
    {
        private string _patientName;
        private DateTime _date;

        public DateTime GetDate() => _date;
        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }
        //public MedicalAppointment(string patientName) : this(patientName, 7)
        //{

        //}
        public MedicalAppointment(string patientName, int daysFromNow = 7)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFromNow);
        }
        public MedicalAppointment(int daysFromNow, string patientName = "John")
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFromNow);
        }
        public void Reschedule(DateTime date)
        {
            _date = date;
            var printer = new MedicalAppointmentPrinter();
            printer.Print(this);
        }

        public void OverrideMonthAndDay(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }

        public void MoveByMonthAndDay(int monthsToAdd, int daysToAdd)
        {
            _date = new DateTime(
                _date.Year,
                _date.Month + monthsToAdd,
                _date.Day + daysToAdd);
        }
    }

}
