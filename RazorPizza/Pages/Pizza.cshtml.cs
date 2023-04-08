using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
	public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=5},
            new PizzasModel(){ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Pineapple=true,
                FinalPrice=15},
            new PizzasModel(){ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                FinalPrice=12},
            new PizzasModel(){ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=5},
            new PizzasModel(){ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Peperoni=true,
                FinalPrice=5}

        };
        public void OnGet()
        {

        }
    }
}
