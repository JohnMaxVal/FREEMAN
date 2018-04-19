using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Infrastrusture
{
    public class NoJoeOnMondaysAttribute : ValidationAttribute
    {
        public NoJoeOnMondaysAttribute()
        {
            ErrorMessage = "Joe cannot bool appointments on Mondays";
        }

        public override bool IsValid(object value)
        {
            Appointment appt = value as Appointment;
            if (appt == null || string.IsNullOrEmpty(appt.ClientName) || appt.Date > DateTime.Now)
            {
                return true;
            }
            else
            {
                return !(appt.ClientName == "Joe" && appt.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}