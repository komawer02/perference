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
    public partial class Form8 : Form
    {
        string title;
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(string title)
        {
            InitializeComponent();
            this.title = title;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            var article = Form1.article.Find(new BsonDocument()).ToList();
            for (int i = 0; i < article.Count; i++)
            {
                if (article[i].title == title)
                {
                    w.Text = article[i].writer;
                    t.Text = article[i].title;
                    c.Text = article[i].content;


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = Builders<Article>.Filter.Eq("title", title);
            var update = Builders<Article>.Update.Set("title", t.Text);
            Form1.article.UpdateOne(filter, update);

            filter = Builders<Article>.Filter.Eq("title", t.Text);
            update = Builders<Article>.Update.Set("writer", w.Text);
            Form1.article.UpdateOne(filter, update);

            
            update = Builders<Article>.Update.Set("content", c.Text);
            Form1.article.UpdateOne(filter, update);
            MessageBox.Show("수정 완료 !");
            this.Close();
            

        }
    }
}
