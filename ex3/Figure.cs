using System;

namespace laba3_ex3
{
  public class Figure
    {
      public double LengthSide(double ab, double bc, double ca) {
        return (ab + bc + ca);
      }
      public double LengthSide(double ab, double bc, double cd, double da) {
        return (ab + bc + cd + da);
    }
      public double LengthSide(double ab, double bc, double cd, double df, double fa) {
        return (ab + bc + cd + df + fa);
    }
  }
}
