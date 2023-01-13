
namespace 선호도조사
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.join_comple = new System.Windows.Forms.Button();
            this.join_to_main = new System.Windows.Forms.Button();
            this.joinName = new System.Windows.Forms.TextBox();
            this.joinId = new System.Windows.Forms.TextBox();
            this.joinPass = new System.Windows.Forms.TextBox();
            this.joinCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_certi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // join_comple
            // 
            this.join_comple.Location = new System.Drawing.Point(309, 268);
            this.join_comple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join_comple.Name = "join_comple";
            this.join_comple.Size = new System.Drawing.Size(79, 39);
            this.join_comple.TabIndex = 0;
            this.join_comple.Text = "회원가입";
            this.join_comple.UseVisualStyleBackColor = true;
            this.join_comple.Click += new System.EventHandler(this.join_comple_Click);
            // 
            // join_to_main
            // 
            this.join_to_main.Location = new System.Drawing.Point(393, 268);
            this.join_to_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join_to_main.Name = "join_to_main";
            this.join_to_main.Size = new System.Drawing.Size(81, 39);
            this.join_to_main.TabIndex = 1;
            this.join_to_main.Text = "취소";
            this.join_to_main.UseVisualStyleBackColor = true;
            this.join_to_main.Click += new System.EventHandler(this.join_to_main_Click);
            // 
            // joinName
            // 
            this.joinName.Location = new System.Drawing.Point(309, 145);
            this.joinName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinName.Name = "joinName";
            this.joinName.Size = new System.Drawing.Size(166, 25);
            this.joinName.TabIndex = 2;
            // 
            // joinId
            // 
            this.joinId.Location = new System.Drawing.Point(309, 176);
            this.joinId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinId.Name = "joinId";
            this.joinId.Size = new System.Drawing.Size(166, 25);
            this.joinId.TabIndex = 3;
            this.joinId.TextChanged += new System.EventHandler(this.joinId_TextChanged);
            // 
            // joinPass
            // 
            this.joinPass.Location = new System.Drawing.Point(309, 206);
            this.joinPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinPass.Name = "joinPass";
            this.joinPass.PasswordChar = '*';
            this.joinPass.Size = new System.Drawing.Size(166, 25);
            this.joinPass.TabIndex = 4;
            // 
            // joinCode
            // 
            this.joinCode.Location = new System.Drawing.Point(309, 238);
            this.joinCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinCode.Name = "joinCode";
            this.joinCode.Size = new System.Drawing.Size(166, 25);
            this.joinCode.TabIndex = 5;
            this.joinCode.TextChanged += new System.EventHandler(this.joinCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(293, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "회원가입 페이지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(155, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(155, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(155, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "PASS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(155, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "주민번호 앞자리";
            // 
            // id_certi
            // 
            this.id_certi.Location = new System.Drawing.Point(480, 175);
            this.id_certi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_certi.Name = "id_certi";
            this.id_certi.Size = new System.Drawing.Size(75, 22);
            this.id_certi.TabIndex = 12;
            this.id_certi.Text = "중복확인";
            this.id_certi.UseVisualStyleBackColor = true;
            this.id_certi.Click += new System.EventHandler(this.id_certi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(482, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "6자리를 입력해주세요";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id_certi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joinCode);
            this.Controls.Add(this.joinPass);
            this.Controls.Add(this.joinId);
            this.Controls.Add(this.joinName);
            this.Controls.Add(this.join_to_main);
            this.Controls.Add(this.join_comple);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button join_comple;
        private System.Windows.Forms.Button join_to_main;
        private System.Windows.Forms.TextBox joinName;
        private System.Windows.Forms.TextBox joinId;
        private System.Windows.Forms.TextBox joinPass;
        private System.Windows.Forms.TextBox joinCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button id_certi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}