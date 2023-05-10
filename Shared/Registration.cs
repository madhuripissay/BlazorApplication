using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApplication.Shared
{
	public class Registration
	
	{
		[Key]
        public int RegistrationID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

    }
}

