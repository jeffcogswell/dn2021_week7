using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAPIDemo.Models
{
	public class Rectangle
	{
		public int length { get; set; }
		public int width { get; set; }

		private static List<Rectangle> Rectangles = init();

		private static List<Rectangle> init()
		{
			List<Rectangle> rects = new List<Rectangle>();
			rects.Add(new Rectangle() { length = 10, width = 20 });
			rects.Add(new Rectangle() { length = 10, width = 10 });
			rects.Add(new Rectangle() { length = 15, width = 10 });
			rects.Add(new Rectangle() { length = 8, width = 10 });
			return rects;
		}

		public static List<Rectangle> GetAll()
		{
			return Rectangles;
		}

		public static List<Rectangle> SearchByWidth(int w)
		{
			List<Rectangle> results = new List<Rectangle>();
			foreach (Rectangle rect in Rectangles)
			{
				if (rect.width == w)
				{
					results.Add(rect);
				}
			}
			return results;
		}

		public static List<Rectangle> SearchByLength(int L)
		{
			List<Rectangle> results = new List<Rectangle>();
			foreach (Rectangle rect in Rectangles)
			{
				if (rect.length == L)
				{
					results.Add(rect);
				}
			}
			return results;
		}

		public static List<Rectangle> FullSearch(int L, int W)
		{
			List<Rectangle> results = new List<Rectangle>();
			foreach (Rectangle rect in Rectangles)
			{
				if (rect.width == W && rect.length == L)
				{
					results.Add(rect);
				}
			}
			return results;
		}

		public static bool AddRectangle(Rectangle newrect)
		{
			Rectangles.Add(newrect);
			return true;
		}

		public static bool DeleteRectangle(Rectangle rect)
		{
			for (int i=0; i<Rectangles.Count; i++)
			{
				if (Rectangles[i].length == rect.length && 
					Rectangles[i].width == rect.width)
				{
					Rectangles.RemoveAt(i);
					return true;
				}
			}
			return false;
		}
	}
}
