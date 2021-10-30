using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class CoupanNumber
    {
        public void coupanNumber()
        {
			String ch = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] stringChars = new char[6];
			Random random = new Random();

			for (int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = ch[random.Next(ch.Length)];
			}

			String couponCode = stringChars.ToString();
			Console.WriteLine("Coupon Code: " + couponCode);
		}
	}
}
