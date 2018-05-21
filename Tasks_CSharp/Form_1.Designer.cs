namespace Tasks_CSharp
{
    partial class Form_1
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
            this.ButtonStart1 = new System.Windows.Forms.Button();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.EditText = new System.Windows.Forms.TextBox();
            this.SourceTextLabel = new System.Windows.Forms.Label();
            this.EditTextLabel = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart1
            // 
            this.ButtonStart1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart1.Location = new System.Drawing.Point(228, 404);
            this.ButtonStart1.Name = "ButtonStart1";
            this.ButtonStart1.Size = new System.Drawing.Size(89, 44);
            this.ButtonStart1.TabIndex = 0;
            this.ButtonStart1.Text = "Start";
            this.ButtonStart1.UseVisualStyleBackColor = true;
            this.ButtonStart1.Click += new System.EventHandler(this.ButtonStart1_Click);
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(12, 65);
            this.SourceText.Multiline = true;
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(237, 333);
            this.SourceText.TabIndex = 1;
            // 
            // EditText
            // 
            this.EditText.Location = new System.Drawing.Point(295, 65);
            this.EditText.Multiline = true;
            this.EditText.Name = "EditText";
            this.EditText.Size = new System.Drawing.Size(237, 333);
            this.EditText.TabIndex = 2;
            // 
            // SourceTextLabel
            // 
            this.SourceTextLabel.AutoSize = true;
            this.SourceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceTextLabel.Location = new System.Drawing.Point(40, 38);
            this.SourceTextLabel.Name = "SourceTextLabel";
            this.SourceTextLabel.Size = new System.Drawing.Size(170, 24);
            this.SourceTextLabel.TabIndex = 3;
            this.SourceTextLabel.Text = "Исходный текст";
            // 
            // EditTextLabel
            // 
            this.EditTextLabel.AutoSize = true;
            this.EditTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTextLabel.Location = new System.Drawing.Point(276, 38);
            this.EditTextLabel.Name = "EditTextLabel";
            this.EditTextLabel.Size = new System.Drawing.Size(276, 24);
            this.EditTextLabel.TabIndex = 4;
            this.EditTextLabel.Text = "Отредактированный текст";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(544, 24);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStrip,
            this.SaveStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenStrip
            // 
            this.OpenStrip.Name = "OpenStrip";
            this.OpenStrip.Size = new System.Drawing.Size(152, 22);
            this.OpenStrip.Text = "Open";
            this.OpenStrip.Click += new System.EventHandler(this.OpenStrip_Click);
            // 
            // SaveStrip
            // 
            this.SaveStrip.Name = "SaveStrip";
            this.SaveStrip.Size = new System.Drawing.Size(152, 22);
            this.SaveStrip.Text = "Save";
            this.SaveStrip.Click += new System.EventHandler(this.SaveStrip_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(77, 418);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown.TabIndex = 7;
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 460);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.EditTextLabel);
            this.Controls.Add(this.SourceTextLabel);
            this.Controls.Add(this.EditText);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.ButtonStart1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form_1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart1;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.TextBox EditText;
        private System.Windows.Forms.Label SourceTextLabel;
        private System.Windows.Forms.Label EditTextLabel;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStrip;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}
