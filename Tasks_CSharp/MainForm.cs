using System;

namespace Tasks_CSharp
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            Form_1 newForm = new Form_1();
            newForm.Show();
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            Form_2 newForm = new Form_2();
            newForm.Show();
        }
    }
}
