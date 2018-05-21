using ClassLibrary_Tasks_CSharp;
using System;
using System.Windows.Forms;

namespace Tasks_CSharp
{
    public partial class Form_1 : Form
    {
        public string Path { get; set; }
        public TextFile Text { get; set; }

        public Form_1()
        {
            InitializeComponent();
        }

        private void OpenStrip_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Text = new TextFile();
                SourceText.Lines = Text.ReadFile(OpenFile.FileName);
                Path = OpenFile.FileName;
            }
        }

        private void SaveStrip_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                Text.WriteFile(SaveFile.FileName);
            }
        }
        private void ButtonStart1_Click(object sender, EventArgs e)
        {
            int k = (int)numericUpDown.Value;
            EditText.Lines = Text.DeleteParagraph(k);
        }
    }
}
