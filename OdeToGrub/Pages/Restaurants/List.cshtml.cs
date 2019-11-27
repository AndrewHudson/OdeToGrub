using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToGrub.Core;
using OdeToGrub.Data;

namespace OdeToGrub.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        
        private readonly IConfiguration Config;
        private readonly IRestaurantData RestaurantData;

        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            Config = config;
            RestaurantData = restaurantData;
        }

        public void OnGet()
        {
            Restaurants = RestaurantData.GetAll();
        }
    }
}