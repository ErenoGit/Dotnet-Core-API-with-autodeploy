using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace TodoList_Web_API_MVC_test.Models
{
    public class TodoRepository : ITodoRepository
    {
        private static ConcurrentDictionary<uint, TodoItem> _todos =
              new ConcurrentDictionary<uint, TodoItem>();
        private static uint _latestId = 1; 

        public TodoRepository()
        {
            Add(new TodoItemInput { Name = "testówka", IsComplete = false });
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todos.Values;
        }

        public TodoItem Add(TodoItemInput item)
        {
            var newTodoItem = new TodoItem();
            newTodoItem.Id = _latestId;
            _latestId++;
            newTodoItem.Name = item.Name;
            newTodoItem.IsComplete = item.IsComplete;
            _todos[newTodoItem.Id] = newTodoItem;
            return newTodoItem;
        }
        
        public TodoItem Find(uint key)
        {
            TodoItem item;
            _todos.TryGetValue(key, out item);
            return item;
        }
    }
}