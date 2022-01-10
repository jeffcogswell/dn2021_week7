using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModelChange.Models
{

	// Main Model

	public class Animal
	{
		public string Name { get; set; }
		public float Weight { get; set; }
		public string SpeciesName { get; set; }
	}


	// The classes below are for the results from the API call
	// The API call will return a single instance of class Zoo,
	// which in turn has instances of ResultsItem and ResultsSpecies
	// in it.

	class ZooResults
	{
		public List<ResultsItem> results { get; set; }
	}

	class ResultsItem
	{
		public string name { get; set; }
		public float weight { get; set; }
		public ResultsSpecies species { get; set; }
	}

	class ResultsSpecies
	{
		public string name { get; set; }
	}

	public class ZooAPI
	{
		private static HttpClient _realClient = null;
		public static HttpClient MyHttp
		{
			get
			{
				if (_realClient == null)
				{
					_realClient = new HttpClient();
					_realClient.BaseAddress = new Uri("http://gc-zoo.surge.sh/");

				}
				return _realClient;
			}
		}

		public static async Task<List<Animal>> GetAnimals()
		{
			var connection = await MyHttp.GetAsync("/api/animals.json");
			ZooResults zoores =
				await connection.Content.ReadAsAsync<ZooResults>();
			List<Animal> animals = new List<Animal>();
			foreach (ResultsItem item in zoores.results)
			{
				Animal ani = new Animal();
				ani.Name = item.name;
				ani.Weight = item.weight;
				ani.SpeciesName = item.species.name;
				animals.Add(ani);
			}
			return animals;
		}
	}
}
