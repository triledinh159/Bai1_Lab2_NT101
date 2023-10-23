namespace Bai1
{
    partial class Ex1
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gcd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_a = new System.Windows.Forms.TextBox();
            this.num_x = new System.Windows.Forms.TextBox();
            this.num_p = new System.Windows.Forms.TextBox();
            this.mod_res = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ran_pri = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(180, 21);
            this.num1.Margin = new System.Windows.Forms.Padding(2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(405, 20);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gen num 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "gen num 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(180, 62);
            this.num2.Margin = new System.Windows.Forms.Padding(2);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(404, 20);
            this.num2.TabIndex = 3;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "GCD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gcd
            // 
            this.gcd.Location = new System.Drawing.Point(180, 106);
            this.gcd.Margin = new System.Windows.Forms.Padding(2);
            this.gcd.Name = "gcd";
            this.gcd.Size = new System.Drawing.Size(403, 20);
            this.gcd.TabIndex = 5;
            this.gcd.TextChanged += new System.EventHandler(this.gcd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "p";
            // 
            // num_a
            // 
            this.num_a.Location = new System.Drawing.Point(180, 164);
            this.num_a.Name = "num_a";
            this.num_a.Size = new System.Drawing.Size(403, 20);
            this.num_a.TabIndex = 9;
            // 
            // num_x
            // 
            this.num_x.Location = new System.Drawing.Point(180, 203);
            this.num_x.Name = "num_x";
            this.num_x.Size = new System.Drawing.Size(403, 20);
            this.num_x.TabIndex = 10;
            // 
            // num_p
            // 
            this.num_p.Location = new System.Drawing.Point(180, 235);
            this.num_p.Name = "num_p";
            this.num_p.Size = new System.Drawing.Size(403, 20);
            this.num_p.TabIndex = 11;
            // 
            // mod_res
            // 
            this.mod_res.Location = new System.Drawing.Point(180, 277);
            this.mod_res.Name = "mod_res";
            this.mod_res.Size = new System.Drawing.Size(403, 20);
            this.mod_res.TabIndex = 12;
            this.mod_res.TextChanged += new System.EventHandler(this.mod_res_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 21);
            this.button4.TabIndex = 13;
            this.button4.Text = "button_mod";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "ramdom prime";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ran_pri
            // 
            this.ran_pri.Location = new System.Drawing.Point(180, 334);
            this.ran_pri.Name = "ran_pri";
            this.ran_pri.Size = new System.Drawing.Size(402, 20);
            this.ran_pri.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 29);
            this.button6.TabIndex = 16;
            this.button6.Text = "Benchmark";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ran_pri);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.mod_res);
            this.Controls.Add(this.num_p);
            this.Controls.Add(this.num_x);
            this.Controls.Add(this.num_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ex1";
            this.Text = "Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox gcd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num_a;
        private System.Windows.Forms.TextBox num_x;
        private System.Windows.Forms.TextBox num_p;
        private System.Windows.Forms.TextBox mod_res;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox ran_pri;
        private System.Windows.Forms.Button button6;
    }
}

