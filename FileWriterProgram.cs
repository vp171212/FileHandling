using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToXmlFile();
            WriteToHtmlFile();
            WriteToTxtFile();
        }

        private static void WriteToTxtFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:/Users/ved.prakash/Desktop/Demo2.txt"))
                {
                    writer.WriteLine("<data>I have 10 Choclates</data>");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }

        private static void WriteToHtmlFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:/Users/ved.prakash/Desktop/Demo1.html"))
                {
                    writer.WriteLine("<data>I have 10 Choclates</data>");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }

        private static void WriteToXmlFile()
        {
            try
            {
                using (StreamWriter writer=new StreamWriter("C:/Users/ved.prakash/Desktop/Demo.xml"))
                {
                    writer.WriteLine("<data>I have 10 Choclates</data>");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: "+e.Message);
            }
        }

    }
}
