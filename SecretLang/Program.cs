using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretLang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do? encode/decode");
            string choice = Console.ReadLine();
            Console.WriteLine("Please enter input...");
            string data = Console.ReadLine();
            DateTime dt = DateTime.Now;
            _secrettaal st = new _secrettaal();
            if (choice == "encode")
            {
                string endata = st.encode(data);
                Console.WriteLine(endata);
            }
            if(choice == "decode")
            {
                string dedata = st.decode(data);
                Console.WriteLine(dedata);
            }


            TimeSpan ts = DateTime.Now - dt;
            Console.WriteLine("runtime " + ts.TotalSeconds.ToString()+"s");
            gotoMain();
        }

        static void gotoMain()
        {
            Console.WriteLine("========================\ngotoMain");
            string[] fakeargs = { "null" };
            Main(fakeargs);
        }
    }
}
