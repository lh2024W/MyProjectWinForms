namespace MyProjectWinForms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Select = new Button();
            Distinct = new Button();
            Where = new Button();
            GroupBy = new Button();
            Max = new Button();
            Subqueries = new Button();
            OrderBy = new Button();
            Limit = new Button();
            Min = new Button();
            Like = new Button();
            Aliases = new Button();
            InnerJoin = new Button();
            Avg = new Button();
            Count = new Button();
            AndOr = new Button();
            Coalesce = new Button();
            Sum = new Button();
            SuspendLayout();
            // 
            // Select
            // 
            Select.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Select.Location = new Point(12, 25);
            Select.Name = "Select";
            Select.Size = new Size(272, 29);
            Select.TabIndex = 17;
            Select.Text = "SELECT Introduction";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // Distinct
            // 
            Distinct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Distinct.Location = new Point(12, 74);
            Distinct.Name = "Distinct";
            Distinct.Size = new Size(272, 29);
            Distinct.TabIndex = 18;
            Distinct.Text = "DISTINCT";
            Distinct.UseVisualStyleBackColor = true;
            Distinct.Click += Distinct_Click;
            // 
            // Where
            // 
            Where.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Where.Location = new Point(12, 123);
            Where.Name = "Where";
            Where.Size = new Size(272, 29);
            Where.TabIndex = 19;
            Where.Text = "WHERE";
            Where.UseVisualStyleBackColor = true;
            Where.Click += Where_Click;
            // 
            // GroupBy
            // 
            GroupBy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBy.Location = new Point(12, 173);
            GroupBy.Name = "GroupBy";
            GroupBy.Size = new Size(272, 29);
            GroupBy.TabIndex = 20;
            GroupBy.Text = "GROUP BY";
            GroupBy.UseVisualStyleBackColor = true;
            GroupBy.Click += GroupBy_Click;
            // 
            // Max
            // 
            Max.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Max.Location = new Point(12, 222);
            Max.Name = "Max";
            Max.Size = new Size(272, 29);
            Max.TabIndex = 21;
            Max.Text = "MAX";
            Max.UseVisualStyleBackColor = true;
            Max.Click += Max_Click;
            // 
            // Subqueries
            // 
            Subqueries.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Subqueries.Location = new Point(12, 267);
            Subqueries.Name = "Subqueries";
            Subqueries.Size = new Size(272, 29);
            Subqueries.TabIndex = 22;
            Subqueries.Text = "Subqueries";
            Subqueries.UseVisualStyleBackColor = true;
            Subqueries.Click += Subqueries_Click;
            // 
            // OrderBy
            // 
            OrderBy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderBy.Location = new Point(12, 321);
            OrderBy.Name = "OrderBy";
            OrderBy.Size = new Size(272, 29);
            OrderBy.TabIndex = 23;
            OrderBy.Text = "ORDER BY";
            OrderBy.UseVisualStyleBackColor = true;
            OrderBy.Click += OrderBy_Click;
            // 
            // Limit
            // 
            Limit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Limit.Location = new Point(12, 366);
            Limit.Name = "Limit";
            Limit.Size = new Size(272, 29);
            Limit.TabIndex = 24;
            Limit.Text = "LIMIT";
            Limit.UseVisualStyleBackColor = true;
            Limit.Click += Limit_Click;
            // 
            // Min
            // 
            Min.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Min.Location = new Point(12, 409);
            Min.Name = "Min";
            Min.Size = new Size(272, 29);
            Min.TabIndex = 25;
            Min.Text = "MIN";
            Min.UseVisualStyleBackColor = true;
            Min.Click += Min_Click;
            // 
            // Like
            // 
            Like.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Like.Location = new Point(328, 25);
            Like.Name = "Like";
            Like.Size = new Size(272, 29);
            Like.TabIndex = 26;
            Like.Text = "LIKE";
            Like.UseVisualStyleBackColor = true;
            Like.Click += Like_Click;
            // 
            // Aliases
            // 
            Aliases.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Aliases.Location = new Point(328, 74);
            Aliases.Name = "Aliases";
            Aliases.Size = new Size(272, 29);
            Aliases.TabIndex = 27;
            Aliases.Text = "Aliases";
            Aliases.UseVisualStyleBackColor = true;
            Aliases.Click += Aliases_Click;
            // 
            // InnerJoin
            // 
            InnerJoin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InnerJoin.Location = new Point(328, 123);
            InnerJoin.Name = "InnerJoin";
            InnerJoin.Size = new Size(272, 29);
            InnerJoin.TabIndex = 28;
            InnerJoin.Text = "INNER JOIN";
            InnerJoin.UseVisualStyleBackColor = true;
            InnerJoin.Click += InnerJoin_Click;
            // 
            // Avg
            // 
            Avg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Avg.Location = new Point(328, 173);
            Avg.Name = "Avg";
            Avg.Size = new Size(272, 29);
            Avg.TabIndex = 29;
            Avg.Text = "AVG";
            Avg.UseVisualStyleBackColor = true;
            Avg.Click += Avg_Click;
            // 
            // Count
            // 
            Count.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Count.Location = new Point(328, 222);
            Count.Name = "Count";
            Count.Size = new Size(272, 29);
            Count.TabIndex = 30;
            Count.Text = "COUNT";
            Count.UseVisualStyleBackColor = true;
            Count.Click += Count_Click;
            // 
            // AndOr
            // 
            AndOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AndOr.Location = new Point(328, 267);
            AndOr.Name = "AndOr";
            AndOr.Size = new Size(272, 29);
            AndOr.TabIndex = 31;
            AndOr.Text = "AND/OR";
            AndOr.UseVisualStyleBackColor = true;
            AndOr.Click += AndOr_Click;
            // 
            // Coalesce
            // 
            Coalesce.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Coalesce.Location = new Point(328, 321);
            Coalesce.Name = "Coalesce";
            Coalesce.Size = new Size(272, 29);
            Coalesce.TabIndex = 32;
            Coalesce.Text = "COALESCE";
            Coalesce.UseVisualStyleBackColor = true;
            Coalesce.Click += Coalesce_Click;
            // 
            // Sum
            // 
            Sum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Sum.Location = new Point(328, 366);
            Sum.Name = "Sum";
            Sum.Size = new Size(272, 29);
            Sum.TabIndex = 33;
            Sum.Text = "SUM";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 450);
            Controls.Add(Sum);
            Controls.Add(Coalesce);
            Controls.Add(AndOr);
            Controls.Add(Count);
            Controls.Add(Avg);
            Controls.Add(InnerJoin);
            Controls.Add(Aliases);
            Controls.Add(Like);
            Controls.Add(Min);
            Controls.Add(Limit);
            Controls.Add(OrderBy);
            Controls.Add(Subqueries);
            Controls.Add(Max);
            Controls.Add(GroupBy);
            Controls.Add(Where);
            Controls.Add(Distinct);
            Controls.Add(Select);
            Name = "Form3";
            Text = "Библиотека";
            ResumeLayout(false);
        }

        #endregion
        private Button Select;
        private Button Distinct;
        private Button Where;
        private Button GroupBy;
        private Button Max;
        private Button Subqueries;
        private Button OrderBy;
        private Button Limit;
        private Button Min;
        private Button Like;
        private Button Aliases;
        private Button InnerJoin;
        private Button Avg;
        private Button Count;
        private Button AndOr;
        private Button Coalesce;
        private Button Sum;
    }
}