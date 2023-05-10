using B.BussinessLayer;
using B.ViewModels;
using BlazorApplication.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApplication.Server.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class RegistrationController : Controller
	{
		private readonly IRegistrationService _registrationService;
		public RegistrationController(IRegistrationService registrationService) {

		_registrationService = registrationService;
		}

		public IActionResult Registration()
		{
			return View();

		}
		[HttpPost]
		public IActionResult Registration(RegistrationViewModel registrationVm)
		{
            _registrationService.PostRegistrationDetails(registrationVm);
			return RedirectToAction("/login", "UserLogin");
		}


	}
}
