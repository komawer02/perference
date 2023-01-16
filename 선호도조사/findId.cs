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
    public partial class findId : Form
    {
        public findId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool name_exist = false;
            bool success = false;
            var user_id = loginPage.collection.Find(new BsonDocument()).ToList();


            for (int i = 0; i < user_id.Count; i++)
            {
              
                if (user_id[i].name == name.Text)
                {
                    name_exist = true;
                        
                    if (user_id[i].num == num.Text)
                    {
                        success = true;
                        this.Close();
                        MessageBox.Show("id : " + user_id[i].user_id + "\n pass : " + user_id[i].user_pass, "아이디 찾기 완료!");
                        break;
                    }
                }
            }
            
            if (success)
            {

            }
            else
            {
                if (name_exist)
                {
                    MessageBox.Show("주민번호가 잘못 되었습니다.");
                }
                else
                {
                    MessageBox.Show("이름을 찾을 수 없습니다.");
                }
            }
        }
    }
}
