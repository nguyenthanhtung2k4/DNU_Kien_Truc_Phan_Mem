using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TodoApp
{
    public class TodoUI
    {
        private readonly TodoService _service = new();


        public void ShowTodos()
        {
            var todos = _service.GetTodos();
            Console.WriteLine("==== DANH SACH CONG VIEC ====");
            foreach (var item in todos)
            {
                Console.WriteLine(item.ToString());
            }
            if (TodoService.Count == 0)
            {
                Console.WriteLine("Chua co cong viec");
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("Chuc nang");
            Console.WriteLine("1. Them moi cong viec");
            Console.WriteLine("2. Danh dau cong viec");
            Console.WriteLine("3. Xoa cong viec");
            Console.WriteLine("4. Cap nhat cong viec");
            Console.WriteLine("0. Thoat");
        }
        public void AddTodo()
        {
            Console.Write("Nhap noi dung cong viec: ");
            string input = Console.ReadLine();
            _service.AddTodo(input);
        }

        public void DeleteTodo()
        {
            Console.Write("Nhap id cong viec muon xoa: ");
            int id = int.Parse(Console.ReadLine());
            _service.RemoveTodo(id);
        }
        public void ToggleTodo()
        {
            Console.Write("Nhap id cong viec muon danh dau: ");
            int id = int.Parse(Console.ReadLine());
            _service.ToggleTodo(id);
        }

        public void EditTodo()
        {
            Console.WriteLine("Nhap id cong viec: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap noi dung moi: ");
            string input = Console.ReadLine();
            _service.UpdateTodo(id, input);
        }
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                ShowTodos();
                ShowMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddTodo(); break;
                    default:
                        Console.WriteLine("Lua chon khong hop le !");
                        break;
                }
                Console.WriteLine("Nhan enter de tiep tuc...");
                Console.WriteLine();
            }
        }
}