using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadXmlFile();
            Console.WriteLine("------------------------------------------------");
            ReadTxtFile();
            Console.WriteLine("------------------------------------------------");
            ReadHtmlFile();
            Console.WriteLine("------------------------------------------------");
        }

        private static void ReadHtmlFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader("C:/Users/ved.prakash/Desktop/Demo1.html"))
                {
                    string message;
                    while ((message = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

        private static void ReadTxtFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader("C:/Users/ved.prakash/Desktop/Demo2.txt"))
                {
                    string message;
                    while ((message = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

        private static void ReadXmlFile()
        {
            try
            {
                using (StreamReader reader=new StreamReader("C:/Users/ved.prakash/Desktop/Demo.xml"))
                {
                    string message;
                    while ((message = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }
    }
}
