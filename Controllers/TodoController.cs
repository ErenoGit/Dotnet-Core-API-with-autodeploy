using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList_Web_API_MVC_test.Models;

namespace TodoList_Web_API_MVC_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        public TodoController(ITodoRepository todoItems)
        {
            TodoItems = todoItems;
        }
        public ITodoRepository TodoItems { get; set; }

        [HttpGet("GetAll", Name = "GetAll")]
        public IEnumerable<TodoItem> GetAll()
        {
            Console.WriteLine("GetAll called");
            return TodoItems.GetAll();
        }

        [HttpGet("GetById/{id}", Name = "GetById")]
        public IActionResult GetById(uint id)
        {
            Console.WriteLine("GetById called");
            var item = TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost("Add", Name = "Add")]
        public IActionResult Create([FromBody] TodoItemInput item)
        {
            Console.WriteLine("Add called");
            if (item == null)
            {
                return BadRequest();
            }
            var addedItem = TodoItems.Add(item);

            //return CreatedAtRoute("GetById", new { id = addedItem.Key }, item);
            return GetById(addedItem.Id);
        }
    }
}