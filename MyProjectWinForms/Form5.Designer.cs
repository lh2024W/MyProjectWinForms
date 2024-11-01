namespace MyProjectWinForms
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            buttonNext = new Button();
            groupBox1 = new GroupBox();
            buttonAllTables = new Button();
            buttonAnswer = new Button();
            buttonLibrary = new Button();
            buttonHelp = new Button();
            buttonSend = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            TaskTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNext.Location = new Point(394, 399);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(132, 44);
            buttonNext.TabIndex = 25;
            buttonNext.Text = "Далее";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonAllTables);
            groupBox1.Controls.Add(buttonAnswer);
            groupBox1.Controls.Add(buttonLibrary);
            groupBox1.Controls.Add(buttonHelp);
            groupBox1.Location = new Point(545, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 323);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // buttonAllTables
            // 
            buttonAllTables.BackColor = SystemColors.ControlLight;
            buttonAllTables.Location = new Point(16, 37);
            buttonAllTables.Name = "buttonAllTables";
            buttonAllTables.Size = new Size(199, 29);
            buttonAllTables.TabIndex = 6;
            buttonAllTables.Text = "Посмотреть все таблицы";
            buttonAllTables.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer
            // 
            buttonAnswer.BackColor = SystemColors.ControlLight;
            buttonAnswer.Location = new Point(16, 233);
            buttonAnswer.Name = "buttonAnswer";
            buttonAnswer.Size = new Size(199, 29);
            buttonAnswer.TabIndex = 9;
            buttonAnswer.Text = "Показать решение";
            buttonAnswer.UseVisualStyleBackColor = false;
            buttonAnswer.Click += buttonAnswer_Click;
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
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ControlLight;
            buttonHelp.Location = new Point(16, 168);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(199, 29);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "Подсказать";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSend.Location = new Point(168, 399);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(132, 44);
            buttonSend.TabIndex = 23;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 198);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(501, 187);
            textBox2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(25, 164);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 21;
            label2.Text = "Напишите запрос";
            // 
            // TaskTextBox
            // 
            TaskTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TaskTextBox.Location = new Point(25, 39);
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.ReadOnly = true;
            TaskTextBox.Size = new Size(501, 105);
            TaskTextBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(25, 8);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 19;
            label1.Text = "Задание";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNext);
            Controls.Add(groupBox1);
            Controls.Add(buttonSend);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(TaskTextBox);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Задание 3";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private GroupBox groupBox1;
        private Button buttonAllTables;
        private Button buttonAnswer;
        private Button buttonLibrary;
        private Button buttonHelp;
        private Button buttonSend;
        private TextBox textBox2;
        private Label label2;
        private TextBox TaskTextBox;
        private Label label1;
    }
}