using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
     public class Todo
    { //  Nhan  prop tab  =>  cac thuoc tinh  ben trong 

        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"[{(IsCompleted ? "x" : " " )}] { Id} : {  Title} " ;
        }

        public string ToFileString()
        {
            return $"{Id} : {Title}: {IsCompleted}";

        }

        public static Todo FormtFileString(String line)
        {
            var parts = line.Split(":");
            return new Todo
            {
                Id = int.Parse(parts[0]),
                Title = parts[1],
                IsCompleted = bool.Parse(parts[2])
            };
        }
    }
}
