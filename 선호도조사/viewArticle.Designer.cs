
namespace 선호도조사
{
    partial class viewArticle
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
            this.t = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.updated = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("굴림", 15F);
            this.t.Location = new System.Drawing.Point(98, 50);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(57, 20);
            this.t.TabIndex = 0;
            this.t.Text = "label1";
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("굴림", 15F);
            this.w.Location = new System.Drawing.Point(98, 91);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(57, 20);
            this.w.TabIndex = 1;
            this.w.Text = "label1";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("굴림", 15F);
            this.c.Location = new System.Drawing.Point(98, 155);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(57, 20);
            this.c.TabIndex = 2;
            this.c.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "게시자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "주제";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "내용 : ";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(596, 389);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(59, 49);
            this.delete.TabIndex = 6;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(267, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "선호";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(358, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "비 선호";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(531, 389);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 49);
            this.result.TabIndex = 9;
            this.result.Text = "결과";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // updated
            // 
            this.updated.Location = new System.Drawing.Point(466, 389);
            this.updated.Name = "updated";
            this.updated.Size = new System.Drawing.Size(59, 49);
            this.updated.TabIndex = 10;
            this.updated.Text = "수정";
            this.updated.UseVisualStyleBackColor = true;
            this.updated.Click += new System.EventHandler(this.updated_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updated);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.w);
            this.Controls.Add(this.t);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.Shown += new System.EventHandler(this.Form7_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button updated;
    }
}