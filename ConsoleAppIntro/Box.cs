using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIntro
{
    public class Box : Rect
    {
		private int h;

		public int Height
		{
			get { return h; }
			set { h = value; }
		}

		public Box() 
		{
			h = 0;
		}
		public Box(int l, int b, int h):base(l,b)
		{
			this.h = h;
		}
		public int vol()
		{
			return area() * h;
		}
	}
}
