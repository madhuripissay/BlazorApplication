using B.BussinessLayer;
using B.IRepository;
using BlazorApplication.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApplication.Server.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class UserLoginController:Controller
	{
		private readonly IUserLoginService _userLoginService;

		public UserLoginController(IUserLoginService userLoginService)
		{
			_userLoginService = userLoginService;
		}

		[HttpPost]
		public IActionResult Login([FromForm]string EmailAddress, [FromForm]string Password)
		{
        var res= _userLoginService.GetLoginDetails(EmailAddress, Password);

			return Ok(res);

        }

	}
}
