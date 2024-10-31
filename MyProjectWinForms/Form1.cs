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
                MessageBox.Show("������� ���.");
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
                MessageBox.Show("������� ���.");
            }
            AddUser(name);
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\n100 ������ - ���� ���� �������� ������\n\n50 ������ - ���� ��������������� ����������\n\n" +
                "25 ������ - ���� ��������������� �����������\n\n10 ������ - ���� ���������� ���� �������\n\n");
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
