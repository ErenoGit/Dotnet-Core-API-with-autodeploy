using System.Text.Json.Serialization;

namespace TodoList_Web_API_MVC_test.Models
{
    public class TodoItem
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoItemInput
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
