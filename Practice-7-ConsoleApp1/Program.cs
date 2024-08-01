using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository();
            rep.Menu();
            Console.ReadKey();

        }
    }
}
