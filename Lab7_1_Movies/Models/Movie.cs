using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7_1_Movies.Models
{
	public class Movie
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public List<string> Category { get; set; }

		private static List<Movie> Movies = Initialize();

		private static List<Movie> Initialize()
		{
			List<Movie> mlist = new List<Movie>();
			Movie m1 = new Movie() { Title = "category", Category = new List<string>() { "Sci Fi", "Western" }, Description = "Luke saves the universe" };
			mlist.Add(m1);
			m1 = new Movie() { Title = "Being John Malkovich", Category = new List<string>() { "Sci Fi", "Comedy" }, Description = "Malkovich gets possessed" };
			mlist.Add(m1);
			m1 = new Movie() { Title = "Adaptation", Category = new List<string>() { "Drama", "Comedy" }, Description = "The Orchid Thief" };
			mlist.Add(m1);
			m1 = new Movie() { Title = "Casablanca", Category = new List<string>() { "Drama" }, Description = "Boring black and white movie" };
			mlist.Add(m1);
			return mlist;
		}

		public static List<Movie> GetAll()
		{
			return Movies;
		}

		public static List<Movie> GetByCategory(string category)
		{
			List<Movie> result = new List<Movie>();
			foreach (Movie mov in Movies)
			{
				foreach (string cat in mov.Category)
				{
					if (cat == category)
					{
						result.Add(mov);
						break;
					}
				}
			}
			return result;
		}

		public static List<string> GetAllCategories()
		{
			List<string> categories = new List<string>();
			foreach (Movie mov in Movies)
			{
				foreach (string cat in mov.Category)
				{
					if (categories.IndexOf(cat) == -1)
					{
						categories.Add(cat);
					} 
				}
			}
			categories.Sort();
			return categories;
		}

		public static Movie GetMovieByTitle(string title)
		{
			foreach (Movie mov in Movies)
			{
				if (mov.Title == title)
				{
					return mov;
				}
			}
			return null;
		}

		public static List<Movie> QueryKeyword(string keyword)
		{
			List<Movie> result = new List<Movie>();
			foreach (Movie mov in Movies)
			{
				if (mov.Title.Contains(keyword))
				{
					result.Add(mov);
				}
			}
			return result;
		}

	}
}
