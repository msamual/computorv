using System;
namespace computorv2
{
	public class Complex
	{
		public double Real { get; private set; }
		public double Imag { get; private set; }

		public Complex()
		{
		}

		public Complex(double real, double imag = 0)
		{
			this.Real = real;
			this.Imag = imag;
		}

		public Complex(Complex other)
		{
			this.Real = other.Real;
			this.Imag = other.Imag;
		}

		public static Complex operator +(Complex lhs, Complex rhs)
		{
			return new Complex(lhs.Real + rhs.Real, lhs.Imag + rhs.Imag);
		}
			
		public override string ToString()
		{
			string res = Real.ToString();
			if (this.Imag != 0)
			{
				res += this.Imag > 0 ? " + " : " - ";
				res += MathUtils.Abs(this.Imag).ToString() + "i"; 
			}
			return res;
		}
	}
}
