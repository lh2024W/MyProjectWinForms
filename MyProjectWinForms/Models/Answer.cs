using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectWinForms.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string NameAnswer { get; set; }


        public override string ToString()
        {
            return String.Format(NameAnswer);
        }
    }
}
