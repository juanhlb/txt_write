using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace write_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt_input = "";
            txt_input= Console.ReadLine();

            StreamWriter ofile;
            ofile = new StreamWriter("prueba.txt");

            ofile.WriteLine(txt_input);
            ofile.Close();

            Console.WriteLine("file written");
          
        }
    }
}
