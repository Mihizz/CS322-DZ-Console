using System;
using System.Text;

namespace CS322_DZ_Console
{
    class Pomocna
    {
        public Pomocna()
        {
        }
        static String velikoSlovo(String str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
        public String randomRec()
        {
            int length = 8;

            StringBuilder str_build = new StringBuilder();
            Random r = new Random();

            char c;

            for (int i = 0; i < length; i++)
            {
                double br = r.NextDouble();
                int randomChar = Convert.ToInt32(Math.Floor(25 * br));
                c = Convert.ToChar(randomChar + 65);
                str_build.Append(c);
            }
            return velikoSlovo(str_build.ToString().ToLower());
        }

        public int randomBroj200()
        {
            Random r = new Random();
            // for (int i = 0; i < 50; i++)
            // {
            //    Console.WriteLine(r.Next(200) + 1);
            //  }
            int a = r.Next(200) + 1;
           // Console.WriteLine("AAA " + r.Next(200)+1);
            return a;
        }
    }
}
