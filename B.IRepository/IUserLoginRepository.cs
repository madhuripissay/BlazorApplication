using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.IRepository
{
	public interface IUserLoginRepository
	{
		int GetLoginDetails(string username, string password);
	}
}
