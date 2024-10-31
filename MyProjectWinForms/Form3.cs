using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectWinForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/sql/sql_ref_select.asp");
        }

        private void Distinct_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_select.asp");
        }

        private void Where_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_where.asp");
        }

        private void GroupBy_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_groupby.asp");
        }

        private void Max_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_min_max.asp");
        }

        private void Subqueries_Click(object sender, EventArgs e)
        {
            OpenLink("https://mode.com/sql-tutorial/sql-sub-queries");
        }

        private void OrderBy_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_orderby.asp");
        }

        private void Limit_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_limit.asp");
        }

        private void Min_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_min_max.asp");
        }

        private void Like_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_like.asp");
        }

        private void Aliases_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_alias.asp");
        }

        private void InnerJoin_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_join_inner.asp");
        }

        private void Avg_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/mysql/mysql_count_avg_sum.asp");
        }

        private void Count_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/sql/sql_count.asp");
        }

        private void AndOr_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/sql/sql_and.asp");
        }

        private void Coalesce_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/sql/func_sqlserver_coalesce.asp#gsc.tab=0&gsc.q=Coalesce");
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.w3schools.com/sql/func_sqlserver_coalesce.asp#gsc.tab=0&gsc.q=Coalesce");
        }
    }
}
