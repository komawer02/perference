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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
        }

        private void post_Click(object sender, EventArgs e)
        {


            Article article = new Article(title.Text, writer.Text, content.Text);
            Form1.article.InsertOne(article);
            MessageBox.Show("글 등록 완료 !");
            this.Close();

        }
    }
}
