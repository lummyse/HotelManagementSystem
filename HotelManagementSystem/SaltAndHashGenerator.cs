using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace WindowsFormsApplication1
{
    class SaltAndHashGenerator
    {
        public Byte[] generateSalt(int saltByteSize)
        {
            //generate random salt
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltByteSize];
            rng.GetBytes(salt);
            return salt;
        }
        public Byte[] generateHash(String password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2sha1 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] generatedHash = pbkdf2sha1.GetBytes(outputBytes);
            return generatedHash;
        }
    }
}
