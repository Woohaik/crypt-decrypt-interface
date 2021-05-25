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

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);

                rsa.ImportParameters(RSAKey);
                byte[] text = Encoding.ASCII.GetBytes(plainText);
                byte[] result = rsa.Encrypt(text, false);
                return result;


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
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

                RSAParameters key = RSAKey;
                byte[] text = Data;
                byte[] resultado = RSAOperations.RSADecrypt(text, key, false);
             return Encoding.Default.GetString(resultado);
            }
            catch (CryptographicException e)
            {
                throw new Exception(e.Message);
          
            }
        }



    }
}
