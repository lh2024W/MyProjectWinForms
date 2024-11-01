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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            textBoxRatingUsers = new TextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            textBoxUserName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(153, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // textBoxRatingUsers
            // 
            textBoxRatingUsers.Location = new Point(490, 55);
            textBoxRatingUsers.Multiline = true;
            textBoxRatingUsers.Name = "textBoxRatingUsers";
            textBoxRatingUsers.ReadOnly = true;
            textBoxRatingUsers.Size = new Size(255, 278);
            textBoxRatingUsers.TabIndex = 2;
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
            linkLabel1.Click += linkLabel1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(93, 98);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 4;
            label2.Text = "Здравствуйте, введите Ваше имя";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(137, 202);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Введите Ваше имя";
            textBoxUserName.Size = new Size(125, 27);
            textBoxUserName.TabIndex = 5;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 440);
            Controls.Add(textBoxUserName);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(textBoxRatingUsers);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxRatingUsers;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox textBoxUserName;
    }
}
