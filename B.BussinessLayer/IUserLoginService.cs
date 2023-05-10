using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BussinessLayer
{
	public interface IUserLoginService
	{
		public int GetLoginDetails(string username, string password);
	}
}
