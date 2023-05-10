using B.ViewModels;
using BlazorApplication.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BussinessLayer
{
	public interface IRegistrationService
	{
		public int PostRegistrationDetails(RegistrationViewModel registrationVm);

	}
}
