using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}