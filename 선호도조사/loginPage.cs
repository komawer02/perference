using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace 선호도조사
{

    

    public partial class loginPage : Form
    {
        
        
        public static MongoClient client = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase db = client.GetDatabase("admin");
        public static IMongoCollection<User> collection = db.GetCollection<User>("userdata");
        public static IMongoCollection<Article> article = db.GetCollection<Article>("article");
        
        
        
        //게시판 전역 변수
        static public int k = 0;
        static public string[,] research_list = new string[10, 4];
        
        //유저 data 전역 변수
        static public int i = 0;
        static public string[,] user_data = new string[50, 4];

        //form1 지역변수
        bool id_exist = false;
        string login_id = "none";
        string login_pass = "none";
        

        public loginPage()
        {
            InitializeComponent();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            login_id = id.Text;
            login_pass = pass.Text;
            id_exist = false;
            //login 유효성 검사
            var user_id = collection.Find(new BsonDocument()).ToList();
            
            
            for(int i = 0; i < user_id.Count; i++)
            {
                if (login_id == "admin" && login_pass == "admin")
                {
                    adminPage form6 = new adminPage();
                    this.Hide();
                    form6.ShowDialog();
                    this.Close();
                    break;
                }

                if (user_id[i].user_id == login_id)
                {
                    if(user_id[i].user_pass == login_pass)
                    {
                        
                        MessageBox.Show(user_id[i].name + "님 환영합니다 !", "로그인 성공");
                            
                        id_exist = true;
                        this.Hide();
                        articleList form5 = new articleList();
                        form5.ShowDialog();
                        this.Close();


                        break;
                    }
                    else
                    {
                        id_exist = true;
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "로그인 오류");
                        break;
                    }
                }
            }
            
            if (!id_exist)
            {
                MessageBox.Show("존재하지 않은 아이디입니다 !!", "로그인 오류");
                id_exist = false;
            }

            
            
            
        }

        //join form Show
        private void join_Click(object sender, EventArgs e)
        {
            joinPage joinform = new joinPage();
            joinform.Show();
            
        }

        private void find_id_Click(object sender, EventArgs e)
        {
            findId find_page = new findId();
            find_page.Show();
        }
    }
    public class User
    {
        public User(string name, string id, string pass, string num)
        {
            
            this.name = name;
            this.user_id = id;
            this.user_pass = pass;
            this.num = num;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("id")]
        public string user_id { get; set; }
        [BsonElement("pass")]
        public string user_pass { get; set; }
        [BsonElement("num")]
        public string num { get; set; }
    }
    public class Article
    {
        public Article(string title, string writer, string content, int total_up = 0, int total_down = 0)
        {

            this.title = title;
            this.writer = writer;
            this.content = content;
            this.total_down = total_down;
            this.total_up = total_up;
            
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
        [BsonElement("writer")]
        public string writer { get; set; }
        [BsonElement("content")]
        public string content { get; set; }
        [BsonElement("total_up")]
        public int total_up { get; set; }
        [BsonElement("total_down")]
        public int total_down { get; set; }

    }
}
