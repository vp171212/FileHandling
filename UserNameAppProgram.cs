using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserNameToFile();
        }

        private static void GetUserNameToFile()
        {
            try
            {
                Console.WriteLine("Enter your username: ");
                string username = Console.ReadLine();
                using (StreamWriter writer=new StreamWriter("Usernames.txt",true))
                {
                    writer.WriteLine(username);
                }
                Console.WriteLine("Username saved to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }
    }
}
