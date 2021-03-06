﻿using System;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HelperMethods.Models
{
    public class Person
    {
        [HiddenInput(DisplayValue =false)]
        public int PersonId { get; set; }

        [Display(Name ="First")]
        [UIHint("MultilineText")]
        public string FirstName { get; set; }

        [Display(Name = "First")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        public Address HomeAddress { get; set; }

        [Display(Name = "Approved")]
        public bool IsApproved { get; set; }

        [UIHint("Enum")]
        public Role Role { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest
    }
}