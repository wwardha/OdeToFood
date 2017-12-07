using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
