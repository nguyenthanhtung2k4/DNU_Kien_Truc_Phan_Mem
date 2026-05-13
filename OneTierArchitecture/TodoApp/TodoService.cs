using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoService
    {
        private readonly TodoRepository _repository = new();

        public static int Cout { get; internal set; }
        public static int Count { get; internal set; }

        public List<Todo> GetTodos() => _repository.GetAll();
        public void RemoveTodo(int id) => _repository.RemoveTodo(id);
        public void ToggleTodo(int id) => _repository.ToggleCompleted(id);
        public bool UpdateTodo(int id, string title) => _repository.UpdateTodo(id, title);

        internal void AddTodo(string? input)
        {
            throw new NotImplementedException();
        }
    }
}
