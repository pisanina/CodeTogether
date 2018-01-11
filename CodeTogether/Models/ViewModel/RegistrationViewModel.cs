using System.ComponentModel.DataAnnotations;

namespace CodeTogether.Models.ViewModel
{
    public class RegistrationViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please provide name", AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please provide email", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide password", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8,
            ErrorMessage = "Password must be 8 char long with some uppercase and numbers")]
        public string UserPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "Confirm password dose not mach")]
        public string ConfirmPassword { get; set; }

        public tblUserData TotblUserData()
        {
            tblUserData UserData = new tblUserData();
            UserData.UserName = this.UserName;
            UserData.Email = this.Email;
            UserData.UserPassword = this.UserPassword;
            return UserData;
        }
       
    }
}