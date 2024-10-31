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
            label1 = new Label();
            TaskTextBox = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonLibrary = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Задание";
            // 
            // TaskTextBox
            // 
            TaskTextBox.Location = new Point(37, 86);
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.Size = new Size(501, 105);
            TaskTextBox.TabIndex = 1;
            TaskTextBox.TextChanged += TaskTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 220);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 2;
            label2.Text = "Напишите запрос";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 269);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(501, 126);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(434, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "отправить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(294, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(16, 37);
            button3.Name = "button3";
            button3.Size = new Size(199, 29);
            button3.TabIndex = 6;
            button3.Text = "Посмотреть все таблицы";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonLibrary
            // 
            buttonLibrary.Location = new Point(16, 101);
            buttonLibrary.Name = "buttonLibrary";
            buttonLibrary.Size = new Size(199, 29);
            buttonLibrary.TabIndex = 7;
            buttonLibrary.Text = "Библиотека";
            buttonLibrary.UseVisualStyleBackColor = true;
            buttonLibrary.Click += buttonLibrary_Click;
            // 
            // button5
            // 
            button5.Location = new Point(16, 168);
            button5.Name = "button5";
            button5.Size = new Size(199, 29);
            button5.TabIndex = 8;
            button5.Text = "Подсказать";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(16, 233);
            button6.Name = "button6";
            button6.Size = new Size(199, 29);
            button6.TabIndex = 9;
            button6.Text = "Показать решение";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(TaskTextBox);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
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
        private Button button2;
        private Button button3;
        private Button buttonLibrary;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
    }
}