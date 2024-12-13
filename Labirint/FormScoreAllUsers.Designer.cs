namespace Labirint
{
    partial class FormScoreAllUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewScoresAllUsers = new System.Windows.Forms.ListView();
            this.columnHeaderLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лучшие результаты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listViewScoresAllUsers
            // 
            this.listViewScoresAllUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLevel,
            this.columnHeaderUserName,
            this.columnHeaderScore});
            this.listViewScoresAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewScoresAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewScoresAllUsers.HideSelection = false;
            this.listViewScoresAllUsers.Location = new System.Drawing.Point(0, 64);
            this.listViewScoresAllUsers.Name = "listViewScoresAllUsers";
            this.listViewScoresAllUsers.Size = new System.Drawing.Size(608, 506);
            this.listViewScoresAllUsers.TabIndex = 1;
            this.listViewScoresAllUsers.UseCompatibleStateImageBehavior = false;
            this.listViewScoresAllUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLevel
            // 
            this.columnHeaderLevel.Text = "Уровень";
            this.columnHeaderLevel.Width = 150;
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "Имя пользователя";
            this.columnHeaderUserName.Width = 300;
            // 
            // columnHeaderScore
            // 
            this.columnHeaderScore.Text = "Количество шагов";
            // 
            // FormScoreAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 570);
            this.Controls.Add(this.listViewScoresAllUsers);
            this.Controls.Add(this.label1);
            this.Name = "FormScoreAllUsers";
            this.Text = "Таблица результатов";
            this.Load += new System.EventHandler(this.FormScoreAllUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewScoresAllUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderLevel;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderScore;
    }
}