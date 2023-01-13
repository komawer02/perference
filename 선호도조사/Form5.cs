using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class Form5 : Form
    {
        int pass = 1;
        int page = 0;
        int page_element = 5;
        
        public Form5()
        {
            InitializeComponent();
            
        }
        public Form5(int pass)
        {
            this.pass = 2;
            InitializeComponent();
        }
        

        private void Form5_Load(object sender, EventArgs e)
        {
            back.Visible = false;
            
            List<Label> label_writer = new List<Label>() { w1, w2, w3, w4, w5 };
            List<Label> label_title = new List<Label>() { t1, t2, t3, t4, t5 };
            List<Label> label_num = new List<Label>() { n1, n2, n3, n4, n5 };
            for (int i = 0; i < label_writer.Count; i++)
            {
                label_num[i].Text = "";
                label_writer[i].Text = "";
                label_title[i].Text = "";
            }
            var article_list = Form1.article.Find(new BsonDocument()).ToList();
            
            if (article_list.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    label_num[i].Text = (i + 1).ToString();
                    label_writer[i].Text = article_list[i].writer.ToString();
                    label_title[i].Text = article_list[i].title.ToString();
                }
            }
            else
            {
                foward.Visible = false;
                for (int i = 0; i < article_list.Count; i++)
                {
                    label_num[i].Text = (i + 1).ToString();
                    label_writer[i].Text = article_list[i].writer.ToString();
                    label_title[i].Text = article_list[i].title.ToString();
                }
            }
            
        }

        private void t1_Click(object sender, EventArgs e)
        {
            if(pass == 2)
            {
                Form7 form = new Form7(t1.Text, 1);
                form.Show();
            }
            else
            {
                Form7 form7 = new Form7(t1.Text);
                form7.Show();
            }
            
        }

        private void t2_Click(object sender, EventArgs e)
        {
            if (pass == 2)
            {
                Form7 form = new Form7(t2.Text, 1);
                form.Show();
            }
            else
            {
                Form7 form7 = new Form7(t2.Text);
                form7.Show();
            }
        }

        private void t3_Click(object sender, EventArgs e)
        {
            if (pass == 2)
            {
                Form7 form = new Form7(t3.Text, 1);
                form.Show();
            }
            else
            {
                Form7 form7 = new Form7(t3.Text);
                form7.Show();
            }
        }

        private void t4_Click(object sender, EventArgs e)
        {
            if (pass == 2)
            {
                Form7 form = new Form7(t4.Text, 1);
                form.Show();
            }
            else
            {
                Form7 form7 = new Form7(t4.Text);
                form7.Show();
            }
        }

        private void t5_Click(object sender, EventArgs e)
        {
            if (pass == 2)
            {
                Form7 form = new Form7(t5.Text, 1);
                form.Show();
            }
            else
            {
                Form7 form7 = new Form7(t5.Text);
                form7.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            page_element = page_element - 5;
            page--;
            if (page == 0)
            {
                back.Visible = false;
            }
            
            var article_list = Form1.article.Find(new BsonDocument()).ToList();
            List<Label> label_writer = new List<Label>() { w1, w2, w3, w4, w5 };
            List<Label> label_title = new List<Label>() { t1, t2, t3, t4, t5 };
            List<Label> label_num = new List<Label>() { n1, n2, n3, n4, n5 };
            for (int i = 0; i < 5; i++)
            {
                label_num[i].Text = "";
                label_writer[i].Text = "";
                label_title[i].Text = "";
            }
            if (article_list.Count > page_element)
            {
                foward.Visible = true;
                for (int j = 0, i = page_element - 5; j < 5 && i < page_element; j++, i++)
                {
                    label_num[j].Text = (i + 1).ToString();
                    label_writer[j].Text = article_list[i].writer.ToString();
                    label_title[j].Text = article_list[i].title.ToString();
                }
            }
            else
            {
                foward.Visible = false;
                for (int j = 0,i = page_element - 5; j < 5 && i < article_list.Count; j++, i++)
                {
                    label_num[j].Text = (i + 1).ToString();
                    label_writer[j].Text = article_list[i].writer.ToString();
                    label_title[j].Text = article_list[i].title.ToString();
                }
            }
        }

        private void foward_Click(object sender, EventArgs e)
        {
            page_element = page_element + 5;
            page++;
            List<Label> label_writer = new List<Label>() { w1, w2, w3, w4, w5 };
            List<Label> label_title = new List<Label>() { t1, t2, t3, t4, t5 };
            List<Label> label_num = new List<Label>() { n1, n2, n3, n4, n5 };
            for (int i = 0; i < 5; i++)
            {
                label_num[i].Text = "";
                label_writer[i].Text = "";
                label_title[i].Text = "";
            }
            if (page > 0)
            {
                back.Visible = true;
            }
            var article_list = Form1.article.Find(new BsonDocument()).ToList();

            if (article_list.Count > page_element)
            {
                foward.Visible = true;
                for (int j = 0, i = page_element - 5; j < 5 && i < page_element;j++, i++)
                {
                    label_num[j].Text = (i+1).ToString();
                    label_writer[j].Text = article_list[i].writer.ToString();
                    label_title[j].Text = article_list[i].title.ToString();
                }
            }
            else
            {
                foward.Visible = false;
                for (int j = 0,i = page_element - 5;j < 5 && i < article_list.Count; j++, i++)
                {
                    label_num[j].Text = (i + 1).ToString();
                    label_writer[j].Text = article_list[i].writer.ToString();
                    label_title[j].Text = article_list[i].title.ToString();
                }
            }



       
        }
    }
}
