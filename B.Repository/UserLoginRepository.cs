using B.Database;
using B.IRepository;
using BlazorApplication.Shared;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace B.Repository
{
	public class UserLoginRepository:IUserLoginRepository 
	{
		private readonly AppDbContext _dbContext;
		public UserLoginRepository(AppDbContext DbContext)
		{
			_dbContext = DbContext;
		}
		public int GetLoginDetails(string EmailAddress, string Password)
		{
			
				//var Users =await DbContext.Logins Where
				if (EmailAddress != null && Password != null)
				{
					Login login=new Login();
					var Res = _dbContext.Registrations.Where(a => a.EmailAddress == EmailAddress).FirstOrDefault();
					if (Res != null)
					{
                        if (!string.IsNullOrEmpty(Res.PasswordSalt) && (!string.IsNullOrEmpty(Password)))
                        {
                            string hashPassword = HashSalt.CreateHash(Password, Res.PasswordSalt);
                            if (Res.PasswordHash == hashPassword)
                            {
                               
                                return 1;
                            }
                        }

					
                        //login.EmailAddress= EmailAddress;
                        //login.Password= Password;
                        //                  _dbContext.Add(login);
                        //_dbContext.SaveChanges();
                       
					}
               
            }

            return 0;

        }
	}
}


