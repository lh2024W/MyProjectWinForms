using Microsoft.EntityFrameworkCore;
using MyProjectWinForms.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectWinForms.Data
{
    public class DbInit
    {
        public void Init(ApplicationContext context, string name)
        {
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //if (!context.Users.Any())
            //{
            //    context.Users.AddRange(new User[]
            //    {
            //        new User { Name = "Liliya", NumberOfPoints = 100},
            //        new User { Name = "Лилия", NumberOfPoints = 250},
            //        new User { Name = "Alex", NumberOfPoints = 1050},
            //        new User { Name = "Helen", NumberOfPoints = 1200},
            //        new User { Name = "Karen", NumberOfPoints = 50}
            //    });
            //    context.SaveChanges();
            //}
            User user = new User { Name = name, NumberOfPoints = 0 };
            if (context.Users.Any(u => u.Name == user.Name))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");

            }
            else
            {
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Ваше имя добавлено.");
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        public List<User> LoadFromDatabase(ApplicationContext context)
        {
            var newList = context.Users.OrderBy(x => x.NumberOfPoints).ToList();
            context.SaveChanges();
            return newList;
        }

        public List<Models.Task> LoadFromDatabaseTask(ApplicationContext context)
        {
            var task = context.Tasks.ToList();
            context.SaveChanges();
            return task;
        }

        public Models.Task TaskById(ApplicationContext context, List<Models.Task> t, int id)
        {
            var taskById = context.Tasks.FirstOrDefault(x => x.Id == id);
            return taskById;
        }
    }
}
