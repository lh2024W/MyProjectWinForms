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

namespace MyProjectWinForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ExerciseLoad();
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void ExerciseLoad()
        {
            Data.ApplicationContext DbContext() => new ApplicationContextFactory().CreateDbContext();
            var exercises = new DbInit().LoadFromDatabaseExercise(DbContext());
            var ex = new DbInit().ExerciseById(DbContext(), exercises, 2);
            TaskTextBox.Text = ex.NameExercise;

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SELECT Professor_Name \r\nFROM SALARIES;");
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Используйте SELECT Introduction!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string request = textBox2.Text;
            if (string.IsNullOrEmpty(request))
            {
                MessageBox.Show("Введите запрос!");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string request = textBox2.Text;
            if (string.IsNullOrEmpty(request))
            {
                MessageBox.Show("Введите запрос!");
            }
            SendRequest(request);
        }

        private void SendRequest(string request)
        {
            Data.ApplicationContext DbContext() => new ApplicationContextFactory().CreateDbContext();

            var answer = new DbInit().AnswerById(DbContext(), 2);
            if (request == answer.ToString())
            {

                MessageBox.Show("Поздравляю!\n\nВаш запрос написан верно!");
            }
            else
            {
                MessageBox.Show("Ваш запрос написан не верно! Попробуйте еще раз!");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();

            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
