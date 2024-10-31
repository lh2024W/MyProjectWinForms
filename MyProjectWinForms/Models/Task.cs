using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectWinForms.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }


        public override string ToString()
        {
            return String.Format("Задание № - {0}\n{1}\n", Id, TaskName);
        }
    }
}
