using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApplication.Shared
{
	public class Login
	{
			[Key]
		    public int LoginId { get; set; }
			public string PasswordHash { get; set; }
			public string PasswordSalt { get; set; }
			public string EmailAddress { get; set; } 
			public string PhoneNumber { get; set; }
			public bool LoginStatus { get; set; }
			public virtual Registration Resistration { get; set; }
		
	}
	
}
