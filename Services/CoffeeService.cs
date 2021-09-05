using CoffeeHeaven.Models;
using System.Collections.Generic; 
using System.Linq;

namespace CoffeeHeaven.Services 
{
    public static class CoffeeService 
    {
        static List<Coffee> Coffees {get; }
        static int nextId = 6;
        static CoffeeService()
        {
            Coffees = new List<Coffee>
            {
                new Coffee {Id = 1, Name="Creamy White Angel", SugarLevel=100, IsCold=true, price=97.50},
                new Coffee {Id = 2, Name="Hot Brew Espresso", SugarLevel=25, IsCold=false, price=58.75},
                new Coffee {Id = 3, Name="Vanilla Almond Latte", SugarLevel=100, IsCold=true, price=120.05},
                new Coffee {Id = 4, Name="Roasted Ground Brew", SugarLevel=40, IsCold=false, price=72.25},
                new Coffee {Id = 5, Name="Salted Caramel Latte", SugarLevel=80, IsCold=true, price=105.10}
            };
        }

            public static List<Coffee> GetAll() => Coffees;

            public static Coffee Get(int Id) => Coffees.FirstOrDefault(p => p.Id == Id);
            public static void Add(Coffee coffee)
            {
                coffee.Id = nextId++;
                Coffees.Add(coffee);
            }

            public static void Delete(int Id)
            {
                var coffee = Get(Id);
                if(coffee is null)
                    return; 
                
                Coffees.Remove(coffee);
            }

            public static void Update(Coffee coffee)
            {
                var index = Coffees.FindIndex(p => p.Id == coffee.Id);
                if(index == -1)
                    return; 

                Coffees[index] = coffee; 

            }
        
    }
}