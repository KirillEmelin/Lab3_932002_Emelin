using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Emelin
{
    public partial class Form1 : Form
    {
        private Color[,] cellColors = null;
        public Form1()
        {
            InitializeComponent();
            var columns = tableLayoutPanel1.ColumnCount;
            var rows = tableLayoutPanel1.RowCount;
            cellColors = new Color[columns, rows];

            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    cellColors[c, r] = SystemColors.Control;
                }
            }
        }

        int rule;
        Boolean isFirstClick = true;
        Random random = new Random();
        int[] firstLine = new int[14];
        int[] nextLine = new int[14];

        int [] buff = new int[8];

        int iterRow = 1;
        public void ToBinary(int val)
        {        
            for (int i = 7; i >= 0; i--)
            {
                int mask = 1 << i;               
                buff[7 - i] = (val & mask) != 0 ? '1' : '0';               
            }            
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            rule = (int)ruleEd.Value;
            ToBinary(rule);

            for (int i = 0; i < 14; i++)
            {
                nextLine[i] = 0;
            }

            if (isFirstClick)
            {
                if(iterRow == 1)
                {
                    for (int i = 1; i < 15; i++)
                        for (int j = 0; j < 15; j++)
                            cellColors[i, j] = Color.White;
                    for (int i = 0; i < 14; i++)
                    {
                        firstLine[i] = 0;

                    }
                    for (int i = 1; i < 13; i++)
                    {
                        firstLine[i] = random.Next()%2;

                    }
                    add_label();
                    for (int i = 1; i < 15; i++)
                        if (firstLine[i - 1] == 1)
                            cellColors[i, 0] = Color.Orange;
                }
                tableLayoutPanel1.Refresh();
                timer1.Start(); 
                isFirstClick = false;
            }
            else
            {
                timer1.Stop();  
                isFirstClick = true;
            }

        }

        public int change(int first, int average, int end)
        {
            if (first == 1 && average == 1 && end == 1)
                return buff[0] % 2;
            if (first == 1 && average == 1 && end == 0)
                return buff[1] % 2;
            if (first == 1 && average == 0 && end == 1)
                return buff[2] % 2;
            if (first == 1 && average == 0 && end == 0)
                return buff[3] % 2;
            if (first == 0 && average == 1 && end == 1)
                return buff[4] % 2;
            if (first == 0 && average == 1 && end == 0)
                return buff[5] % 2;
            if (first == 0 && average == 0 && end == 1)
                return buff[6] % 2;
            
            return buff[7] % 2;
        }

        public void add_label()
        {
            switch(iterRow)
            {
                case 1:
                    lab1.Visible = true;
                    break;
                case 2:
                    lab2.Visible = true;
                    break;
                case 3:
                    lab3.Visible = true;
                    break;
                case 4:
                    lab4.Visible = true;
                    break;
                case 5:
                    lab5.Visible = true;
                    break;
                case 6:
                    lab6.Visible = true;
                    break;
                case 7:
                    lab7.Visible = true;
                    break;
                case 8:
                    lab8.Visible = true;
                    break;
                case 9:
                    lab9.Visible = true;
                    break;
                case 10:
                    lab10.Visible = true;
                    break;
                case 11:
                    lab11.Visible = true;
                    break;
                case 12:
                    lab12.Visible = true;
                    break;
                case 13:
                    lab13.Visible = true;
                    break;
                case 14:
                    lab14.Visible = true;
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i < 13; i++)
            {
                nextLine[i] = change(firstLine[i - 1], firstLine[i], firstLine[i + 1]);
            }
            add_label();
            for (i = 1; i < 15; i++)
                if (nextLine[i - 1] == 1)
                    cellColors[i, iterRow] = Color.Orange;

            for (i = 0; i < 14; i++)
            {
                firstLine[i] = nextLine[i];
                nextLine[i] = 0;
            }
            

            iterRow++;
            if(iterRow == 15)
            {
                iterRow = 1;
                timer1.Stop();
            }
            tableLayoutPanel1.Refresh();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (cellColors != null)
            {
                var color = cellColors[e.Column, e.Row];
                e.Graphics.FillRectangle(new SolidBrush(color), e.CellBounds);
            }
        }

        private void ruleEd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
