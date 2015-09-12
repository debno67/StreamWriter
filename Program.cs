using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //Create an instance of StreamWriter to write to a file
            StreamWriter writer = new StreamWriter("..\\..\\Answers.txt");
                    //the using statement will auto-close the file for us
            using (writer)
            {
                //write a line
                writer.WriteLine("Hello World");
            }
        }
    }
}
