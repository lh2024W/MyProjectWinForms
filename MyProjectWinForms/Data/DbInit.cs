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
                f.Show();

            }
        }

        public List<User> LoadFromDatabase(ApplicationContext context)
        {
            var newList = context.Users.OrderByDescending(x => x.NumberOfPoints).ToList();
            context.SaveChanges();
            return newList;
        }

        public List<Exercise> LoadFromDatabaseExercise(ApplicationContext context)
        {
            var ex = context.Exercises.ToList();
            context.SaveChanges();
            return ex;
        }

        public Exercise ExerciseById(ApplicationContext context, List<Exercise> t, int id)
        {
            var exById = context.Exercises.FirstOrDefault(x => x.Id == id);
            return exById;
        }

        public List<Answer> LoadFromDatabaseAnswer(ApplicationContext context)
        {
            var ans = context.Answers.ToList();
            context.SaveChanges();
            return ans;
        }

        public Answer AnswerById(ApplicationContext context, int id)
        {
            var ansById = context.Answers.FirstOrDefault(x => x.Id == id);
            return ansById;
        }
    }
}
