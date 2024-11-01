namespace MyProjectWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            TaskTextBox = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            buttonLibrary = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            buttonNext = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Задание";
            // 
            // TaskTextBox
            // 
            TaskTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TaskTextBox.Location = new Point(37, 49);
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.ReadOnly = true;
            TaskTextBox.Size = new Size(501, 105);
            TaskTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(37, 174);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 2;
            label2.Text = "Напишите запрос";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 208);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(501, 187);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(180, 409);
            button1.Name = "button1";
            button1.Size = new Size(132, 44);
            button1.TabIndex = 4;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(16, 37);
            button3.Name = "button3";
            button3.Size = new Size(199, 29);
            button3.TabIndex = 6;
            button3.Text = "Посмотреть все таблицы";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonLibrary
            // 
            buttonLibrary.BackColor = SystemColors.ControlLight;
            buttonLibrary.Location = new Point(16, 101);
            buttonLibrary.Name = "buttonLibrary";
            buttonLibrary.Size = new Size(199, 29);
            buttonLibrary.TabIndex = 7;
            buttonLibrary.Text = "Библиотека";
            buttonLibrary.UseVisualStyleBackColor = false;
            buttonLibrary.Click += buttonLibrary_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Location = new Point(16, 168);
            button5.Name = "button5";
            button5.Size = new Size(199, 29);
            button5.TabIndex = 8;
            button5.Text = "Подсказать";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Location = new Point(16, 233);
            button6.Name = "button6";
            button6.Size = new Size(199, 29);
            button6.TabIndex = 9;
            button6.Text = "Показать решение";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(buttonLibrary);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(557, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 323);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNext.Location = new Point(406, 409);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(132, 44);
            buttonNext.TabIndex = 11;
            buttonNext.Text = "Далее";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 465);
            Controls.Add(buttonNext);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(TaskTextBox);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Задание 1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TaskTextBox;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
        private Button buttonLibrary;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Button buttonNext;
    }
}