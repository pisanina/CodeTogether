using CodeTogether.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CodeTogether.Models.EntityManager
{
    public class UserManager
    {
        public string GetUserPassword(string loginName)
        {
            using (UserDataContext db = new UserDataContext())
            {
                var user = db.tblUserData.Where(o => o.UserName.Equals(loginName));
                if (user.Any())
                    return user.FirstOrDefault().UserPassword;
                else
                    return string.Empty;
            }
        }

        public int Register(RegistrationViewModel Data)
        {
            using (UserDataContext db = new UserDataContext())
            {
                if (db.tblUserData.Any(o => o.UserName.Equals(Data.UserName)))
                    return 1;
                var UserData = Data.TotblUserData();


                var User = db.tblUserData.Add(UserData);
                tblAddress Adress = new tblAddress();
                // User AdressID = Address.Id

                db.tblAddress.Add(Adress);
                User.AddressID = Adress.ID;// Increment Address.ID
                db.SaveChanges();
                return 0;
            }
        }

        public MySettingsViewModel MyProfile()
        {
            MySettingsViewModel MyProfileView = new MySettingsViewModel();
            using (UserDataContext db = new UserDataContext())
            {
               
                var UserName = HttpContext.Current.User.Identity.Name;
                var User = db.tblUserData.Single((o => o.UserName.Equals(UserName)));
                var UserAddress = db.tblAddress.Single((o => o.ID.Equals(User.AddressID)));

                MyProfileView.UserName        = User.UserName;
                MyProfileView.FirstName       = User.FirstName;
                MyProfileView.LastName        = User.LastName;
                MyProfileView.Email           = User.Email;
                MyProfileView.Gender          = User.Gender;
                MyProfileView.BirthDate       = User.BirthDate;

                MyProfileView.Country         = UserAddress.Country;
                MyProfileView.City            = UserAddress.City;
                MyProfileView.Region          = UserAddress.Region;
                MyProfileView.ZipCode         = UserAddress.ZipCode;
                MyProfileView.Street          = UserAddress.Street;
                MyProfileView.Number          = UserAddress.Number;
                MyProfileView.ApartmentNumber = UserAddress.ApartmentNumber;

                
            }

                return MyProfileView;
        }

        public int SaveProfile(MySettingsViewModel Data)
        {
            using (UserDataContext db = new UserDataContext())
            {
               
      
                var User = db.tblUserData.Single(o => o.UserName.Equals(Data.UserName));
                if (Data.ConfirmPassword == User.UserPassword)
                {
                    User.UserName  = Data.UserName;
                    User.Email     = Data.Email;
                    User.FirstName = Data.FirstName;
                    User.LastName  = Data.LastName;
                    User.Gender    = Data.Gender;
                    User.BirthDate = Data.BirthDate;

                    var Address = db.tblAddress.Single(o => o.ID.Equals(User.AddressID));
                    Address.Country         = Data.Country;
                    Address.City            = Data.City;
                    Address.Region          = Data.Region;
                    Address.ZipCode         = Data.ZipCode;
                    Address.Street          = Data.Street;
                    Address.Number          = Data.Number;
                    Address.ApartmentNumber = Data.ApartmentNumber;

                    db.SaveChanges();
                    return 0;
                }

                else return 1;

            }
        }
    }
}