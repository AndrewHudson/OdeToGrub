using OdeToGrub.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToGrub.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants; 

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name = "Francis", Location = "Paris", Cuisine=CusineType.Italian},
                new Restaurant{Id=2,Name = "Rajput", Location = "Paris", Cuisine=CusineType.Indian},
                new Restaurant{Id=3,Name = "Senyors", Location = "Paris", Cuisine=CusineType.Mexican},
                new Restaurant{Id=4,Name = "Petes", Location = "Paris", Cuisine=CusineType.Mexican},
		new Restaurant{Id=5,Name = "Tonys", Location = "Paris", Cuisine=CusineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
