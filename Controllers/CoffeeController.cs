using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CoffeeHeaven.Models;
using CoffeeHeaven.Services;

namespace CoffeeHeaven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        public CoffeeController()
        {

        }

        //GET all available coffees
        [HttpGet]
        public ActionResult<List<Coffee>> GetAll() => CoffeeService.GetAll();

        //GET individual flavor of coffees 
        [HttpGet("{Id}")]
        public ActionResult<Coffee> Get(int Id)
        {
            var coffee = CoffeeService.Get(Id);

            if(coffee == null)
                return NotFound();
            
            return coffee;
        }

        //POST create new menu list of coffee
        [HttpPost]
        public IActionResult Create(Coffee coffee)
        {
            CoffeeService.Add(coffee);
            return CreatedAtAction(nameof(Create), new {Id = coffee.Id}, coffee);   
        }


        //PUT for updating the values of  menu list
        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Coffee coffee)
        {
            if(Id != coffee.Id)
                return BadRequest();

            var existingCoffee = CoffeeService.Get(Id);
                if (existingCoffee is null) 
                    return NotFound();

            CoffeeService.Update(coffee);

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var coffee = CoffeeService.Get(Id);

            if(coffee is null)
                return NotFound();

            CoffeeService.Delete(Id);

            return NoContent();
        }
    }   
    
}