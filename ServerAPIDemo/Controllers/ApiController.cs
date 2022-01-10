using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAPIDemo.Controllers
{

	[Route("rectangle")]
	[ApiController]
	public class ApiController : ControllerBase
	{
		[HttpGet("name")]
		public Rectangle test()
		{
			Rectangle r1 = new Rectangle();
			r1.length = 10;
			r1.width = 20;
			return r1;
		}

		// Get back all rectangles
		//   /rectangle
		[HttpGet]
		public List<Rectangle> AllRectangles()
		{
			return Rectangle.GetAll();
		}

		// Return rectangles that match by specified width
		//    /rectangle/width/10
		[HttpGet("width/{w}")]
		public List<Rectangle> ByWidth(int w)
		{
			return Rectangle.SearchByWidth(w);
		}

		// Return rectangles that match by specified length
		//    /rectangle/length/10
		[HttpGet("length/{L}")]
		public List<Rectangle> ByLength(int L)
		{
			return Rectangle.SearchByLength(L);
		}

		// This one uses QUERY PARAMETERS
		//   /rectangle/search?length=10&width=10
		[HttpGet("search")]
		public List<Rectangle> Search(int length, int width)
		{
			return Rectangle.FullSearch(length, width);
		}

		// Create a new rectangle
		//   /rectangle
		[HttpPost]
		public bool NewRect(Rectangle rect)
		{
			return Rectangle.AddRectangle(rect);
		}

		// Delete a rectangle
		//    /rectangle
		[HttpDelete]
		public bool DelRect(Rectangle rect)
		{
			return Rectangle.DeleteRectangle(rect);
		}
	}
}
