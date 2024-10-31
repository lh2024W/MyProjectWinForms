using MyProjectWinForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProjectWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void TaskTextBox_TextChanged(object sender, EventArgs e)
        {
            Data.ApplicationContext DbContext() => new ApplicationContextFactory().CreateDbContext();
            var tasks = new DbInit().LoadFromDatabaseTask(DbContext());
            var task = new DbInit().TaskById(DbContext(), tasks, 1);
            TaskTextBox.Text = task.ToString();
            
        }

        
    }
}
