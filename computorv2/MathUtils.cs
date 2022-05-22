using System;
namespace computorv2
{
	public class MathUtils
	{
		public static double Abs(double n)
		{
			return n < 0 ? -n : n;
		}

		public static double Pow2(double n)
		{
			return n * n;
		}

	}
}
