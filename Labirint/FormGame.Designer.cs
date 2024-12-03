namespace Labirint
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewLabirint = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLabirint
            // 
            this.dataGridViewLabirint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabirint.ColumnHeadersVisible = false;
            this.dataGridViewLabirint.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLabirint.Name = "dataGridViewLabirint";
            this.dataGridViewLabirint.RowHeadersVisible = false;
            this.dataGridViewLabirint.RowTemplate.Height = 21;
            this.dataGridViewLabirint.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLabirint.Size = new System.Drawing.Size(240, 231);
            this.dataGridViewLabirint.TabIndex = 0;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 231);
            this.Controls.Add(this.dataGridViewLabirint);
            this.Name = "FormGame";
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLabirint;
    }
}

