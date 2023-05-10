using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Paket.Core.Common;

namespace B.Repository
{
    public class HashSalt
    {
        public static string CreateSalt()
        {
            RNGCryptoServiceProvider Rand =new RNGCryptoServiceProvider();
            byte[] Buffer = new byte[15];
            Rand.GetBytes(Buffer);
            return Convert.ToBase64String(Buffer);
        }
        public static string CreateHash(string Password, string Salt)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] PasswordBytes = Encoding.Unicode.GetBytes(Password);
            byte[] SaltBytes = Convert.FromBase64String(Salt);
            byte[] PasswordAndSalt = new byte[SaltBytes.Length + PasswordBytes.Length];
            Array.Copy(PasswordBytes, 0, PasswordAndSalt, 0, PasswordBytes.Length);
            Array.Copy(SaltBytes,0, PasswordAndSalt, PasswordBytes.Length,SaltBytes.Length);
            return Convert.ToBase64String(sha1.ComputeHash(PasswordAndSalt));
        }
    }
}
