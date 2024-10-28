namespace MyProjectWinForms
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(153, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "отправить";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 32);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 1;
            label1.Text = "Рейтинг участников";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 278);
            textBox1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(490, 355);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(236, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Информация о подсчете баллов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 98);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 4;
            label2.Text = "Здравствуйте, введите Ваше имя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 440);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox textBox2;
    }
}
