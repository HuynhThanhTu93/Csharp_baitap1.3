namespace Csharp_baitap1._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_a = new TextBox();
            txt_b = new TextBox();
            txt_c = new TextBox();
            txt_Max = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 33);
            label1.TabIndex = 0;
            label1.Text = "Tìm số lớn nhất trong 3 số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(134, 33);
            label2.TabIndex = 0;
            label2.Text = "Nhập số a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 0;
            label3.Text = "Nhập số b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(132, 33);
            label4.TabIndex = 0;
            label4.Text = "Nhập số c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 224);
            label5.Name = "label5";
            label5.Size = new Size(101, 33);
            label5.TabIndex = 0;
            label5.Text = "Số Max";
            // 
            // txt_a
            // 
            txt_a.Location = new Point(162, 77);
            txt_a.Name = "txt_a";
            txt_a.Size = new Size(100, 40);
            txt_a.TabIndex = 1;
            // 
            // txt_b
            // 
            txt_b.Location = new Point(162, 123);
            txt_b.Name = "txt_b";
            txt_b.Size = new Size(100, 40);
            txt_b.TabIndex = 1;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(162, 169);
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(100, 40);
            txt_c.TabIndex = 1;
            // 
            // txt_Max
            // 
            txt_Max.Location = new Point(119, 215);
            txt_Max.Name = "txt_Max";
            txt_Max.Size = new Size(214, 40);
            txt_Max.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(38, 299);
            button1.Name = "button1";
            button1.Size = new Size(209, 47);
            button1.TabIndex = 2;
            button1.Text = "Giải";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(38, 352);
            button2.Name = "button2";
            button2.Size = new Size(209, 47);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(253, 299);
            button3.Name = "button3";
            button3.Size = new Size(113, 47);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 423);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_Max);
            Controls.Add(txt_c);
            Controls.Add(txt_b);
            Controls.Add(txt_a);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_a;
        private TextBox txt_b;
        private TextBox txt_c;
        private TextBox txt_Max;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
