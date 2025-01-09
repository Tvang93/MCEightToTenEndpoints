using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCEightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCEightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
    
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestuarantPicker/{chickenBeefOrSeaFood}")]
        public string RestaurantPicker(string chickenBeefOrSeaFood)
        {
            return _restaurantPickerServices.RestaurantPicker(chickenBeefOrSeaFood);
        }
    }
}