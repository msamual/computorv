using System;
using System.Collections.Generic;

namespace computorv2
{
	public class Matrix
	{
		public List<List<double>> M { get; set; }
		public int sizeX { get; private set; }
		public int sizeY { get; private set; }
		
		public override this[int x, int y]
		{
			public get
			{
				this
			}
		}

		public Matrix()
		{
		}

		public Matrix(List<List<double>> m)
		{
			this.M = m;
			this.sizeY = m.Count;
			this.sizeX = this.sizeY != 0 ? m[0].Count : 0;
		}

		public Matrix(Matrix other)
		{
			this.M = other.M;
		}

		public static Matrix operator +(Matrix left, Matrix right)
		{
			if (left.sizeX != right.sizeX | left.sizeY != right.sizeY)
				throw new ApplicationException(
					$"matrices of different dimensions [{left.sizeY}:{left.sizeX}] " +
					$"and [{right.sizeY}:{right.sizeX}]. i dont know what addicting it");
			List<List<double>> res = new List<List<double>>();
			List<double> tmp;
			for (int i = 0; i < left.sizeY; ++i)
			{
				tmp = new List<double>();
				for (int j = 0; j < left.sizeX; ++j)
				{
					tmp.Add(left.M[i][j] + right.M[i][j]);
				}
				res.Add(tmp);
			}
			return new Matrix(res);
		}

		public static Matrix operator -(Matrix left, Matrix right)
		{
			if (left.sizeX != right.sizeX | left.sizeY != right.sizeY)
				throw new ApplicationException(
					$"matrices of different dimensions [{left.sizeY}:{left.sizeX}] " +
					$"and [{right.sizeY}:{right.sizeX}]. i dont know what subtract it");
			List<List<double>> res = new List<List<double>>();
			List<double> tmp;
			for (int i = 0; i < left.sizeY; ++i)
			{
				tmp = new List<double>();
				for (int j = 0; j < left.sizeX; ++j)
				{
					tmp.Add(left.M[i][j] - right.M[i][j]);
				}
				res.Add(tmp);
			}
			return new Matrix(res);
		}

		public static Matrix operator *(Matrix left, Matrix right)
		{
			if (left.sizeY != right.sizeX)
				throw new ApplicationException($"Incompatible matrixes [{left.sizeY}:{left.sizeX}] " +
					$"and [{right.sizeY}:{right.sizeX}] i dont know what multiply their");
			return new Matrix();
		}


		public override string ToString()
		{
			string res = "";
			
			foreach(var line in this.M)
			{
				res += "[ ";
				foreach (var n in line)
					res += n.ToString() + ", ";
				res = res.Trim(new char[] { ',',' '});
				res += " ]\n";
			}
			return res;
		}

	}
}
