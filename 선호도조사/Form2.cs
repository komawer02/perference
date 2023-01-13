
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
    public partial class Form2 : Form
    {
        bool id_exist = true;
        bool joinable = false;
        string join_id = "none";
        string join_pass = "none";
        string join_name = "none";
        string join_code = "none";
        public Form2()
        {
            
            InitializeComponent();
            
        }

        private void join_comple_Click(object sender, EventArgs e)
        {
            join_id = joinId.Text;
            join_pass = joinPass.Text;
            join_name = joinName.Text;
            join_code = joinCode.Text;
            string join_path = @"C:\Users\홍동우123\선호도조사\userdata.txt";
            string join_data = "\r\n" + join_name + "/" + join_id + "/" + join_pass + "/" + join_code;
            
            
            if(joinId.Text == "" || joinPass.Text == "" || joinName.Text == "" || joinCode.Text == "")
            {
                MessageBox.Show("공백인 칸이 있습니다 !");
            }
            else
            {
                if (joinable)
                {
                    if (join_code.Length == 6)
                    {

                        

                        User user = new User(join_name, join_id, join_pass, join_code);
                        Form1.collection.InsertOne(user);
                        System.IO.File.AppendAllText(join_path, join_data, Encoding.Default);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("주민번호는 6 자리 입니다.", "회원가입 실패");
                    }
                }
                else
                {
                    MessageBox.Show("중복확인을 해주세요 !");
                }
            }
            
            
            


        }

        private void join_to_main_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void id_certi_Click(object sender, EventArgs e)
        {
              //READ
            
            joinable = false;
            id_exist = true;
            
            
            var user_id = Form1.collection.Find(new BsonDocument()).ToList();
            if(user_id.Count == 0)
            {
                id_exist = false;
                joinable = true;
            }
            if (joinId.Text == "")
            {
                MessageBox.Show("공백입니다 !!");
            }
            else
            {
                
                for (int i = 0; i < user_id.Count; i++)
                {
                        
                    if (user_id[i].user_id == joinId.Text)
                    {
                        id_exist = true;
                        MessageBox.Show("중복된 아이디입니다.", "중복확인오류");
                        break;

                    }
                    id_exist = false;
                }

                
                if (!id_exist)
                {
                    label7.Text = "중복확인 완료";
                    label7.ForeColor = Color.Green;
                    MessageBox.Show("중복확인 완료 !");
                    joinable = true;
                }
            }
        }

        private void joinId_TextChanged(object sender, EventArgs e)
        {
            joinable = false;
            label7.Text = "중복확인 필요";
            label7.ForeColor = Color.Red;

        }

        private void joinCode_TextChanged(object sender, EventArgs e)
        {
            if(joinCode.Text.Length != 6)
            {
                label8.ForeColor = Color.Red;
                label8.Text = "6자리를 입력해주세요";

            }
            else
            {
                label8.Text = "";
            }
        }
    }
    
}
