using B.IRepository;
using B.ViewModels;
using BlazorApplication.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BussinessLayer
{
	public class RegistrationService : IRegistrationService
	{
		private readonly IRegistrationRepository _registrationRepository;
		public RegistrationService(IRegistrationRepository registrationRepository)
		{
			_registrationRepository = registrationRepository;
		}
        public int PostRegistrationDetails(RegistrationViewModel registrationVm)
		{
			var res = _registrationRepository.PostRegistrationDetails(registrationVm);
			return res;
		}
	}
}
