using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt_decrypt
{
   public class RandomHex
    {
        public static string RandomHexString(Random rm)
        {

     
            string hexValue = "";
            int num;

            for (int i = 0; i < 2; i++)
            {
                num = rm.Next(0, int.MaxValue);
                hexValue += num.ToString("X8");
            }


            return hexValue;
        }
    }
}
