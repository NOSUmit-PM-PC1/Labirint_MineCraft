using System;
using System.IO;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormEnterUserName : Form
    {
        public int level;
        public int steps;

        public FormEnterUserName()
        {
            InitializeComponent();
        }

        private void buttonSaveUserName_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("scoreGame.txt", true);
            string userName = textBoxUserName.Text;

            sw.WriteLine(level + "|" + userName + "|" + steps);
            sw.Close();
            FormScoreAllUsers formScoreAllUsers = new FormScoreAllUsers();
            formScoreAllUsers.ShowDialog();
            this.Close();
        }
    }
}
