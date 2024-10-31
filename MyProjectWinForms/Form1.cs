using Microsoft.VisualBasic.ApplicationServices;
using MyProjectWinForms.Data;
using MyProjectWinForms.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ApplicationContext = MyProjectWinForms.Data.ApplicationContext;

namespace MyProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя.");
            }

        }

        private void AddUser(string userName)
        {
            ApplicationContext DbContext() => new ApplicationContextFactory().CreateDbContext();

            new DbInit().Init(DbContext(), userName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя.");
            }
            AddUser(name);
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\n100 баллов - если сами написали запрос\n\n50 баллов - если воспользовались подсказкой\n\n" +
                "25 баллов - если воспользовались библиотекой\n\n10 баллов - если посмотрели наше решение\n\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ApplicationContext DbContext() => new ApplicationContextFactory().CreateDbContext();

            var users = new DbInit().LoadFromDatabase(DbContext());

            foreach (var user in users)
            {
                textBox1.Text = user.ToString();
            }
        }
    }
}
