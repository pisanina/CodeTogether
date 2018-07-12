using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTogether.Models.ViewModel
{
    public class MySettingsViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please provide name", AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please provide email", AllowEmptyStrings = false)]
        public string Email { get; set; }

       

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        //[Compare("UserPassword", ErrorMessage = "Confirm password dose not mach")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$")]
        public string LastName { get; set; }

        public string Gender { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1910", "1/1/2010",
            ErrorMessage = "Birth date must be between year 1910 and 2010")]
        public Nullable<System.DateTime> BirthDate { get; set; }

        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$")]
        public string Country { get; set; }

        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$")]
        public string Region { get; set; }

        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$")]
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$")]
        public string Street { get; set; }

        [Range(1, 1000)]
        public Nullable<int> Number { get; set; }

        [Display(Name = "Apartment Number")]
        [Range(1, 1000)]
        public Nullable<int> ApartmentNumber { get; set; }

        public string SaveMessage { get; set; }

    }
}