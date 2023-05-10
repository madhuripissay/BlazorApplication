using B.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BussinessLayer
{
	public class UserLoginService:IUserLoginService

	{
		private readonly IUserLoginRepository _userLoginRepository;
		public UserLoginService(IUserLoginRepository userLoginRepository)
		{
			_userLoginRepository = userLoginRepository;
		}
		public int GetLoginDetails(string EmailAddress, string Password)
		{
		var res=	_userLoginRepository.GetLoginDetails(EmailAddress, Password);
            return res;
        }
		
	}
}
