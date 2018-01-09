using CodeTogether.Models.ViewModel;
using System.Linq;

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
                Adress.ID = User.ID;

                db.tblAddress.Add(Adress);
                db.SaveChanges();
                return 0;
            }
        }
    }
}