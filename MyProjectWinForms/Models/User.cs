using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectWinForms.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int NumberOfPoints { get; set; }//кол-во балов

        public override string ToString()
        {
            return String.Format("Name - {0}\nNumber of points - {1}\n", Name, NumberOfPoints);
        }

    }
}
