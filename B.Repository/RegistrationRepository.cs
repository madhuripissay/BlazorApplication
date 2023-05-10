using B.Database;
using B.IRepository;
using B.ViewModels;
using BlazorApplication.Shared;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Repository
{
	public class RegistrationRepository : IRegistrationRepository
	{
		private readonly AppDbContext appDb;
		public RegistrationRepository(AppDbContext DbContext)
		{
			appDb = DbContext;
		}
		public int PostRegistrationDetails(B.ViewModels.RegistrationViewModel registrationVm)
		{
			Registration registration= new Registration();
			if (registrationVm != null)
			{
				registration.FirstName = registrationVm.FirstName;
				registration.LastName = registrationVm.LastName;
				registration.PhoneNumber = registrationVm.PhoneNumber;
				registration.EmailAddress = registrationVm.EmailAddress;
                string PasswordSalt = HashSalt.CreateSalt();

                string PasswordHash = HashSalt.CreateHash(registrationVm.Password,PasswordSalt);
            registration.PasswordHash = PasswordHash;
                registration.PasswordSalt = PasswordSalt;
            }
			appDb.Registrations.Add(registration);
			var res = appDb.SaveChanges();
			if (res != 0)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}

}
