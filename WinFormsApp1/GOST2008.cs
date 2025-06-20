using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GOST2008 : Form
    {
        private GOST2018 mainForm;

        public GOST2008(GOST2018 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void GOST2008_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
