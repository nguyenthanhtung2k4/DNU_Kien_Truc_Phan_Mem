using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoRepository
    {
        private readonly List<Todo> _todos;
        private readonly String _path = "todos.txt";
        private  int _nextId = 1;
        public TodoRepository()
        {
            LoadFromFile();

        }

        private void LoadFromFile()
        {
            if (!File.Exists(_path))
            {
                return;

            }
            foreach (var line in File.ReadAllLines(_path))
            {
                var item = Todo.FormtFileString(line);
                _todos.Add(item);
                if (item.Id >= _nextId)
                {
                    _nextId = item.Id + 1;

                }
            }
        }

        public void SaveToFile()
        {
            File.WriteAllLines(_path, _todos.Select(x => x.ToFileString()));

        }
        public List<Todo> GetAll => _todos;
        public Todo AddTodo (string title)
        {
            var item = new Todo()
            {
                Id = _nextId,
                Title = title,
                IsCompleted = false
            };
            
            _todos.Add (item);
            SaveToFile();
            return item;
        }

        public bool RemoveTodo(int id)
        {
            var item= _todos.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _todos.Remove(item);
                SaveToFile();
                return true;

            }
            return false;
        }
        public bool ToggleCompleted(int id)
        {
            var item= _todos.FirstOrDefault(x =>  x.Id == id);
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
                SaveToFile();
                return true;
            }
            return false ;
        }
        public bool UpdateTodo(int id, string title)
        {
            var item = _todos.FirstOrDefault(y => y.Id == id);
            if (item != null)
            {
                item.Title = title;
                SaveToFile();
                return true;
            }
            return false;
        }

        internal List<Todo> GetAll()
        {
            throw new NotImplementedException();
        }
    }
    
}
