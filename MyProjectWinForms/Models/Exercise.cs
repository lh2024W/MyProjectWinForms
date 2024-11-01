using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectWinForms.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string NameExercise { get; set; }


        public override string ToString()
        {
            return String.Format(NameExercise);
        }
    }
}
