namespace Tasks_CSharp
{
    partial class MainForm
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
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_1
            // 
            this.Button_1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_1.Location = new System.Drawing.Point(27, 38);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(120, 58);
            this.Button_1.TabIndex = 0;
            this.Button_1.Text = "Task_1.1";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // Button_2
            // 
            this.Button_2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_2.Location = new System.Drawing.Point(153, 38);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(120, 58);
            this.Button_2.TabIndex = 1;
            this.Button_2.Text = "Task_2";
            this.Button_2.UseVisualStyleBackColor = true;
            this.Button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 442);
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.Button_1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Button_2;
    }
}

