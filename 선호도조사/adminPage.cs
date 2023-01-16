using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 선호도조사
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            articleList form5 = new articleList(3);
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createArticle form3 = new createArticle();
            form3.Show();
        }
    }
}
