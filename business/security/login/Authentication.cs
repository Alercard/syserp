using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using datos;
using datos.Models;


namespace business.security.login
{
    public static class Authentication
    {
        public static bool validateCredentials(string email, string password)
        {
            using (var context = new SQLDbContext())
            {
                var queryResult =  from t1 in context.Users
                                   where email.Equals(t1.Email) && password.Equals(t1.Password)
                                   select new { t1.Id };

                return queryResult.ToList().Count() > 0;
            }
        }
    }
}
