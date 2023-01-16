
namespace 선호도조사
{
    partial class createArticle
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
            this.label1 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.Label();
            this.writer = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(219, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "글 게시 페이지";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Font = new System.Drawing.Font("굴림", 11F);
            this.ss.Location = new System.Drawing.Point(111, 108);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(66, 19);
            this.ss.TabIndex = 2;
            this.ss.Text = "게시자";
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("굴림", 11F);
            this.aa.Location = new System.Drawing.Point(111, 140);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(47, 19);
            this.aa.TabIndex = 3;
            this.aa.Text = "주제";
            // 
            // writer
            // 
            this.writer.Location = new System.Drawing.Point(177, 108);
            this.writer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.writer.Name = "writer";
            this.writer.Size = new System.Drawing.Size(197, 25);
            this.writer.TabIndex = 4;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(177, 140);
            this.title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(197, 25);
            this.title.TabIndex = 5;
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(537, 295);
            this.post.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(89, 51);
            this.post.TabIndex = 6;
            this.post.Text = "글 등록";
            this.post.UseVisualStyleBackColor = true;
            this.post.Click += new System.EventHandler(this.post_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(177, 174);
            this.content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(274, 172);
            this.content.TabIndex = 7;
            this.content.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(111, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "내용";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.content);
            this.Controls.Add(this.post);
            this.Controls.Add(this.title);
            this.Controls.Add(this.writer);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.TextBox writer;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button post;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label label2;
    }
}