using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormScoreAllUsers : Form
    {
        public FormScoreAllUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormScoreAllUsers_Load(object sender, EventArgs e)
        {
            string[] levels = new string[10];
            string[] names = new string[10];
            string[] scores = new string[10];
            int length = 0; 
            StreamReader sr = new StreamReader("scoreGame.txt");
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    string[] temp = sr.ReadLine().Split('|');
                    levels[i] = temp[0];
                    names[i] = temp[1];
                    scores[i] = temp[2];
                    length++;
                }   
            }
            catch
            { }
            finally
            { 
                sr.Close();
                for (int i = 0; i < length; i++)
                {
                    ListViewItem item = new ListViewItem(new string[] { levels[i], names[i], scores[i] });
                    listViewScoresAllUsers.Items.Add(item);
                }
            
            }

        }
    }
}
