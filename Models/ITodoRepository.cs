using System.Collections.Generic;

namespace TodoList_Web_API_MVC_test.Models
{
    public interface ITodoRepository
    {
        TodoItem Add(TodoItemInput item);
        IEnumerable<TodoItem> GetAll();
        TodoItem Find(uint key);
    }
}
