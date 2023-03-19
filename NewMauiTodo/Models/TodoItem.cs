using System;
namespace NewMauiTodo.Models
{
	public class TodoItem
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Due { get; set; }
        public bool Done { get; set; }
    }
}

