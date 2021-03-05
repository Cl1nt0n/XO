using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum XOvalue { Empty, X, O };

        bool isPlayerXStep;
        bool isGameOver;

        XOvalue btn11, btn12, btn13, btn21, btn22, btn23, btn31, btn32, btn33;

        public void WinX(bool isGameOver, bool isPlayerXstep, int btn, int btn1, int btn2, int btn3)
        {
            if (btn == (int)XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    btn.ImageIndex = 1;
                    btn = (int)XOvalue.X;
                }
                else
                {
                    button31.ImageIndex = 6;
                    btn = (int)XOvalue.O;
                }

                #region
                if (btn31 == XOvalue.X && btn32 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button31.ImageIndex = 5;
                    button32.ImageIndex = 5;
                    button33.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn11 == XOvalue.X && btn21 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button11.ImageIndex = 4;
                    button21.ImageIndex = 4;
                    button31.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn13 == XOvalue.X && btn22 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button13.ImageIndex = 3;
                    button22.ImageIndex = 3;
                    button31.ImageIndex = 3;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn31 == XOvalue.O && btn32 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button31.ImageIndex = 10;
                    button32.ImageIndex = 10;
                    button33.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn11 == XOvalue.O && btn21 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button11.ImageIndex = 9;
                    button21.ImageIndex = 9;
                    button31.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn13 == XOvalue.O && btn22 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button13.ImageIndex = 8;
                    button22.ImageIndex = 8;
                    button31.ImageIndex = 8;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion
                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (btn31 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button31.ImageIndex = 1;
                    btn31 = XOvalue.X;
                }
                else
                {
                    button31.ImageIndex = 6;
                    btn31 = XOvalue.O;
                }

                #region
                if (btn31 == XOvalue.X && btn32 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button31.ImageIndex = 5;
                    button32.ImageIndex = 5;
                    button33.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn11 == XOvalue.X && btn21 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button11.ImageIndex = 4;
                    button21.ImageIndex = 4;
                    button31.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn13 == XOvalue.X && btn22 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button13.ImageIndex = 3;
                    button22.ImageIndex = 3;
                    button31.ImageIndex = 3;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn31 == XOvalue.O && btn32 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button31.ImageIndex = 10;
                    button32.ImageIndex = 10;
                    button33.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn11 == XOvalue.O && btn21 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button11.ImageIndex = 9;
                    button21.ImageIndex = 9;
                    button31.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn13 == XOvalue.O && btn22 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button13.ImageIndex = 8;
                    button22.ImageIndex = 8;
                    button31.ImageIndex = 8;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion
                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (btn32 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button32.ImageIndex = 1;
                    btn32 = XOvalue.X;
                }
                else
                {
                    button32.ImageIndex = 6;
                    btn32 = XOvalue.O;
                }

                #region
                if (btn12 == XOvalue.O && btn22 == XOvalue.O && btn32 == XOvalue.O)
                {
                    button12.ImageIndex = 9;
                    button22.ImageIndex = 9;
                    button32.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn31 == XOvalue.O && btn32 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button31.ImageIndex = 10;
                    button32.ImageIndex = 10;
                    button33.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion

                #region
                if (btn12 == XOvalue.X && btn22 == XOvalue.X && btn32 == XOvalue.X)
                {
                    button12.ImageIndex = 4;
                    button22.ImageIndex = 4;
                    button32.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn31 == XOvalue.X && btn32 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button31.ImageIndex = 5;
                    button32.ImageIndex = 5;
                    button33.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion
                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (btn33 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button33.ImageIndex = 1;
                    btn33 = XOvalue.X;
                }
                else
                {
                    button33.ImageIndex = 6;
                    btn33 = XOvalue.O;
                }

                #region
                if (btn31 == XOvalue.X && btn32 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button31.ImageIndex = 5;
                    button32.ImageIndex = 5;
                    button33.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }

                if (btn13 == XOvalue.X && btn23 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button13.ImageIndex = 4;
                    button23.ImageIndex = 4;
                    button33.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }

                if (btn11 == XOvalue.X && btn22 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button11.ImageIndex = 2;
                    button22.ImageIndex = 2;
                    button33.ImageIndex = 2;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn31 == XOvalue.O && btn32 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button31.ImageIndex = 10;
                    button32.ImageIndex = 10;
                    button33.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn13 == XOvalue.O && btn23 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button13.ImageIndex = 9;
                    button23.ImageIndex = 9;
                    button33.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn11 == XOvalue.O && btn22 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button11.ImageIndex = 7;
                    button22.ImageIndex = 7;
                    button33.ImageIndex = 7;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion
                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (btn23 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button23.ImageIndex = 1;
                    btn23 = XOvalue.X;
                }
                else
                {
                    button23.ImageIndex = 6;
                    btn23 = XOvalue.O;
                }

                #region
                if (btn13 == XOvalue.X && btn23 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button13.ImageIndex = 4;
                    button23.ImageIndex = 4;
                    button33.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn21 == XOvalue.X && btn22 == XOvalue.X && btn23 == XOvalue.X)
                {
                    button21.ImageIndex = 5;
                    button22.ImageIndex = 5;
                    button23.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn13 == XOvalue.O && btn23 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button13.ImageIndex = 9;
                    button23.ImageIndex = 9;
                    button33.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn21 == XOvalue.O && btn22 == XOvalue.O && btn23 == XOvalue.O)
                {
                    button21.ImageIndex = 10;
                    button22.ImageIndex = 10;
                    button23.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (btn22 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button22.ImageIndex = 1;
                    btn22 = XOvalue.X;
                }
                else
                {
                    button22.ImageIndex = 6;
                    btn22 = XOvalue.O;
                }

                #region
                if (btn12 == XOvalue.X && btn22 == XOvalue.X && btn32 == XOvalue.X)
                {
                    button12.ImageIndex = 4;
                    button22.ImageIndex = 4;
                    button32.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn13 == XOvalue.X && btn22 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button13.ImageIndex = 3;
                    button22.ImageIndex = 3;
                    button31.ImageIndex = 3;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn11 == XOvalue.X && btn22 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button11.ImageIndex = 2;
                    button22.ImageIndex = 2;
                    button33.ImageIndex = 2;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn21 == XOvalue.X && btn22 == XOvalue.X && btn23 == XOvalue.X)
                {
                    button21.ImageIndex = 5;
                    button22.ImageIndex = 5;
                    button23.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn12 == XOvalue.O && btn22 == XOvalue.O && btn32 == XOvalue.O)
                {
                    button12.ImageIndex = 9;
                    button22.ImageIndex = 9;
                    button32.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn13 == XOvalue.O && btn22 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button13.ImageIndex = 8;
                    button22.ImageIndex = 8;
                    button31.ImageIndex = 8;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn11 == XOvalue.O && btn22 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button11.ImageIndex = 2;
                    button22.ImageIndex = 2;
                    button33.ImageIndex = 2;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                if (btn21 == XOvalue.O && btn22 == XOvalue.O && btn23 == XOvalue.O)
                {
                    button21.ImageIndex = 10;
                    button22.ImageIndex = 10;
                    button23.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion
                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (btn21 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button21.ImageIndex = 1;
                    btn21 = XOvalue.X;
                }
                else
                {
                    button21.ImageIndex = 6;
                    btn21 = XOvalue.O;
                }

                #region
                if (btn21 == XOvalue.X && btn22 == XOvalue.X && btn23 == XOvalue.X)
                {
                    button21.ImageIndex = 5;
                    button22.ImageIndex = 5;
                    button23.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }

                if (btn11 == XOvalue.X && btn21 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button11.ImageIndex = 4;
                    button21.ImageIndex = 4;
                    button31.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn21 == XOvalue.O && btn22 == XOvalue.O && btn23 == XOvalue.O)
                {
                    button21.ImageIndex = 10;
                    button22.ImageIndex = 10;
                    button23.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn11 == XOvalue.O && btn21 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button11.ImageIndex = 9;
                    button21.ImageIndex = 9;
                    button31.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion
                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (btn13 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button13.ImageIndex = 1;
                    btn13 = XOvalue.X;
                }
                else
                {
                    button13.ImageIndex = 6;
                    btn13 = XOvalue.O;
                }

                #region
                if (btn13 == XOvalue.X && btn22 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button13.ImageIndex = 3;
                    button22.ImageIndex = 3;
                    button31.ImageIndex = 3;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }

                if (btn13 == XOvalue.X && btn23 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button13.ImageIndex = 4;
                    button23.ImageIndex = 4;
                    button33.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }

                if (btn11 == XOvalue.X && btn12 == XOvalue.X && btn13 == XOvalue.X)
                {
                    button11.ImageIndex = 5;
                    button12.ImageIndex = 5;
                    button13.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn13 == XOvalue.O && btn23 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button13.ImageIndex = 9;
                    button23.ImageIndex = 9;
                    button33.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn13 == XOvalue.O && btn22 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button13.ImageIndex = 8;
                    button22.ImageIndex = 8;
                    button31.ImageIndex = 8;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn11 == XOvalue.O && btn12 == XOvalue.O && btn13 == XOvalue.O)
                {
                    button11.ImageIndex = 10;
                    button12.ImageIndex = 10;
                    button13.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (btn12 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button12.ImageIndex = 1;
                    btn12 = XOvalue.X;
                }
                else
                {
                    button12.ImageIndex = 6;
                    btn12 = XOvalue.O;
                }
                #region
                if (btn12 == XOvalue.X && btn22 == XOvalue.X && btn32 == XOvalue.X)
                {
                    button12.ImageIndex = 4;
                    button22.ImageIndex = 4;
                    button32.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }

                if (btn11 == XOvalue.X && btn12 == XOvalue.X && btn13 == XOvalue.X)
                {
                    button11.ImageIndex = 5;
                    button12.ImageIndex = 5;
                    button13.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn11 == XOvalue.O && btn12 == XOvalue.O && btn13 == XOvalue.O)
                {
                    button11.ImageIndex = 10;
                    button12.ImageIndex = 10;
                    button13.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn12 == XOvalue.O && btn22 == XOvalue.O && btn32 == XOvalue.O)
                {
                    button12.ImageIndex = 9;
                    button22.ImageIndex = 9;
                    button32.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }
                #endregion

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (btn11 == XOvalue.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button11.ImageIndex = 1;
                    btn11 = XOvalue.X;
                }
                else
                {
                    button11.ImageIndex = 6;
                    btn11 = XOvalue.O;
                }

                #region
                if (btn11 == XOvalue.X && btn12 == XOvalue.X && btn13 == XOvalue.X)
                {
                    button11.ImageIndex = 5;
                    button12.ImageIndex = 5;
                    button13.ImageIndex = 5;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn11 == XOvalue.X && btn21 == XOvalue.X && btn31 == XOvalue.X)
                {
                    button11.ImageIndex = 4;
                    button21.ImageIndex = 4;
                    button31.ImageIndex = 4;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                if (btn11 == XOvalue.X && btn22 == XOvalue.X && btn33 == XOvalue.X)
                {
                    button11.ImageIndex = 2;
                    button22.ImageIndex = 2;
                    button33.ImageIndex = 2;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion

                #region
                if (btn11 == XOvalue.O && btn12 == XOvalue.O && btn13 == XOvalue.O)
                {
                    button11.ImageIndex = 10;
                    button12.ImageIndex = 10;
                    button13.ImageIndex = 10;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn11 == XOvalue.O && btn21 == XOvalue.O && btn31 == XOvalue.O)
                {
                    button11.ImageIndex = 7;
                    button21.ImageIndex = 7;
                    button31.ImageIndex = 7;

                    isGameOver = true;

                    MessageBox.Show("победили 0");
                }

                if (btn11 == XOvalue.O && btn22 == XOvalue.O && btn33 == XOvalue.O)
                {
                    button11.ImageIndex = 9;
                    button22.ImageIndex = 9;
                    button33.ImageIndex = 9;

                    isGameOver = true;

                    MessageBox.Show("победили X");
                }
                #endregion


                isPlayerXStep = !isPlayerXStep;
            }

        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPlayerXStep = true;
            isGameOver = false;
            btn11 = btn12 = btn13 = btn21 = btn22 = btn23 = btn31 = btn32 = btn33 = XOvalue.Empty;
            button11.ImageIndex = 0;
            button12.ImageIndex = 0;
            button13.ImageIndex = 0;
            button21.ImageIndex = 0;
            button22.ImageIndex = 0;
            button23.ImageIndex = 0;
            button31.ImageIndex = 0;
            button32.ImageIndex = 0;
            button33.ImageIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isPlayerXStep = true;
            isGameOver = false;
            btn11 = btn12 = btn13 = btn21 = btn22 = btn23 = btn31 = btn32 = btn33 = XOvalue.Empty;
        }
    }
}
