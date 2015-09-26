using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky7
{
  class Program
  {
    static void Main(string[] args)
    {
      bool doorgaan = true;
      bool gewonnen = false;
      string proceedY_N = "";
      Lucky7 lucky7 = new Lucky7();
      int getal1, getal2, getal3;

      while (doorgaan)
      {
        gewonnen = lucky7.Try(out getal1, out getal2, out getal3);
        Console.WriteLine("{0}\t{1}\t{2}", getal1, getal2, getal3);
        if (gewonnen)
        {
          Console.WriteLine("Gewonnen");
        }
        else
        {
          Console.WriteLine("Verloren");
        }
        Console.WriteLine("Another try <y/n>");
        proceedY_N = Console.ReadLine();
        if (proceedY_N.ToUpper().Equals("N"))
        {
          doorgaan = false;
        }
      }

    }
  }
}
