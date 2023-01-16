
namespace 선호도조사
{
    partial class loginPage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.join = new System.Windows.Forms.Button();
            this.find_id = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(248, 170);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(178, 25);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(248, 201);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(178, 25);
            this.pass.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("굴림", 15F);
            this.title.Location = new System.Drawing.Point(255, 118);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(253, 25);
            this.title.TabIndex = 2;
            this.title.Text = "선호도 조사 프로그램";
            // 
            // join
            // 
            this.join.Location = new System.Drawing.Point(248, 232);
            this.join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(75, 22);
            this.join.TabIndex = 3;
            this.join.Text = "회원가입";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // find_id
            // 
            this.find_id.Location = new System.Drawing.Point(329, 232);
            this.find_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find_id.Name = "find_id";
            this.find_id.Size = new System.Drawing.Size(155, 22);
            this.find_id.TabIndex = 4;
            this.find_id.Text = "ID/PASS 찾기";
            this.find_id.UseVisualStyleBackColor = true;
            this.find_id.Click += new System.EventHandler(this.find_id_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(432, 170);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(90, 56);
            this.login.TabIndex = 5;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.find_id);
            this.Controls.Add(this.join);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button find_id;
        private System.Windows.Forms.Button login;
    }
}

