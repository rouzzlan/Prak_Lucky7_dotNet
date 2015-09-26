using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky7
{
  public partial class Lucky7
  {
    private Random generateRandomNumber = new Random();
    private int gekozenGetal = 7;

    public Lucky7()
    {

    }

    public Lucky7(int gekozenGetal)
    {
      this.gekozenGetal = gekozenGetal;
    }

    public bool Try(out int getal1, out int getal2, out int getal3)
    {
      getal1 = generateRandomNumber.Next(1, 9);
      getal2 = generateRandomNumber.Next(1, 9);
      getal3 = generateRandomNumber.Next(1, 9);
      if (getal1 == gekozenGetal || getal2 == gekozenGetal || getal3 == gekozenGetal)
      {
        return true;
      }
      return false;
    }
  }
}
