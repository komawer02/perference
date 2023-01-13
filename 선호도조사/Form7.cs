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
    public partial class Form7 : Form
    {
        string title;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(string title)
        {
            this.title = title;
            InitializeComponent();
            delete.Visible = false;
            result.Visible = false;
            updated.Visible = false;
            
        }
        public Form7(string title, int pass)
        {
            this.title = title;
            InitializeComponent();
            delete.Visible = true;
            button1.Visible = false;
            button2.Visible = false;

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var article = Form1.article.Find(new BsonDocument()).ToList();
            for (int i = 0; i < article.Count; i++)
            {
                
                if (article[i].title.ToString() == title)
                {

                    w.Text = article[i].writer.ToString();
                    t.Text = article[i].title;
                    c.Text = article[i].content;
                }
                
                
            }

        }

        private void Form7_Shown(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = Builders<Article>.Filter.Eq("title",this.title);
            Form1.article.DeleteOne(filter);
            MessageBox.Show("삭제 완료 !");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int total_up = 0;
            var article = Form1.article.Find(new BsonDocument()).ToList();
            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].title.ToString() == title)
                {

                    total_up = article[i].total_up;
                }


            }
            var filter = Builders<Article>.Filter.Eq("title", title);
            var update = Builders<Article>.Update.Set("total_up", ++total_up);
            Form1.article.UpdateOne(filter, update);
            MessageBox.Show("투표 완료 !");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total_down = 0;
            var article = Form1.article.Find(new BsonDocument()).ToList();
            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].title.ToString() == title)
                {

                    total_down = article[i].total_down;
                }


            }
            var filter = Builders<Article>.Filter.Eq("title", title);
            var update = Builders<Article>.Update.Set("total_down", ++total_down);
            Form1.article.UpdateOne(filter, update);
            MessageBox.Show("투표 완료 !");
            this.Close();
        }

        private void result_Click(object sender, EventArgs e)
        {
            float result = 0;
            int sum = 0;
            var article = Form1.article.Find(new BsonDocument()).ToList();
            for(int i = 0; i < article.Count; i++)
            {
                if(article[i].title == title)
                {
                    sum = article[i].total_down + article[i].total_up;
                    if(sum != 0)
                    {
                        result = article[i].total_up * 100 / (article[i].total_up + article[i].total_down);
                    }
                    else
                    {
                        result = 0;
                    }
                    
                    
                }
            }
            MessageBox.Show("선호도 : " + result.ToString() + "%, 참여인원 : "+ sum.ToString());
        }

        private void updated_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8(title);
            form.Show();
            
            
        }
    }
}
