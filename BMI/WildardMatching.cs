using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
	class WildardMatching
	{
		public static bool isMatch(string s,string p,int n,int m)
		{
			if (m == 0)
				return (n==0);

			bool[,] T = new bool[n + 1, m + 1];
			for (int i=0;i<n+1;i++)
			{
				for(int j=0;j<m+1;j++)
				{
					T[i, j] = false;
				}
			}

			T[0, 0] = true;

			for(int j=1;j<=m;j++)
			{
				if(p[j-1]=='*')
				{
					T[0, j] = T[0,j-1];
				}
			}

			for(int i=1;i<=n;i++)
			{
				for(int j=1;j<=m;j++)
				{
					if(p[j-1]=='*')
					{
						T[i, j] = T[i, j - 1] || T[i - 1, j];
					}
					else if(p[j-1]=='?'||s[i-1]==p[j-1])
					{
						T[i, j] = T[i-1,j-1];
					}
					else
					{
						T[i,j]= false;
					}
				}
			}

			return T[n,m];
		}
		static void Main()
		{
			string s = "adceb";
			string p = "*a*b";
			bool result= isMatch(s,p,s.Length,p.Length);
			if(result==false)
			{
				Console.WriteLine("No");
			}
			else
			{
				Console.WriteLine("Yes");
			}
		}
	}
}
