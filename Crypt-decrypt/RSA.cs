using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Crypt_decrypt
{
    public class RSA
    {
        public static string generateKeys()
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                return RSA.ToXmlString(true);

            }
        }

        static public byte[] encrypt_RSA(string plainText, RSAParameters RSAKey)
        {
            try
            {
                byte[] Data = ByteConvert.GetBytes(plainText);
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, true);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        static public string decrypt_RSA(byte[] Data, RSAParameters RSAKey)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, true);
                }
                UnicodeEncoding converter = new UnicodeEncoding();
                return converter.GetString(decryptedData);
            }
            catch (CryptographicException e)
            {
                throw new Exception(e.Message);
          
            }
        }



    }
}
