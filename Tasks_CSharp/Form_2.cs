using ClassLibrary_Tasks_CSharp;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tasks_CSharp
{
    public partial class Form_2 : Form
    {
        string path = @"D:\VS_Projects\C#\BinaryFile.dat";
        BinaryFile file = new BinaryFile();
        public Form_2()
        {
            InitializeComponent();
        }
        /*private void OpenStrip_Click_1(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader file = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    TextBox_1.Text = Convert.ToString(file.ReadString());
                }
            }
        }*/
        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (BinaryWriter file = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                double[] a = TextBox_1.Text.Split(' ').
                    Where(x => !string.IsNullOrWhiteSpace(x)).
                    Select(x => double.Parse(x)).ToArray();

                for (int i = 0; i < a.Length; i++)
                {
                    file.Write(a[i]);
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            file.EditBinaryFile();

            string s = "";

            for (int i = 0; i < file.Arr2.Length; i++)
            {
                s = s + (double)file.Arr2[i] + " ";
            }

            TextBox_2.Text = s;
        }
    }
}
