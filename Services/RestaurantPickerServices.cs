using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCEightToTen.Services
{
    public class RestaurantPickerServices
    {
        Random rng = new Random();
        public List<string> categoryList = new();
        int catergoryIndex = 0;
        string[][] arrayCategory = [
            ["Wingstop", "CocoDak", "Raising Cane's", "Bonchon", "Fire Wings", "Popeyes", "KFC", "Chick-fil-A", "Luu's Chicken Bowl", "Pollos Asados"],
            ["El Rancho Inn", "Westlane Restaurant & Bar", "Fat City Brew & BBQ", "Smoke & Meat BBQ", "Chili's", "Market Tavern", "La Kora", "Pho Island", "The Kitchen", "Sizzler"],
            ["Captain Crab", "Dripping Crab", "Blazin Cajun", "Mariscos El Tiburon", "Tasty Pot", "Red Lobster", "Jimmies Place", "Toyo Sushi", "Ichiban Teppanyaki & Sushi", "Ahipoki Bowl"],
        ];

        public RestaurantPickerServices()
        {
            categoryList.Add("chicken");
            categoryList.Add("beef");
            categoryList.Add("seafood");
        }

        public string RestaurantPicker(string userChoice)
        {
            if (categoryList.Contains(userChoice.ToLower()))
            {
                int randomNumber = rng.Next(10);
                switch (userChoice.ToLower())
                {
                    case "chicken":
                        catergoryIndex = 0;
                        return $"How about {arrayCategory[catergoryIndex][randomNumber]}?";
                    case "beef":
                        catergoryIndex = 1;
                        return $"How about {arrayCategory[catergoryIndex][randomNumber]}?";
                    default:
                        catergoryIndex = 2;
                        return $"How about {arrayCategory[catergoryIndex][randomNumber]}?";
                }
            }
            else 
            {
                return "Invalid choice. Please choose from chicken, beef, or seafood.";
            }
        }

    }
}