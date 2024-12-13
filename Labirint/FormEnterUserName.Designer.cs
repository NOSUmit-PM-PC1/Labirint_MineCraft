namespace Labirint
{
    partial class FormEnterUserName
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSaveUserName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.Location = new System.Drawing.Point(52, 35);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(257, 38);
            this.textBoxUserName.TabIndex = 0;
            // 
            // buttonSaveUserName
            // 
            this.buttonSaveUserName.Location = new System.Drawing.Point(52, 103);
            this.buttonSaveUserName.Name = "buttonSaveUserName";
            this.buttonSaveUserName.Size = new System.Drawing.Size(257, 39);
            this.buttonSaveUserName.TabIndex = 1;
            this.buttonSaveUserName.Text = "Готово";
            this.buttonSaveUserName.UseVisualStyleBackColor = true;
            this.buttonSaveUserName.Click += new System.EventHandler(this.buttonSaveUserName_Click);
            // 
            // FormEnterUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 190);
            this.Controls.Add(this.buttonSaveUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormEnterUserName";
            this.Text = "введите имя пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonSaveUserName;
    }
}