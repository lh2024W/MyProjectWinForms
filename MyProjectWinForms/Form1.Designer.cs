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
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(153, 304);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 0;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(527, 29);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 1;
            label1.Text = "Рейтинг участников";
            // 
            // textBoxRatingUsers
            // 
            textBoxRatingUsers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxRatingUsers.Location = new Point(490, 55);
            textBoxRatingUsers.Multiline = true;
            textBoxRatingUsers.Name = "textBoxRatingUsers";
            textBoxRatingUsers.ReadOnly = true;
            textBoxRatingUsers.ScrollBars = ScrollBars.Vertical;
            textBoxRatingUsers.Size = new Size(255, 278);
            textBoxRatingUsers.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            linkLabel1.ForeColor = SystemColors.ActiveCaption;
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 255);
            linkLabel1.Location = new Point(456, 363);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(317, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Информация о подсчете баллов";
            linkLabel1.Click += linkLabel1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(30, 99);
            label2.Name = "label2";
            label2.Size = new Size(413, 31);
            label2.TabIndex = 4;
            label2.Text = "Здравствуйте, введите Ваше имя";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = SystemColors.InactiveBorder;
            textBoxUserName.Location = new Point(137, 202);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Введите Ваше имя";
            textBoxUserName.Size = new Size(185, 27);
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
