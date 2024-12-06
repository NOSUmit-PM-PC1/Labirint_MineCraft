using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormGame : Form
    {
        char[,] field;
        Image fon, stone, steve, enemy;
        int x = 1, y = 1;
        int enemyX = 7, enemyY = 1;
        Random rnd = new Random();

        char[,] LoadLevelFromFile(string filename)
        {
            
            StreamReader reader = new StreamReader(filename);
            string[] temp = reader.ReadLine().Split();
            int rows = Convert.ToInt32(temp[0]);
            int cols = Convert.ToInt32(temp[1]);
            char[,] data = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string s = reader.ReadLine();
                for (int j = 0; j < cols; j++)
                    data[i, j] = s[j];
            }
            reader.Close();
            return data;
        }

        bool CheckCellField(int x, int y)
        {
            int row = y;
            int col = x;
            if (0 <= row && row < field.GetLength(0) && 0 <= col && col < field.GetLength(1))
                return field[row, col] == '0';
            return false;
        }
        void ShowMoveGame()
        {
            ShowField(field);
            dataGridViewLabirint[x, y].Value = steve;
            dataGridViewLabirint[enemyX, enemyY].Value = enemy;

        }

        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            int direct = rnd.Next(4);
             switch (direct)
            {
                //влево
                case 0: 
                   if (CheckCellField(enemyX - 1, enemyY)) enemyX -= 1; break;
                // вверх
                case 1:
                    if (CheckCellField(enemyX, enemyY - 1)) enemyY -= 1; break;
                //вправо
                case 2:
                    if (CheckCellField(enemyX + 1, enemyY)) enemyX += 1; break;
                //вниз
                case 3:
                    if (CheckCellField(enemyX, enemyY + 1)) enemyY += 1; break;
            }
            ShowMoveGame();
        }

        void CreateField(char[,] data)
        {
            int widthColumn = 60;

            dataGridViewLabirint.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewLabirint.RowTemplate.Height = widthColumn;

            dataGridViewLabirint.Width = (data.GetLength(1) + 1) * (widthColumn);
            dataGridViewLabirint.Height = (data.GetLength(0) + 1) * (widthColumn);

            this.Width = dataGridViewLabirint.Width;
            this.Height = dataGridViewLabirint.Height;

            for (int i = 0; i < data.GetLength(1); i++)
            {
                var column = new DataGridViewImageColumn();
                column.Width = widthColumn;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewLabirint.Columns.Add(column);
            }

            dataGridViewLabirint.RowCount = data.GetLength(0);
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (CheckCellField(x, y + 1))
                {
                    y += 1;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (CheckCellField(x, y - 1))
                {
                    y -= 1;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (CheckCellField(x - 1, y))
                {
                    x -= 1;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (CheckCellField(x + 1, y))
                {
                    x += 1;
                    
                }
            }
            ShowMoveGame();
        }

        void ShowField(char[,] data)
        {
           
           for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    switch (data[i, j])
                    {
                        case 'x':
                            dataGridViewLabirint.Rows[i].Cells[j].Value = stone; break;
                        case '0':
                            dataGridViewLabirint.Rows[i].Cells[j].Value = fon; break;
                            //dataGridViewLabirint[x, y].Value = fon; 
                    }
                }
            }
        }

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            fon = Bitmap.FromFile("images/fon.jpg");
            stone = Bitmap.FromFile("images/stone.jpg");
            steve = Bitmap.FromFile("images/Steve.jpg");
            enemy = Bitmap.FromFile("images/enemy.png");

            field = LoadLevelFromFile("levels/level1.txt");

            CreateField(field);
            ShowMoveGame();
        }
    }
}
