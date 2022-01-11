using Lab7_1_Movies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7_1_Movies.Controllers
{
	[Route("movie")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		// Get All Movies
		//    GET /movie/
		[HttpGet]
		public List<Movie> GetAll()
		{
			return Movie.GetAll();
		}

		// Get All within Category
		//    GET /movie/category/categoryname
		//    e.g. /movie/category/sci%20fi
		[HttpGet("category/{category}")]
		public List<Movie> GetByCategory(string category)
		{
			return Movie.GetByCategory(category);
		}

		// Get all categories
		//    GET /movie/category
		[HttpGet("category")]
		public List<string> GetAllCategories()
		{
			return Movie.GetAllCategories();
		}

		// Get by title
		//    GET /movie/title
		//    e.g. /movie/star%20wars
		[HttpGet("{title}")]
		public Movie GetMovieByTitle(string title)
		{
			return Movie.GetMovieByTitle(title);
		}

		// Query keyword
		//    GET /movie/search?query=string
		//    e.g.  /movie/search?query=Star
		[HttpGet("search")]
		public List<Movie> QueryKeyword(string query)
		{
			return Movie.QueryKeyword(query);
		}
	}
}
