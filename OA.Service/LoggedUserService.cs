using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Data;

namespace OA.Service
{
    public static class LoggedUserService
    {
        public static void Init()
        {
            UserName = string.Empty;
            UserId = 0;
            IsUserLogged = false;
        }
        public static string UserName { get; set; }

        public static int UserId { get; set; }

        public static bool IsUserLogged { get; set; }

        public static int UserPrivilages { get; set; }

        public static string LoginUser(string login, string pass)
        {
            var result = string.Empty;

            IsUserLogged = true;
            UserName = "";
            UserId = 0;
            UserPrivilages = 0;

            return result;
        }
    }
}
